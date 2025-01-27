using Microsoft.Extensions.DependencyInjection;
using MongoDBHackathon.data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBT_Automation.Data.Repositories
{
    public static class RepositoriesExtentions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IQueryRepository, QueryRepository>();
        }
    }
}
