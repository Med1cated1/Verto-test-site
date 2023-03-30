using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace verto_app.Models
{
    public class Photo
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Decription")]
        [Required]
        public String? Decription { get; set; }

        [Display(Name = "Image Path")]
        public String? ImagePath { get; set; }
    }
}
