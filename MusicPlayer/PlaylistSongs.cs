namespace MusicPlayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PlaylistSongs
    {
        public int Id { get; set; }

        public int PlaylistId { get; set; }

        public int SongId { get; set; }

        public virtual Playlists Playlists { get; set; }

        public virtual Songs Songs { get; set; }
    }
}
