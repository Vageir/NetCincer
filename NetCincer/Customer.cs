﻿using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCincer
{
    [FirestoreData]
    public class Customer
    {
        public String CustomerID { get; set; }
        public Cart Cart { get; }
        public Order CurrentOrder { get; set; }
        [FirestoreProperty]
        public String Name { get; set; }
        [FirestoreProperty]
        public String PhoneNumber { get; set; }
        [FirestoreProperty]
        public String Password { get; set; }
        [FirestoreProperty]
        public Location Address { get; set; }
        public Customer()
        {
            Cart = new Cart();
        }
        public void MakeOrder(String resturantID)
        {
            Order order = new Order
            {
                Address = Address,
                CustomerID = CustomerID,
                RestaurantID = resturantID,
                CourierID = null,
                TakeAway = Cart.TakeAway,
                Foods = Cart.ListAllFoods(),
                Status = Status.Pending
            };
            order.OrderID = Guid.NewGuid().ToString();
            CurrentOrder = order;
        }
    }
}