using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoManager;
using PhotoManager.Models;

namespace UnitTests
{
    [TestClass]
    public class DbTests
    {
        [TestMethod]
        public void CreateAlbumTests()
        {
            using (PhotoManagerDbContext dbContext = new PhotoManagerDbContext())
            {
                dbContext.Albums.Add(new AlbumModel { Title = "TestsAlbum1" });
                dbContext.SaveChanges();
            }
        }
        [TestMethod]
        public void CreatePhotoTests()
        {
            using (PhotoManagerDbContext dbContext = new PhotoManagerDbContext())
            {
                dbContext.Photoes.Add(new PhotoModel { Title = "TestPhoto1" });
                dbContext.SaveChanges();
            }
        }
    }
}
