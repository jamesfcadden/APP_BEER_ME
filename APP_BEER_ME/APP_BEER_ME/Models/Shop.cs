using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace APP_BEER_ME.Models
{
    public class Shop
    {
        [Key]
        public int ShopID { get; set; }
        [Display(Name = "Shop Name")]
        public string ShopName { get; set; }
        [Display(Name = "Shop Address")]
        public string ShopAddress { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }
        
    }
}
