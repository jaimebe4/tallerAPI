using Microsoft.AspNetCore.Mvc;
using tallerAPI.Data.Models;

namespace tallerAPI.Services
{
    public interface IVehicleService
    {
        Task<ActionResult<IEnumerable<Vehicle>>> PostObtenerVehiculosAsync();
        Task<ActionResult<Int64>> PostCrearVehiculoAsync(Vehicle vehicle);

    }
}
