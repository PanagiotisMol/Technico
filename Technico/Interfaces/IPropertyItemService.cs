using Technico.Models;

namespace Technico.Interfaces
{
    public interface IPropertyItemService
    {
        PropertyItem? CreateItem(PropertyItem item);
        PropertyItem? DeleteItem(PropertyItem item);
        List<PropertyItem> GetAll();
        PropertyItem? GetOne(string VAT);
        PropertyItem? UpdateItem(PropertyItem item);
    }
}