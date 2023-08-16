using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace tallerAPI.Data.Models
{
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public string VehicleType { get; set; }

        [Required]
        public string VehicleName { get; set; }

        [Required]
        public string VehicleBrand { get; set; }

        [Required]
        public int VehicleModel { get; set; }

        [Required]
        public string VehiclePlaque { get; set; }

    }
}
