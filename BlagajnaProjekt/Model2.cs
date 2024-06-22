using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BlagajnaProjekt
{
    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<Playlists> Playlists { get; set; }
        public virtual DbSet<Songs> Songs { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Playlists>()
                .HasMany(e => e.Songs)
                .WithMany(e => e.Playlists)
                .Map(m => m.ToTable("PlaylistSongs").MapLeftKey("PlaylistId").MapRightKey("SongID"));

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Playlists)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}
