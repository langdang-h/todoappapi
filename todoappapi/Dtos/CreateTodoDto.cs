using System;
namespace todoappapi.Dtos
{
    public record CreateTodoDto
    {
        public int id { get; init; }
        public string title { get; init; }
        public bool MyProperty = false;
    }
}
