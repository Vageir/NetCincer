﻿using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace NetCincer
{
    class FireBaseService
    {
        private FirestoreDb Root;
        public FireBaseService()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"netcincer.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            Root = FirestoreDb.Create("netcincer-2777a");
        }
        
        public async Task<Restaurant> GetRestaurant(String RestaurantID)
        {
            DocumentSnapshot documentRestaurantSnapshot = await Root.Collection("restaurants").Document(RestaurantID).GetSnapshotAsync();
            Restaurant restaurant = documentRestaurantSnapshot.ConvertTo<Restaurant>();
            if (restaurant != null)
            {
                restaurant.RestaurantID = documentRestaurantSnapshot.Id;
                return restaurant;
            }
            else
            {
                return null;
            }
        }
        public async Task<Customer> GetCustomer(String CustomerID)
        {
            Customer customerx = new Customer();
            try
            {
                DocumentSnapshot documentCustomerSnapshot = await Root.Collection("customers").Document(CustomerID).GetSnapshotAsync();
                if (documentCustomerSnapshot != null)
                {
                    customerx = documentCustomerSnapshot.ConvertTo<Customer>();
                    if (customerx != null)
                    {
                        customerx.CustomerID = documentCustomerSnapshot.Id;
                        return customerx;
                    } else
                    {
                        return null;
                    }
                    
                }
            } catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return null;
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
        public async Task<WriteResult> AddMenuCategory(String RestaurantID, String MenuCategory)
        {

            WriteResult writeResult = await Root.Collection("restaurants").Document(RestaurantID).UpdateAsync("MenuCategories", FieldValue.ArrayUnion(MenuCategory));
            return writeResult;
        }
        public async Task<WriteResult> AddCourier(Courier courier)
        {
            WriteResult writeResult = await Root.Collection("couriers").Document(courier.CourierID).SetAsync(courier);
            return writeResult;
        }
        public async Task<Courier> GetCourier(String CourierID)
        {
            DocumentSnapshot documentRestaurantSnapshot = await Root.Collection("couriers").Document(CourierID).GetSnapshotAsync();
            return documentRestaurantSnapshot.ConvertTo<Courier>();
        }
        public async Task<List<Courier>> ListCouriers()
        {
            QuerySnapshot querySnapshot = await Root.Collection("couriers").GetSnapshotAsync();
            List<Courier> couriers = new List<Courier>();
            foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
            {
                Courier courier = documentSnapshot.ConvertTo<Courier>();
                courier.CourierID = documentSnapshot.Id;
                couriers.Add(courier);
            }
            return couriers;
        }
        public async Task<WriteResult> AddOrder(Order order)
        {
            WriteResult writeResult = await Root.Collection("pendingOrders").Document(order.OrderID).SetAsync(order);
            return writeResult;
        }
    }
}