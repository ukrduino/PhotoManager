﻿using System;
using System.Collections.Generic;

namespace PhotoManager.Models
{
    public class PhotoModel
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Place { get; set; }
        public string Camera{ get; set; }
        public string FocalLength{ get; set; }
        public string Diaphragm { get; set; }
        public string CameraLockSpeed { get; set; }
        public string ISO { get; set; }
        public bool UsedFlash { get; set; }
        public ICollection<AlbumModel> Album { get; set; }

        public PhotoModel()
        {
            Album = new List<AlbumModel>();
        }
    }
}