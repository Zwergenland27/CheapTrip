using CheapTrip.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CheapTrip.Backend.Controllers;

[ApiController]
[Route("[controller]")]
public class StationController(HttpClient http) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<Station>>> GetStations([FromQuery(Name = "search")] string search)
    {
        var stations = await http.GetFromJsonAsync<List<Station>>($"reiseloesung/orte?suchbegriff={search}");
        return Ok(stations);
    }
}