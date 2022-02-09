using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities;
using ToDo.Domain.Queries;

namespace ToDo.Domain.Tests.QueryTests
{
    [TestClass]
    public class TodoQueryTests
    {
        private List<TodoItem> _items;
        public TodoQueryTests()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("tarefa 1","usuario1",DateTime.Now));
            _items.Add(new TodoItem("tarefa 2", "usuario1", DateTime.Now));
            _items.Add(new TodoItem("tarefa 3", "marcio", DateTime.Now));
            _items.Add(new TodoItem("tarefa 4", "usuario1", DateTime.Now));
            _items.Add(new TodoItem("tarefa 5", "marcio", DateTime.Now));
            _items.Add(new TodoItem("tarefa 6", "marcio", DateTime.Now));
        }
        [TestMethod]
        public void Dado_uma_consulta_retorna_todas_as_tarefas_do_usuario_marcio()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("marcio"));
            Assert.AreEqual(3,result.Count());
            
        }

        
    }
}
