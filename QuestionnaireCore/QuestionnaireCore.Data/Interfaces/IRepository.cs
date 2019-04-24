using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionnaireCore.Data.Interfaces
{
    public interface IRepository { }

    public interface IRepository<T> : IRepository where T : class, IEntityBase, new()
    {
        IQueryable<T> GetAll();
        T Get(params object[] id);
        void Create(T item);
        void Update(T item);
        void Delete(T item);
    }
}
