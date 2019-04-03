using QuestionnaireCore.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuestionnaireCore.Data.Entities
{
    [Table("Family")]
    public class Family : EntityBase<int>
    {
        public string Sex { get; set; }
        public short Age { get; set; }
        public int FormId { get; set; }

        public virtual Form Form { get; set; }
    }
}
