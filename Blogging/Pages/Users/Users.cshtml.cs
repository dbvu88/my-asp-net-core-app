using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blogging.Core;
using Blogging.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Blogging.Pages.Users
{
    public class UsersModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IUserData userData;

        public string Message;
        public IEnumerable<User> Users;

        public UsersModel(IConfiguration config, IUserData userData)
        {
            this.config = config;
            this.userData = userData;
        }
        public void OnGet()
        {
            Message = config["Message"];
            Users = userData.GetAll();
        }
    }
}