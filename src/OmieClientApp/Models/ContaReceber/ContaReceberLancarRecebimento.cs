using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.ContaReceber
{
    /// <summary>
    /// Informações para realizar a baixa de uma Conta a Receber.
    /// </summary>
    public class ContaReceberLancarRecebimento
    {
        /// <summary>
        /// Chave do lançamento a receber.
        /// </summary>
        [JsonProperty("codigo_lancamento")]
        public long CodigoLancamento { get; set; }

        /// <summary>
        /// Código do lançamento gerado pelo integrador.
        /// </summary>
        [JsonProperty("codigo_lancamento_integracao")]
        [StringLength(60, ErrorMessage = "O campo deve ter no máximo 60 caracteres.")]
        public string CodigoLancamentoIntegracao { get; set; }

        /// <summary>
        /// Código da baixa.
        /// </summary>
        [JsonProperty("codigo_baixa")]
        public long CodigoBaixa { get; set; }

        /// <summary>
        /// Código da baixa gerada pelo integrador.
        /// </summary>
        [JsonProperty("codigo_baixa_integracao")]
        [StringLength(20, ErrorMessage = "O campo deve ter no máximo 20 caracteres.")]
        public string CodigoBaixaIntegracao { get; set; }

        /// <summary>
        /// Id da conta corrente onde será registrada a baixa.
        /// </summary>
        [JsonProperty("codigo_conta_corrente")]
        public long CodigoContaCorrente { get; set; }

        /// <summary>
        /// Código da conta corrente onde será registrada a baixa.
        /// </summary>
        [JsonProperty("codigo_conta_corrente_integracao")]
        [StringLength(20, ErrorMessage = "O campo deve ter no máximo 20 caracteres.")]
        public string CodigoContaCorrenteIntegracao { get; set; }

        /// <summary>
        /// Valor a ser baixado.
        /// </summary>
        [JsonProperty("valor")]
        public decimal Valor { get; set; }

        /// <summary>
        /// Valor do juros.
        /// </summary>
        [JsonProperty("juros")]
        public decimal Juros { get; set; }

        /// <summary>
        /// Valor do desconto.
        /// </summary>
        [JsonProperty("desconto")]
        public decimal Desconto { get; set; }

        /// <summary>
        /// Valor da multa.
        /// </summary>
        [JsonProperty("multa")]
        public decimal Multa { get; set; }

        /// <summary>
        /// Data da baixa. (Formato dd/MM/yyyy)
        /// </summary>
        [JsonProperty("data")]
        [StringLength(10, ErrorMessage = "O campo deve ter no máximo 10 caracteres.")]
        public string Data { get; set; }

        /// <summary>
        /// Observação da baixa.
        /// </summary>
        [JsonProperty("observacao")]
        public string Observacao { get; set; }

        /// <summary>
        /// Bloquear lançamento (S/N)
        /// </summary>
        [JsonProperty("bloqueado")]
        public string Bloqueado { get; set; }

        /// <summary>
        /// Conciliar documento (S/N)
        /// </summary>
        [JsonProperty("conciliar_documento")]
        public string ConciliarDocumento { get; set; }

        /// <summary>
        /// Número sequencial único.
        /// </summary>
        [JsonProperty("nsu")]
        [StringLength(100, ErrorMessage = "O campo deve ter no máximo 100 caracteres.")]
        public string Nsu { get; set; }
    }
}
