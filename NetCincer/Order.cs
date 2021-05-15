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
        [FirestoreProperty]
        public int EstimatedDeliveryTime { get; set; }
        [FirestoreProperty]
        public String OrderDate { get; set; }
        public Order()
        {
            EstimatedDeliveryTime = -1;
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
                subTotals.Add(item.FoodID, item.Price * item.Quantity);
            }
            return subTotals;
        }

    }
    public enum Status
    {
       
        Pending,
        Accepted,
        ReadyToDeliver,
        Delivery,
        Completed,
        Refused
    };
}
