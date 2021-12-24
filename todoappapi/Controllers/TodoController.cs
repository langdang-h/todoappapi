using System;
using System.Collections.Generic;
using System.Linq;
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

            return items;
        }

        [HttpPost]
        public ActionResult PostTodo(CreateTodoDto todo)
        {
            Todo newTodo = new()
            {
                title = todo.title,
                id = todo.id

            };

            repository.AddTodo(newTodo);

            return NoContent();
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
        public ActionResult DeleteTodo(int id)
        {
            var item = repository.GetTodo(id);

            if(item is null)
            {
                NotFound();
            }

            repository.DeleteTodo(id);

            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateTodo(int id, UpdateDto updateDto)
        {
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

            return NoContent();
        }


    }
}
