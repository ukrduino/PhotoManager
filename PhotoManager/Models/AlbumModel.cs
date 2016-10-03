using System;
using System.Collections.Generic;

namespace PhotoManager.Models
{
    public class AlbumModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public DateTime Date { get; set; }
        public ICollection<PhotoModel> Photoes { get; set; }

        public AlbumModel()
        {
            Photoes = new List<PhotoModel>();
        }
    }
}