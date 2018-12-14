using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruCam.Data.DataModels;
using TruCam.Data.DTOs;

namespace TruCam.Data.Extensions
{
    public static class PointConversions
    {
        public static Point ToSqlModel(this PointDto pointDto)
        {
            return new Point
            {
                Id = pointDto.Id,
                CreatorId = pointDto.CreatorId,
                Current = pointDto.Current,
                PointCoordinates = pointDto.PointCoordinates,
                PointName = pointDto.PointName,
                User = pointDto.User.ToSqlModel()
            };
        }

        public static PointDto ToDto(this Point point)
        {
            return new PointDto
            {
                Id = point.Id,
                CreatorId = point.CreatorId,
                Current = point.Current,
                PointCoordinates = point.PointCoordinates,
                PointName = point.PointName,
                User = point.User.ToDto()
            };
        }


    }
}
