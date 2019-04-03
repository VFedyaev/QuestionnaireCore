using QuestionnaireCore.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireCore.Data.Entities.Base
{
    public class EntityBase : IEntityBase
    {
    }

    public class EntityBase<T> : IEntityBase<T>
    {
        public T Id { get; set; }
    }
}
