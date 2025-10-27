using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System.Net.Http.Headers;

namespace RapidApiConsume.Controllers
{
    public class ExchangeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/meta/getExchangeRates?base_currency=TRY"),
                Headers =
            {
                { "x-rapidapi-key", "ac7e28c5camshaf5f21c3247d4d3p1ec152jsn85b1d7c8a0f2" },
                { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
            },
            };

            using (var response = await client.SendAsync(request))
            {
                var body = await response.Content.ReadAsStringAsync();

                // JSON'u kontrol edelim
                if (!response.IsSuccessStatusCode)
                {
                    ViewBag.Error = $"API hatası: {response.StatusCode} - {body}";
                    return View("Error");
                }

                // JSON'u modele dönüştür
                var result = JsonConvert.DeserializeObject<ExchangeViewModel>(body);

                // Eğer veri null gelirse ViewBag ile hata gönder
                if (result?.data?.exchange_rates == null)
                {
                    ViewBag.Error = "API'den veri alınamadı.";
                    return View("Error");
                }

                // exchange_rates listesini view'e gönder
                return View(result.data.exchange_rates);
            }
        }
    }
}
