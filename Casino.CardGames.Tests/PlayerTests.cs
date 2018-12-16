using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Casino.Games.Common;

namespace Casino.CardGames.Tests
{
    /// <summary>
    /// Contains test methods for verifying various functionality of the Player class
    /// </summary>
    [TestClass]
    public class PlayerTests
    {
        #region Constructors

        public PlayerTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #endregion

        #region Fields

        private TestContext testContextInstance;

        #endregion

        #region Properties

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #endregion

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        #region Test Methods

        [TestMethod]
        public void BalanceTest()
        {
            double balance;
            PlayerPurse hand = new PlayerPurse(5, 1000, 3, 500, 10, 100, 10, 50, 25, 25);
            Player player1 = new Player();
            Player player2 = new Player(hand);

            balance = player1.Balance;
            Assert.AreEqual(0, balance);

            balance = player2.Balance;
            Assert.AreEqual(8625, balance);
        }

        #endregion
    }
}
