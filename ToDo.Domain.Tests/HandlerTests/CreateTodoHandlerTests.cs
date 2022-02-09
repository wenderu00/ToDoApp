using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Commands;
using ToDo.Domain.Handlers;
using ToDo.Domain.Tests.Repositories;

namespace ToDo.Domain.Tests.HandlerTests
{
    [TestClass]
    public class CreateTodoHandlerTests
    {
        private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", "", DateTime.Now);

        private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("Comando valido", "usuario valido", DateTime.Now);
     
        private readonly TodoHandler _handler = new TodoHandler(new FakeTodoRepository());
        private GenericCommandResult _result = new GenericCommandResult();
        [TestMethod]
        public void Dado_um_comando_invalido_deve_interromper_execucao()
        {
            
            
            _result = (GenericCommandResult)_handler.Handle(_invalidCommand);
            Assert.AreEqual(_result.Sucess,false);
        }
        [TestMethod]
        public void Dado_um_comando_valido_criar_tarefa()
        {
           
            _result = (GenericCommandResult)_handler.Handle(_validCommand);
            Assert.AreEqual(_result.Sucess, true);

        }
    }
}
