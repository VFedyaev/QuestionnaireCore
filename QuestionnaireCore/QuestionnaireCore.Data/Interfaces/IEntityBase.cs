using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireCore.Data.Interfaces
{
    public interface IEntityBase
    {
    }

    public interface IEntityBase<T> : IEntityBase
    {
        T Id { get; set; }
    }
}
