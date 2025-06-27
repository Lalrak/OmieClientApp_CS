using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.Clientes;

/// <summary>
/// Informações do cliente ou fornecedor.
/// </summary>
public class Info
{
    /// <summary>
    /// Data da Inclusão (formato dd/MM/yyyy). (Até 10 caracteres).
    /// </summary>
    [JsonProperty("dInc")]
    [StringLength(10, ErrorMessage = "A data de inclusão deve ter no máximo 10 caracteres.")]
    public string DInc { get; set; }

    /// <summary>
    /// Hora da Inclusão (formato HH:mm:ss). (Até 8 caracteres).
    /// </summary>
    [JsonProperty("hInc")]
    [StringLength(8, ErrorMessage = "A hora de inclusão deve ter no máximo 8 caracteres.")]
    public string HInc { get; set; }

    /// <summary>
    /// Usuário que realizou a inclusão. (Até 10 caracteres).
    /// </summary>
    [JsonProperty("uInc")]
    [StringLength(10, ErrorMessage = "O usuário de inclusão deve ter no máximo 10 caracteres.")]
    public string UInc { get; set; }

    /// <summary>
    /// Data da Alteração (formato dd/MM/yyyy). (Até 10 caracteres).
    /// </summary>
    [JsonProperty("dAlt")]
    [StringLength(10, ErrorMessage = "A data de alteração deve ter no máximo 10 caracteres.")]
    public string DAlt { get; set; }

    /// <summary>
    /// Hora da Alteração (formato HH:mm:ss). (Até 8 caracteres).
    /// </summary>
    [JsonProperty("hAlt")]
    [StringLength(8, ErrorMessage = "A hora de alteração deve ter no máximo 8 caracteres.")]
    public string HAlt { get; set; }

    /// <summary>
    /// Usuário que realizou a alteração. (Até 10 caracteres).
    /// </summary>
    [JsonProperty("uAlt")]
    [StringLength(10, ErrorMessage = "O usuário de alteração deve ter no máximo 10 caracteres.")]
    public string UAlt { get; set; }

    /// <summary>
    /// Indicador de importação pela API (“S” para SIM, “N” para NÃO). (Até 1 caractere).
    /// </summary>
    [JsonProperty("cImpAPI")]
    [StringLength(1, ErrorMessage = "O campo Importação API deve ter no máximo 1 caractere.")]
    public string CImpApi { get; set; }
}