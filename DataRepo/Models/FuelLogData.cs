using System.ComponentModel.DataAnnotations;

namespace DataRepo.Models;

public class FuelLogData
{
    public Guid Id { get; set; }

    [Required]
    public int FuelAdded { get; set; }
    [Required]
    public string FuelUnit { get; set; } = default!;
    [Required]
    public float Price { get; set; }
    [Required]
    public string Currency { get; set; } = default!;
    
    public Guid VehicleId { get; set; }
    
    public VehicleData VehicleData { get; set; }
}
