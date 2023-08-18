using tallerAPI.Data.Models;
using tallerAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tallerAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehiclesController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }


        [HttpPost]
        [Route("PostObtenerVehiculos")]
        public async Task<ActionResult<IEnumerable<Vehicle>>> PostObtenerVehiculos()
        {

            var vehiculo = await _vehicleService.PostObtenerVehiculosAsync();

            if (vehiculo == null)
            {
                return NotFound();
            }
            /*
            var token = _accountService.GenerateJwtToken(user);

            var userDto = new UserDto
            {
                UserName = user.UserName,
                Role = user.Role,
                Token = token
            };*/

            return Ok(vehiculo);
        }

        [HttpPost]
        [Route("PostCrearVehiculo")]
        public async Task<ActionResult> PostCrearVehiculo(Vehicle vehicle)
        {

            if (vehicle == null)
            {
                return Problem("Entity set 'tallerDBContext.vehicle'  is null.");
            }

            var _vehicle = await _vehicleService.PostCrearVehiculoAsync(vehicle);

            if (_vehicle == null)
            {
                return Problem("Error creando nuevo vehiculo");
            }

            /*
            var userDto = new UserDto
            {
                UserName = user.UserName,
                Role = user.Role,
                Token = token
            };*/

            return Ok();
        }










    }
}
