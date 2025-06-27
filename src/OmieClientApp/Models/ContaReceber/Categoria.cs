using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.ContaReceber;

/// <summary>
/// Rateio de categoria.
/// </summary>
public class Categoria
{
    /// <summary>
    /// Código da categoria.
    /// </summary>
    [JsonProperty("codigo_categoria")]
    [StringLength(20, ErrorMessage = "O código da categoria deve ter no máximo 20 caracteres.")]
    public string CodigoCategoria { get; set; }

    /// <summary>
    /// Valor do rateio.
    /// </summary>
    [JsonProperty("valor")]
    public decimal? Valor { get; set; }

    /// <summary>
    /// Percentual da categoria.
    /// </summary>
    [JsonProperty("percentual")]
    public decimal? Percentual { get; set; }
}