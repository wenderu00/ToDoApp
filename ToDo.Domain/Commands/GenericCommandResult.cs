using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Commands.Contracts;

namespace ToDo.Domain.Commands
{
    public class GenericCommandResult : ICommandResult
    {
        public GenericCommandResult() { }
        public GenericCommandResult(bool success,string message, object data) { 
            Sucess = success;
            Message = message;
            Data = data;
        }
        public bool Sucess { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
