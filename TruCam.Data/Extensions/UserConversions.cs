using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruCam.Data.DataModels;
using TruCam.Data.DTOs;

namespace TruCam.Data.Extensions
{
    public static class UserConversions
    {
        public static User ToSqlModel(this UserDto userDto)
        {
            return new User
            {
                Id= userDto.Id,
                FirstName=userDto.FirstName,
                SecondName =userDto.SecondName,
                City =userDto.City,
                IsDeleted = userDto.IsDeleted
            };
        }

        public static UserDto ToDto(this User user)
        {
            return new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                SecondName = user.SecondName,
                City = user.City,
                IsDeleted = user.IsDeleted
            };
        }
    }
}
