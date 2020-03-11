using CQRS.Command.UserCommands;
using CQRS.Common.Handlers;
using CQRS.DAL.Context;
using System.Threading.Tasks;

namespace CQRS.CommandHandler
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
            context.Users.Add(new Entity.User(command.Id, command.FirstName, command.LastName, command.Email));
            await context.SaveChangesAsync();
        }
    }
}
