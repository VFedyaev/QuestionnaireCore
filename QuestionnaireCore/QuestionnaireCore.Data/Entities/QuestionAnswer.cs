using QuestionnaireCore.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuestionnaireCore.Data.Entities
{
    [Table("QuestionAnswer")]
    public class QuestionAnswer : EntityBase<int>
    {
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }

        public virtual Question Question { get; set; }
        public virtual Answer Answer { get; set; }
    }
}
