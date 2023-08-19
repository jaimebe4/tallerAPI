using tallerAPI.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace tallerAPI.Services
{
    public interface IStorieService
    {
        Task<ActionResult<IEnumerable<Storie>>> PostObtenerHistoriasAsync();
        Task<ActionResult<Int64>> PostCrearHistoriaAsync(Storie storie);

    }
}
