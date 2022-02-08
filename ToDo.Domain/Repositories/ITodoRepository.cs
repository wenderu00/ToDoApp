using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities;

namespace ToDo.Domain.Repositories
{
    public interface ITodoRepository
    {
        void Create(TodoItem todo);
        void Update(TodoItem todo);
    }
}
