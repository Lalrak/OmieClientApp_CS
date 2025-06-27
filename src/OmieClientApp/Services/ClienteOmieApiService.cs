using Newtonsoft.Json;
using OmieClientApp.Models;
using OmieClientApp.Models.Clientes;
using OmieClientApp.Models.Clientes.Responses;
using System.Net.Http.Headers;
using System.Text;

namespace OmieClientApp.Services;

/// <summary>
/// Serviço para interagir com a API Omie
/// </summary>
public class ClienteOmieApiService
{
    private readonly HttpClient _httpClient;
    private readonly string _appKey;
    private readonly string _appSecret;
    private readonly string _baseUrl = "https://app.omie.com.br/api/v1/geral/clientes/";

    /// <summary>
    /// Construtor da classe
    /// </summary>
    /// <param name="appKey">Chave da API</param>
    /// <param name="appSecret">Segredo da API</param>
    public ClienteOmieApiService(string appKey, string appSecret)
    {
        _appKey = appKey;
        _appSecret = appSecret;
        _httpClient = new HttpClient { BaseAddress = new Uri(_baseUrl) };
        _httpClient.DefaultRequestHeaders.Accept.Clear();
        _httpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json")
        );
    }

    /// <summary>
    /// Método para realizar requisições POST
    /// </summary>
    /// <typeparam name="T">Tipo do retorno</typeparam>
    /// <param name="call">Nome da chamada</param>
    /// <param name="param">Parâmetros da requisição</param>
    private async Task<T> PostAsync<T>(string call, object param)
    {
        var request = new OmieRequest
        {
            Call = call,
            AppKey = _appKey,
            AppSecret = _appSecret,
            Param = new[] { param }
        };

        var jsonRequest = JsonConvert.SerializeObject(request, new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            Formatting = Formatting.Indented
        });

        var content = new StringContent(jsonRequest, Encoding.UTF8);
        content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        var response = await _httpClient.PostAsync("", content);
        var jsonResponse = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode || jsonResponse.Contains("faultstring"))
        {
            var error = JsonConvert.DeserializeObject<OmieFaulResponse>(jsonResponse);
            throw new HttpRequestException($"Erro ao chamar a API: {error.FaultString} - {error.FaultString}");
        }

        return JsonConvert.DeserializeObject<T>(jsonResponse);
    }

    /// <summary>
    /// Método para alterar um cliente
    /// </summary>
    /// <param name="request">Request com os dados do cliente</param>
    /// <returns>Response com o status da operação</returns>
    public async Task<ClientesStatusResponse> AlterarCliente(ClientesCadastro request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O par�metro 'request' n�o pode ser nulo.");
        return await PostAsync<ClientesStatusResponse>("AlterarCliente", request);
    }

    /// <summary>
    /// Método para associar um código interno ao cliente
    /// </summary>
    /// <param name="request">Request com os dados do cliente</param>
    /// <returns>Response com o status da operação</returns>
    public async Task<ClientesStatusResponse> AssociarCodIntCliente(ClientesCadastroResumido request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O par�metro 'request' n�o pode ser nulo.");
        return await PostAsync<ClientesStatusResponse>("AssociarCodIntCliente", request);
    }

    /// <summary>
    /// Método para consultar um cliente
    /// </summary>
    /// <param name="request">Request com os dados do cliente</param>
    /// <returns>Response com os dados do cliente</returns>
    public async Task<ClientesCadastro> ConsultarCliente(ClientesCadastroResumido request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O par�metro 'request' n�o pode ser nulo.");
        return await PostAsync<ClientesCadastro>("ConsultarCliente", request);
    }

    /// <summary>
    /// Método para excluir um cliente
    /// </summary>
    /// <param name="request">Request com os dados do cliente</param>
    /// <returns>Response com o status da operação</returns>
    public async Task<ClientesStatusResponse> ExcluirCliente(ClientesCadastroResumido request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O par�metro 'request' n�o pode ser nulo.");
        return await PostAsync<ClientesStatusResponse>("ExcluirCliente", request);
    }

    /// <summary>
    /// Método para incluir um cliente
    /// </summary>
    /// <param name="request">Request com os dados do cliente</param>
    /// <returns>Response com o status da operação</returns>
    public async Task<ClientesStatusResponse> IncluirCliente(ClientesCadastro request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O par�metro 'request' n�o pode ser nulo.");
        return await PostAsync<ClientesStatusResponse>("IncluirCliente", request);
    }

    /// <summary>
    /// Método para listar clientes
    /// </summary>
    /// <param name="request">Request com os dados do cliente</param>
    /// <returns>Response com os dados dos clientes</returns>
    public async Task<ClientesListResponse> ListarClientes(ClientesListRequest request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O par�metro 'request' n�o pode ser nulo.");
        return await PostAsync<ClientesListResponse>("ListarClientes", request);
    }

    /// <summary>
    /// Método para listar clientes resumido
    /// </summary>
    /// <param name="request">Request com os dados do cliente</param>
    /// <returns>Response com os dados dos clientes</returns>
    public async Task<ClientesListResponse> ListarClientesResumido(ClientesListRequest request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O par�metro 'request' n�o pode ser nulo.");
        return await PostAsync<ClientesListResponse>("ListarClientesResumido", request);
    }

    /// <summary>
    /// Método para upsert de cliente
    /// </summary>
    /// <param name="request">Request com os dados do cliente</param>
    /// <returns>Response com o status da operação</returns>
    public async Task<ClientesStatusResponse> UpsertCliente(ClientesCadastro request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O par�metro 'request' n�o pode ser nulo.");
        return await PostAsync<ClientesStatusResponse>("UpsertCliente", request);
    }

    /// <summary>
    /// Método para upsert de cliente com CPF/CNPJ
    /// </summary>
    /// <param name="request">Request com os dados do cliente</param>
    /// <returns>Response com o status da operação</returns>
    public async Task<ClientesStatusResponse> UpsertClienteCpfCnpj(ClientesCadastro request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O par�metro 'request' n�o pode ser nulo.");
        return await PostAsync<ClientesStatusResponse>("UpsertClienteCpfCnpj", request);
    }
}