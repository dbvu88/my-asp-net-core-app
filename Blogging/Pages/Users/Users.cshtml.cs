using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Blogging.Pages.Users
{
    public class UsersModel : PageModel
    {
        private readonly IConfiguration config;

        public String Message;

        public UsersModel(IConfiguration config)
        {
            this.config = config;
        }
        public void OnGet()
        {
            Message = config["Message"];
        }
    }
}