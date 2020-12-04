using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PG_Coding_Challenge;

namespace PG_Test_Cases
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void TestCalculateAge()
        {
            // Arrange
            Customer c = new Customer();
            
            double expected = 220;

            // Act
            c.Age = 50;
            c.CalculateAge();
            double actual = c.Cost;

            // Assert
            Assert.AreEqual(expected, actual, "CalculateAge passed.");
        }
        [TestMethod]
        public void TestCalculateCovg()
        {
            // Arrange
            Customer c = new Customer();

            double expected = 145;

            // Act
            c.CovgAmount = 1250000;
            c.CalculateCovg();
            double actual = c.Cost;

            // Assert
            Assert.AreEqual(expected, actual, "CalculateCovg passed.");
        }
        [TestMethod]
        public void TestCalculateCondition()
        {
            // Arrange
            Customer c = new Customer();

            double expected = 101;

            // Act
            c.Condition = "allergies";
            c.CalculateCondition();
            double actual = c.Cost;

            // Assert
            Assert.AreEqual(expected, actual, "CalculateCondition passed.");
        }
        [TestMethod]
        public void TestCalculateEstimate()
        {
            // Arrange
            Customer c = new Customer();

            double expected = 310.19;

            // Act
            c.Age = 50;
            c.Gender = "female";
            c.Condition = "allergies";
            c.CovgAmount = 1250000;

            double actual = c.CalculateEstimate();

            // Assert
            Assert.AreEqual(expected, actual, "CalculateEstimate passed.");
        }
    }
}
