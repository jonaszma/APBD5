using Microsoft.AspNetCore.Mvc;
using RestApp1.Classes;
using RestApp1.Services;

namespace RestApp1.Controllers;


[ApiController]
[Route("Zwierze")]
public class ZwierzeController: ControllerBase
{
    private IMockDb _mockDb;

    public ZwierzeController(IMockDb mockDb)
    {
        _mockDb = mockDb;
    }


    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_mockDb.GetAll());
    }
    
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok(_mockDb.GetById(id));
    }
    
    
    [HttpPost]
    public IActionResult Add(Zwierze zwierze)
    {
        if (_mockDb.GetAll().FirstOrDefault(e=>e.Id==zwierze.Id) is not null)
        {
            return Conflict();
        }
        _mockDb.Add(zwierze);
        return Created();
    }
    
    [HttpPut("{id}")]
    public IActionResult Replace(Zwierze zwierze,int id)
    {
        _mockDb.Replace(zwierze, id);
        return NoContent();
    }
    
    [HttpDelete("{id}")]
    public IActionResult Remove(int id)
    {
        return Ok(_mockDb.Remove(id));
    }
    
    
}