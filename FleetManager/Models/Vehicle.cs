namespace FleetManager.Models
{
    public class Vehicle
    {
        public Guid Id { get; set; }

        public string FuelType { get; set; } = default!;

        public int FuelCapacity { get; set; }

        public string FuelUnit { get; set; } = default!;

        public string Manufacturer { get; set; } = default!;

        public string Model { get; set; } = default!;

        public string License {  get; set; } = default!;

    }
}
