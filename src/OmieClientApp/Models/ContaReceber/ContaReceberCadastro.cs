using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.ContaReceber;

/// <summary>
/// Cadastro de contas a receber conforme API Omie.
/// </summary>
public class ContaReceberCadastro
{
    /// <summary>
    /// Chave do Lançamento
    /// </summary>
    [JsonProperty("codigo_lancamento_omie")]
    public long? CodigoLancamentoOmie { get; set; }

    /// <summary>
    /// Código do lançamento gerado pelo integrador.
    /// </summary>
    [JsonProperty("codigo_lancamento_integracao")]
    [StringLength(60, ErrorMessage = "O código de integração deve ter no máximo 60 caracteres.")]
    public string CodigoLancamentoIntegracao { get; set; }

    /// <summary>
    /// Código do cliente fornecedor.
    /// </summary>
    [JsonProperty("codigo_cliente_fornecedor")]
    public long? CodigoClienteFornecedor { get; set; }

    /// <summary>
    /// Código do cliente fornecedor gerado pelo integrador.
    /// </summary>
    [JsonProperty("codigo_cliente_fornecedor_integracao")]
    [StringLength(60, ErrorMessage = "O código de integração deve ter no máximo 60 caracteres.")]
    public string CodigoClienteFornecedorIntegracao { get; set; }

    /// <summary>
    /// Data de vencimento do lançamento. (Formato: dd/mm/yyyy)
    /// </summary>
    [JsonProperty("data_vencimento")]
    [StringLength(10, ErrorMessage = "A data de vencimento deve ter no máximo 10 caracteres.")]
    public string DataVencimento { get; set; }

    /// <summary>
    /// Valor do documento.
    /// </summary>
    [JsonProperty("valor_documento")]
    public decimal? ValorDocumento { get; set; }

    /// <summary>
    /// Código da categoria.
    /// </summary>
    [JsonProperty("codigo_categoria")]
    [StringLength(20, ErrorMessage = "O código da categoria deve ter no máximo 20 caracteres.")]
    public string CodigoCategoria { get; set; }

    /// <summary>
    /// Data de previsão do lançamento. (Formato: dd/mm/yyyy)
    /// </summary>
    [JsonProperty("data_previsao")]
    [StringLength(10, ErrorMessage = "A data de previsão deve ter no máximo 10 caracteres.")]
    public string DataPrevisao { get; set; }

    /// <summary>
    /// Rateio de Categoria
    /// </summary>
    [JsonProperty("categorias")]
    public List<Categoria> Categorias { get; set; }

    /// <summary>
    /// Id da conta corrente.
    /// </summary>
    [JsonProperty("id_conta_corrente")]
    public long? IdContaCorrente { get; set; }

    /// <summary>
    /// Número do documento.
    /// </summary>
    [JsonProperty("numero_documento")]
    [StringLength(20, ErrorMessage = "O número do documento deve ter no máximo 20 caracteres.")]
    public string NumeroDocumento { get; set; }

    /// <summary>
    /// Número da parcela "Formatada" como 999/999.
    /// </summary>
    [JsonProperty("numero_parcela")]
    [StringLength(7, ErrorMessage = "O número da parcela deve ter no máximo 7 caracteres.")]
    public string NumeroParcela { get; set; }

    /// <summary>
    /// Código do tipo de documento.
    /// </summary>
    [JsonProperty("codigo_tipo_documento")]
    [StringLength(5, ErrorMessage = "O código do tipo de documento deve ter no máximo 5 caracteres.")]
    public string CodigoTipoDocumento { get; set; }

    /// <summary>
    /// Número do documento fiscal.
    /// </summary>
    [JsonProperty("numero_documento_fiscal")]
    [StringLength(20, ErrorMessage = "O número do documento fiscal deve ter no máximo 20 caracteres.")]
    public string NumeroDocumentoFiscal { get; set; }

    /// <summary>
    /// Número do pedido.
    /// </summary>
    [JsonProperty("numero_pedido")]
    [StringLength(15, ErrorMessage = "O número do pedido deve ter no máximo 15 caracteres.")]
    public string NumeroPedido { get; set; }

    /// <summary>
    /// Chave da NFe.
    /// </summary>
    [JsonProperty("chave_nfe")]
    [StringLength(44, ErrorMessage = "A chave da NFe deve ter no máximo 44 caracteres.")]
    public string ChaveNfe { get; set; }

    /// <summary>
    /// Observação do lançamento.
    /// </summary>
    [JsonProperty("observacao")]
    public string Observacao { get; set; }

