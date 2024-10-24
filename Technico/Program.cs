using System;
using System.Runtime.ConstrainedExecution;
using Technico.Enums;
using Technico.Models;
using static Technico.Models.PropertyOwner;
using static Technico.Models.Repair;



var PropertyOwner = new PropertyOwner()
{
    VATNumber = 123456789,
    FirstName = "John",
    LastName = "Doe",
    Address = "123 Main St, Springfield",
    TelephoneNumber = 5551234,
    Email = "john.doe@example.com",
    Password = "password123",
    RepairDone = { },
    PropertyItems = { },
    Role = UserType.Default
};





var PropertyOwner1 = new PropertyOwner()
{
    VATNumber = 987654321,
    FirstName = "Jane",
    LastName = "Smith",
    Address = "456 Elm St, Rivertown",
    TelephoneNumber = 5559876,
    Email = "jane.smith@example.com",
    Password = "qwerty987",
    RepairDone = { },
    PropertyItems = { },
    Role = UserType.Admin
};


var PropertyOwner2 = new PropertyOwner()
{
    VATNumber = 111222333,
    FirstName = "Robert",
    LastName = "Johnson",
    Address = "789 Pine St, Greenfield",
    TelephoneNumber = 5554321,
    Email = "robert.johnson@example.com",
    Password = "securePass456",
    RepairDone = { },
    PropertyItems = { },
    Role = UserType.Admin
};










var PropertyOwner3 = new PropertyOwner()
{
    VATNumber = 444555666,
    FirstName = "Emily",
    LastName = "Clark",
    Address = "321 Oak St, Blue Hills",
    TelephoneNumber = 5556789,
    Email = "emily.clark@example.com",
    Password = "password!789",
    RepairDone = { },
    PropertyItems = { },
    Role = UserType.Default
};






var PropertyOwner4 = new PropertyOwner()
{
    VATNumber = 777888999,
    FirstName = "David",
    LastName = "Lee",
    Address = "654 Cedar St, Lakeside",
    TelephoneNumber = 5558765,
    Email = "david.lee@example.com",
    Password = "david@2024",
    RepairDone = { },
    PropertyItems = { },
    Role = UserType.Admin
};

Console.WriteLine();

var Repair = new Repair()
{
    StartDate = new DateTime(2024, 4, 12),
    //TypeOfRepair = TypeOfRepair.Frames,
    RepairDescription = "Replacing window and door frames throughout the house.",
    RepairAddress = "123 Main St, Springfield",
    //StatusOfTheRepair = StatusOfTheRepair.Complete,
    CostOfRepair = 2700,
    OwnerVAT = 123456789
};


var Repair1 = new Repair()
{
    StartDate = new DateTime(2024, 3, 20),
    //TypeOfRepair = TypeOfRepair.Insulation,
    RepairDescription = "Installing insulation in the attic for better energy efficiency.",
    RepairAddress = "456 Elm St, Rivertown",
    //StatusOfTheRepair = StatusOfTheRepair.Inprogress,
    CostOfRepair = 2700,
    OwnerVAT = 987654321
};




var Repair2 = new Repair()
{
    StartDate = new DateTime(2023, 12, 5),
    //TypeOfRepair = TypeOfRepair.ElectricalWork,
    RepairDescription = "Rewiring and installation of new lighting fixtures.",
    RepairAddress = "789 Pine St, Greenfield",
    //StatusOfTheRepair = StatusOfTheRepair.Inprogress,
    CostOfRepair = 1800,
    OwnerVAT = 111222333
};





var Repair3 = new Repair()
{
    StartDate = new DateTime(2024, 2, 10),
    //TypeOfRepair = TypeOfRepair.Plumbing,
    RepairDescription = "Fixing leaky pipes in the kitchen and bathroom.",
    RepairAddress = "321 Oak St, Blue Hills",
    //StatusOfTheRepair = StatusOfTheRepair.Pending,
    CostOfRepair = 2200,
    OwnerVAT = 444555666
};







var Repair4 = new Repair()
{
    StartDate = new DateTime(2024, 2, 10),
    //TypeOfRepair = TypeOfRepair.Painting,
    RepairDescription = "Repainting of living room and bedrooms.",
    RepairAddress = "654 Cedar St, Lakeside",
    //StatusOfTheRepair = StatusOfTheRepair.Complete,
    CostOfRepair = 1500,
    OwnerVAT = 777888999
};



var PropertyItem = new PropertyItem()
{
    PropertIdNumber = 8080,
    PropertyAddress = "123 Main St, Springfield",
    YearOfConstruction = 2011,
    //TypeOfProperty = TypeOfProperty.ApartmentBuilding
    VATNumber = 123456789

};

var PropertyItem1 = new PropertyItem()
{
    PropertIdNumber = 2143,
    PropertyAddress = "456 Elm St, Rivertown",
    YearOfConstruction = 2000,
    //TypeOfProperty = TypeOfProperty.ApartmentBuilding
    VATNumber = 987654321

};

var PropertyItem2 = new PropertyItem()
{
    PropertIdNumber = 2010,
    PropertyAddress = "789 Pine St, Greenfield",
    YearOfConstruction = 2019,
    //TypeOfProperty = TypeOfProperty.DetachedHouse
    VATNumber = 111222333

};

var PropertyItem3 = new PropertyItem()
{
    PropertIdNumber = 1020,
    PropertyAddress = "321 Oak St, Blue Hills",
    YearOfConstruction = 2005,
    //TypeOfProperty = TypeOfProperty.DetachedHouse
    VATNumber = 444555666

};

var PropertyItem4 = new PropertyItem()
{
    PropertIdNumber = 5068,
    PropertyAddress = "654 Cedar St, Lakeside",
    YearOfConstruction = 1999,
    //TypeOfProperty = TypeOfProperty.Maisonet
    VATNumber = 777888999

};


