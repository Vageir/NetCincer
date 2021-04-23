using System;
using System.Collections.Generic;
using System.Text;

namespace NetCincer
{
    public class Cart
    {
        public bool TakeAway { get; set; }
        private Dictionary<Food, int> Foods;

        public void AddFood(Food food, int quantity)
        {
            Foods.Add(food, quantity);
        }
        public void RemoveFood(Food food)
        {
            Foods.Remove(food);
        }
        public void IncreaseQuantity(Food food, int quantity)
        {
            Foods[food] += quantity;
        }
        public int TotalPrice()
        {
            int total = 0;
            foreach (var item in SubTotalPrices())
            {
                total += item.Value;
            }
            return total;
        }
        public Dictionary<String, int> SubTotalPrices()
        {
            Dictionary<String, int> subTotals = new Dictionary<String, int>();
            foreach (var item in Foods)
            {
                subTotals.Add(item.Key.FoodID, item.Key.Price* item.Value);
            }
            return subTotals;
        }
        public List<Food> ListAllFoods()
        {
            List<Food> foods = new List<Food>();
            foreach (var item in Foods)
            {
                foods.Add(item.Key);
            }
            return foods;
        }
        public void EmptyCart()
        {
            Foods = null;
        }
        public Cart()
        {
            Foods = new Dictionary<Food, int>();
        }
    }
}
