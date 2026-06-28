namespace GerenciadorBLContainer
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;
    using Microsoft.Extensions.Configuration;
    using System.IO;

    // Gabriel Afonso dos Santos - CB3026167
    public class GerenciadorBLContextFactory : IDesignTimeDbContextFactory<GerenciadorBLContext>
    {
        public GerenciadorBLContext CreateDbContext(string[] args)
        {
            // Constrói a configuração para ler do appsettings.json
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<GerenciadorBLContext>();

            // Obtém a string de conexão com o TrustServerCertificate=True
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseSqlServer(connectionString);

            return new GerenciadorBLContext(builder.Options);
        }
    }
}
