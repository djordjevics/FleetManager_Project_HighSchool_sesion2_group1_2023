using System.Text.Json.Serialization;

namespace FleetManager.Models;

public class PutVehicle
{
    [JsonIgnoreAttribute]
    public Guid Id { get; set; }

    public string FuelType { get; set; } = default!;

    public string License { get; set; } = default!;

    public string FuelUnit { get; set; } = default!;
}
