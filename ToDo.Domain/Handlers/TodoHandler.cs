using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Commands;
using ToDo.Domain.Commands.Contracts;
using ToDo.Domain.Entities;
using ToDo.Domain.Handlers.Contracts;
using ToDo.Domain.Repositories;

namespace ToDo.Domain.Handlers
{
    public class TodoHandler : 
        Notifiable,
        IHandler<CreateTodoCommand>,
        IHandler<UpdateTodoCommand>,
        IHandler<MarkTodoAsDoneCommand>,
        IHandler<MarkTodoAsUndoneCommand>

    {

        private readonly ITodoRepository _repository;
        public TodoHandler(ITodoRepository repository)
        {
            _repository = repository;
        }
        public ICommandResult Handle(CreateTodoCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false,"Ops, parece que sua tarefa está errada",command.Notifications);

            var todo = new TodoItem(command.Title, command.User, command.Date);
            _repository.Create(todo);

            return new GenericCommandResult(true, "Tarefa salva", todo);
        }

        public ICommandResult Handle(UpdateTodoCommand command)
        {
            throw new NotImplementedException();
        }

        public ICommandResult Handle(MarkTodoAsDoneCommand command)
        {
            throw new NotImplementedException();
        }

        public ICommandResult Handle(MarkTodoAsUndoneCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
