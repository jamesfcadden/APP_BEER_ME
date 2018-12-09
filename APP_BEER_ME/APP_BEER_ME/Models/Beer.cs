using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APP_BEER_ME.Models
{
    public enum Container { Bottle, Can }
    public class Beer
    {
        [Key]
        public int BeerID { get; set; }
        [Required(ErrorMessage = "The Name field is required ! ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The Style field is required ! ")]
        public string Style { get; set; }
        [Required(ErrorMessage = "The Brand field is required ! ")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "The Brewery field is required ! ")]
        public string Brewery { get; set; }
        [Required(ErrorMessage = "The Container field is required ! ")]
        public Container Container { get; set; }
        [Display(Name = "Volume (ml)")]
        public int Volume { get; set; }
        [Required(ErrorMessage = "The ABV field is required ! ")]
        public double ABV { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }
    }

}
