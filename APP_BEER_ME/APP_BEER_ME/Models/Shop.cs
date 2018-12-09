using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APP_BEER_ME.Models
{
    public class Shop
    {
        [Key]
        public int ShopID { get; set; }
        [Display(Name = "Shop Name")]
        [Required(ErrorMessage = "The Shop Name field is required ! ")]
        public string ShopName { get; set; }
        [Display(Name = "Shop Address")]
        [Required(ErrorMessage = "The Shop Address field is required ! ")]
        public string ShopAddress { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
