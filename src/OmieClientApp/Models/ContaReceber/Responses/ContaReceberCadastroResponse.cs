using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.ContaReceber.Responses;

/// <summary>
/// Resposta do cadastro de contas a receber.
/// </summary> 
public class ContaReceberCadastroResponse
{
    /// <summary>
    /// Código do lançamento Omie.
    /// </summary>
    [JsonProperty("codigo_lancamento_omie")]
    public long? CodigoLancamentoOmie { get; set; }

    /// <summary>
    /// Código do lançamento gerado pelo integrador.
    /// </summary>
    [JsonProperty("codigo_lancamento_integracao")]
    [StringLength(60, ErrorMessage = "O código de integração deve ter no máximo 60 caracteres.")]
    public string CodigoLancamentoIntegracao { get; set; }

    /// <summary>
    /// Código do status do processamento.
    /// </summary>
    [JsonProperty("codigo_status")]
    [StringLength(4, ErrorMessage = "O código de status deve ter no máximo 4 caracteres.")]
    public string CodigoStatus { get; set; }

    /// <summary>
    /// Descrição do status do processamento.
    /// </summary>
    [JsonProperty("descricao_status")]
    public string DescricaoStatus { get; set; }
}