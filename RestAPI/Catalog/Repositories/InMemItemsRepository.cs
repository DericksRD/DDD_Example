using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using Catalog.Models;

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
            CreatedDate = DateTime.Now
        },

        new Item
        {
            Id = Guid.NewGuid(),
            Name = "Iron Sword",
            Price = 20,
            CreatedDate = DateTime.Now
        },

        new Item
        {
            Id = Guid.NewGuid(),
            Name = "Brozen Shield",
            Price = 10,
            CreatedDate = DateTime.Now
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