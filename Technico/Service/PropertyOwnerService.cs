using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Technico.DataBase;
using Technico.Models;
using Technico.Service;



namespace Technico.Service;



public class PropertyOwnerService
{

    public TempData TempData = new TempData();

    private List<string> ValidateUser(PropertyOwner user)
    {
        var errors = new List<string>();
        

        // Validate Email
        if (string.IsNullOrWhiteSpace(user.Email))
        {
            errors.Add("Email is required.");
        }
        else if (!new EmailAddressAttribute().IsValid(user.Email))
        {
            errors.Add("Email format is invalid.");
        }

        // Validate Password
        if (string.IsNullOrWhiteSpace(user.Password))
        {
            errors.Add("Password is required.");
        }
        else if (user.Password.Length > 15)
        {
            errors.Add("Password must be at most 15 characters long.");
        }
        else if (user.Password.Length < 6)
        {
            errors.Add("Password must be at least 6 characters long.");
        }

        //Validate VatNumber
        if (string.IsNullOrWhiteSpace(user.VATNumber))
        {
            errors.Add("VAT number is required.");

        }

        // Check if the VAT number is exactly 9 digits long and numeric
        if (user.VATNumber.Length != 9 || !long.TryParse(user.VATNumber, out _))
        {
            errors.Add("VAT number must be exactly 9 digits long and numeric.");

        }

        return errors;
    }
    public PropertyOwner? CreateUser(PropertyOwner owner)
    {
        var errors = ValidateUser(owner);
        if (errors.Count > 0)
        {
            return null;
        }

        TempData.PropertyOwners.Add(owner);

        return owner;
    }
    public PropertyOwner? UpdateUser(PropertyOwner owner)
    {
        var errors = ValidateUser(owner);
        if (errors.Count > 0)
        {
            return null;
        }

        var selectedUser = TempData.PropertyOwners.Find(x => x.VATNumber == owner.VATNumber);
        if (selectedUser != null)
        {
            TempData.PropertyOwners.Remove(selectedUser);
        }
        TempData.PropertyOwners.Add(owner);
        return owner;
    }
    public PropertyOwner? DeleteUser(PropertyOwner owner)
    {
        var errors = ValidateUser(owner);
        if (errors.Count > 0)
        {
            return null;
        }
        var selectedUser = TempData.PropertyOwners.Find(x => x.VATNumber == owner.VATNumber);
        if (selectedUser != null)
        {
            TempData.PropertyOwners.Remove(selectedUser);
        }
        return owner;
    }
    public List<PropertyOwner> GetAll()
    {
        return TempData.PropertyOwners;

    }
    public PropertyOwner? GetOne(string VAT)
    {
        var selectedUser = TempData.PropertyOwners.Find(x => x.VATNumber == VAT);

        return selectedUser;
    }

}


