using Google.Cloud.Firestore;
using System;

namespace NetCincer
{
    [FirestoreData]
    public class Food
    {
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
    }
}