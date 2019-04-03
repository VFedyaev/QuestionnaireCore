using QuestionnaireCore.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuestionnaireCore.Data.Entities
{
    [Table("Answer")]
    public class Answer : EntityBase<int>
    {
        public string Name{ get; set; }
    }
}
