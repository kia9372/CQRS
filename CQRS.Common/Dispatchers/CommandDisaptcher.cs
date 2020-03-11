using Autofac;
using CQRS.Common.Handlers;
using System;
using System.Threading.Tasks;

namespace CQRS.Common.Dispatchers
{
    public class CommandDisaptcher : ICommandDispatcher
    {
        private IServiceProvider _serviceProvider;

        public CommandDisaptcher(IServiceProvider serviceProvider)
        {
            this._serviceProvider = serviceProvider;
        }
        public async Task SendAsync<T>(T command) where T : ICommand
        {
            var service = this._serviceProvider.GetService(typeof(ICommandHandler<T>)) as ICommandHandler<T>;
            await service.HandlersAsync(command);
        }
    }
}
