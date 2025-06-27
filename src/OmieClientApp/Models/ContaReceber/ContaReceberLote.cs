using Newtonsoft.Json;

namespace OmieClientApp.Models.ContaReceber
{
    /// <summary>
    /// Requisição de inclusão de contas a receber por lote.
    /// </summary>
    public class ContaReceberLote
    {
        /// <summary>
        /// Identificador do lote.
        /// </summary>
        [JsonProperty("lote")]
        public int Lote { get; set; }

        /// <summary>
        /// Lista de contas a receber no lote.
        /// </summary>
        [JsonProperty("conta_receber_cadastro")]
        public List<ContaReceberCadastro> ContaReceberCadastro { get; set; }
    }
}
