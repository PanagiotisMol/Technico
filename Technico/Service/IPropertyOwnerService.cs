using Technico.Models;

namespace Technico.Service
{
    public interface IPropertyOwnerService
    {
        PropertyOwner? CreateUser(PropertyOwner owner);
        PropertyOwner? DeleteUser(PropertyOwner owner);
        List<PropertyOwner> GetAll();
        PropertyOwner? GetOne(string VAT);
        PropertyOwner? UpdateUser(PropertyOwner owner);
    }
}