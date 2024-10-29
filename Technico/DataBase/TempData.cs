
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Enums;
using Technico.Models;

namespace Technico.DataBase;
public class TempData
{
    public List<PropertyOwner> PropertyOwners { get; set; }
    public List<PropertyItem> PropertyItems { get; set; }
    public List<Repair> Repairs { get; set; }
    public TempData()
    {
        PropertyOwners = new List<PropertyOwner>
        {
            new PropertyOwner
            {
                VATNumber = "123456789",
                Name = "John",
                Surname = "Doe",
                Address = "123 Main Street, Athens, Greece",
                PhoneNumber = 2101234567,
                Email = "john.doe@example.com",
                Password = "Password123!",
                Role = UserType.Admin,

            },
            new PropertyOwner
            {
                VATNumber = "987654321",
                Name = "Maria",
                Surname = "Papadopoulou",
                Address = "456 Elm Street, Thessaloniki, Greece",
                PhoneNumber = 231045678,
                Email = "maria.p@example.com",
                Password = "Password456!",
                Role = UserType.Default,

            },
            new PropertyOwner
            {
                VATNumber = "555666777",
                Name = "Kostas",
                Surname = "Nikolopoulos",
                Address = "789 Oak Avenue, Patras, Greece",
                PhoneNumber = 261012356,
                Email = "kostas.n@example.com",
                Password = "Password789!",
                Role = UserType.Admin,

            },
            new PropertyOwner
            {
                VATNumber = "111222333",
                Name = "Eleni",
                Surname = "Karapanagioti",
                Address = "101 Pine Road, Heraklion, Greece",
                PhoneNumber = 281013456,
                Email = "eleni.k@example.com",
                Password = "Password101!",
                Role = UserType.Default,

            }

        };

        PropertyItems = new List<PropertyItem>
{
    new PropertyItem
    {
        PropertyIdNumber = "1000",
        PropertyAddress = "123 Main Street, Athens, Greece",
        YearOfConstruction = "2005",
        PropertyType = TypeOfProperty.DetachedHouse,
        OwnerVAT = "123456789" // John Doe's VATNumber
    },
    new PropertyItem
    {
        PropertyIdNumber = "2000",
        PropertyAddress = "456 Elm Street, Thessaloniki, Greece",
        YearOfConstruction = "1999",
        PropertyType = TypeOfProperty.DetachedHouse,
        OwnerVAT = "987654321" // Maria Papadopoulou's VATNumber
    },
    new PropertyItem
    {
        PropertyIdNumber = "3000",
        PropertyAddress = "789 Oak Avenue, Patras, Greece",
        YearOfConstruction = "2010",
        PropertyType = TypeOfProperty.DetachedHouse,
        OwnerVAT = "555666777" // Kostas Nikolopoulos's VATNumber
    },
    new PropertyItem
    {
        PropertyIdNumber = "4000",
        PropertyAddress = "101 Pine Road, Heraklion, Greece",
        YearOfConstruction = "2003",
        PropertyType = TypeOfProperty.Maisonet,
        OwnerVAT = "111222333" // Eleni Karapanagioti's VATNumber
    },
    new PropertyItem
    {
        PropertyIdNumber = "5000",
        PropertyAddress = "321 Maple Street, Athens, Greece",
        YearOfConstruction = "2015",
        PropertyType = TypeOfProperty.ApartmentBuilding,
        OwnerVAT = "123456789" // John Doe's VATNumber
    },
    new PropertyItem
    {
        PropertyIdNumber = "6000",
        PropertyAddress = "654 Cedar Lane, Thessaloniki, Greece",
        YearOfConstruction = "2008",
        PropertyType = TypeOfProperty.ApartmentBuilding,
        OwnerVAT = "987654321" // Maria Papadopoulou's VATNumber
    }
};
        Repairs = new List<Repair>
{
    new Repair
    {
        StartDate = new DateTime(2024, 01, 15),
        RepairType = TypeOfRepair.Plumbing,
        RepairDescription = "Fixed leaking pipes in the bathroom.",
        RepairAddress = "123 Main Street, Athens, Greece", // John's property
        RepairStatus = StatusOfTheRepair.Complete,
        CostOfRepair = "150",
        OwnerVAT = "123456789"
    },
    new Repair
    {
        StartDate = new DateTime(2024, 02, 10),
        RepairType = TypeOfRepair.ElectricalWork,
        RepairDescription = "Replaced faulty wiring in living room.",
        RepairAddress = "456 Elm Street, Thessaloniki, Greece", // Maria's property
        RepairStatus = StatusOfTheRepair.Complete,
        CostOfRepair = "200",
        OwnerVAT = "987654321"
    },
    new Repair
    {
        StartDate = new DateTime(2024, 03, 05),
        RepairType = TypeOfRepair.Painting,
        RepairDescription = "Repainted the exterior walls.",
        RepairAddress = "789 Oak Avenue, Patras, Greece", // Kostas's property
        RepairStatus = StatusOfTheRepair.Inprogress,
        CostOfRepair = "300",
        OwnerVAT = "555666777"
    },
    new Repair
    {
        StartDate = new DateTime(2024, 03, 20),
        RepairType = TypeOfRepair.Insulation,
        RepairDescription = "Replaced broken roof tiles.",
        RepairAddress = "101 Pine Road, Heraklion, Greece", // Eleni's property
        RepairStatus = StatusOfTheRepair.Pending,
        CostOfRepair = "500",
        OwnerVAT = "111222333"
    },
    new Repair
    {
        StartDate = new DateTime(2024, 04, 15),
        RepairType = TypeOfRepair. ElectricalWork,
        RepairDescription = "Annual maintenance and inspection.",
        RepairAddress = "654 Cedar Lane, Thessaloniki, Greece", // Maria's second property
        RepairStatus = StatusOfTheRepair.Complete,
        CostOfRepair = "100",
        OwnerVAT = "987654321"
    }
};
    }  
}