using System;
using DwellDuo.Models;

namespace DwellDuo.ViewModels
{
	public class IndexViewModel
	{
		public List<MatchDto> Matches { get; set; }
		public UserPreferenecesDto UserPreferences { get; set; }
	}
}

