using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Enums;

namespace Technico.Models;

public class Repair
{
    public DateTime StartDate { get; set; }
    public  TypeOfRepair  RepairType { get; set; }

    public string RepairDescription { get; set; } = null!;
    public string RepairAddress { get; set; } = null!;

    public  StatusOfTheRepair RepairStatus { get; set; }
    public int CostOfRepair { get; set; }
    public int OwnerVAT {  get; set; }

    public TypeOfProperty PropertyType { get; set; }
}
