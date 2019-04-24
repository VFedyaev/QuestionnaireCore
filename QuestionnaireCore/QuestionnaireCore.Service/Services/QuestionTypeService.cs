using AutoMapper;
using QuestionnaireCore.Data.Entities;
using QuestionnaireCore.Data.Interfaces;
using QuestionnaireCore.Service.Enums;
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
    public class QuestionTypeService : BaseQueryService<QuestionType, QuestionTypeModel, PostSortType>, IQuestionTypeService
    {
        public QuestionTypeService(IUnitOfWork uow, IMapper mapper)
            : base(uow, mapper)
        { }

        public QuestionTypeModel Get(int id)
        {
            var questionType = _uow.GetRepository<QuestionType>().Get(id);
            _uow.GetRepository<QuestionType>().Delete(questionType);
            _uow.SaveChanges();
        }

        public QuestionTypeModel Get(int? id)
        {
            throw new NotImplementedException();
        }

        public void Add(QuestionTypeModel item)
        {
            var questionType = _mapper.Map<QuestionType>(item);
            _uow.GetRepository<QuestionType>().Create(questionType);
            _uow.SaveChanges();
        }

        public void Update(QuestionTypeModel item)
        {
            var questionType = _mapper.Map<QuestionType>(item);
            _uow.GetRepository<QuestionType>().Update(questionType);
            _uow.SaveChanges();
        }

        public void Delete(int id)
        {
            
            var questionType = _uow.GetRepository<QuestionType>().Get(id);
            _uow.GetRepository<QuestionType>().Delete(questionType);
            _uow.SaveChanges();
        }
       
        public IEnumerable<QuestionTypeModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<QueryResponse<QuestionTypeModel>> GetAsync(QueryRequest<SortDirectionType> query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<QuestionTypeModel> GetListOrderedByName()
        {
            throw new NotImplementedException();
        }

       

        protected override IQueryable<QuestionType> Category(IQueryable<QuestionType> items, QuerySearch category)
        {
            throw new NotImplementedException();
        }

        protected override IQueryable<QuestionType> Order(IQueryable<QuestionType> items, bool isFirst, QueryOrder<PostSortType> order)
        {
            throw new NotImplementedException();
        }

        protected override IQueryable<QuestionType> Search(IQueryable<QuestionType> items, QuerySearch search)
        {
            throw new NotImplementedException();
        }

        protected override IQueryable<QuestionType> SourceOrder(IQueryable<QuestionType> items, QuerySearch source)
        {
            throw new NotImplementedException();
        }
    }
}
