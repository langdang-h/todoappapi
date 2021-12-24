using System;
using todoappapi.Dtos;
using todoappapi.Entity;

namespace todoappapi
{
    public static class Extensions
    {
        public static TodoDto AsDto(this Todo todo)
        {
            return new TodoDto
            {
                done = todo.done,
                title = todo.title,
                id = todo.id
            };
        }
    }
}
