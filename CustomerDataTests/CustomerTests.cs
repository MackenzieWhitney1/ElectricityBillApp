    /*
     * Defines customer related tests in that when adding a new customer the correct charge is made
     * Author: Mackenzie Whitney
     * Date: June 2024
     */
namespace UnitTests.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        public void CalculateChargeWithZerokWh()
        {
            // Arrange
            
            double expectedCharged = 12;
            double actualCharged;

            // Act

            Customer acct = new Customer("Test", "User");
            actualCharged = acct.BillAmount;
            // Assert

            Assert.AreEqual(expectedCharged, actualCharged);
        }

        [TestMethod()]
        public void CalculateChargeWithPositivekWh()
        {
            // Arrange

            double expectedCharged = 19;
            double actualCharged;

            // Act

            Customer acct = new Customer("Test", "User", 100);
            actualCharged = acct.BillAmount;
            // Assert

            Assert.AreEqual(expectedCharged, actualCharged);
        }

        [TestMethod()]
        public void CalculateChargeWithNegativekWh()
        {
            // Arrange

            double expectedCharged = 12;
            double actualCharged;

            // Act

            Customer acct = new Customer("Test", "User", -100);
            actualCharged = acct.BillAmount;
            // Assert

            Assert.AreEqual(expectedCharged, actualCharged);
        }
    }
}