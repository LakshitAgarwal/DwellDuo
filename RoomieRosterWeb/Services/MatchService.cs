using Microsoft.Extensions.Options;
using DwellDuo.Models;
using DwellDuo.Settings;

namespace DwellDuo.Services
{
	public class MatchService:BaseService, IMatchService
	{
        private readonly MatchApiSettings _apiSettings;
        public MatchService(IOptions<MatchApiSettings> apiSettings)
        {
            _apiSettings = apiSettings.Value;
        }

        public async Task<object> GetMatchesAsync(string accessToken)
        {
            var uri = new Uri(_apiSettings.BaseUrl);

            var response = await SendGetRequestAsync<MatchesDto>(uri + _apiSettings.Endpoints.Match, new {token = accessToken});

            return response;
        }
    }
}

