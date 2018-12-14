using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruCam.Data.DTOs
{
    public class PointDto
    {
        public int Id { get; set; }

        public string PointName { get; set; }

        public string PointCoordinates { get; set; }

        public bool? Current { get; set; }

        public int? CreatorId { get; set; }

        public bool? IsDeleted { get; set; }

        public virtual UserDto User { get; set; }
    }
}
