using System;
using DwellDuo.Models;

namespace DwellDuo.Services
{
	public interface IMatchService
	{
        Task<object> GetMatchesAsync(string accessToken);
    }
}

