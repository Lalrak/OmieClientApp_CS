using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.ContaReceber;

/// <summary>
/// Detalhes do recebimento (baixa).
/// </summary>
public class Recebimento
{
    /// <summary>
    /// Código de integração do recebimento.
    /// </summary>
    [JsonProperty("codigo_recebimento_integracao")]
    [StringLength(20, ErrorMessage = "O código de integração do recebimento deve ter no máximo 20 caracteres.")]
    public string CodigoRecebimentoIntegracao { get; set; }

    /// <summary>
    /// Código da conta corrente.
    /// </summary>
    [JsonProperty("codigo_conta_corrente")]
    public long? CodigoContaCorrente { get; set; }

    /// <summary>
    /// Valor do recebimento.
    /// </summary>
    [JsonProperty("valor")]
    public decimal? Valor { get; set; }

    /// <summary>
    /// Desconto do recebimento.
    /// </summary>
    [JsonProperty("desconto")]
    public decimal? Desconto { get; set; }

    /// <summary>
    /// Juros do recebimento.
    /// </summary>
    [JsonProperty("juros")]
    public decimal? Juros { get; set; }

    /// <summary>
    /// Multa do recebimento.
    /// </summary>
    [JsonProperty("multa")]
    public decimal? Multa { get; set; }

    /// <summary>
    /// Data do recebimento. (Formato dd/MM/yyyy)
    /// </summary>
    [JsonProperty("data")]
    [StringLength(10, ErrorMessage = "A data do recebimento deve ter no máximo 10 caracteres.")]
    public string Data { get; set; }

    /// <summary>
    /// Observação do recebimento.
    /// </summary>
    [JsonProperty("observacao")]
    public string Observacao { get; set; }
}