using QuestionnaireCore.Service.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireCore.Service.Models
{
    public class InterviewerModel : BaseModel<short>
    {
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
