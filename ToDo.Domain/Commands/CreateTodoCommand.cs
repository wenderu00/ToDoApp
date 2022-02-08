]using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.Commands
{
    public class CreateTodoCommand
    {
        public CreateTodoCommand() { }
        public CreateTodoCommand(string title, string user, DateTime date) {
            Title = title;
            User = user;
            Date = date;
        }
        public string Title { get; set; }
        public string User {get; set; }
        public DateTime Date { get; set; }

    }
}
