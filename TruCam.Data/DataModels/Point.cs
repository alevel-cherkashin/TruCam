namespace TruCam.Data.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Point")]
    public partial class Point
    {
        public int Id { get; set; }

        public string PointName { get; set; }

        [StringLength(50)]
        public string PointCoordinates { get; set; }

        public bool? Current { get; set; }

        public int? CreatorId { get; set; }

        public bool? IsDeleted { get; set; }

        public virtual User User { get; set; }
    }
}
