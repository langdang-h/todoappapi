using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using todoappapi.Entity;

namespace todoappapi.Repository
{
    public class InMemoryTodoRepo : ITodoRepository
    {

        private List<Todo> todos = new()
        {
            new Todo { id = 1, done = false, title = "todo1" },
            new Todo { id = 2, done = false, title = "todo2" },
            new Todo { id = 3, done = false, title = "todo3" }
        };

        public void AddTodo(Todo todo)
        {
            todos.Add(todo);
        }

        public void DeleteTodo(int id)
        {
            var item = todos.Find(todo => todo.id == id);
            todos.Remove(item);
        }

        public Todo GetTodo(int id)
        {
            Todo existingTodo = todos.Find(todo => todo.id == id);
            return existingTodo;
        }

        public IEnumerable<Todo> GetTodos()
        {
            return todos;
        }
        
        public void UpdateTodo(Todo todo)
        {
            int index = todos.FindIndex(item => item.id == todo.id);

            todos[index] = todo;
        }
    }
}
