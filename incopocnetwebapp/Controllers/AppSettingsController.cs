using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace incopocnetwebapp.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AppSettingsController : ControllerBase
	{
		private readonly IConfiguration _configuration;

		public AppSettingsController(IConfiguration configuration)
		{ 
			_configuration = configuration;
		}
		[HttpGet]
		public IDictionary<string, string> Get()
		{
			var appSettings =  _configuration.GetSection("AppSettings");
			var settingDictionary = new Dictionary<string, string>();
			foreach (var setting in appSettings.GetChildren())
			{
				settingDictionary.Add(setting.Key, setting.Value);
			}
			return settingDictionary;
		}


	}
}
