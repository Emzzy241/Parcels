using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcels.Models;  
using System;
using System.Collections.Generic;

namespace Parcels.Tests.ModelTests  // Correct namespace
{
    [TestClass]
    public class MyParcelTests : IDisposable
    {

        // Making sure to clear my list of parcels before moving on to a new test
        public void Dispose()
        {
            Parcel.RemoveAllParcels();
        }
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

        // 5th Test: Test to set the weight of a parcel
        [TestMethod]
        public void SetWeight_SetsValueOfParcelWeight_Void()
        {
            // Arrange
            Parcel newParcel = new Parcel("20 * 30 * 40", 60);
            int parcelsNewWeightValue = 60;

            // Act 
            int parcelsCurrentWeightValue = newParcel.Weight;
            newParcel.Weight = parcelsNewWeightValue;

            // Assert
            Assert.AreEqual(parcelsNewWeightValue, newParcel.Weight);
        }
        

        // 6th Test: Test to get all parcels from list of parcels
        [TestMethod]
        public void GetAllParcel_ReturnsParcel_Parcel()
        {
            // Arrange
            Parcel newParcel1 = new Parcel("20 * 30 * 40", 60);
            Parcel newParcel2 = new Parcel("20 * 40 * 20", 45);
            Parcel newParcel3 = new Parcel("20 * 90 * 30", 600);
            List<Parcel> expectedparcelsList = new List<Parcel>(){newParcel1, newParcel2, newParcel3};
            
            // Act
            List<Parcel> returnedParcelsList = Parcel.GetAllParcels();


            // Assert
            CollectionAssert.AreEqual(expectedparcelsList, returnedParcelsList);

        }

        // 7th Test: Test for Finding a parcel Id to each Parcel
        [TestMethod]
        public void GetParcelsId_ReturnsParcelsIdNumber_Int()
        {
            // Arrange
            Parcel newParcel1 = new Parcel("20 * 30 * 40", 60);
            Parcel newParcel2 = new Parcel("20 * 40 * 20", 45);
            Parcel newParcel3 = new Parcel("20 * 90 * 30", 600);
            // Act
            Parcel returnedParcelId = Parcel.FindParcel(2);

            // Assert
            Assert.AreEqual(newParcel2, returnedParcelId);
        }

        // 8th Test: Test Method to get the 3 sides of my parcels
        [TestMethod]
        public void GetEachSide_ReturnsDimensionsOfParcel_Int()
        {
            // Arrange
            Parcel newParcel = new Parcel("20 * 30 * 40", 60);
            int expectedLengthVal = 20;
            int expectedWidthVal = 30;
            int expectedHeightVal = 40;

            // Act
            var dimensions = newParcel.GetEachSide(newParcel.Dimension);

            // Assert
            Assert.AreEqual(expectedLengthVal, dimensions.Length);
            Assert.AreEqual(expectedWidthVal, dimensions.Width);
            Assert.AreEqual(expectedHeightVal, dimensions.Height);
        }

        // 9th Test: Test Method Volume() that is called on Dimension
        [TestMethod]
        public void Volume_CalculatesVolumeOfParcel_Int()
        {
            // Arrange
            Parcel newParcel = new Parcel("20 * 30 * 40", 60);
            int expectedVolumeValue = 24000;

            // Act
            var dimensions = newParcel.GetEachSide(newParcel.Dimension);
            int returnedVolumeValue = newParcel.Volume(dimensions.Length, dimensions.Width, dimensions.Height);

            // Assert
            Assert.AreEqual(expectedVolumeValue, returnedVolumeValue);
        }

        // 10th Test: Test Method CostShip()
        [TestMethod]
        public void CostShip_CalculatesCostToShipAParcel_Int()
        {
            // Arrange
             Parcel newParcel = new Parcel("20 * 30 * 40", 60);
            int expectedCostToShipValue = 24700;
            int shippingCharges = 700;

            // Act
            var dimensions = newParcel.GetEachSide(newParcel.Dimension);
            int returnedCostToShipValue = newParcel.CostToShip(dimensions.Length, dimensions.Width, dimensions.Height, shippingCharges);

            // Assert
            Assert.AreEqual(expectedCostToShipValue, returnedCostToShipValue);
        }
        

    }    
}
