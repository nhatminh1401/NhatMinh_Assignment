using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace app.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly app.Data.ApplicationDbContext _context;

        private readonly HttpClient _http;
        public User DBUser = new User();

        public RegisterModel(app.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User User { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7068/");

            var res = await client.GetAsync("api/User/signup");
            var result = res.Content.ReadAsStringAsync().Result;
            DBUser = JsonConvert.DeserializeObject<User>(result);

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.User.Add(User);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Login");

        }
    }
}