    /// <summary>
    /// Código de barras da ficha de compensação.
    /// </summary>
    [JsonProperty("codigo_barras_ficha_compensacao")]
    [StringLength(70, ErrorMessage = "O código de barras da ficha de compensação deve ter no máximo 70 caracteres.")]
    public string CodigoBarrasFichaCompensacao { get; set; }

    /// <summary>
    /// Código CMC7 do cheque.
    /// </summary>
    [JsonProperty("codigo_cmc7_cheque")]
    [StringLength(40, ErrorMessage = "O código CMC7 do cheque deve ter no máximo 40 caracteres.")]
    public string CodigoCmc7Cheque { get; set; }

    /// <summary>
    /// Data de emissão do lançamento. (Formato: dd/mm/yyyy)
    /// </summary>
    [JsonProperty("data_emissao")]
    [StringLength(10, ErrorMessage = "A data de emissão deve ter no máximo 10 caracteres.")]
    public string DataEmissao { get; set; }

    /// <summary>
    /// Código da origem do lançamento.
    /// <para>
    /// 'APIR' - Integração de Conta a Receber
    /// 'BARR' - Conta a Receber Importada por Código de Barras
    /// 'CTER' - Parcela a Receber de um CT-e
    /// 'DEVR' - Conta a Receber da Devolução ao Fornecedor
    /// 'MANR' - Lançamento Manual de Conta a Receber
    /// 'NFER' - Conta a Receber Importada de uma NF-e
    /// 'RPTR' - Repetição de Contas a Receber
    /// 'VENR' - Parcela a Receber de Vendas
    /// 'XMLR' - Conta a Receber Importada de um arquivo XML
    /// </para>
    /// </summary>
    [JsonProperty("id_origem")]
    [StringLength(4, ErrorMessage = "O código da origem deve ter no máximo 4 caracteres.")]
    public string IdOrigem { get; set; }

    /// <summary>
    /// Código da operação.
    /// </summary>
    [JsonProperty("operacao")]
    [StringLength(2)]
    public string Operacao { get; set; }

    /// <summary>
    /// Valor do PIS.
    /// </summary>
    [JsonProperty("valor_pis")]
    public decimal? ValorPis { get; set; }

    /// <summary>
    /// Indica se o PIS será retido. (S/N)
    /// </summary>
    [JsonProperty("retem_pis")]
    [StringLength(1)]
    public string RetemPis { get; set; }

    /// <summary>
    /// Valor do COFINS.
    /// </summary>
    [JsonProperty("valor_cofins")]
    public decimal? ValorCofins { get; set; }

    /// <summary>
    /// Indica se o COFINS será retido. (S/N)
    /// </summary>
    [JsonProperty("retem_cofins")]
    [StringLength(1)]
    public string RetemCofins { get; set; }

    /// <summary>
    /// Valor do CSLL.
    /// </summary>
    [JsonProperty("valor_csll")]
    public decimal? ValorCsll { get; set; }

    /// <summary>
    /// Indica se o CSLL será retido. (S/N)
    /// </summary>
    [JsonProperty("retem_csll")]
    [StringLength(1)]
    public string RetemCsll { get; set; }

    /// <summary>
    /// Valor do IR.
    /// </summary>
    [JsonProperty("valor_ir")]
    public decimal? ValorIr { get; set; }

    /// <summary>
    /// Indica se o IR será retido. (S/N)
    /// </summary>
    [JsonProperty("retem_ir")]
    [StringLength(1)]
    public string RetemIr { get; set; }

    /// <summary>
    /// Valor do ISS.
    /// </summary>
    [JsonProperty("valor_iss")]
    public decimal? ValorIss { get; set; }

    /// <summary>
    /// Indica se o ISS será retido. (S/N)
    /// </summary>
    [JsonProperty("retem_iss")]
    [StringLength(1)]
    public string RetemIss { get; set; }

    /// <summary>
    /// Valor do INSS.
    /// </summary>
    [JsonProperty("valor_inss")]
    public decimal? ValorInss { get; set; }

    /// <summary>
    /// Indica se o INSS será retido. (S/N)
    /// </summary>
    [JsonProperty("retem_inss")]
    [StringLength(1)]
    public string RetemInss { get; set; }

    /// <summary>
    /// Indica se o lançamento está bloqueado. (S/N)
    /// </summary>
    [JsonProperty("bloqueado")]
    [StringLength(1)]
    public string Bloqueado { get; set; }

    /// <summary>
    /// Indica se a baixa do lançamento está bloqueada. (S/N)
    /// </summary>
    [JsonProperty("bloquear_baixa")]
    [StringLength(1)]
    public string BloquearBaixa { get; set; }

    /// <summary>
    /// Indica se o lançamento foi importado via API. (S/N)
    /// </summary>
    [JsonProperty("importado_api")]
    [StringLength(1)]
    public string ImportadoApi { get; set; }

