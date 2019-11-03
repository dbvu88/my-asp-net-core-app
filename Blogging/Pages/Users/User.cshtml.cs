using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blogging.Core;
using Blogging.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blogging.Pages.Users
{
    public class UserModel : PageModel
    {
        private readonly IUserData userData;

        public User User { get; set; }

        public UserModel(IUserData userData)
        {
            this.userData = userData;
        }
        public IActionResult OnGet(int userId)
        {
            User = userData.GetById(userId);
            if (User == null)
            {
                return RedirectToPage("NotFound");
            }
            return Page();
        }
    }
}