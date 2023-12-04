using DataRepo.Interfaces;
using DataRepo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepo.Implementation
{
    public class FuelLogRepository : IFuelLogRepository
    {
        FleetDbContext _context;
        public FuelLogRepository(FleetDbContext context) 
        {
            _context = context;
        }

        public Guid Add(FuelLogData data)
        {
            data.Id = Guid.NewGuid();
            _context.fuelLogData.Add(data);
            _context.SaveChanges();
            return data.Id;
        }

        public void Delete(Guid id)
        {
            _context.Remove(id);
        }

        public List<FuelLogData> GetAll()
        {
            return _context.fuelLogData.ToList();
        }

        public FuelLogData GetById(Guid id)
        {
          
            return _context.fuelLogData.Find(id); 
        }

            public List<FuelLogData> GetByVehicleId(Guid vehicleId)
        {
            return _context.fuelLogData.Where(f=>f.VehicleId == vehicleId).ToList();
        }

        public void Update(FuelLogData entity)
        {
            var updated = _context.fuelLogData.Find(entity.Id);
            if (updated == null)
            {
                _context.fuelLogData.Add(entity);
            }
            else 
            {
                updated.Currency = entity.Currency;
                updated.Price = entity.Price;
                updated.FuelUnit = entity.FuelUnit;
                updated.FuelAdded = entity.FuelAdded;
            }
            _context.SaveChanges();
        }
    }
}
