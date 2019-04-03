using QuestionnaireCore.Service.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireCore.Service.Models
{
    public class FormModel : BaseModel<int>
    {
        public int NumberForm { get; set; }
        public short SurveyGeographyId { get; set; }
        public short HousingTypeId { get; set; }
        public Nullable<short> DistrictId { get; set; }
        public short InterviewerId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime InterviewDate { get; set; }
        public DateTime StartTime { get; set; }
        public Nullable<DateTime> EndTime { get; set; }

        public SurveyGeographyModel SurveyGeography { get; set; }
        public HousingTypeModel HousingType { get; set; }
        public DistrictModel District { get; set; }
        public InterviewerModel Interviewer { get; set; }
    }
}
