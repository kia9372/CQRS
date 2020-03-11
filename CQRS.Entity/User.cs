using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public User(int Id, string FirstName, string LastName, string Email)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
        }
    }
}
