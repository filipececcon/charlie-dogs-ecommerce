using System.Data.Entity;

namespace ChalieDogs.Ecommerce.DataAccess.Context
{
    public class CharlieDogsContextInitializer : CreateDatabaseIfNotExists<CharlieDogsContext>
    {
        protected override void Seed(CharlieDogsContext context)
        {
            base.Seed(context);

            // TODO: Configurar os dados iniciais 
        }
    }
}
