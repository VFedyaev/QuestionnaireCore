using QuestionnaireCore.Service.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireCore.Service.Models
{
    public class DistrictModel : BaseModel<short>
    {
        public string Name { get; set; }
    }
}
