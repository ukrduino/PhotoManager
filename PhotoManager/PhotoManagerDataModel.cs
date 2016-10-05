using PhotoManager.Models;
using System.Data.Entity;

namespace PhotoManager
{


    public class PhotoManagerDataModel : DbContext
    {

        public PhotoManagerDataModel()
            : base("name=PhotoManagerDB")
        {
        }

        public virtual DbSet<AlbumModel> Albums { get; set; }
        public virtual DbSet<PhotoModel> Photoes { get; set; }
    }
}