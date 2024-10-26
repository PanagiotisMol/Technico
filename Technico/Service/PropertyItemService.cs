using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technico.Service;

public class PropertyItemService
{
    //TODO UPDATE , DELETE,VIEW

    public string PropertIdNumber { get; set; } = null!;
    public string PropertyAddress { get; set; } = null!;
    public string VATNumber { get; set; } =null!;

    public class ValidationService
    {
        public static List<string> ValidateUser(PropertyItemService user)
        {
            var errors = new List<string>();

            // Validate PropertyAddress
            if (string.IsNullOrWhiteSpace(user.PropertyAddress))
            {
                errors.Add("Password is required.");
            }

            else if (!user.PropertyAddress.Any(char.IsUpper))
            {
                errors.Add("Password must contain at least one uppercase letter.");
            }
            else if (!user.PropertyAddress.Any(char.IsLower))
            {
                errors.Add("Password must contain at least one lowercase letter.");
            }
            else if (!user.PropertyAddress.Any(char.IsDigit))
            {
                errors.Add("Password must contain at least one number.");
            }

            //Validate OwnersVatNumber
            if (string.IsNullOrWhiteSpace(user.VATNumber))
            {
                errors.Add("VAT number is required.");

            }

            // Check if the Owners VAT number is exactly 9 digits long and numeric
            if (user.VATNumber.Length != 9 || !long.TryParse(user.VATNumber, out _))
            {
                errors.Add("VAT number must be exactly 9 digits long and numeric.");

            }

            //Validate PropertysIDNumber
            if (string.IsNullOrWhiteSpace(user.PropertIdNumber))
            {
                errors.Add("VAT number is required.");

            }

            // Check if the Properys Id number is exactly 4 digits long and numeric
            if (user.PropertIdNumber.Length != 4 || !long.TryParse(user.PropertIdNumber, out _))
            {
                errors.Add("VAT number must be exactly 4 digits long and numeric.");

            }

            return errors;
        }


    }
}
