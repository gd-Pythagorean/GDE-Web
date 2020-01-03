using GDE.Web.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GDE.Web.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            GlobalVariables.CurrentSection = LinkItems.Home;
        }
    }
}