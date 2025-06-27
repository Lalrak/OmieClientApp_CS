using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.ContaReceber;

/// <summary>
/// Repetição semanal.
/// </summary>
public class Semanal
{
    /// <summary>
    /// Informe o dia da semana que será o vencimento do lançamento.
    /// (segunda, terca, quarta, quinta, sexta, sabado, domingo)
    /// </summary>
    [JsonProperty("repetir_dia_semana")]
    [StringLength(10, ErrorMessage = "O dia da semana deve ter no máximo 10 caracteres.")]
    public string RepetirDiaSemana { get; set; }

    /// <summary>
    /// Informe aqui a quantidade de parcelas que serão cadastradas com um limite de até 120 repetições
    /// </summary>
    [JsonProperty("repetir_por")]
    public int? RepetirPor { get; set; }
}