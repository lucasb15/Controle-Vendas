using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Controle_Vendas.br.com.projeto.conexao;

public class ConnectionFactory
{
    public SqlConnection GetConnection()
    {
        // Carrega o arquivo JSON
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        // Busca a string de conexão pelo nome exato que está no seu JSON
        // No seu arquivo anterior estava "DefaultConnection"
        string conexao = configuration.GetConnectionString("DefaultConnection");

        return new SqlConnection(conexao);
    }
}
