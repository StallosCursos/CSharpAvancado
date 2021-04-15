using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CadastroCliente.InfraEstrutura
{
    public static class DataContextFactory
    {
        public static ClienteDataContext Create()
        {
            var ContextBuild = new DbContextOptionsBuilder<ClienteDataContext>();
            ContextBuild.UseSqlServer(ConfigurationManager.AppSettings.Get("connectionString"));

            return new ClienteDataContext(ContextBuild.Options);
        }
    }
}