    /// <summary>
    /// Indica se o documento deve ser baixado. (S/N)
    /// </summary>
    [JsonProperty("baixar_documento")]
    [StringLength(1)]
    public string BaixarDocumento { get; set; }

    /// <summary>
    /// Indica se o documento deve ser conciliado. (S/N)
    /// </summary>
    [JsonProperty("conciliar_documento")]
    [StringLength(1)]
    public string ConciliarDocumento { get; set; }

    /// <summary>
    /// Ação a ser realizada.
    /// <para>
    /// A-Adiciona Valor
    /// S-Subtrai valor
    /// L-Lança valor.
    /// </para>
    /// </summary>
    [JsonProperty("acao")]
    public string Acao { get; set; }

    /// <summary>
    /// Detalhes do lançamento.
    /// </summary>
    [JsonProperty("lancamento_detalhe")]
    public List<LancamentoDetalhe> LancamentoDetalhe { get; set; }

    /// <summary>
    /// Distribuição por departamentos.
    /// </summary>
    [JsonProperty("distribuicao")]
    public List<Distribuicao> Distribuicao { get; set; }

    /// <summary>
    /// Status do título.
    /// </summary>
    [JsonProperty("status_titulo")]
    [StringLength(100, ErrorMessage = "O status do título deve ter no máximo 100 caracteres.")]
    public string StatusTitulo { get; set; }

    /// <summary>
    /// Código do vendedor.
    /// </summary>
    [JsonProperty("codigo_vendedor")]
    public int? CodigoVendedor { get; set; }

    /// <summary>
    /// Código do projeto.
    /// </summary>
    [JsonProperty("codigo_projeto")]
    public int? CodigoProjeto { get; set; }

    /// <summary>
    /// Número sequencial único.
    /// </summary>
    [JsonProperty("nsu")]
    [StringLength(100, ErrorMessage = "O número sequencial único deve ter no máximo 100 caracteres.")]
    public string Nsu { get; set; }

    /// <summary>
    /// Data de registro do lançamento.
    /// </summary>
    [JsonProperty("data_registro")]
    [StringLength(10, ErrorMessage = "A data de registro deve ter no máximo 10 caracteres.")]
    public string DataRegistro { get; set; }

    /// <summary>
    /// Tipo de agrupamento dos lancamentos.
    /// <para>Pode ser:
    /// C-Consolidado (sintético).
    /// I-Individual (analítico).
    /// </para>
    /// <para>
    /// Não deve ser preenchido na Inclusão/alteração pois é de preenchimento automático para lançamentos recebidos do PDV.
    /// </para>
    /// </summary>
    [JsonProperty("tipo_agrupamento")]
    [StringLength(1, ErrorMessage = "O tipo de agrupamento deve ter no máximo 1 caractere.")]
    public string TipoAgrupamento { get; set; }

    /// <summary>
    /// Informações do lançamento.
    /// </summary>
    [JsonProperty("info")]
    public Info Info { get; set; }

    /// <summary>
    /// Boleto do lançamento.
    /// </summary>
    [JsonProperty("boleto")]
    public Boleto Boleto { get; set; }

    /// <summary>
    /// Código do pedido.
    /// </summary>
    [JsonProperty("nCodPedido")]
    public int? NCodPedido { get; set; }

    /// <summary>
    /// Postergar data de vencimento.
    /// </summary>
    [JsonProperty("bloquear_exclusao")]
    [StringLength(1)]
    public string BloquearExclusao { get; set; }

    /// <summary>
    /// Código da ordem de serviço.
    /// </summary>
    [JsonProperty("nCodOS")]
    public int? NCodOS { get; set; }

    /// <summary>
    /// Código do pedido do cliente.
    /// </summary>
    [JsonProperty("cPedidoCliente")]
    [StringLength(30)]
    public string CPedidoCliente { get; set; }

    /// <summary>
    /// Código do número do contrato.
    /// </summary>
    [JsonProperty("cNumeroContrato")]
    [StringLength(20)]
    public string CNumeroContrato { get; set; }

    /// <summary>
    /// Recebimento do lançamento.
    /// </summary>
    [JsonProperty("recebimento")]
    public Recebimento Recebimento { get; set; }

    /// <summary>
    /// Repetição do lançamento.
    /// </summary>
    [JsonProperty("repeticao")]
    public Repeticao Repeticao { get; set; }

    /// <summary>
    /// Indica se o aprendizado do rateio está ativado.
    /// </summary>
    [JsonProperty("aprendizado_rateio")]
    [StringLength(1)]
    public string AprendizadoRateio { get; set; }
}