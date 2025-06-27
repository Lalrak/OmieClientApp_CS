using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.ContaReceber.Requests
{
    /// <summary>
    /// Requisição para conciliação de recebimento de conta a receber.
    /// </summary>
    public class ContaReceberConciliarRequest
    {
        /// <summary>
        /// Código da baixa.
        /// </summary>
        [JsonProperty("codigo_baixa")]
        public long? CodigoBaixa { get; set; }

        /// <summary>
        /// Código do lançamento gerado pelo integrador. (Até 60 caracteres)
        /// </summary>
        [JsonProperty("codigo_baixa_integracao")]
        [StringLength(60, ErrorMessage = "O campo deve ter no máximo 60 caracteres.")]
        public string CodigoBaixaIntegracao { get; set; }
    }
}
