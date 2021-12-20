using Microsoft.AspNetCore.Mvc;
namespace ApiWithJwt.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{

    private readonly ILogger<PersonController> _logger;

    public PersonController(ILogger<PersonController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetPeople")]
    public IEnumerable<Person> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Person(
        BirthDate: DateTime.Now.AddDays(index),
                TemperatureC: Random.Shared.Next(-20, 55),
                Summary: "valami"
            ))
            .ToArray();
    }
}