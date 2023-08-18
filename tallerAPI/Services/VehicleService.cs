using tallerAPI.Data;
using tallerAPI.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace tallerAPI.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly tallerDBContext _context;

        public VehicleService(tallerDBContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<long>> PostCrearVehiculoAsync(Vehicle vehicle)
        {
            if (_context.Vehicles == null)
            {
                return null;
            }

            if (VehiculoExistsPorNombre(vehicle.VehicleName))
            {
                return null;
            }

            _context.Vehicles.Add(vehicle);
            var _vehicle = await _context.SaveChangesAsync();

            return _vehicle;

        }

        private bool VehiculoExistsPorNombre(string descripcion)
        {
            return (_context.Vehicles?.Any(e => e.VehicleName.ToLower().Trim() == descripcion)).GetValueOrDefault();
        }


        public async Task<ActionResult<IEnumerable<Vehicle>>> PostObtenerVehiculosAsync()
        {
            if (_context.Vehicles == null)
            {
                return null;
            }
            //var GastosFijos = await _context.GastosFijos.Include(u => u.User).ToListAsync();
            var vehiculos = await _context.Vehicles.Include(u => u.Id).ToListAsync();

            return vehiculos;
        }
    }
}