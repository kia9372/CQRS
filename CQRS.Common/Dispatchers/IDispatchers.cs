using CQRS.Common.Handlers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Common.Dispatchers
{
    public interface IDispatchers
    {
        Task SendAsync<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
