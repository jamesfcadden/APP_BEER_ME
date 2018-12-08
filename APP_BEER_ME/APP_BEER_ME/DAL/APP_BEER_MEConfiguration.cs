using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace APP_BEER_ME.DAL
{
    public class APP_BEER_MEConfiguration : DbConfiguration
    {
        public APP_BEER_MEConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}