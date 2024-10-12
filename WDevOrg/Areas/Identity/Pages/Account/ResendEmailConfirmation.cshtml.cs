using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace WDevOrg.Areas.Identity.Pages.Account;

[AllowAnonymous]
public class ResendEmailConfirmation : PageModel
{
    public IActionResult OnGet()
    {
        return Page();
    }
}