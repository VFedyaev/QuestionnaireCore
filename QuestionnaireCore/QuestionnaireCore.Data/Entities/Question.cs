using QuestionnaireCore.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuestionnaireCore.Data.Entities
{
    [Table("Question")]
    public class Question : EntityBase<int>
    {
        public short QuestionTypeId { get; set; }
        public string Name { get; set; }
        public bool MultipleAnswer { get; set; }

        public virtual QuestionType QuestionType { get; set; }
    }
}
