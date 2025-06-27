using Newtonsoft.Json;

namespace OmieClientApp.Models.ContaReceber;

/// <summary>
/// Repetição específica.
/// </summary>
public class Especifico
{
    /// <summary>
    /// Indica o intervalo em dias entre cada vencimento do lançamento que será cadastrado.
    /// </summary>
    [JsonProperty("repetir_a_cada")]
    public int? RepetirACada { get; set; }

    /// <summary>
    /// Informe aqui a quantidade de parcelas que serão cadastradas com um limite de até 120 repetições
    /// </summary>
    [JsonProperty("repetir_por")]
    public int? RepetirPor { get; set; }
}