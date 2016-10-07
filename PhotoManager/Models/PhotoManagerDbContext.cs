using System.Data.Entity;

namespace PhotoManager.Models
{


    public class PhotoManagerDbContext : DbContext
    {

        public PhotoManagerDbContext()
            : base("name=PhotoManagerDB")
        {
        }

        public virtual DbSet<AlbumModel> Albums { get; set; }
        public virtual DbSet<PhotoModel> Photoes { get; set; }
    }
}