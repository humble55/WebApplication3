using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebApplication3.Models;
using WebApplication3.Models.DTO;

namespace SampleWebApi.Services
{
    public class HouseMapper : IHouseMapper
    {
        public UserDTO MapToDto(User user2)
        {
            return new UserDTO()
            {
                Fname = user2.Fname,
                Lname = user2.Lname,
                LanguageUsers = user2.LanguageUsers,
                FollowerUsers = user2.FollowerUsers.Select(x => new FollowDTO { FolloweId = x.FolloweId, FollowerAfer = x.FollowerAfer,
                    FullName = x.FollowerAferNavigation.Fname + " " + x.FollowerAferNavigation.Lname, UserId = x.FollowerAferNavigation.UserId, Title = "TEST" }).ToList(),
                FollowMe = user2.FollowerFollowerAferNavigations.Select(x => new FollowDTO
                {
                    FolloweId = x.FolloweId,
                    FollowerAfer = x.FollowerAfer,
                    FullName = x.User.Fname +" "+ x.User.Lname,
                    UserId = x.User.UserId,
                    Title = "TEST"
                }).ToList(),
                
            };
        }

        //public UserDTO MapToEntity(UserDTO houseDto)
        //{
        //    return new HouseEntity()
        //    {
        //        Id = houseDto.Id,
        //        ZipCode = houseDto.ZipCode,
        //        City = houseDto.City,
        //        Street = houseDto.Street
        //    };
        //}
    }
}