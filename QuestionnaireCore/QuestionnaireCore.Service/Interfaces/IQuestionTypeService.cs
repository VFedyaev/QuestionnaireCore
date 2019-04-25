using QuestionnaireCore.Data.Entities;
using QuestionnaireCore.Service.Enums;
using QuestionnaireCore.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuestionnaireCore.Service.Interfaces
{
    public interface IQuestionTypeService : IBaseQueryService<QuestionType, QuestionTypeModel, QuestionTypeSort>
    {
        IEnumerable<QuestionTypeModel> GetQuestionTypes();
        QuestionTypeModel GetQuestionTypeById(int id);
        void AddQuestionType(QuestionTypeModel questionTypeModel);
        void UpdateQuestionType(QuestionTypeModel questionTypeModel);
        void DeleteQuestionType(int questionTypeId);
    }
}
