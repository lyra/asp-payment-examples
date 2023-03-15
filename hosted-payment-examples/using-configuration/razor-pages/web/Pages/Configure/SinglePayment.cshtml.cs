using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace web.Pages.Configure
{
    public class SinglePaymentModel : PageModel
    {
        [BindProperty]
        public string Amount { get; set; } = string.Empty;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                return RedirectToPage("/Payment/Single", new { amount = Amount });
            }
            return Page();
        }
    }
}
