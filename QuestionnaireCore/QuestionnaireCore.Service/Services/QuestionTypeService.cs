using AutoMapper;
using QuestionnaireCore.Data.Entities;
using QuestionnaireCore.Data.Interfaces;
using QuestionnaireCore.Service.Enums;
using QuestionnaireCore.Service.Extensions;
using QuestionnaireCore.Service.Interfaces;
using QuestionnaireCore.Service.Models;
using QuestionnaireCore.Service.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QuestionnaireCore.Service.Services
{
    public class QuestionTypeService : BaseQueryService<QuestionType, QuestionTypeModel, QuestionTypeSort>, IQuestionTypeService
    {
        public QuestionTypeService(IUnitOfWork uow, IMapper mapper)
            : base(uow, mapper)
        { }

        public void AddQuestionType(QuestionTypeModel questionTypeModel)
        {
            var questionType = _uow.GetRepository<QuestionType>().All()
              .FirstOrDefault(x => x.Name == questionTypeModel.Name);

            if (questionType != null)
                return;

            questionType = _mapper.Map<QuestionType>(questionTypeModel);

            _uow.GetRepository<QuestionType>().Insert(questionType);

            _uow.SaveChanges();
        }

        public void DeleteQuestionType(int questionTypeId)
        {
            var questionType = _uow.GetRepository<QuestionType>().GetById(questionTypeId);
            _uow.GetRepository<QuestionType>().Delete(questionType);
            _uow.SaveChanges();
        }

        public QuestionTypeModel GetQuestionTypeById(int id)
        {
            var questionType = _uow.GetRepository<QuestionType>().GetById(id);
            return _mapper.Map<QuestionTypeModel>(questionType);
        }

        public IEnumerable<QuestionTypeModel> GetQuestionTypes()
        {
            var questionType = _uow.GetRepository<QuestionType>().All();
            return _mapper.Map<IEnumerable<QuestionTypeModel>>(questionType.OrderBy(x => x.Name));
        }

        public void UpdateQuestionType(QuestionTypeModel questionTypeModel)
        {
            var questionType = _uow.GetRepository<QuestionType>().All()
            .FirstOrDefault(x => x.Name == questionTypeModel.Name);

            if (questionType != null)
                return;

            questionType = _mapper.Map<QuestionType>(questionTypeModel);

            _uow.GetRepository<QuestionType>().Update(questionType);

            _uow.SaveChanges();
        }

        protected override IQueryable<QuestionType> Order(IQueryable<QuestionType> items, bool isFirst, QueryOrder<QuestionTypeSort> order)
        {
            switch (order.OrderType)
            {
                case QuestionTypeSort.Name:
                    return items.OrderWithDirectionBy(isFirst, order.Direction, x => x.Name);
            }

            throw new ArgumentOutOfRangeException(nameof(order.OrderType));
        }

        protected override IQueryable<QuestionType> Paging(IQueryable<QuestionType> items, int? start, int? length)
        {
            return items.Skip(start.Value).Take(length.Value);
        }

        protected override IQueryable<QuestionType> Search(IQueryable<QuestionType> items, QuerySearch search)
        {
            if (!string.IsNullOrEmpty(search?.Value))
            {
                return items.Where(x => x.Name.Contains(search.Value));
            }
            return items;
        }
    }
}
