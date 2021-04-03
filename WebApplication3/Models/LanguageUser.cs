using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplication3.Models
{
    public partial class LanguageUser
    {
        [Key]
        [Column("LanguageID")]
        public int LanguageId { get; set; }
        [Key]
        [Column("UserID")]
        public int UserId { get; set; }

        [ForeignKey(nameof(LanguageId))]
        [InverseProperty("LanguageUsers")]
        public virtual Language Language { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("LanguageUsers")]
        public virtual User User { get; set; }
    }
}
