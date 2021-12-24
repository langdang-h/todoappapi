using System;
using System.Collections.Generic;
using todoappapi.Entity;

namespace todoappapi.Repository
{
    public class MongoRepository : ITodoRepository
    {
        private string DataBaseName { get; set; }




        public void AddTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public void DeleteTodo(int id)
        {
            throw new NotImplementedException();
        }

        public Todo GetTodo(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Todo> GetTodos()
        {
            throw new NotImplementedException();
        }

        public void UpdateTodo(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}
