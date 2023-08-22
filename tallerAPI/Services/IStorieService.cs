using tallerAPI.Data.Dto;
using tallerAPI.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace tallerAPI.Services
{
    public interface IStorieService
    {
        Task<ActionResult<IEnumerable<StoriesDto>>> PostObtenerHistoriasAsync();
        Task<ActionResult<Int64>> PostCrearHistoriaAsync(Storie storie);

    }
}
