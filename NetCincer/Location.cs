using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCincer
{
    [FirestoreData]
    public class Location
    {
        [FirestoreProperty]
        public String City { get; set; }
        [FirestoreProperty]
        public String Street { get; set; }
        [FirestoreProperty]
        public int HouseNumber { get; set; }

        public override string ToString()
        {
            return City+" "+ Street + " "+HouseNumber;
        }
    }
}
