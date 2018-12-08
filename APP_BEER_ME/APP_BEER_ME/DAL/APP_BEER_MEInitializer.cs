using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using APP_BEER_ME.Models;

namespace APP_BEER_ME.DAL
{
    public class APP_BEER_MEInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<APP_BEER_MEContext>
    {
        protected override void Seed(APP_BEER_MEContext context)
        {
            var beers = new List<Beer>
            {
                new Beer { Name = "Darkside IPA", Style = "IPA - American", Brand = "Brú Brewery", Brewery = "Brú Brewery", Container = Container.Bottle, Volume = 500 , ABV = 5.2 },
                new Beer { Name = "Darragh's Session IPA", Style = "IPA - Session / India Session Ale", Brand = "McGargles", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 3.8 },
                new Beer { Name = "O'Hara's Irish Stout", Style = "Stout - Irish Dry", Brand = "O'Hara's", Brewery = "O'Hara's Brewery (Carlow Brewing Company)", Container = Container.Bottle, Volume = 500 , ABV = 4.3 },
                new Beer { Name = "O'Hara's Irish Pale Ale", Style = "IPA - International", Brand = "O'Hara's", Brewery = "O'Hara's Brewery (Carlow Brewing Company)", Container = Container.Bottle, Volume = 500 , ABV = 5.2 },
                new Beer { Name = "Rye River Ól Orange Lager", Style = "Lager - IPL (India Pale Lager)", Brand = "Rye River", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 4.4 },
                new Beer { Name = "Rye River Just the Tipple", Style = "Saison / Farmhouse Ale", Brand = "Rye River", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 6.5 },
                new Beer { Name = "Rye River Miami J IPA", Style = "IPA - New England", Brand = "Rye River", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 6.5 },
                new Beer { Name = "Rye River Belgian Imperial Stout", Style = "Stout - Imperial / Double", Brand = "Rye River", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 8.2 },
                new Beer { Name = "The Crafty Brewing Company - Irish Red Ale", Style = "Red Ale - Irish", Brand = "The Crafty Brewing Company", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 4.1 },
                new Beer { Name = "The Crafty Brewing Company - Irish Pale Ale", Style = "Pale Ale - Australian", Brand = "The Crafty Brewing Company", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 4.5 },
                new Beer { Name = "The Crafty Brewing Company - Irish Stout", Style = "Stout - Irish Dry", Brand = "The Crafty Brewing Company", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 4.5 },
                new Beer { Name = "The Crafty Brewing Company - Golden Fields Saison", Style = "Saison / Farmhouse Ale", Brand = "The Crafty Brewing Company", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 4.8 },
                new Beer { Name = "The Crafty Brewing Company - American Style Brown Ale", Style = "Brown Ale - American", Brand = "The Crafty Brewing Company", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 5 },
                new Beer { Name = "The Crafty Brewing Company - Irish Lager", Style = "Lager - Pale", Brand = "The Crafty Brewing Company", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 5 },
                new Beer { Name = "The Crafty Brewing Company American Style Pale Wheat Ale", Style = "Pale Wheat Ale - American", Brand = "The Crafty Brewing Company", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 5 },
                new Beer { Name = "The Crafty Brewing Company - Irish IPA", Style = "IPA - American", Brand = "The Crafty Brewing Company", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 6 },
                new Beer { Name = "Boyne Brewhouse Imperial Stout Sherry Cask", Style = "Stout - Russian Imperial", Brand = "Boyne Brewhouse", Brewery = "Boyne Brewhouse", Container = Container.Bottle, Volume = 500 , ABV = 10.8 },
                new Beer { Name = "Grafters IPA", Style = "IPA - American", Brand = "Grafters", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 6.5 },
                new Beer { Name = "O'Shea's IPA", Style = "IPA - English", Brand = "O'Shea's", Brewery = "O'Hara's Brewery (Carlow Brewing Company)", Container = Container.Bottle, Volume = 500 , ABV = 5 },
                new Beer { Name = "Brown Bear Double IPA", Style = "IPA - Imperial / Double", Brand = "Brown Bear", Brewery = "Station Works Brewery", Container = Container.Bottle, Volume = 500 , ABV = 6.3 },
                new Beer { Name = "Brown Bear IPA", Style = "IPA - English", Brand = "Brown Bear", Brewery = "Station Works Brewery", Container = Container.Bottle, Volume = 500 , ABV = 5.2 },
                new Beer { Name = "Solas Hops & Grains Belgian Wit", Style = "Wit bier", Brand = "Solas Hops & Grains", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 5.2 },
                new Beer { Name = "Grafters Small Batch Kölsch", Style = "Kölsch", Brand = "Grafters", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 5 },
                new Beer { Name = "Brown Bear Brown Ale", Style = "Brown Ale - English", Brand = "Brown Bear", Brewery = "Station Works Brewery", Container = Container.Bottle, Volume = 500 , ABV = 4.5 },
                new Beer { Name = "Grafters Pale Ale", Style = "Pale Ale - American", Brand = "Grafters", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 4.5 },
                new Beer { Name = "Solas Hops & Grains Session IPA", Style = "IPA - Session / India Session Ale", Brand = "Solas Hops & Grains", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 4.5 },
                new Beer { Name = "Francis' Big Bangin' IPA", Style = "IPA - American", Brand = "McGargles", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 7.1 },
                new Beer { Name = "Ned's Retro IPA", Style = "IPA - English", Brand = "McGargles", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 6.5 },
                new Beer { Name = "Boyne Brewhouse Irish Craft IPA", Style = "IPA - American", Brand = "Boyne Brewhouse", Brewery = "Boyne Brewhouse", Container = Container.Bottle, Volume = 500 , ABV = 6.8 },
                new Beer { Name = "O'Hara's Leann Folláin", Style = "Stout - Irish Dry", Brand = "O'Hara's", Brewery = "O'Hara's Brewery (Carlow Brewing Company)", Container = Container.Bottle, Volume = 500 , ABV = 6 },
                new Beer { Name = "Solas Hops & Grains Brown Porter", Style = "Porter", Brand = "Solas Hops & Grains", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 4.5 },
                new Beer { Name = "Boyne Brewhouse Saison", Style = "Saison / Farmhouse Ale", Brand = "Boyne Brewhouse", Brewery = "Boyne Brewhouse", Container = Container.Bottle, Volume = 500 , ABV = 5.5 },
                new Beer { Name = "Boyne Brewhouse Oatmeat Stout", Style = "Stout - Oatmeal", Brand = "Boyne Brewhouse", Brewery = "Boyne Brewhouse", Container = Container.Bottle, Volume = 500 , ABV = 6.2 },
                new Beer { Name = "Winter Star Spice Rye Pale Ale", Style = "Rye Beer", Brand = "O'Hara's", Brewery = "O'Hara's Brewery (Carlow Brewing Company)", Container = Container.Bottle, Volume = 500 , ABV = 5 },
                new Beer { Name = "Boyne Brewhouse Pale Ale", Style = "Pale Ale - International", Brand = "Boyne Brewhouse", Brewery = "Boyne Brewhouse", Container = Container.Bottle, Volume = 500 , ABV = 4.8 },
                new Beer { Name = "Boyne Brewhouse Lager", Style = "Lager - Dortmunder / Export", Brand = "Boyne Brewhouse", Brewery = "Boyne Brewhouse", Container = Container.Bottle, Volume = 500 , ABV = 4.8 },
                new Beer { Name = "Boyne Brewhouse Amber Ale", Style = "Red Ale - American Amber / Red", Brand = "Boyne Brewhouse", Brewery = "Boyne Brewhouse", Container = Container.Bottle, Volume = 500 , ABV = 4.8 },
                new Beer { Name = "Rosie's Pale Ale", Style = "Pale Ale - American", Brand = "McGargles", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 4.5 },
                new Beer { Name = "O'Hara's Irish Pale Ale", Style = "IPA - International", Brand = "O'Hara's", Brewery = "O'Hara's Brewery (Carlow Brewing Company)", Container = Container.Bottle, Volume = 500 , ABV = 4.3 },
                new Beer { Name = "O'Hara's Irish Red", Style = "Red Ale - Irish", Brand = "O'Hara's", Brewery = "O'Hara's Brewery (Carlow Brewing Company)", Container = Container.Bottle, Volume = 500 , ABV = 4.3 },
                new Beer { Name = "Fancy Frank's Lager", Style = "Lager - Helles", Brand = "McGargles", Brewery = "Rye River Brewing Company", Container = Container.Bottle, Volume = 500 , ABV = 4.5 },
                new Beer { Name = "O'Hara's 'Opsession IPA", Style = "IPA - Session / India Session Ale", Brand = "O'Hara's", Brewery = "O'Hara's Brewery (Carlow Brewing Company)", Container = Container.Bottle, Volume = 500 , ABV = 4 },
                new Beer { Name = "Boyne Brewhouse Vienna Lager", Style = "Lager - Vienna", Brand = "Boyne Brewhouse", Brewery = "Boyne Brewhouse", Container = Container.Can, Volume = 330 , ABV = 5 },
                new Beer { Name = "Boyne Brewhouse American Pale Ale", Style = "Pale Ale - American", Brand = "Boyne Brewhouse", Brewery = "Boyne Brewhouse", Container = Container.Can, Volume = 330 , ABV = 4.5 },
                new Beer { Name = "Ironmonger", Style = "IPA - English", Brand = "Metalman Brewing", Brewery = "Metalman Brewing", Container = Container.Can, Volume = 330 , ABV = 6.5 },
                new Beer { Name = "Boyne Brewhouse Session IPA", Style = "IPA - Session / India Session Ale", Brand = "Boyne Brewhouse", Brewery = "Boyne Brewhouse", Container = Container.Can, Volume = 330 , ABV = 4 }
            };

            beers.ForEach(b => context.Beers.Add(b));
            context.SaveChanges();

            var shops = new List<Shop>
            {
                new Shop { ShopName = "Lidl", ShopAddress = "1 Moore St" },
                new Shop { ShopName = "Dunnes", ShopAddress = "62 Grafton Street" },
                new Shop { ShopName = "Tesco", ShopAddress = "Jervis St" },
                new Shop { ShopName = "Centra", ShopAddress = "35 Abbey Street Lower" }
            };

            shops.ForEach(b => context.Shops.Add(b));
            context.SaveChanges();

            var stocks = new List<Stock>
            {
                new Stock{ ShopID = 1, BeerID = 9, Price = 1.89 }
            };

            stocks.ForEach(b => context.Stocks.Add(b));
            context.SaveChanges();
        }
    }
}
