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
            using (PhotoManagerDataModel dataModel = new PhotoManagerDataModel())
            {
                dataModel.Albums.Add(new AlbumModel { Title = "TestsAlbum1" });
                dataModel.SaveChanges();
            }
        }
        [TestMethod]
        public void CreatePhotoTests()
        {
            using (PhotoManagerDataModel dataModel = new PhotoManagerDataModel())
            {
                dataModel.Photoes.Add(new PhotoModel { Title = "TestPhoto1" });
                dataModel.SaveChanges();
            }
        }
    }
}
