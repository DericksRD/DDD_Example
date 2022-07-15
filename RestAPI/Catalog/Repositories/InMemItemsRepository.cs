using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using Catalog.Models;
using Catalog.ValueObjects;

namespace Catalog.Repositories;

public class InMemItemsRepository : IItemsRepository
{
    private readonly List<Item> items = new()
    {
        /*
         * En C# 9 se puede inicializar un obejto 
         * sin el constructor. Solo hace falta
         * usar new().
         */
        new Item
        {
            Id = Guid.NewGuid(),
            Name = "Potion",
            Price = 9,
            CreatedDate = DateTime.Now,
            Category = new Category(1)
        },

        new Item
        {
            Id = Guid.NewGuid(),
            Name = "Diamond Sword",
            Price = 20,
            CreatedDate = DateTime.Now,
            Category = new Category(2)
        },

        new Item
        {
            Id = Guid.NewGuid(),
            Name = "Brozen Shield",
            Price = 10,
            CreatedDate = DateTime.Now,
            Category = new Category(0)
        }
    };

    public IEnumerable<Item> GetItems()
    {
        return items;
    }

    public Item GetItem(Guid id)
    {
        return items
            .Where(i => i.Id == id)
            .SingleOrDefault();
    }
}