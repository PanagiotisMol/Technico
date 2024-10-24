using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technico.Models;

public class Repair
{
    public DateTime StartDate { get; set; }
    public enum TypeOfRepair { Painting, Insulation, Frames, plumbing, electricalWork }

    public string RepairDescription { get; set; } = null!;
    public string RepairAddress { get; set; } = null!;

    public enum StatusOfTheRepair { Pending, Inprogress, Complete , Default }
    public int CostOfRepair { get; set; }
    public int OwnerVAT {  get; set; }
    

    
}
