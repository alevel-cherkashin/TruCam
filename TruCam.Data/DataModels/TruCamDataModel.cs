namespace TruCam.Data.DataModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TruCamDataModel : DbContext
    {
        public TruCamDataModel()
            : base("name=TruCamDataModel")
        {
        }

        public virtual DbSet<Point> Point { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(e => e.Point)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.CreatorId);
        }
    }
}
