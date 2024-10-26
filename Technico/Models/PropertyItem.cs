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
    public int PropertIdNumber { get; set; } 
    public string PropertyAddress { get; set; } = null! ;
    public int YearOfConstruction { get; set; }
    public TypeOfProperty PropertyType { get; set; }
    public int VATNumber { get; set; } 

    
}






