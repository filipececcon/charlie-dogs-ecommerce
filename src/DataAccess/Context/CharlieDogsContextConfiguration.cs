using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace ChalieDogs.Ecommerce.DataAccess.Context
{
    public class CharlieDogsContextConfiguration : DbConfiguration
    {
        public CharlieDogsContextConfiguration()
        {
            SetDefaultConnectionFactory(new SqlConnectionFactory(ConfigurationManager.ConnectionStrings["CharlieDogsDB"].ConnectionString));
            SetProviderServices("System.Data.SqlClient", System.Data.Entity.SqlServer.SqlProviderServices.Instance);
        }
    }
}
