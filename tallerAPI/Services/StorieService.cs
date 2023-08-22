using tallerAPI.Data;
using tallerAPI.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tallerAPI.Data.Dto;
using Microsoft.Data.SqlClient;
using System.Linq;

namespace tallerAPI.Services
{
    public class StorieService : IStorieService
    {
        private readonly tallerDBContext _context;

        public StorieService(tallerDBContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<long>> PostCrearHistoriaAsync(Storie storie)
        {
            if (_context.Stories == null)
            {
                return null;
            }

            _context.Stories.Add(storie);
            var _storie = await _context.SaveChangesAsync();

            return _storie;

        }

        public async Task<ActionResult<IEnumerable<StoriesDto>>> PostObtenerHistoriasAsync()
        {
            if (_context.Stories == null)
            {
                return null;
            }

            var stories = await _context.Stories.Include(p => p.Id).ToListAsync();

            var resultado = stories.Join(
                 _context.Vehicles,
                 ST => ST.VehicleId,
                 VH => VH.Id,
                 (ST, VH) => new
                 {
                     Stories = ST,
                     DesVehiculo = VH.VehicleName,
                     PlaVehiculo = VH.VehiclePlaque
                 }).Where(result => result.Stories.VehicleId != 0)
                 .ToList();

            List<StoriesDto> ListaStoriesDto = resultado.Select(a => new StoriesDto()
            {
                IdStorie = a.Stories.IdStorie,
                StorieDate = a.Stories.StorieDate,
                StorieHour = a.Stories.StorieHour,
                StorieKm = a.Stories.StorieKm,
                StorieLocal = a.Stories.StorieLocal,
                StoriePrice = a.Stories.StoriePrice,
                StorieType = a.Stories.StorieType,
                StorieNotes = a.Stories.StorieNotes,
                VehicleId = a.Stories.VehicleId,
                DescriVehiculo = a.DesVehiculo,
                PlacaVehiculo = a.PlaVehiculo

            }).ToList();


            return ListaStoriesDto;
        }
    }
}
