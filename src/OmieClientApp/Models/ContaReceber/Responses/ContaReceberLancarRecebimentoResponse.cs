using Newtonsoft.Json;

namespace OmieClientApp.Models.ContaReceber.Responses;

/// <summary>
/// Resposta da operação de lançamento de recebimento.
/// </summary>
public class ContaReceberLancarRecebimentoResponse
{
    /// <summary>
    /// Chave do lançamento a receber.
    /// </summary>
    [JsonProperty("codigo_lancamento")]
    public long CodigoLancamento { get; set; }

    /// <summary>
    /// Código do lançamento gerado pelo integrador.
    /// </summary>
    [JsonProperty("codigo_lancamento_integracao")]
    public string CodigoLancamentoIntegracao { get; set; }

    /// <summary>
    /// Código da baixa gerada.
    /// </summary>
    [JsonProperty("codigo_baixa")]
    public long CodigoBaixa { get; set; }

    /// <summary>
    /// Código da baixa gerada pelo integrador.
    /// </summary>
    [JsonProperty("codigo_baixa_integracao")]
    public string CodigoBaixaIntegracao { get; set; }


    /// <summary>
    /// Indica que o recebimento liquidado
    /// </summary>
    [JsonProperty("liquidado")]
    public string Liquidado { get; set; }

    /// <summary>
    /// Valor efetivamente recebido.
    /// </summary>
    [JsonProperty("valor_baixado")]
    public decimal ValorBaixado { get; set; }

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