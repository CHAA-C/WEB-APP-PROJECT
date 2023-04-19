﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using WEB_APP_PROJECT.Data;
using WEB_APP_PROJECT.Models;

namespace WEB_APP_PROJECT.Repositpries
{
    public class HomeRepository
    {
        private readonly ApplicationDbContext _db;
        public HomeRepository(ApplicationDbContext db) { 
            _db = db;
        }
        public async Task<IEnumerable<FC>> DisplayFoodCourts(string sTerm="", int categoryId = 0)
        {
            var foods = (from food in _db.FoodCourts
                         select new FC
                         {
                             Id = food.Id,
                             FoodShopImg = food.FoodShopImg,
                             ShopContact = food.ShopContact,
                             FoodRecommened = food.FoodRecommened,
                             FoodShopName = food.FoodShopName

                         }
                         ).ToListAsync();
        }
    }
}
