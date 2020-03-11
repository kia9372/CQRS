using CQRS.Common.Handlers;
using CQRS.DAL.Context;
using CQRS.Entity;
using System.Threading.Tasks;

namespace CQRS.Command.UserCommands
{
    public class UserCommandHandler : ICommandHandler<UserCommand>
    {
        private readonly CQRSContext context;

        public UserCommandHandler(CQRSContext context)
        {
            this.context = context;
        }
        public async Task HandlersAsync(UserCommand command)
        {
            context.Users.Add(new User(command.Id, command.FirstName, command.LastName, command.Email));
            context.SaveChanges();
        }
    }
}
