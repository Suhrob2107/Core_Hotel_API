using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System.Net.Http.Headers;

namespace RapidApiConsume.Controllers
{
    public class ImdbController : Controller
    {
        public async Task<IActionResult> Index()
        {
           List<ApiMovieViewModel> apiModelViewModels = new List<ApiMovieViewModel>();
            var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
				Headers =
				{
					{ "x-rapidapi-key", "ac7e28c5camshaf5f21c3247d4d3p1ec152jsn85b1d7c8a0f2" },
					{ "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" },
				},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
                apiModelViewModels = JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);
                return View(apiModelViewModels);
            }
        }
    }
}
