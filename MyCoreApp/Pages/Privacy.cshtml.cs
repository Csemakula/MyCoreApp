using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace MyCoreApp.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // Datetime dd/M/yyyy H:mm:ss
            string dateTime = DateTime.Now.ToString("dd/M/yyyy H:mm:ss", new CultureInfo("en-UK"));
            string myCopy = "This is done by Ssemakula";
            ViewData["TimeStamp"] = dateTime;
            ViewData["MyCopy"] = myCopy;
        }
    }

}
