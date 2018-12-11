using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APP_BEER_ME.Models;
using APP_BEER_ME.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace APP_BEER_ME.Tests
{
    [TestClass()]
    public class APP_BEER_METests
    {
        [TestMethod()]
        public void CreateBeer()
        {
            Beer b = new Beer() { BeerID = 1, Name = "James' Good Time Ale", Brand = "Cadden's Old Fashioned Ales", Style = "Bitter", Brewery = "Cadden's Beer Refinery", ABV = 4.8, Container = Container.Bottle, Volume = 500 };
            Assert.IsInstanceOfType(b, typeof(Beer));
            Assert.AreEqual(b.BeerID, 1);
            Assert.AreEqual(b.Name, "James' Good Time Ale");
            Assert.AreEqual(b.Brand, "Cadden's Old Fashioned Ales");
            Assert.AreEqual(b.Style, "Bitter");
            Assert.AreEqual(b.Brewery, "Cadden's Beer Refinery");
            Assert.AreEqual(b.ABV, 4.8);
            Assert.AreEqual(b.Container, Container.Bottle);
            Assert.AreEqual(b.Volume, 500);
        }

        [TestMethod()]
        public void CreateShop()
        {
            Shop sh = new Shop() { ShopID = 1, ShopName = "Julianna's Beer Emporium", ShopAddress = "Beer Street" };
            Assert.IsInstanceOfType(sh, typeof(Shop));
            Assert.AreEqual(sh.ShopID, 1);
            Assert.AreEqual(sh.ShopName, "Julianna's Beer Emporium");
            Assert.AreEqual(sh.ShopAddress, "Beer Street");
        }

        [TestMethod()]
        public void CreateStock()
        {
            Stock st = new Stock() { StockID = 1, BeerID = 1, ShopID = 1, Price = 3 };
            Assert.IsInstanceOfType(st, typeof(Stock));
            Assert.AreEqual(st.StockID, 1);
            Assert.AreEqual(st.ShopID, 1);
            Assert.AreEqual(st.BeerID, 1);
            Assert.AreEqual(st.Price, 3);
        }

        [TestMethod()]
        public void TestUnitCalc()
        {
            Beer b = new Beer() { BeerID = 1, Name = "Tomasz' Red Ale", Brand = "Tomasz's Finest", Brewery = "Kutela's Brewmastery", Container = Container.Can, Style = "Red Ale", ABV = 3.3, Volume = 330 };
            
        }
    }
}
