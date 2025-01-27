

using SBT_Automation.Data.Models;
using SBT_Automation.Data.Models.Responses;
using SBT_Automation.Data.Repositories.Interfaces;
using SBT_Automation.Server.Interfaces;

namespace SBT_Automation.Server
{
    public class QueryService : IQueryServices
    {
        private readonly IQueryRepository _queryRepository;

        public QueryService(IQueryRepository queryRepository)
        {
            _queryRepository = queryRepository;
        }

        public async Task<ApiResponse<List<QueryModel>>> GetAllQueries()
        {
            var queries = await _queryRepository.GetAllQueries();
            return new ApiResponse<List<QueryModel>>(true, "Queries retrieved successfully", queries);
        }

        public async Task<ApiResponse<QueryModel>> GetQueryById(string id)
        {
            var query = await _queryRepository.GetQueryById(id);
            if (query == null)
            {
                return new ApiResponse<QueryModel>(false, "Query not found", null);
            }
            return new ApiResponse<QueryModel>(true, "Query retrieved successfully", query);
        }

        public async Task<ApiResponse<bool>> CreateQuery(QueryModel query)
        {
            await _queryRepository.CreateQuery(query);
            return new ApiResponse<bool>(true, "Query created successfully", true);
        }

        public async Task<ApiResponse<bool>> UpdateQuery(string id, QueryModel query)
        {
            var result = await _queryRepository.UpdateQuery(id, query);
            if (!result)
            {
                return new ApiResponse<bool>(false, "Query update failed", false);
            }
            return new ApiResponse<bool>(true, "Query updated successfully", true);
        }

        public async Task<ApiResponse<bool>> DeleteQuery(string id)
        {
            var result = await _queryRepository.DeleteQuery(id);
            if (!result)
            {
                return new ApiResponse<bool>(false, "Query deletion failed", false);
            }
            return new ApiResponse<bool>(true, "Query deleted successfully", true);
        }
    }
}
