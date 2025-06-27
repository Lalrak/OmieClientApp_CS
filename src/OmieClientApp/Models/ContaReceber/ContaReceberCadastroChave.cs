using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.ContaReceber
{
    /// <summary>
    /// Chave da conta a receber.
    /// </summary>
    public class ContaReceberCadastroChave
    {
        /// <summary>
        /// Chave do Lançamento.
        /// </summary>
        [JsonProperty("chave_lancamento")]
        public int ChaveLancamento { get; set; }

        /// <summary>
        /// Código do lançamento gerado pelo integrador. (Até 60 caracteres)
        /// </summary>
        [JsonProperty("codigo_lancamento_integracao")]
        [StringLength(60, ErrorMessage = "O campo deve ter no máximo 60 caracteres.")]
        public string CodigoLancamentoIntegracao { get; set; }
    }
}
