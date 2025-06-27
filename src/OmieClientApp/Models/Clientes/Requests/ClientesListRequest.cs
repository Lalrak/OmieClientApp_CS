using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace OmieClientApp.Models.Clientes;

/// <summary>
/// <para>Parâmetros para listagem de clientes conforme definido pela API Omie.</para>
/// </summary>
public class ClientesListRequest
{

    /// <summary>
    /// <para>Número da página retornada.</para>
    /// </summary>
    [JsonProperty("pagina")]
    [Range(1, int.MaxValue, ErrorMessage = "O campo Página deve ser maior que 0.")]
    public int Pagina { get; set; } = 1;

    /// <summary>
    /// <para>Número de registros retornados na página.</para>
    /// </summary>
    [JsonProperty("registros_por_pagina")]
    public int RegistrosPorPagina { get; set; } = 50;

    /// <summary>
    /// <para>Exibir apenas os registros gerados pela API.</para>
    /// </summary>
    [JsonProperty("apenas_importado_api")]
    [StringLength(1, ErrorMessage = "O campo ApenasImportadoApi deve ter no máximo 1 caractere.")]
    public string ApenasImportadoApi { get; set; } = "N";

    /// <summary>
    /// <para>Filtrar os registros a partir de uma data (formato dd/MM/yyyy).</para>
    /// </summary>
    [JsonProperty("filtrar_por_data_de")]
    [StringLength(10, ErrorMessage = "O campo FiltrarPorDataDe deve ter no máximo 10 caracteres.")]
    public string FiltrarPorDataDe { get; set; }

    /// <summary>
    /// <para>Filtrar os registros até uma data (formato dd/MM/yyyy).</para>
    /// </summary>
    [JsonProperty("filtrar_por_data_ate")]
    [StringLength(10, ErrorMessage = "O campo FiltrarPorDataAte deve ter no máximo 10 caracteres.")]
    public string FiltrarPorDataAte { get; set; }

    /// <summary>
    /// <para>Filtro por hora a partir de (formato HH:mm:ss).</para>
    /// </summary>
    [JsonProperty("filtrar_por_hora_de")]
    [StringLength(8, ErrorMessage = "O campo FiltrarPorHoraDe deve ter no máximo 8 caracteres.")]
    public string FiltrarPorHoraDe { get; set; }

    /// <summary>
    /// <para>Filtro por hora até (formato HH:mm:ss).</para>
    /// </summary>
    [JsonProperty("filtrar_por_hora_ate")]
    [StringLength(8, ErrorMessage = "O campo FiltrarPorHoraAte deve ter no máximo 8 caracteres.")]
    public string FiltrarPorHoraAte { get; set; }

    /// <summary>
    /// <para>Filtrar apenas os registros incluídos.</para>
    /// </summary>
    [JsonProperty("filtrar_apenas_inclusao")]
    [StringLength(1, ErrorMessage = "O campo FiltrarApenasInclusao deve ter no máximo 1 caractere.")]
    public string FiltrarApenasInclusao { get; set; }

    /// <summary>
    /// <para>Filtrar apenas os registros alterados.</para>
    /// </summary>
    [JsonProperty("filtrar_apenas_alteracao")]
    [StringLength(1, ErrorMessage = "O campo FiltrarApenasAlteracao deve ter no máximo 1 caractere.")]
    public string FiltrarApenasAlteracao { get; set; }

    /// <summary>
    /// <para>Filtros avançados para cadastro de clientes.</para>
    /// </summary>
    [JsonProperty("clientesFiltro")]
    public ClientesFiltro ClientesFiltro { get; set; }

    /// <summary>
    /// <para>Lista de códigos para filtro de clientes.</para>
    /// </summary>
    [JsonProperty("clientesPorCodigo")]
    public List<ClientePorCodigo> ClientesPorCodigo { get; set; }

    /// <summary>
    /// <para>Exibe as características do cliente.</para>
    /// </summary>
    [JsonProperty("exibir_caracteristicas")]
    [StringLength(1, ErrorMessage = "O campo ExibirCaracteristicas deve ter no máximo 1 caractere.")]
    public string ExibirCaracteristicas { get; set; }

    /// <summary>
    /// <para>Exibe as observações do cliente. (“S” para SIM, “N” para NÃO)</para>
    /// <para>
    /// Padrão Não: "N"
    /// </para>
    /// </summary>
    [JsonProperty("exibir_obs")]
    [StringLength(1, ErrorMessage = "O campo ExibirObs deve ter no máximo 1 caractere.")]
    public string ExibirObs { get; set; }

}