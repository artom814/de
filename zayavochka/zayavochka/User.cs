using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zayavochka
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

        public User(int id)
        {
            Id = id;
            Name = string.Empty;
            SecondName = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            PhoneNumber = string.Empty;
        }
    }
}
