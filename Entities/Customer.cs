namespace AutoMapping.Store.Entities;

public class Customer
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    
    public string Email { get; private set; }
    
    public string Address { get; private set; }
    
    public Customer(string name, string email, string address)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        Address = address;
    }
}