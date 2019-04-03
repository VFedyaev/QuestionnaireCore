using QuestionnaireCore.Service.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireCore.Service.Models
{
    public class AnswerModel : BaseModel<int>
    {
        public string Name { get; set; }
    }
}
