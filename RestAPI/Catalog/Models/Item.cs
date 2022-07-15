using System;
using Catalog.ValueObjects;

namespace Catalog.Models
{
    public record Item
    {
        public Guid Id { get; init; } 

        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTime CreatedDate { get; init; }
        public Category Category {get; set;}
    }
}