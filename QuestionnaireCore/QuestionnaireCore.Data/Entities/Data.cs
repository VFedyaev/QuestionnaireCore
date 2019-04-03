using QuestionnaireCore.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuestionnaireCore.Data.Entities
{
    [Table("Data")]
    public class Data : EntityBase<int>
    {
        public int QuestionId { get; set; }
        public int QuestionAnswerId { get; set; }
        public int FormId { get; set; }
        public string Comment { get; set; }

        public virtual QuestionAnswer QuestionAnswer { get; set; }
        public virtual Form Form { get; set; }
    }
}
