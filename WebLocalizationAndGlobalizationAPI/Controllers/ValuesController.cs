using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using WebLocalizationAndGlobalizationAPI.Resources;

namespace WebLocalizationAndGlobalizationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IStringLocalizer<SharedResouce> _localizer;
        public ValuesController(IStringLocalizer<SharedResouce> localizer)
        {
            _localizer= localizer;
        }
        [HttpGet("GetData")]
        public IActionResult Get() 
        {

            return Ok(_localizer["Hello"]);
        }
    }
}
