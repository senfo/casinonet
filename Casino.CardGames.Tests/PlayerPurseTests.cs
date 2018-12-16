using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Casino.Games.Common;

namespace Casino.CardGames.Tests
{
    /// <summary>
    /// Contains test methods for verifying various functionality of the PlayerPurse
    /// </summary>
    [TestClass]
    public class PlayerPurseTests
    {
        #region Constructors

        public PlayerPurseTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #endregion

        #region Fields

        private TestContext testContextInstance;

        #endregion

        #region Public Methods

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

        /// <summary>
        /// Tests that the value of the hand is properly calculated
        /// </summary>
        [TestMethod]
        public void GetValueOfChips()
        {
            double balance = 0;
            PlayerPurse playerPurse1 = new PlayerPurse();
            PlayerPurse playerPurse2 = new PlayerPurse(5, 1000, 3, 500, 10, 100, 10, 50, 25, 25);

            balance = playerPurse1.ValueOfChips;
            Assert.AreEqual(0, balance);

            balance = playerPurse2.ValueOfChips;
            Assert.AreEqual(8625, balance);
        }

        #endregion
    }
}
