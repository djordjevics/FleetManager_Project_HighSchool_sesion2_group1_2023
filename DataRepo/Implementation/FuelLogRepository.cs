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
            throw new NotImplementedException();
        }

        public List<FuelLogData> GetAll()
        {
            return _context.fuelLogData.ToList();
        }

        public FuelLogData GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<FuelLogData> GetByVehicleId(Guid vehicleId)
        {
            throw new NotImplementedException();
        }

        public void Update(FuelLogData entity)
        {
            throw new NotImplementedException();
        }
    }
}
