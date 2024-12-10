using AutoMapper;
using AutoMapping.Store.Entities;
using AutoMapping.Store.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapping.Store.Controllers;

[ApiController]
public class UserController(IMapper mapper) : ControllerBase
{
    [HttpPost("/user")]
    public IActionResult Post([FromBody] CustomerViewModel customerViewModel)
    {
        var customer = mapper.Map<Customer>(customerViewModel);
        
        return Ok(customer);
    }
}