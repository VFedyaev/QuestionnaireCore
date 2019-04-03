using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuestionnaireCore.Data.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T : class, IEntityBase, new();
        void SaveChanges();
        Task SaveChangesAsync();
        void RunInTransaction(Action action);
        Task RunInTransactionAsync(Func<Task> actionAsync);
    }
}
