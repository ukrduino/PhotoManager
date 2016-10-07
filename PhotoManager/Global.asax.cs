using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using PhotoManager.Models;

namespace PhotoManager
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<PhotoManagerDbContext>());
            SeedDb();
        }

        private void SeedDb()
        {
            using (PhotoManagerDbContext dbContext = new PhotoManagerDbContext())
            {
                dbContext.Albums.Add(new AlbumModel { Title = "TestsAlbum" });
                dbContext.Photoes.Add(new PhotoModel { Title = "TestPhoto" });
                dbContext.SaveChanges();
            }
        }
    }
}
