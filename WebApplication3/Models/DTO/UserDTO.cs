using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models.DTO
{
    public class UserDTO
    {

        public string Fname { get; set; }

        public string Lname { get; set; }

        public virtual ICollection<FollowDTO> FollowMe { get; set; }
        public virtual ICollection<FollowDTO> FollowerUsers { get; set; }
        public virtual ICollection<LanguageUser> LanguageUsers { get; set; }
        public virtual ICollection<Pikadon> Pikadons { get; set; }
    }
}
