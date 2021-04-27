using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCincer
{
    [FirestoreData]
    public class Courier
    {
        
        public String CourierID { get; set; }
        public List<Order> Orders { get; set; }
        [FirestoreProperty]
        public List<String> Cities { get; set; }
        [FirestoreProperty]
        public String Name { get; set; }
        public Courier()
        {
            Cities = new List<String>();
        }
        [FirestoreProperty]
        public String Password { get; set; }
        [FirestoreProperty]
        public String PhoneNumber { get; set; }
        [FirestoreProperty]
        public bool available { get; set;}
    }
}
