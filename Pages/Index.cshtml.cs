using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ToverLand_Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public string Username { get; set; }
        
        [BindProperty]
        public string Password { get; set; }
        
        [BindProperty]
        public bool RememberMe { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (IsValidUser(Username, Password))
            {
                // Handle successful login (e.g., set authentication cookie)
                // Redirect to the main page
                return RedirectToPage("/Main");
            }

            // Handle failed login
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return Page();
        }

        private bool IsValidUser(string username, string password)
        {
            // Replace with your actual authentication logic
            return username == "admin" && password == "password";
        }
    }
}
