using QuestionnaireCore.Data.Entities;
using QuestionnaireCore.Service.Enums;
using QuestionnaireCore.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireCore.Service.Interfaces
{
    public interface IQuestionTypeService : IBaseQueryService<QuestionType, QuestionTypeModel, SortDirectionType>
    {
        IEnumerable<QuestionTypeModel> GetListOrderedByName();
        QuestionTypeModel Get(int? id);

        IEnumerable<QuestionTypeModel> GetAll();
        QuestionTypeModel Get(int id);
        void Add(QuestionTypeModel item);
        void Update(QuestionTypeModel item);
        void Delete(int id);
    }
}
