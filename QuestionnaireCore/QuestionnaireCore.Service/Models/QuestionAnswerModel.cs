using QuestionnaireCore.Service.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireCore.Service.Models
{
    public class QuestionAnswerModel : BaseModel<int>
    {
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }

        public QuestionModel Question { get; set; }
        public AnswerModel Answer { get; set; }
    }
}
