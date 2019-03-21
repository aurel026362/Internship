using System;
using System.Collections.Generic;

namespace TESTDB
{
    public partial class Users
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NumberPhone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public virtual Interns Interns { get; set; }
        public virtual Menthors Menthors { get; set; }
    }
}
