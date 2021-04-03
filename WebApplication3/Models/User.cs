using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplication3.Models
{
    [Table("User")]
    public partial class User
    {
        public User()
        {
            FollowerFollowerAferNavigations = new HashSet<Follower>();
            FollowerUsers = new HashSet<Follower>();
            LanguageUsers = new HashSet<LanguageUser>();
            Pikadons = new HashSet<Pikadon>();
        }

        [Key]
        [Column("UserID")]
        public int UserId { get; set; }
        [Column("FName")]
        [StringLength(50)]
        public string Fname { get; set; }
        [Column("LName")]
        [StringLength(50)]
        public string Lname { get; set; }

        [InverseProperty(nameof(Follower.FollowerAferNavigation))]
        public virtual ICollection<Follower> FollowerFollowerAferNavigations { get; set; }
        [InverseProperty(nameof(Follower.User))]
        public virtual ICollection<Follower> FollowerUsers { get; set; }
        [InverseProperty(nameof(LanguageUser.User))]
        public virtual ICollection<LanguageUser> LanguageUsers { get; set; }
        [InverseProperty(nameof(Pikadon.User))]
        public virtual ICollection<Pikadon> Pikadons { get; set; }
    }
}
