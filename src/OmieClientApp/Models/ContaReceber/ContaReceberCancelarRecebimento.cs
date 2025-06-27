using Newtonsoft.Json;

namespace OmieClientApp.Models.ContaReceber
{
    /// <summary>
    /// Requisição de cancelamento de lançamento de baixa do recebimento.
    /// </summary>
    public class ContaReceberCancelarRecebimento
    {
        /// <summary>
        /// Código da baixa a ser cancelada.
        /// </summary>
        [JsonProperty("codigo_baixa")]
        public long? CodigoBaixa { get; set; }
    }
}
