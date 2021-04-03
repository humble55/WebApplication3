using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplication3.Models
{
    [Table("Pikadon")]
    public partial class Pikadon
    {
        [Key]
        [Column("PikadonID")]
        public int PikadonId { get; set; }
        [StringLength(10)]
        public string Type { get; set; }
        public int? Amount { get; set; }
        [Column("UserID")]
        public int? UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("Pikadons")]
        public virtual User User { get; set; }
    }
}
