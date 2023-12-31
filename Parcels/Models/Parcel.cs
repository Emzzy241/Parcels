using System;
using System.Collections.Generic;

namespace Parcels.Models
{
    public class Parcel
    {
        public string Dimension { get; set; }

        public int Weight { get; set; }
        
        // private static List<object> _parcelInstances = new List<object>();
        
        
        public Parcel(string parcelsDimesion, int parcelsWeight)
        {
            Dimension = parcelsDimesion;
            Weight = parcelsWeight;
            _parcelInstances.Add(this);
        }

        // public static Parcel GetParcel(Parcel myParcel)
        // {
        //     return myParcel;
        // }
    }
}