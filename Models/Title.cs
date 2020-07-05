using Jupiter.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Models
{
    public class Title
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }

        public string UserRating { get; set; }

        public decimal Price { get; set; }

        public EGameCategory GameCategory { get; set; }

        public string Carousel1{ get; set; }

        public string Carousel2 { get; set; }

        public string Carousel3 { get; set; }

        public int CategoryId { get; set; }

        public string videosource { get; set; }

        public string Publisher { get; set; }

        public string ReleaseDate { get; set; }

    }
}
