using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace PhotoManager.Models
{


    public class PhotoManagerDbContext : DbContext
    {

        public PhotoManagerDbContext()
            : base("name=PhotoManagerDB")
        {
        }

        public override int SaveChanges()
        {
            DateTime now = DateTime.Now;
            foreach (ObjectStateEntry entry in (this as IObjectContextAdapter).ObjectContext.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified))
            {
                if (!entry.IsRelationship)
                {
                    HasLastModifiedField lastModified = entry.Entity as HasLastModifiedField;
                    if (lastModified != null)
                        lastModified.LastModified = now;
                }
            }

            return base.SaveChanges();
        }

        public virtual DbSet<AlbumModel> Albums { get; set; }
        public virtual DbSet<PhotoModel> Photoes { get; set; }
    }
}