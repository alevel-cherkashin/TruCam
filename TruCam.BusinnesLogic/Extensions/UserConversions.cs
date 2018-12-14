using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruCam.BusinnesLogic.Models;
using TruCam.Data.DTOs;

namespace TruCam.BusinnesLogic.Extensions
{
    public static class UserConversions
    {
        public static UserViewModel ToViewModel(this UserDto userDto)
        {
            return new UserViewModel
            {
                Id = userDto.Id,
                FirstName = userDto.FirstName,
                SecondName = userDto.SecondName,
                City = userDto.City,
                IsDeleted = userDto.IsDeleted
            };
        }

        public static UserDto ToDto(this UserViewModel userViewModel)
        {
            return new UserDto
            {
                Id = userViewModel.Id,
                FirstName = userViewModel.FirstName,
                SecondName = userViewModel.SecondName,
                City = userViewModel.City,
                IsDeleted = userViewModel.IsDeleted
            };
        }
    }
}
