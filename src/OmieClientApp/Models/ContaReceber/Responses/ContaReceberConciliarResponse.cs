using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.ContaReceber.Responses;

/// <summary>
/// Resposta da conciliação de recebimento de conta a receber.
/// </summary>
public class ContaReceberConciliarResponse
{
    /// <summary>
    /// Código da baixa.
    /// </summary>
    [JsonProperty("codigo_baixa")]
    public long? CodigoBaixa { get; set; }

    /// <summary>
    /// Código de integração da baixa. (Até 20 caracteres)
    /// </summary>
    [JsonProperty("codigo_baixa_integracao")]
    [StringLength(20, ErrorMessage = "O campo deve ter no máximo 20 caracteres.")]
    public string CodigoBaixaIntegracao { get; set; }

    /// <summary>
    /// Código do status do processamento. (Até 4 caracteres)
    /// </summary>
    [JsonProperty("codigo_status")]
    [StringLength(4, ErrorMessage = "O campo deve ter no máximo 4 caracteres.")]
    public string CodigoStatus { get; set; }

    /// <summary>
    /// Descrição do status do processamento.
    /// </summary>
    [JsonProperty("descricao_status")]
    public string DescricaoStatus { get; set; }
}