using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhotoManager.Models
{
    public class AlbumModel: HasLastModifiedField
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<PhotoModel> Photoes { get; set; }
        public byte[] CoverImageData { get; set; }
        public DateTime? LastModified { get; set; }

        public AlbumModel()
        {
            Photoes = new List<PhotoModel>();
            CreatedDate = DateTime.Now;
        }
    }
}