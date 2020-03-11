using CQRS.Common.Handlers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Common.Dispatchers
{
    public class Dispatcher : IDispatchers
    {
        private readonly ICommandDispatcher commandDispatcher;

        public Dispatcher(ICommandDispatcher commandDispatcher)
        {
            this.commandDispatcher = commandDispatcher;
        }
        public async Task SendAsync<TCommand>(TCommand command) where TCommand : ICommand
        {
            await commandDispatcher.SendAsync(command);
        }
    }
}
