using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Enums;

namespace Technico.Models;

public class PropertyOwner
{
    public string VATNumber { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public string Address { get; set; } = null!;
    public int PhoneNumber { get; set; }
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;

    public UserType Role { get; set; }

    public List<PropertyItem>? PropertyItems { get; set; }
    public List<PropertyOwner>? RepairDone { get; set; }
}
