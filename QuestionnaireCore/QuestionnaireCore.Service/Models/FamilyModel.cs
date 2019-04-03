using QuestionnaireCore.Service.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireCore.Service.Models
{
    public class FamilyModel : BaseModel<int>
    {
        public string Sex { get; set; }
        public short Age { get; set; }
        public int FormId { get; set; }

        public FormModel Form { get; set; }
    }
}
