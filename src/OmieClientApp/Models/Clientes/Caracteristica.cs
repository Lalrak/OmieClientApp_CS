using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.Clientes;

/// <summary>
/// Características do cliente.
/// </summary>
public class Caracteristica
{
    /// <summary>
    /// Nome da característica. (Até 30 caracteres)
    /// </summary>
    [JsonProperty("campo")]
    [StringLength(30, ErrorMessage = "O campo deve ter no máximo 30 caracteres.")]
    public string Campo { get; set; }

    /// <summary>
    /// Conteúdo da característica. (Até 60 caracteres)
    /// </summary>
    [JsonProperty("conteudo")]
    [StringLength(60, ErrorMessage = "O conteúdo deve ter no máximo 60 caracteres.")]
    public string Conteudo { get; set; }
}