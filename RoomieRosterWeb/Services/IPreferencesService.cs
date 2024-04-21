using System;
using DwellDuo.Models;

namespace DwellDuo.Services
{
	public interface IPreferencesService
	{
		public Task<object> UpdatePreferences(UserPreferenecesDto preferencesDto, string accessToken);
	}
}

