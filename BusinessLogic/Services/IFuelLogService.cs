﻿using FleetManager.Models;

namespace BusinessLogic.Services;

public interface IFuelLogService
{
    List<FuelLog> GetAllFuelLogs();
    FuelLog GetById(Guid Id);
    List<FuelLog> GetLogsByCarId(Guid id);
    FuelLog Add(FuelLog fuelLog);
    void Delete(Guid id);

}
