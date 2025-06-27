using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.ContaReceber;

/// <summary>
/// Chave de pesquisa do Lançamento de Contas a Receber.
/// </summary>
public class LcrChave
{
    /// <summary>
    /// Chave do lançamento no Omie.
    /// </summary>
    [JsonProperty("codigo_lancamento_omie")]
    public int CodigoLancamentoOmie { get; set; }

    /// <summary>
    /// Código do lançamento gerado pelo integrador. (Até 60 caracteres)
    /// </summary>
    [JsonProperty("codigo_lancamento_integracao")]
    [StringLength(60, ErrorMessage = "O campo deve ter no máximo 60 caracteres.")]
    public string CodigoLancamentoIntegracao { get; set; }
}
