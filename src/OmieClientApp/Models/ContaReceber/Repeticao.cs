using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.ContaReceber;

/// <summary>
/// Repetição do lançamento.
/// </summary>
public class Repeticao
{
    /// <summary>
    /// Indica se o lançamento será antecipado. (S/N)
    /// </summary>
    [JsonProperty("antecipar")]
    [StringLength(1)]
    public string Antecipar { get; set; }

    /// <summary>
    /// Indica se o lançamento será postergado. (S/N)
    /// </summary>
    [JsonProperty("postergar")]
    [StringLength(1)]
    public string Postergar { get; set; }

    /// <summary>
    /// Informações da repetição mensal.
    /// </summary>
    [JsonProperty("mensal")]
    public Mensal Mensal { get; set; }

    /// <summary>
    /// Informações da repetição semanal.
    /// </summary>
    [JsonProperty("semanal")]
    public Semanal Semanal { get; set; }

    /// <summary>
    /// Informações da repetição específica.
    /// </summary>
    [JsonProperty("especifico")]
    public Especifico Especifico { get; set; }
}