using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcels.Models;  

namespace Parcels.Tests.ModelTests  // Correct namespace
{
    [TestClass]
    public class MyParcelTests
    {
        // First Test: Test for creating instance of Parcel
        [TestMethod]
        public void ParcelsConstructor_CreatesInstanceOfParcels_Parcels()
        {
            Parcel newParcel = new Parcel("50 * 30 * 20", 60);

            Assert.AreEqual(typeof(Parcel), newParcel.GetType());
        }

        // 2nd Test: Test to get dimenson of a parcel
        [TestMethod]
        public void GetDimesnsion_ReturnsTheParcelsDimension_String()
        {
            // Arrange
            Parcel newParcel = new Parcel("50 * 30 * 20", 60);
            string expectedDimension = "50 * 30 * 20";

            // Act
            string returnedDimension = newParcel.Dimension;

            // Assert
            Assert.AreEqual(expectedDimension, returnedDimension);
        }

        // 3rd Test: Test to set the dimension of a parcel
        [TestMethod]
        public void SetDimension_SetsValueOfParcelDimension_Void()
        {
            // Arrange
            Parcel newParcel = new Parcel("20 * 30 * 40", 60);
            string parcelsNewValue = "30 * 40 * 20";

            // Act 
            string parcelsCurrentValue = newParcel.Dimension;
            newParcel.Dimension = parcelsNewValue;

            // Assert
            Assert.AreEqual(parcelsNewValue, newParcel.Dimension);

        }

        // 4th Test: Test to get weight value of Parcel
        [TestMethod]
        public void GetWeight_ReturnsWeightValue_Int()
        {
            // Arrange
            Parcel newParcel = new Parcel("20 * 30 * 40", 40);
            int expectedWeight = 40;

            // Act
            int returnedWeight = newParcel.Weight;

            // Assert
            Assert.AreEqual(expectedWeight, returnedWeight);
            
        }


    }    
}
