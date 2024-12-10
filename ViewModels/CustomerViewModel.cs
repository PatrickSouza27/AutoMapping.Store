namespace AutoMapping.Store.ViewModels;

public class CustomerViewModel
{
    public string Name { get; private set; }
    
    public string Email { get; private set; }
    
    public string Address { get; private set; }
    
    public CustomerViewModel(string name, string email, string address)
    {
        Name = name;
        Email = email;
        Address = address;
    }
    
    
}