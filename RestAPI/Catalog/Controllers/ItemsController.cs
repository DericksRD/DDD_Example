using System;
using System.Reflection;
using System.Collections.ObjectModel;
using System.Linq;
using Catalog.Models;
using Catalog.Repositories;
using Catalog.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ItemsController : ControllerBase
{

    private readonly IItemsRepository _repository;

    public ItemsController(IItemsRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public IEnumerable<Item> GetItems()
    {
        return _repository.GetItems();
    }

    [HttpGet("(id)")]
    public ActionResult<ItemDTO> GetItem(Guid id)
    {
        var item = _repository.GetItem(id);

        if(item is null)
            return NotFound();

        return item.AsDTO();

        /*
         * Otra forma de hacerlo:
         * 
         * var item = _repository.GetItem(id)
         *              .Select(item => new Item.AsDTO());
         */
    }
}