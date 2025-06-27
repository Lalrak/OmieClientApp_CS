using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.ContaReceber;

/// <summary>
/// Detalhe do lançamento.
/// </summary>
public class LancamentoDetalhe
{
    /// <summary>
    /// Código de integração.
    /// </summary>
    [JsonProperty("nCodInt")]
    [StringLength(20, ErrorMessage = "O código de integração deve ter no máximo 20 caracteres.")]
    public string NCodInt { get; set; }

    /// <summary>
    /// Código do cliente.
    /// </summary>
    [JsonProperty("COO")]
    [StringLength(20, ErrorMessage = "O código do cliente deve ter no máximo 20 caracteres.")]
    public string COO { get; set; }

    /// <summary>
    /// Código do fornecedor.
    /// </summary>
    [JsonProperty("CCF")]
    [StringLength(20, ErrorMessage = "O código do fornecedor deve ter no máximo 20 caracteres.")]
    public string CCF { get; set; }
}