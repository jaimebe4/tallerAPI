using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tallerAPI.Data.Models
{
    public class Storie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdStorie { get; set; }
        
        [Required]
        public DateTime StorieDate { get; set; }

        [Required]
        public string StorieHour { get; set; }
        [Required]
        public long StorieKm { get; set; }
        [Required]
        public string StorieType { get; set; }
        [Required]
        public string StorieLocal { get; set; }
        [Required]
        public long StoriePrice { get; set; }

        public string StorieNotes { get; set; }

        public long VehicleId { get; set; }
        [ForeignKey("VehicleId")]
        public virtual Vehicle? Id { get; set; }

    }
}
