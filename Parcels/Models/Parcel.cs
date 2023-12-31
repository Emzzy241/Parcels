using System;

namespace Parcels.Models
{
    public class Parcel
    {
        public string Dimension { get; set; }

        
        
        
        public Parcel(string myDimesion)
        {
            Dimension = myDimesion;
        }
    }
}