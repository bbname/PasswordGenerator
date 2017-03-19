using System;

namespace DataServices.Entity
{
    public class User : Entity
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}