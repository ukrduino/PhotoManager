using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhotoManager.Models
{
    public class AlbumModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public DateTime? Date { get; set; }
        public ICollection<PhotoModel> Photoes { get; set; }

        public AlbumModel()
        {
            Photoes = new List<PhotoModel>();
        }
    }
}