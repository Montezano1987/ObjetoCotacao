using System.Text.Json;
using ObjetosCotacao.Cotacao;

public static class CotacaoService
{
    public static readonly HttpClient _httpClient = new HttpClient();

    public static async Task<USDBRL> BuscarCotacaoDolar()
    {
        string url = "https://economia.awesomeapi.com.br/last/USD-BRL,EUR-BRL,BTC-BRL";
        HttpResponseMessage response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        var cotacoesDolar = JsonSerializer.Deserialize<CotacaoDTO>(responseBody);

        return cotacoesDolar.USDBRL;
    }
}