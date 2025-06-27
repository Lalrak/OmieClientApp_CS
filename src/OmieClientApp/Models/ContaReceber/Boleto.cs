using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.ContaReceber;

/// <summary>
/// Informações do boleto.
/// </summary>
public class Boleto
{
    /// <summary>
    /// Indica se o boleto foi gerado. (S/N)
    /// </summary>
    [JsonProperty("cGerado")]
    [StringLength(1, ErrorMessage = "O campo deve ter no máximo 1 caractere.")]
    public string CGerado { get; set; }

    /// <summary>
    /// Data de emissão do boleto. (Formato dd/MM/yyyy)
    /// </summary>
    [JsonProperty("dDtEmBol")]
    [StringLength(10, ErrorMessage = "O campo deve ter no máximo 10 caracteres.")]
    public string DDtEmBol { get; set; }

    /// <summary>
    /// Número do boleto.
    /// </summary>
    [JsonProperty("cNumBoleto")]
    [StringLength(30, ErrorMessage = "O campo deve ter no máximo 30 caracteres.")]
    public string CNumBoleto { get; set; }

    /// <summary>
    /// Número bancário do boleto.
    /// </summary>
    [JsonProperty("cNumBancario")]
    [StringLength(30, ErrorMessage = "O campo deve ter no máximo 30 caracteres.")]
    public string CNumBancario { get; set; }

    /// <summary>
    /// Percentual de juros do boleto.
    /// </summary>
    [JsonProperty("nPerJuros")]
    public decimal? NPerJuros { get; set; }

    /// <summary>
    /// Percentual de multa do boleto.
    /// </summary>
    [JsonProperty("nPerMulta")]
    public decimal? NPerMulta { get; set; }
}
