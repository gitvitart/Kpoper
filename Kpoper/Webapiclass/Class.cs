using Kpoper.Entities;
using Kpoper.Webapiclass;
using System.Diagnostics;
using System.Text.Json;


public class WebIdolsApiService
{
    private static readonly HttpClient _client = new HttpClient();
    private readonly string _url;

    public WebIdolsApiService(string url)
    {
        if (string.IsNullOrEmpty(url))
        {
            throw new ArgumentException(nameof(url));
        }

        _url = url;
    }

    public async Task<IEnumerable<Idol>> GetIdolsAsync()
    {
        var result = new List<Idol>();
        WebIdols webIdols = null;

        try
        {
            using (var response = await _client.GetAsync(_url))
            using (var stream = await response.Content.ReadAsStreamAsync())
            {
                webIdols = await JsonSerializer.DeserializeAsync<WebIdols>(stream);
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }

        if (webIdols != null && webIdols.data.Count > 0)
        {
            foreach (var wi in webIdols.data)
            {
                var idol = new Idol
                {
                    Id = wi.id,
                    FullName = wi.name,
                    //IdolSex = wi.idolSex,
                    //IdolLinks = wi.idolLinks                    
                };
                result.Add(idol);
            }
        }

        return result;
    }
}