using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruCam.BusinnesLogic.Models;
using TruCam.Data.DTOs;

namespace TruCam.BusinnesLogic.Extensions
{
    public static class PointConversions
    {
        public static PointViewModel ToViewModel(PointDto pointDto)
        {
            return new PointViewModel
            {
                Id = pointDto.Id,
                CreatorId = pointDto.CreatorId,
                Current = pointDto.Current,
                PointCoordinates = pointDto.PointCoordinates,
                PointName = pointDto.PointName,
                User = pointDto.User.ToViewModel()
            };
        }

        public static PointDto ToDto(PointViewModel pointViewModel)
        {
            return new PointDto
            {
                Id = pointViewModel.Id,
                CreatorId = pointViewModel.CreatorId,
                Current = pointViewModel.Current,
                PointCoordinates = pointViewModel.PointCoordinates,
                PointName = pointViewModel.PointName,
                User = pointViewModel.User.ToDto()
            };
        }
    }
}
