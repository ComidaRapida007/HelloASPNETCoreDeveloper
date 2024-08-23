using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Generic.Domain.Model.Entities;

namespace WebApplication1.Generic.Interfaces.REST.Controllers;

[ApiController]
[Route("[controller]")]
public class WelcomeController : ControllerBase
{
    [HttpGet]
    public string welcome()
    {
        return WelcomeBuilder.Build(null);
    }


    [HttpGet("{name}")]
    public string welcome(string name)
    {
        return WelcomeBuilder.Build(name);
    }
}