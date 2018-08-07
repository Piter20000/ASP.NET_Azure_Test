using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NET.Models
{
    public class Shop_Item
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Item Name is required")]
        [StringLength(255)]
        [Display(Name = "Item Name")]
        public string Name { get; set; }

        [Url]
        [StringLength(600)]
        [Display(Name = "Image URL")]
        public string Image_URL { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Genre is required")]
        [StringLength(50)]
        public string Genre { get; set; }

        [Display(Name = "Alternative for Image")]
        public string Image_Name { get; set; }

        public DateTime Created { get; set; }

        public string Added_By_UID { get; set; }
    }
}