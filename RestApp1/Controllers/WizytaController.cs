using Microsoft.AspNetCore.Mvc;
using RestApp1.Classes;
using RestApp1.Services;

namespace RestApp1.Controllers;
[ApiController]
[Route("Wizyta")]
public class WizytaController: ControllerBase
{
    private IMockWz _mockWz;

    public WizytaController(IMockWz mockWz)
    {
        _mockWz = mockWz;
    }
    
    [HttpGet("{id}")]
    public IActionResult GetByZwierzeId(int id)
    {
        return Ok(_mockWz.GetByZwierzeId(id));
    }
    
    [HttpPost]
    public IActionResult Add(Wizyta wizyta)
    {

        _mockWz.Add(wizyta);
        return Created();
    }
    
}