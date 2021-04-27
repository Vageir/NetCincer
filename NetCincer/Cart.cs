using System;
using System.Collections.Generic;
using System.Text;

namespace NetCincer
{
    public class Cart
    {
        public bool TakeAway { get; set; }
        private List<Food> Foods;

        public void AddFood(Food food, int quantity)
        {
            food.Quantity = quantity;
            Foods.Add(food);
        }
        public void RemoveFood(Food food)
        {
            Foods.Remove(food);
        }
        public void IncreaseQuantity(Food food)
        {
            foreach(var item in Foods)
            {
                if(item.Name == food.Name)
                {
                    item.Quantity++;
                }
            }
            
        }
        public void SetQuantity(Food food, int quantity)
        {
            foreach (var item in Foods)
            {
                if (item.Name == food.Name)
                {
                    item.Quantity = quantity;
                }
            }
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
                subTotals.Add(item.FoodID, item.Price*item.Quantity);
            }
            return subTotals;
        }
        public List<Food> GetFoods()
        {
            return Foods;
        }
        public List<Food> ListAllFoods()
        {
            List<Food> foods = new List<Food>();
            foreach (var item in Foods)
            {
                foods.Add(item);
            }
            return foods;
        }
        public Food GetFood(String foodID)
        {
            foreach(var item in ListAllFoods())
            {
                if (item.FoodID.Equals(foodID))
                    return item;
            }
            return null;
        }
        public void EmptyCart()
        {
            Foods = new List<Food>();
        }
        public Cart()
        {
            Foods = new List<Food>();
        }

        public void RemoveFood(String foodID)
        {
            foreach(var item in ListAllFoods()) {
                if (item.FoodID.Equals(foodID))
                {
                    Foods.Remove(item);
                    return;
                }
            }
            
        }
    }
}
