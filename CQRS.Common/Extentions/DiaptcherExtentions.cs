using Autofac;
using CQRS.Common.Dispatchers;
using CQRS.Common.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Common.Extentions
{
    public static class DiaptcherExtentions
    {
        public static void AddDispatchers(this ContainerBuilder builder)
        {
            builder.RegisterType<CommandDisaptcher>().As<ICommandDispatcher>();
            builder.RegisterType<Dispatcher>().As<IDispatchers>();
        }
    }
}
