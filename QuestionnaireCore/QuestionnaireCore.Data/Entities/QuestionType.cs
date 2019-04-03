using QuestionnaireCore.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuestionnaireCore.Data.Entities
{
    [Table("QuestionType")]
    public class QuestionType : EntityBase<short>
    {
        public string Name { get; set; }
    }
}
