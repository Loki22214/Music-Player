using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BlagajnaProjekt
{
    public partial class Model3 : DbContext
    {
        public Model3()
            : base("name=Model3")
        {
        }

        public virtual DbSet<Playlists> Playlists { get; set; }
        public virtual DbSet<PlaylistSongs> PlaylistSongs { get; set; }
        public virtual DbSet<Songs> Songs { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Playlists>()
                .HasMany(e => e.PlaylistSongs)
                .WithRequired(e => e.Playlists)
                .HasForeignKey(e => e.PlaylistId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Songs>()
                .HasMany(e => e.PlaylistSongs)
                .WithRequired(e => e.Songs)
                .HasForeignKey(e => e.SongId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Playlists)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}
