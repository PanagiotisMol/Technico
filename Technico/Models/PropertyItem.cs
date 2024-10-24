using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technico.Models;

public class PropertyItem
{
    public int PropertIdNumber { get; set; }
    public string PropertyAddress { get; set; } = null! ;
    public int YearOfConstruction { get; set; }
    public enum TypeOfProperty { DetachedHouse, Maisonet, ApartmentBuilding }
    public int VATNumber { get; set; }
                                                        

}

