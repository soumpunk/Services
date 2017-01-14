using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangout.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public string PlantFinal { get; set; }
        public DateTime ReviewDate { get; set; }
        public int CardID { get; set; }
        public double Cost { get; set; }
        public int RatingStars { get; set; }
        public int SKU { get; set; }
        public string CommentsTitle { get; set; }
        public string RatingText { get; set; }
        public int ReviewUserId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
