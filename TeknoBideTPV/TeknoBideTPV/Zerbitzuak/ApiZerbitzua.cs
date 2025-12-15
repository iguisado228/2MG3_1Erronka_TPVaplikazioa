using _1Erronka_API.DTOak;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TeknoBideTPV.DTOak;

namespace TeknoBideTPV.Zerbitzuak
{
    public class ApiZerbitzua
    {
        private static readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:5001/")
        };

        public async Task<List<ErreserbaDto>> ErreserbakLortuAsync()
        {
            var erreserbak = await _httpClient.GetFromJsonAsync<List<ErreserbaDto>>("api/erreserbak");
            return erreserbak ?? new List<ErreserbaDto>();
        }

        public async Task<LangileaDto?> LoginAsync(string username, string password)
        {
            var request = new { Erabiltzailea = username, Pasahitza = password };
            var response = await _httpClient.PostAsJsonAsync("api/login", request);

            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadFromJsonAsync<LangileaDto>();
        }

        public async Task<List<ProduktuaDto>> LortuProduktuakAsync()
        {
            var produktuak = await _httpClient.GetFromJsonAsync<List<ProduktuaDto>>("api/produktuak");
            return produktuak ?? new List<ProduktuaDto>();
        }

        public async Task<EskariaSortuErantzunaDto?> SortuEskariaAsync(EskariaSortuDto dto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/eskariak", dto);

            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadFromJsonAsync<EskariaSortuErantzunaDto>();
        }
    }
}
