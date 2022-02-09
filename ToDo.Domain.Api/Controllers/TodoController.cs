using Microsoft.AspNetCore.Mvc;
using ToDo.Domain.Commands;
using ToDo.Domain.Handlers;

namespace ToDo.Domain.Api.Controllers
{
    [ApiController]
    [Route("v1/todos")]
    public class TodoController:ControllerBase
    {
        [Route("")]
        [HttpPost]
        public GenericCommandResult Create(
            [FromBody] CreateTodoCommand command,
            [FromServices] TodoHandler handler)
        {
            command.User = "marcio";
            return (GenericCommandResult)handler.Handle(command);
        }
    }
}
