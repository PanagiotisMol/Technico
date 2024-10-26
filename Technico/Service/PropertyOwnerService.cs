using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Technico.Models;
using Technico.Service;


namespace Technico.Service;

    //TODO UPDATE , DELETE,VIEW
    
    public class PropertyOwnerService
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string VATNumber { get; set; } = null!; // Set to string to allow easy validation of digit length and numeric checks
       
    

    public class ValidationService
    {
        public static List<string> ValidateUser(PropertyOwnerService user)
        {
            var errors = new List<string>();
            string specialCharacters = "@$!%*?&";

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
            else if (user.Password.Length < 8)
            {
                errors.Add("Password must be at least 8 characters long.");
            }
            else if (!user.Password.Any(char.IsUpper))
            {
                errors.Add("Password must contain at least one uppercase letter.");
            }
            else if (!user.Password.Any(char.IsLower))
            {
                errors.Add("Password must contain at least one lowercase letter.");
            }
            else if (!user.Password.Any(char.IsDigit))
            {
                errors.Add("Password must contain at least one number.");
            }
            else if (!user.Password.Any(c => specialCharacters.Contains(c)))
            {
                errors.Add("Password must contain at least one special character (@, $, !, %, *, ?, &).");
            }

            //Validate VatNumber
            if (string.IsNullOrWhiteSpace(user.VATNumber))
            {
                errors.Add ("VAT number is required.");
                
            }

            // Check if the VAT number is exactly 9 digits long and numeric
            if (user.VATNumber.Length != 9 || !long.TryParse(user.VATNumber, out _))
            {
                errors.Add ("VAT number must be exactly 9 digits long and numeric.");
                
            }

            return errors;
        }

        
    }
}



