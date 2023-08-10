﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using tallerAPI.Data.Models;

namespace tallerAPI.Data.Models
{
    public class User
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public long RoleId { get; set; }

        [ForeignKey("RoleId")]
        public virtual UserRole Role { get; set; }
    }

}

