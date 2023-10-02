// See https://aka.ms/new-console-template for more information
using Freelancer_OOP.Entities;

Console.WriteLine("Hello, World!");

var anotherCustomerInstance = new Customer
{
    Id = Guid.NewGuid(),         
    CreatedOn = DateTime.Now,   
    FirstName = "Bob",
    LastName = "Smith",
    PhoneNumber = "555-123-4567" 
};


