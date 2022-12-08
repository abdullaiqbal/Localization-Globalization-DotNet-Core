using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using WebLocalizationAndGlobalizationAPI.Resources;

namespace WebLocalizationAndGlobalizationAPI.Controllers
{
    public class TestController : Controller
    {
        private readonly IStringLocalizer<SharedResouce> _localizer;
        public TestController(IStringLocalizer<SharedResouce> localizer)
        {
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public string getdata()
        {
            return _localizer["Hello"];
        }

    }
}
