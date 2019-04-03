using QuestionnaireCore.Service.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireCore.Service.Models
{
    public class QuestionModel : BaseModel<int>
    {
        public short QuestionTypeId { get; set; }
        public string Name { get; set; }
        public bool MultipleAnswer { get; set; }

        public QuestionTypeModel QuestionType { get; set; }
    }
}
