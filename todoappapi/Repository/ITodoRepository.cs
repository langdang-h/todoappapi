using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using todoappapi.Entity;

namespace todoappapi.Repository
{
    public interface ITodoRepository
    {
        public IEnumerable<Todo> GetTodos();
        public Todo GetTodo(int id);
        public void AddTodo(Todo todo);
        public void DeleteTodo(int id);
        public void UpdateTodo(Todo todo);
    }


}


