using Technico.Models;

namespace Technico.Service
{
    public interface IRepairService
    {
        Repair? CreateRepair(Repair work);
        Repair? DeleteRepair(Repair work);
        List<Repair> GetAll();
        Repair? GetOne(string VAT);
        Repair? UpdateRepair(Repair work);
    }
}