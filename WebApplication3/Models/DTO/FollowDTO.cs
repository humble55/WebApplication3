using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models.DTO
{
    public class FollowDTO
    {

        public int FolloweId { get; set; }
        public int? UserId { get; set; }
        public int? FollowerAfer { get; set; }

        public string? FullName { get; set; }
        public string? Title { get; set; }


    }
}
