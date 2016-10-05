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
            Database.SetInitializer(new DropCreateDatabaseAlways<PhotoManagerDataModel>());
            SeedDb();
        }

        private void SeedDb()
        {
            using (PhotoManagerDataModel dataModel = new PhotoManagerDataModel())
            {
                dataModel.Albums.Add(new AlbumModel { Title = "TestsAlbum" });
                dataModel.Photoes.Add(new PhotoModel { Title = "TestPhoto" });
                dataModel.SaveChanges();
            }
        }
    }
}
