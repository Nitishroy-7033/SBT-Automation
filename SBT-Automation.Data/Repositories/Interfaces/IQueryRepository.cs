using SBT_Automation.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBT_Automation.Data.Repositories.Interfaces
{
    public interface IQueryRepository
    {
        Task<List<QueryModel>> GetAllQueries();
        Task<QueryModel> GetQueryById(string id);
        Task CreateQuery(QueryModel query);
        Task<bool> UpdateQuery(string id, QueryModel query);
        Task<bool> DeleteQuery(string id);
    }
}
