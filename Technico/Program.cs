using System;
using System.Runtime.ConstrainedExecution;
using Technico.Enums;
using Technico.Models;
using Technico.Service;
using static Technico.Models.PropertyOwner;
using static Technico.Models.Repair;



public class Program
{
    public static void Main()
    {
        //INIT OF SERVICES
        var propertyOwnerService = new PropertyOwnerService();
        var propertyItemService = new PropertyItemService();
        var repairService = new RepairService();

        var user = new PropertyOwner
        {
            VATNumber = "123456789",
            Name = "Makis",
            Surname = "Doe",
            Address = "123 Main Street, Athens, Greece",
            PhoneNumber = 2101234567,
            Email = "john.doe@example.com",
            Password = "Password123!",
            Role = UserType.Admin,

        };

        //GET TEMPORARY OWNERLIST
        propertyOwnerService.CreateUser(user);
        var userList = propertyOwnerService.GetAll();

        //edit functionality
        user.PhoneNumber = 200000;
        propertyOwnerService.UpdateUser(user);
        userList = propertyOwnerService.GetAll();

        //Delete function
        propertyOwnerService.DeleteUser(user);
        userList = propertyOwnerService.GetAll();

        var item = new PropertyItem
        {
            PropertyIdNumber = "3",
            PropertyAddress = "789 Oak Avenue, Patras, Greece",
            YearOfConstruction = "2010",
            PropertyType = TypeOfProperty.DetachedHouse,
            OwnerVAT = "555666777" // Kostas Nikolopoulos's VATNumber
        };


        //GET TEMPORARY ItemLIST
        propertyItemService.CreateItem(item);
        var itemList = propertyItemService.GetAll();

        //edit functionality
        item.PropertyIdNumber = "5000";
        propertyItemService.UpdateItem(item);
        itemList = propertyItemService.GetAll();

        //Delete function
        propertyItemService.DeleteItem(item);
        itemList = propertyItemService.GetAll();



        var repair = new Repair
        {
            StartDate = new DateTime(2024, 02, 10),
            RepairType = TypeOfRepair.ElectricalWork,
            RepairDescription = "Replaced faulty wiring in living room.",
            RepairAddress = "456 Elm Street, Thessaloniki, Greece", // Maria's property
            RepairStatus = StatusOfTheRepair.Complete,
            CostOfRepair = "200",
            OwnerVAT = "987654321"

        };

        //GET TEMPORARY RepairLIST
        repairService.CreateRepair(repair);
        var repairList = repairService.GetAll();
        
        //edit functionality
        repair.RepairAddress = "456 Elm Street, Thessaloniki, Greece";
        repairService.UpdateRepair(repair);
        repairList = repairService.GetAll();

        //Delete function
        repairService.DeleteRepair(repair);
        repairList = repairService.GetAll();
    }
}





