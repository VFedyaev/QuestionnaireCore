using QuestionnaireCore.Service.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireCore.Service.Models
{
    public class DataModel : BaseModel<int>
    {
        public int QuestionId { get; set; }
        public int QuestionAnswerId { get; set; }
        public int FormId { get; set; }
        public string Comment { get; set; }

        public QuestionAnswerModel QuestionAnswer { get; set; }
        public FormModel Form { get; set; }
    }
}
