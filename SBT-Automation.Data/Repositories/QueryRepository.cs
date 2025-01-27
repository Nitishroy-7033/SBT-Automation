using MongoDB.Driver;
using MongoDBHackathon.data.Models;
using MongoDBHackathon.data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBT_Automation.Data.Repositories
{
    public class QueryRepository : IQueryRepository
    {
        private readonly IMongoCollection<QueryModel> _context;

        public QueryRepository(MongoDbContext<QueryModel> context)
        {
            _context = context.GetCollection();
        }

        public async Task<List<QueryModel>> GetAllQueries()
        {
            return await _context.Find(a => true).ToListAsync();
        }

        public async Task<QueryModel> GetQueryById(string id)
        {
            return await _context.Find(a => a.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateQuery(QueryModel query)
        {
            await _context.InsertOneAsync(query);
        }

        public async Task<bool> UpdateQuery(string id, QueryModel query)
        {
            var result = await _context.ReplaceOneAsync(a => a.Id == id, query);
            return result.IsAcknowledged && result.ModifiedCount > 0;
        }

        public async Task<bool> DeleteQuery(string id)
        {
            var result = await _context.DeleteOneAsync(a => a.Id == id);
            return result.IsAcknowledged && result.DeletedCount > 0;
        }
    }
}
