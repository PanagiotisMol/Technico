using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Enums;

namespace Technico.Models;

public class PropertyOwner
{
    public int VATNumber { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Address { get; set; } = null!;
    public int TelephoneNumber { get; set; }
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;

    public UserType Role { get; set; }

    public List<PropertyItem>? PropertyItems { get; set; }
    public List<PropertyOwner>? RepairDone { get; set; }
    //LIST OF REPAIRS
}
