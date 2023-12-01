using System.ComponentModel.DataAnnotations;

namespace DataRepo.Models
{
    public class VehicleData
    {
        public Guid Id { get; set; }

        
        [Required]
        public string FuelType { get; set; } = default!;

        [Required]
        public int FuelCapacity { get; set; }
        [Required]
        public string FuelUnit { get; set; } = default!;
        [Required]
        public string Manufacturer { get; set; } = default!;
        [Required]
        public string Model { get; set; } = default!;
        [Required]
        public string License { get; set; } = default!;

    }
}
