using AjayTutoral.Model;
using Microsoft.Extensions.Options;
using System.Text.Json;
using static AjayTutoral.Model.ChallengeApiResponse;

namespace AjayTutoral.Service
{
    public class ChallengeService : IChallengeService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ApiSetting _api;

        public ChallengeService(IHttpClientFactory httpClientFactory, IOptions<ApiSetting> api)
        {
            _httpClientFactory = httpClientFactory;
            _api = api.Value;
        }
        public async Task<List<Root>> GetChallenges()
        {
            var client = _httpClientFactory.CreateClient();

            var url = String.Format(_api.Url, _api.Username, _api.ApiKey);
            var response = await client.GetAsync(url + "tournaments/" + _api.TournamentId + "/matches.json");

            HttpResponseMessage httpResponseMessage = response.EnsureSuccessStatusCode();


            var content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<Root>>(content);
        }
    }
}
