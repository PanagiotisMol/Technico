using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Enums;

namespace Technico.Models;

public class PropertyItem
{
    public string PropertyIdNumber { get; set; } = null!;
    public string PropertyAddress { get; set; } = null!;
    public string YearOfConstruction { get; set; } = null!;
    public TypeOfProperty PropertyType { get; set; }
    public string OwnerVAT { get; set; } = null!;
}






