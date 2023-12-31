using System;

namespace Parcels.Models
{
    public class Parcel
    {
        public string Dimension { get; set; }

        public int Weight { get; }
        
        
        
        
        public Parcel(string parcelsDimesion, int parcelsWeight)
        {
            Dimension = parcelsDimesion;
            Weight = parcelsWeight;
        }
    }
}