using tallerAPI.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace tallerAPI.Data.Dto
{
    public class StoriesDto
    {
        public long IdStorie { get; set; }
        public DateTime StorieDate { get; set; }
        public string StorieHour { get; set; }
        public long StorieKm { get; set; }
        public string StorieType { get; set; }
        public string StorieLocal { get; set; }
        public long StoriePrice { get; set; }
        public string StorieNotes { get; set; }
        public long VehicleId { get; set; }
        public string DescriVehiculo { get; set; }
        public string PlacaVehiculo { get;set; }

    }
}
