using Technico.Models;

namespace Technico.Service
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