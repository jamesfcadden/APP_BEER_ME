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
        public int BeerID { get; set; }
        public string Name { get; set; }
        public string Style { get; set; }
        public string Brand { get; set; }
        public string Brewery { get; set; }
        public Container Container { get; set; }
        [Display(Name = "Volume (ml)")]
        public int Volume { get; set; }
        public double ABV { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }
    }

}
