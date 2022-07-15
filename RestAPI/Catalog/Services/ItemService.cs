using System.Collections.ObjectModel;
using Catalog.Repositories;
using Catalog.Models;
using Catalog.DTOs;

namespace Catalog.Services;
public class ItemService : IItemService
{
    private IItemsRepository _repository;

    public ItemService(IItemsRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<ItemDTO> GetItems() 
    {
        var result = new Collection<ItemDTO>();
        var items = _repository.GetItems();  

        foreach (Item item in items)
        {
            result.Add(item.AsDTO());
        }

        return result;
    }

    public ItemDTO GetItemByID(Guid Id)
    {
        var item = _repository.GetItem(Id);
        return item.AsDTO();
    }
}