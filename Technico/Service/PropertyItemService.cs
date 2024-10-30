using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.DataBase;
using Technico.Enums;
using Technico.Interfaces;
using Technico.Models;

namespace Technico.Service;

public class PropertyItemService : IPropertyItemService
{

    public TempData TempData = new TempData();



    private List<string> ValidateItem(PropertyItem item)
    {
        var errors = new List<string>();


        // Validate PropertyIdNumber
        if (string.IsNullOrWhiteSpace(item.PropertyIdNumber))
        {
            errors.Add("PropertyIdNumber is required.");
        }
        else if (item.PropertyIdNumber.Length != 4)
        {
            errors.Add("PropertyIdNumber must be  4 digits.");
        }
        if (!long.TryParse(item.YearOfConstruction, out _))
        {
            errors.Add("PropertyIdNumber  must be   numeric.");
        }


        // Validate PropertyAdress
        if (string.IsNullOrWhiteSpace(item.PropertyAddress))
        {
            errors.Add("PropertyAddress is required.");
        }


        //Validate YearOfConstruction
        if (string.IsNullOrWhiteSpace(item.YearOfConstruction))
        {
            errors.Add("YearOfConstruction is required.");

        }
        if (!long.TryParse(item.YearOfConstruction, out _))
        {
            errors.Add("YearOfConstruction  must be numeric.");
        }

        //Validate VatNumber
        if (string.IsNullOrWhiteSpace(item.OwnerVAT))
        {
            errors.Add("VAT number is required.");

        }

        // Check if the VAT number is exactly 9 digits long and numeric
        if (item.OwnerVAT.Length != 9 || !long.TryParse(item.OwnerVAT, out _))
        {
            errors.Add("VAT number must be exactly 9 digits long and numeric.");

        }

        return errors;


    }
    public PropertyItem? CreateItem(PropertyItem item)
    {
        var errors = ValidateItem(item);
        if (errors.Count > 0)
        {
            return null;
        }

        TempData.PropertyItems.Add(item);

        return item;
    }
    public PropertyItem? UpdateItem(PropertyItem item)
    {
        var errors = ValidateItem(item);
        if (errors.Count > 0)
        {
            return null;
        }

        var selectedItem = TempData.PropertyItems.Find(x => x.PropertyIdNumber == item.PropertyIdNumber);
        if (selectedItem != null)
        {
            TempData.PropertyItems.Remove(selectedItem);
        }
        TempData.PropertyItems.Add(item);
        return item;
    }
    public PropertyItem? DeleteItem(PropertyItem item)
    {
        var errors = ValidateItem(item);
        if (errors.Count > 0)
        {
            return null;
        }
        var selectedItem = TempData.PropertyItems.Find(x => x.PropertyIdNumber == item.PropertyIdNumber);
        if (selectedItem != null)
        {
            TempData.PropertyItems.Remove(selectedItem);
        }
        return item;
    }
    public List<PropertyItem> GetAll()
    {
        return TempData.PropertyItems;

    }
    public PropertyItem? GetOne(string PropertyIdNumber)
    {
        var selectedItem = TempData.PropertyItems.Find(x => x.PropertyIdNumber == PropertyIdNumber);

        return selectedItem;
    }
}



    




   
    

