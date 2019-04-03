﻿using QuestionnaireCore.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuestionnaireCore.Data.Entities
{
    [Table("Form")]
    public class Form : EntityBase<int>
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

        public virtual SurveyGeography SurveyGeography { get; set; }
        public virtual HousingType HousingType { get; set; }
        public virtual District District { get; set; }
        public virtual Interviewer Interviewer { get; set; }
    }
}
