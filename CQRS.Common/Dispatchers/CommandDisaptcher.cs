using Autofac;
using CQRS.Common.Handlers;
using System.Threading.Tasks;

namespace CQRS.Common.Dispatchers
{
    public class CommandDisaptcher : ICommandDispatcher
    {
        private readonly IComponentContext context;

        public CommandDisaptcher(IComponentContext context)
        {
            this.context = context;
        }
        public async Task SendAsync<T>(T command) where T : ICommand
        {
            await context.Resolve<ICommandHandler<T>>().HandlersAsync(command);
        }
    }
}
