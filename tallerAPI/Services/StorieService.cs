using tallerAPI.Data;
using tallerAPI.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public async Task<ActionResult<IEnumerable<Storie>>> PostObtenerHistoriasAsync()
        {
            if (_context.Stories == null)
            {
                return null;
            }
            var stories = await _context.Stories.ToListAsync();

            return stories;
        }
    }
}
