using QuestionnaireCore.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuestionnaireCore.Data.Entities
{
    [Table("Interviewer")]
    public class Interviewer : EntityBase<short>
    {
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
