using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Commands.Contracts;

namespace ToDo.Domain.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
