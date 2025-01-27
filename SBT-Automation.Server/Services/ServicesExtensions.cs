using MongoDBHackathon.Services.Interfaces;

namespace SBT_Automation.Server
{
    public static class ServicesExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {

            services.AddTransient<IQueryServices, QueryService>();

        }
    }
}
