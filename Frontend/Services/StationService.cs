using CheapTrip.Contracts;
using System.Net.Http.Json;

namespace CheapTrip.Frontend.Services;

public class StationService(HttpClient http)
{
    public async Task<List<Station>> GetStationSuggestions(string input)
    {
        var stations = await http.GetFromJsonAsync<List<Station>>($"stations?search={input}");
        return stations ?? [];

        //return [
        //    new Station{
        //        Id = "1",
        //        Name = "Berlin"
        //    },
        //    new Station{
        //        Id = "2",
        //        Name = "Hamburg"
        //    },
        //    new Station{
        //        Id = "3",
        //        Name = "Munich"
        //    }
        //    ];
    }
}
