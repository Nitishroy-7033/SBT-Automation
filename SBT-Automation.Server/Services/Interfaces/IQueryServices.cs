
using SBT_Automation.Data.Models;
using SBT_Automation.Data.Models.Responses;

namespace SBT_Automation.Server.Interfaces
{
    public interface IQueryServices
    {
        Task<ApiResponse<List<QueryModel>>> GetAllQueries();
        Task<ApiResponse<QueryModel>> GetQueryById(string id);
        Task<ApiResponse<bool>> CreateQuery(QueryModel query);
        Task<ApiResponse<bool>> UpdateQuery(string id, QueryModel query);
        Task<ApiResponse<bool>> DeleteQuery(string id);
    }
}
