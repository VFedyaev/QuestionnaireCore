using QuestionnaireCore.Data.Interfaces;
using QuestionnaireCore.Service.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuestionnaireCore.Service.Interfaces
{
    public interface IBaseQueryService<TEntity, TModel, TSortType>
        where TEntity : class, IEntityBase, new()
    {
        Task<QueryResponse<TModel>> GetAsync(QueryRequest<TSortType> query);
    }
}
