using Catalog.Models;
using Catalog.DTOs;

namespace Catalog.Services;
public interface IItemService 
{
    public IEnumerable<ItemDTO> GetItems();
    public ItemDTO GetItemByID(Guid id);
}