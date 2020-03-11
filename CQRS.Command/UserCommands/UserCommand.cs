using CQRS.Common.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Command.UserCommands
{
    public class UserCommand : ICommand
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public UserCommand(int Id, string FirstName, string LastName, string Email)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
        }
    }
}
