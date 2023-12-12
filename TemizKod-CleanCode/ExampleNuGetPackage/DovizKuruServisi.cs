using Newtonsoft.Json;

namespace ExampleNuGetPackage;
public sealed class DovizKuruServisi
{
    private readonly HttpClient _httpClient;

    public DovizKuruServisi()
    {
        _httpClient = new HttpClient();
    }

    public async Task<DovizKuru?> DovizKuruGetirAsync(string dovizKuru)
    {
        try
        {
            var response = await _httpClient.GetAsync("api");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<DovizKuru>(content);
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"Bir hata oluştu: {ex.Message}");
            return null;
        }
    }
}
public sealed class DovizKuru
{
    public string Kod { get; set; } = string.Empty;
    public double Deger { get; set; }
}