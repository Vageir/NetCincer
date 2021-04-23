using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCincer
{
    [FirestoreData]
    public class Order
    {
        public String OrderID {get;set;}
        [FirestoreProperty]
        public Status Status { get; set; }
        [FirestoreProperty]
        public List<Food> Foods { get; set; }
        [FirestoreProperty]
        public Location Address { get; set; }
        [FirestoreProperty]
        public String CustomerID { get; set; }
        [FirestoreProperty]
        public String RestaurantID { get; set; }
        [FirestoreProperty]
        public String CourierID { get; set; }
        [FirestoreProperty]
        public bool TakeAway { get; set; }
       

    }
    public enum Status
    {
        Pending,
        Accepted,
        ReadyToDeliver,
        Delivery,
        Completed
    };
}
