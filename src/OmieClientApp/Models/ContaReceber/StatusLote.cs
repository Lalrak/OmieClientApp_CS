using Newtonsoft.Json;

namespace OmieClientApp.Models.ContaReceber;

/// <summary>
/// Status do lote de lançamentos.
/// </summary>
public class StatusLote
{
    /// <summary>
    /// Código do lançamento no Omie.
    /// </summary>
    [JsonProperty("codigo_lancamento_omie")]
    public long CodigoLancamentoOmie { get; set; }

    /// <summary>
    /// Código do lançamento gerado pelo integrador.
    /// </summary>
    [JsonProperty("codigo_lancamento_integracao")]
    public string CodigoLancamentoIntegracao { get; set; }

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
}