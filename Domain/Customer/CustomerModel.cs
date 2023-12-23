using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Customer
{
public class CustomerModel
{
    public int CustomerId { get; private set; }
    public string Name { get; private set; }
    public string FamilyName { get; private set; }
    public string Email { get; private set; }
    public string PhoneNumber { get; private set; }
    public string Username { get; private set; }
    private string Password { get;private set; } 

    public CustomerModel(int customerId, string name, string email, string phoneNumber, string username, string password)
    {
        CustomerId = customerId;
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        Username = username;
        Password = password;
    }

    public void SetPassword(string newPassword)
    {
    
        Password = newPassword;
    }

    public string GetPassword()
    {
    
        return Password;
    }

    public List<ReservationModel> Reservations { get; private set; }
}

}