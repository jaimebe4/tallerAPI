using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using tallerAPI.Data.Enumerations;

namespace tallerAPI.Data.Models
{
    public class UserRole
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long RoleId { get; set; }

        [Required]
        public string Name { get; set; }

        public RoleType Type { get; set; }
    }
}
