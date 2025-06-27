using Newtonsoft.Json;
using OmieClientApp.Models;
using OmieClientApp.Models.ContaReceber;
using OmieClientApp.Models.ContaReceber.Requests;
using OmieClientApp.Models.ContaReceber.Responses;
using System.Net.Http.Headers;
using System.Text;

namespace OmieClientApp.Services;

public class ContaReceberOmieApiService
{
    private readonly HttpClient _httpClient;
    private readonly string _appKey;
    private readonly string _appSecret;
    private readonly string _baseUrl = "https://app.omie.com.br/api/v1/financas/contareceber/";
    public ContaReceberOmieApiService(string appKey, string appSecret)
    {
        _appKey = appKey;
        _appSecret = appSecret;
        _httpClient = new HttpClient { BaseAddress = new Uri(_baseUrl) };
        _httpClient.DefaultRequestHeaders.Accept.Clear();
        _httpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json")
        );
    }

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

    public async Task<ContaReceberCadastroResponse> AlterarContaReceber(ContaReceberCadastro request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O parâmetro 'request' não pode ser nulo.");
        return await PostAsync<ContaReceberCadastroResponse>("AlterarContaReceber", request);
    }

    public async Task<ContaReceberCadastroChave> AlterarDistribuicaoDepartamento(RateioCadastro request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O parâmetro 'request' não pode ser nulo.");
        return await PostAsync<ContaReceberCadastroChave>("AlterarDistribuicaoDepartamento", request);
    }

    public async Task<ContaReceberCadastroResponse> CancelarContaReceber(ContaReceberCadastroChave request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O parâmetro 'request' não pode ser nulo.");
        return await PostAsync<ContaReceberCadastroResponse>("CancelarContaReceber", request);
    }

    public async Task<ContaReceberCancelarRecebimentoResponse> CancelarRecebimento(ContaReceberCancelarRecebimento request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O parâmetro 'request' não pode ser nulo.");
        return await PostAsync<ContaReceberCancelarRecebimentoResponse>("CancelarRecebimento", request);
    }

    public async Task<ContaReceberConciliarResponse> ConciliarRecebimento(ContaReceberConciliarRequest request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O parâmetro 'request' não pode ser nulo.");
        return await PostAsync<ContaReceberConciliarResponse>("ConciliarRecebimento", request);
    }

    public async Task<ContaReceberCadastro> ConsultarContaReceber(LcrChave request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O parâmetro 'request' não pode ser nulo.");
        return await PostAsync<ContaReceberCadastro>("ConsultarContaReceber", request);
    }

    public async Task<ContaReceberConciliarResponse> DesconciliarRecebimento(ContaReceberConciliarRequest request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O parâmetro 'request' não pode ser nulo.");
        return await PostAsync<ContaReceberConciliarResponse>("DesconciliarRecebimento", request);
    }

    public async Task<ContaReceberCadastroResponse> ExcluirContaReceber(ContaReceberCadastroChave request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O parâmetro 'request' não pode ser nulo.");
        return await PostAsync<ContaReceberCadastroResponse>("ExcluirContaReceber", request);
    }

    public async Task<ContaReceberCadastroResponse> ExcluirDistribuicaoDepartamento(ContaReceberCadastroChave request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O parâmetro 'request' não pode ser nulo.");
        return await PostAsync<ContaReceberCadastroResponse>("ExcluirDistribuicaoDepartamento", request);
    }

    public async Task<ContaReceberCadastroResponse> IncluirContaReceber(ContaReceberCadastro request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O parâmetro 'request' não pode ser nulo.");
        return await PostAsync<ContaReceberCadastroResponse>("IncluirContaReceber", request);
    }

    public async Task<ContaReceberLoteResponse> IncluirContaReceberPorLote(ContaReceberLote request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O parâmetro 'request' não pode ser nulo.");
        return await PostAsync<ContaReceberLoteResponse>("IncluirContaReceberPorLote", request);
    }

    public async Task<ContaReceberCadastroChave> IncluirDistribuicaoDepartamento(RateioCadastro request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O parâmetro 'request' não pode ser nulo.");
        return await PostAsync<ContaReceberCadastroChave>("IncluirDistribuicaoDepartamento", request);
    }

    public async Task<ContaReceberCadastroResponse> LancarRecebimento(ContaReceberLancarRecebimento request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O parâmetro 'request' não pode ser nulo.");
        return await PostAsync<ContaReceberCadastroResponse>("LancarRecebimento", request);
    }

    public async Task<LcrListarResponse> ListarContasReceber(LcrListarRequest request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O parâmetro 'request' não pode ser nulo.");
        return await PostAsync<LcrListarResponse>("ListarContasReceber", request);
    }

    public async Task<ContaReceberCadastro> UpsertContaReceber(ContaReceberCadastro request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O parâmetro 'request' não pode ser nulo.");
        return await PostAsync<ContaReceberCadastro>("UpsertContaReceber", request);
    }

    public async Task<ContaReceberLoteResponse> UpsertContaReceberPorLote(ContaReceberLote request)
    {
        if (request == null)
            throw new ArgumentNullException(nameof(request), "O parâmetro 'request' não pode ser nulo.");
        return await PostAsync<ContaReceberLoteResponse>("UpsertContaReceberPorLote", request);
    }
}
