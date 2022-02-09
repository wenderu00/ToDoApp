using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.Infra.Contexts
{
    internal class TodoContext :DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }
    }
}
