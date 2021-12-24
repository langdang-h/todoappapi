using System;
using System.Collections.Generic;
using todoappapi.Entity;
using todoappapi.Repository;

namespace todoappapi.Dtos
{
    public record TodoDto
    {
        public int id { get; init; }
        public string title { get; init; }

        public bool done { get; init; }
    }
}