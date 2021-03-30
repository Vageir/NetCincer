using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCincer
{
    [FirestoreData]
    public class Customer
    {
        public String CustomerID { get; set; }
        [FirestoreProperty]
        public String Name {  get; set; }
        [FirestoreProperty]
        public String PhoneNumber { get; set; }
        [FirestoreProperty]
        public String Password { get; set; }
        [FirestoreProperty]
        public Location Address { get; set; }
    }
}
