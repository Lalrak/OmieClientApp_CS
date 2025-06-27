using Newtonsoft.Json;

namespace OmieClientApp.Models.ContaReceber;

/// <summary>
/// Repetição mensal.
/// </summary>
public class Mensal
{
    /// <summary>
    /// Informe aqui o dia do mês em que cadá lançamento irá vencer .
    /// </summary>
    [JsonProperty("repetir_todo_dia")]
    public int? RepetirTodoDia { get; set; }

    /// <summary>
    /// Informe aqui a quantidade de parcelas que serão cadastradas com um limite de até 120 repetições
    /// </summary>
    [JsonProperty("repetir_por")]
    public int? RepetirPor { get; set; }
}