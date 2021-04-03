using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplication3.Models
{
    [Table("Language")]
    public partial class Language
    {
        public Language()
        {
            LanguageUsers = new HashSet<LanguageUser>();
        }

        [Key]
        [Column("LanguageID")]
        public int LanguageId { get; set; }
        [StringLength(50)]
        public string LanguageName { get; set; }

        [InverseProperty(nameof(LanguageUser.Language))]
        public virtual ICollection<LanguageUser> LanguageUsers { get; set; }
    }
}
