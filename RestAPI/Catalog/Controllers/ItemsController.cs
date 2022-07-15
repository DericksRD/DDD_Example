using System;
using System.Reflection;
using System.Collections.ObjectModel;
using System.Linq;
using Catalog.Models;
using Catalog.Services;
using Catalog.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ItemsController : ControllerBase
{
    private readonly IItemService _itemService;

    public ItemsController(IItemService itemService)
    {
        _itemService = itemService;
    }

    [HttpGet]
    public IEnumerable<ItemDTO> GetItems()
    {
        return _itemService.GetItems();
    }

    [HttpGet("ById")]
    public ActionResult<ItemDTO> GetItem([FromQuery] Guid id)
    {
        return _itemService.GetItemByID(id);
    }
}