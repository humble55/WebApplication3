using WebApplication3.Models;
using WebApplication3.Models.DTO;

namespace SampleWebApi.Services
{
    public interface IHouseMapper
    {
       UserDTO MapToDto(User houseEntity);
      //  HouseEntity MapToEntity(HouseDto houseDto);
    }
}