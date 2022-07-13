using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace app.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly HttpClient _http;
        public List<User> DBUser = new List<User>();

        public async Task<IActionResult> OnPostAsync()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7068/");

            var res = await client.GetAsync("api/Users/login");
            var result = res.Content.ReadAsStringAsync().Result;
            DBUser = JsonConvert.DeserializeObject<List<User>>(result);



            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("../Index");

        }
    }
}
