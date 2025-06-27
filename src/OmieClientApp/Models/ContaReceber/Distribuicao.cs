using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.ContaReceber;

/// <summary>
/// Distribuição por departamento.
/// </summary>
public class Distribuicao
{
    /// <summary>
    /// Código do departamento.
    /// </summary>
    [JsonProperty("cCodDep")]
    [StringLength(40, ErrorMessage = "O código do departamento deve ter no máximo 40 caracteres.")]
    public string CCodDep { get; set; }

    /// <summary>
    /// Descrição do departamento.
    /// </summary>
    [JsonProperty("cDesDep")]
    [StringLength(50, ErrorMessage = "A descrição do departamento deve ter no máximo 50 caracteres.")]
    public string CDesDep { get; set; }

    /// <summary>
    /// Valor do departamento.
    /// </summary>
    [JsonProperty("nValDep")]
    public decimal? NValDep { get; set; }

    /// <summary>
    /// Percentual do departamento.
    /// </summary>
    [JsonProperty("nPerDep")]
    public decimal? NPerDep { get; set; }
}