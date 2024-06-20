using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ToverLand_Website.Pages
{
    public class MainModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public MainModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
