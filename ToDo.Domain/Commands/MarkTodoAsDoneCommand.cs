using Flunt.Notifications;
using System;
using ToDo.Domain.Commands.Contracts;
using Flunt.Validations;
namespace ToDo.Domain.Commands
{
    public class MarkTodoAsDoneCommand : Notifiable, ICommand
    {
        public MarkTodoAsDoneCommand() { }
        public MarkTodoAsDoneCommand(Guid id, string user)
        {
            Id = id;
            User = user;
        }
        public Guid Id { get; set; }
        public string User { get; set; }
        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .HasLen(Id.ToString(),36,"Id","Id inválido")
                    .HasMinLen(User,6,"User","Usuario inválido")
                );
        }
    }
}
