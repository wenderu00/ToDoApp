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
        [TestMethod]
        public void Dado_um_comando_invalido_deve_interromper_execucao()
        {
            var command = new CreateTodoCommand("", "", DateTime.Now);
            var handler = new TodoHandler(new FakeTodoRepository);
        }
        [TestMethod]
        public void Dado_um_comando_valido_criar_tarefa()
        {
            Assert.Fail();
        }
    }
}
