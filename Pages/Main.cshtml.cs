using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ToverLand_Website.Pages
{
    public class MainModel : PageModel
    {
        private readonly ILogger<AccountModel> _logger;

        public MainModel(ILogger<AccountModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
