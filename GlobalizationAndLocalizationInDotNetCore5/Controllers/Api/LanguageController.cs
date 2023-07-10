using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalizationAndLocalizationInDotNetCore5.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly IStringLocalizer<LanguageController> _localizer;
        public LanguageController(IStringLocalizer<LanguageController> localizer)
        {
            _localizer = localizer;
        }

        [HttpGet]
        public IActionResult Get()
        {
            // this URL to get with specific culture
            //https://localhost:44372/api/language?culture=ar 

            var username = "Ahmed Fathy";
            return Ok(_localizer["Welcome",username].Value);
        }
    }
}
