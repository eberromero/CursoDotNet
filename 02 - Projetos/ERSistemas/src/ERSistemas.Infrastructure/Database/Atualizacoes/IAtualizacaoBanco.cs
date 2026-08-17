using Microsoft.Data.SqlClient;

namespace ERSistemas.Infrastructure.Database.Atualizacoes;

public interface IAtualizacaoBanco
{
    int Versao { get; }
    string Descricao { get; }
    bool Validar(SqlConnection connection);
    string ObterScript();
}
