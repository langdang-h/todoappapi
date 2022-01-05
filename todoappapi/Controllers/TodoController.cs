using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using todoappapi.Dtos;
using todoappapi.Entity;
using todoappapi.Repository;

namespace todoappapi.Controllers
{ 
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoRepository repository;

        public TodoController(ITodoRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<TodoDto> GetTodos()
        {
            var items = repository.GetTodos().Select(item => item.AsDto());

            Console.WriteLine("A GET REQUEST WAS MADE");
            Console.WriteLine(items);
            return items;
        }

        [HttpPost]
        public ActionResult<Todo> PostTodo(CreateTodoDto todo)
        {
            Todo newTodo = new()
            {
                title = todo.title,
                id = todo.id

            };

            repository.AddTodo(newTodo);
            Console.WriteLine("a request was made");
            return newTodo;
        }


        [HttpGet("{id}")]
        public ActionResult<TodoDto> GetTodo(int id)
        {
            Todo existingTodo = repository.GetTodo(id);
            if(existingTodo is null)
            {
                NotFound();
            }
            

            return existingTodo.AsDto();
        }



        [HttpDelete("{id}")]
        public ActionResult<int> DeleteTodo(int id)
        {
            var item = repository.GetTodo(id);

            if(item is null)
            {
                NotFound();
            }

            repository.DeleteTodo(id);

            return id;
        }

        [HttpPut("{id}")]
        public ActionResult<int> UpdateTodo(int id, UpdateDto updateDto)
        {
            Console.WriteLine(id);

            var existingTodo = repository.GetTodo(id);

            if(existingTodo is null)
            {
                NotFound();
            }

            Todo todo = new()
            {
                id = existingTodo.id,
                done = updateDto.done,
                title = updateDto.title
            };

            repository.UpdateTodo(todo);

            return todo.id;
        }


    }
}
