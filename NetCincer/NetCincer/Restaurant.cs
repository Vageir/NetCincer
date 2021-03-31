using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;

namespace NetCincer
{
    [FirestoreData]
    public class Restaurant
    {
        public String RestaurantID { get; set; }
        [FirestoreProperty]
        public String RestaurantName { get; set; }
        [FirestoreProperty]
        public String OpenTime { get; set; }
        [FirestoreProperty]
        public String CloseTime { get; set; }
        [FirestoreProperty]
        public int DeliveryTime { get; set; }
        [FirestoreProperty]
        public String Password { get; set; }
        [FirestoreProperty]
        public Location Address { get ; set ; }
        [FirestoreProperty]
        public List<Food> Foods { get; set; }
        [FirestoreProperty]
        public List<String> MenuCategories { get; set; }
        public Restaurant()
        {
            Foods = new List<Food>();
            MenuCategories = new List<String>();
        }
    }
}