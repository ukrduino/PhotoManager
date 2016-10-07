using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhotoManager.Models
{
    public class PhotoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public DateTime? TakenDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Place { get; set; }
        public string Camera { get; set; }
        public string FocalLength { get; set; }
        public string Diaphragm { get; set; }
        public string CameraLockSpeed { get; set; }
        public string ISO { get; set; }
        public bool UsedFlash { get; set; }
        public byte[] ImageData { get; set; }
        public ICollection<AlbumModel> Album { get; set; }

        public PhotoModel()
        {
            Album = new List<AlbumModel>();
            CreatedDate = DateTime.Now;
        }
    }
}