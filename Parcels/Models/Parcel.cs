using System;
using System.Collections.Generic;

namespace Parcels.Models
{
    public class Parcel
    {
        public string Dimension { get; set; }

        public int Weight { get; set; }

        // Look closely, we set the value of our parcel's ID right in our constructor... This is because we determine this value by ourselves, we do not need the user's help here
        public int ParcelId { get; }

        private static List<Parcel> _parcelInstances = new List<Parcel>();

        public Parcel(string parcelsDimension, int parcelsWeight)
        {
            Dimension = parcelsDimension;
            Weight = parcelsWeight;
            _parcelInstances.Add(this);
            ParcelId = _parcelInstances.Count;
        }

        public static List<Parcel> GetAllParcels()
        {
            return _parcelInstances;
        }

        public static void RemoveAllParcels()
        {
            _parcelInstances.Clear();
        }

        public static Parcel FindParcel(int inputtedId)
        {
            return _parcelInstances[inputtedId - 1];
        }

        // A powerful method to get me the length value right from my dimension
        // In this example, the ParseDimensions method splits the input string using the asterisk (*) as the delimiter, trims any leading or trailing whitespace from each dimension, and attempts to parse each dimension as an integer. If successful, it sets the values of length, width, and height using the out parameters. If any parsing fails or if the array doesn't have exactly three elements, it throws a FormatException.
        // The return type of our method is: (int Length, int Width, int Height)  It specifies that the method will return a tuple of three integers with named components: Length, Width, and Height. This feature is part of C# 7.0 and later versions and is known as tuple deconstruction.
        // I am writing C# 10, so the tuple deconstruction works
        public (int Length, int Width, int Height) GetEachSide(string inputtedDimension)
        {
            try
            {
                // dimensionsString.Split('*'): This part of the code uses the Split method on the dimensionsString. The Split method takes a character (or an array of characters) as an argument and divides the original string into an array of substrings wherever that character appears.
                // '*': The asterisk is the delimiter here. It's the character at which the string is split.

                string[] dimensionsArray = inputtedDimension.Split("*");

                int length;
                int width;
                int height;

                if (dimensionsArray.Length == 3 &&
                    int.TryParse(dimensionsArray[0].Trim(), out length) &&
                    int.TryParse(dimensionsArray[1].Trim(), out width) &&
                    int.TryParse(dimensionsArray[2].Trim(), out height))
                {
                    // All Parsing succeeded
                    return (length, width, height);
                }
                else
                {
                    // Handle parsing failure (invalid format)
                    throw new FormatException("Invalid dimensions format");
                }
            }
            catch
            {
                // Handle parsing failure (invalid format)
                throw new FormatException("Invalid dimensions format");
            }
        }

        public int Volume(int lengthVal, int widthVal, int heightVal)
        {
            return lengthVal * widthVal * heightVal;
        } 

        // public int Volume(int lengthVal, int widthVal, int heightVal)
        // {
        //     return lengthVal * widthVal * heightVal;
        // } 


    }
}
