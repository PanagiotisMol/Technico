using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.DataBase;
using Technico.Enums;
using Technico.Models;

namespace Technico.Service;

public class RepairService : IRepairService

{

    public TempData TempData = new TempData();

    private List<string> ValidateRepair(Repair work)
    {
        var errors = new List<string>();


        // Validate RepairDescription
        if (string.IsNullOrWhiteSpace(work.RepairDescription))
        {
            errors.Add("RepairDescription is required.");
        }


        // Validate RepairAddress
        if (string.IsNullOrWhiteSpace(work.RepairAddress))
        {
            errors.Add("RepairAddress is required.");
        }


        //Validate CostOfRepair
        if (string.IsNullOrWhiteSpace(work.CostOfRepair))
        {
            errors.Add("CostOfRepair is required.");

        }
        if (!long.TryParse(work.CostOfRepair, out _))
        {
            errors.Add("CostOfRepair must be  numeric.");

        }

        // Check if the VAT number is exactly 9 digits long and numeric
        if (work.OwnerVAT.Length != 9 || !long.TryParse(work.OwnerVAT, out _))
        {
            errors.Add("VAT number must be exactly 9 digits long and numeric.");

        }

        return errors;
    }
    public Repair? CreateRepair(Repair work)
    {
        var errors = ValidateRepair(work);
        if (errors.Count > 0)
        {
            return null;
        }

        TempData.Repairs.Add(work);

        return work;
    }
    public Repair? UpdateRepair(Repair work)
    {
        var errors = ValidateRepair(work);
        if (errors.Count > 0)
        {
            return null;
        }

        var selectedRepair = TempData.Repairs.Find(x => x.RepairId == work.RepairId);
        if (selectedRepair != null)
        {
            TempData.Repairs.Remove(selectedRepair);
        }
        TempData.Repairs.Add(work);
        return work;
    }
    public Repair? DeleteRepair(Repair work)
    {
        var errors = ValidateRepair(work);
        if (errors.Count > 0)
        {
            return null;
        }
        var selectedRepair = TempData.Repairs.Find(x => x.RepairId == work.RepairId);
        if (selectedRepair != null)
        {
            TempData.Repairs.Remove(selectedRepair);
        }
        return work;
    }
    public List<Repair> GetAll()
    {
        return TempData.Repairs;

    }
    public Repair? GetOne(string RepairId)
    {
        var selectedRepair = TempData.Repairs.Find(x => x.RepairId == RepairId);

        return selectedRepair;
    }

}
