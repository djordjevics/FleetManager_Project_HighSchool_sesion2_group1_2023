namespace FleetManager.Models
{
    public class FuelLog
    {
        public Guid Id { get; set; }

        public Guid VehicleId { get; set; }

        public int FuelAdded { get; set; }

        public string FuelUnit { get; set; } = default!;

        public float Price { get; set; }

        public string Currency { get; set; } = default!;
    }
}
