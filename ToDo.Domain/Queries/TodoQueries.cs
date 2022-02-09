using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities;

namespace ToDo.Domain.Queries
{
    public static class TodoQueries
    {
        public static Expression<Func<TodoItem,bool>> GetAll(string user)
        {
            return x => x.User == user;
        }
        public static Expression<Func<TodoItem, bool>> GetAllDone(string user)
        {
            return x => x.User == user&&x.Done;
        }
        public static Expression<Func<TodoItem, bool>> GetAllUndone(string user)
        {
            return x => x.User == user && !x.Done;
        }
        public static Expression<Func<TodoItem, bool>> GetByPeriod(string user,DateTime date,bool Done)
        {
            return x => x.User == user && x.Done && x.Date.Date == date.Date;
        }
    }
}
