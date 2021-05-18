using Google.Cloud.Firestore;
using System;

namespace NetCincer
{
    [FirestoreData]
    public class Food
    {
        public Food() { }
        public Food(string foodID)
        {
            FoodID = foodID;
        }

        [FirestoreProperty]
        public String FoodID { get; set; }
        [FirestoreProperty]
        public String Category { get; set; }
        [FirestoreProperty]
        public int Price { get; set; }
        [FirestoreProperty]
        public String Name { get; set; }
        [FirestoreProperty]
        public String Allergens { get; set; }
        [FirestoreProperty]
        public String Description { get; set; }
        [FirestoreProperty]
        public String StartPeriod { get; set; }
        [FirestoreProperty]
        public String EndPeriod { get; set; }
        [FirestoreProperty]
        public int Quantity { get; set; }
        [FirestoreProperty]
        public int Discount { get; set; }
       
    }
}