using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FireBase
{
    class FireBaseService
    {
        private FirestoreDb Root = FirestoreDb.Create("netcincer-2777a");
        public async Task<Restaurant> GetRestaurant(String RestaurantID)
        {
            DocumentSnapshot documentRestaurantSnapshot = await Root.Collection("restaurants").Document(RestaurantID).GetSnapshotAsync();
            return documentRestaurantSnapshot.ConvertTo<Restaurant>();
        }
        public async Task<Customer> GetCustomer(String CustomerID)
        {
            DocumentSnapshot documentRestaurantSnapshot = await Root.Collection("customers").Document(CustomerID).GetSnapshotAsync();
            return documentRestaurantSnapshot.ConvertTo<Customer>();
        }
        public async Task<WriteResult> AddCustomer(Customer customer)
        {
            WriteResult writeResult = await Root.Collection("customers").Document(customer.CustomerID).SetAsync(customer);
            return writeResult;
        }
        public async Task<WriteResult> AddRestaurant(Restaurant restaurant)
        {
            WriteResult writeResult = await  Root.Collection("restaurants").Document(restaurant.RestaurantID).SetAsync(restaurant);
            return writeResult;
        }
        public async Task<List<Restaurant>> ListRestaurants()
        {
            QuerySnapshot querySnapshot = await Root.Collection("restaurants").GetSnapshotAsync();
            List<Restaurant> restaurants = new List<Restaurant>();
            foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
            {
                Restaurant restaurant = documentSnapshot.ConvertTo<Restaurant>();
                restaurant.RestaurantID = documentSnapshot.Id;
                restaurants.Add(restaurant);
            }
            return restaurants;
        }
        public async Task<List<Food>> ListFoods(String RestaurantID)
        {
            DocumentSnapshot documentSnapshot = await Root.Collection("restaurants").Document(RestaurantID).GetSnapshotAsync();
            List<Food> foods;
            Restaurant restaurant = documentSnapshot.ConvertTo<Restaurant>();
            foods = restaurant.Foods;
            return foods;
        }
        public async Task<List<String>> ListMenuCategories(String RestaurantID)
        {
            DocumentSnapshot documentSnapshot = await Root.Collection("restaurants").Document(RestaurantID).GetSnapshotAsync();
            List<String> menuCategories;
            Restaurant restaurant = documentSnapshot.ConvertTo<Restaurant>();
            menuCategories = restaurant.MenuCategories;
            return menuCategories;
        }
        public async Task<WriteResult> AddMenuCategories(String RestaurantID, List<String> MenuCategories)
        {
            foreach (String item in MenuCategories)
            {
                 await AddMenuCategory(RestaurantID, item);
            }
            return null;
        }
        public async Task<WriteResult> AddFoods(String RestaurantID,Food food)
        {
            WriteResult writeResult = await Root.Collection("restaurants").Document(RestaurantID).UpdateAsync("Foods",FieldValue.ArrayUnion(food));
            return writeResult;
        }
        public async Task<WriteResult> RemoveFoods(String RestaurantID, Food food)
        {
            WriteResult writeResult = await Root.Collection("restaurants").Document(RestaurantID).UpdateAsync("Foods", FieldValue.ArrayRemove(food));
            return writeResult;
        }
        public async Task<WriteResult> RemoveMenuCategory(String RestaurantID, String MenuCategory)
        {
            WriteResult writeResult = await Root.Collection("restaurants").Document(RestaurantID).UpdateAsync("MenuCategories", FieldValue.ArrayRemove(MenuCategory));
            return writeResult;
        }
        private async Task<WriteResult> AddMenuCategory(String RestaurantID, String MenuCategory)
        {

            WriteResult writeResult = await Root.Collection("restaurants").Document(RestaurantID).UpdateAsync("MenuCategories", FieldValue.ArrayUnion(MenuCategory));
            return writeResult;
        }
    }
}
