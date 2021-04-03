using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

#nullable disable

namespace WebApplication3.Models
{
    public partial class Follower
    {
        [Key]
        [Column("FolloweID")]
        public int FolloweId { get; set; }
        [Column("UserID")]
        public int? UserId { get; set; }
        [Column("followerAfer")]
        public int? FollowerAfer { get; set; }

        [ForeignKey(nameof(FollowerAfer))]
        [InverseProperty("FollowerFollowerAferNavigations")]
        public virtual User FollowerAferNavigation { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("FollowerUsers")]
        [JsonIgnore]
        public virtual User User { get; set; }
    }
}
