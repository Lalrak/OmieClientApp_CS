using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.ContaReceber;

/// <summary>
/// Informações complementares do lançamento.
/// </summary>
public class Info
{
    /// <summary>
    /// Data da Inclusão. (Formato dd/MM/yyyy)
    /// </summary>
    [JsonProperty("dInc")]
    [StringLength(10, ErrorMessage = "O campo deve ter no máximo 10 caracteres.")]
    public string DInc { get; set; }

    /// <summary>
    /// Hora da Inclusão. (Formato hh:mm:ss)
    /// </summary>
    [JsonProperty("hInc")]
    [StringLength(8, ErrorMessage = "O campo deve ter no máximo 8 caracteres.")]
    public string HInc { get; set; }

    /// <summary>
    /// Usuário da Inclusão.
    /// </summary>
    [JsonProperty("uInc")]
    [StringLength(10, ErrorMessage = "O campo deve ter no máximo 10 caracteres.")]
    public string UInc { get; set; }

    /// <summary>
    /// Data da Alteração. (Formato dd/MM/yyyy)
    /// </summary>
    [JsonProperty("dAlt")]
    [StringLength(10, ErrorMessage = "O campo deve ter no máximo 10 caracteres.")]
    public string DAlt { get; set; }

    /// <summary>
    /// Hora da Alteração. (Formato hh:mm:ss)
    /// </summary>
    [JsonProperty("hAlt")]
    [StringLength(8, ErrorMessage = "O campo deve ter no máximo 8 caracteres.")]
    public string HAlt { get; set; }

    /// <summary>
    /// Usuário da Alteração.
    /// </summary>
    [JsonProperty("uAlt")]
    [StringLength(10, ErrorMessage = "O campo deve ter no máximo 10 caracteres.")]
    public string UAlt { get; set; }

    /// <summary>
    /// Importado pela API. (S/N)
    /// </summary>
    [JsonProperty("cImpAPI")]
    [StringLength(1, ErrorMessage = "O campo deve ter no máximo 1 caractere.")]
    public string CImpApi { get; set; }
}