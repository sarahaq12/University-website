using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class registerModel : PageModel
    {
        private readonly ILogger<registerModel> _logger;

        public registerModel(ILogger<registerModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}