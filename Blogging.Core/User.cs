using System;

namespace Blogging.Core
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public Role Role { get; set; }
    }
}
