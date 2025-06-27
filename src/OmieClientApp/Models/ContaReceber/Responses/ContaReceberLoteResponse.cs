using Newtonsoft.Json;

namespace OmieClientApp.Models.ContaReceber.Responses;

/// <summary>
/// Resposta da inclusão de contas a receber por lote.
/// </summary>
public class ContaReceberLoteResponse
{
    /// <summary>
    /// Identificador do lote gerado.
    /// </summary>
    [JsonProperty("lote")]
    public int Lote { get; set; }

    /// <summary>
    /// Código do status do processamento.
    /// </summary>
    [JsonProperty("codigo_status")]
    public string CodigoStatus { get; set; }

    /// <summary>
    /// Descrição do status do processamento.
    /// </summary>
    [JsonProperty("descricao_status")]
    public string DescricaoStatus { get; set; }

    /// <summary>
    /// Detalhes da inclusão/alteração dos lançamentos.
    /// </summary>
    [JsonProperty("status_lote")]
    public List<StatusLote> StatusLote { get; set; }
}