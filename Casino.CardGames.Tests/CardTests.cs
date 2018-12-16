using Casino.Games.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Casino.CardGames.Tests
{
    /// <summary>
    /// Contains test methods for verifying various functionality of the Card class
    /// </summary>
    [TestClass]
    public class CardTests
    {
        #region Constructors

        public CardTests()
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

        /// <summary>
        /// Verifies the CompareTo method on the Card object
        /// </summary>
        [TestMethod]
        public void CompareTo()
        {
            Card lowCard = new Card
            {
                CardSuit = Suit.Spade,
                CardValue = CardValue.Two
            };
            Card highCard = new Card
            {
                CardSuit = Suit.Spade,
                CardValue = CardValue.Three
            };

            Assert.AreEqual(-1, lowCard.CompareTo(highCard));
            Assert.AreEqual(1, highCard.CompareTo(lowCard));
            Assert.AreEqual(0, lowCard.CompareTo(lowCard));
        }

        /// <summary>
        /// Verifies the Equal method on the Card object
        /// </summary>
        [TestMethod]
        public void Equal()
        {
            Card card1 = new Card
            {
                CardSuit = Suit.Spade,
                CardValue = CardValue.Three
            };
            Card card2 = new Card
            {
                CardSuit = Suit.Spade,
                CardValue = CardValue.Three
            };
            Card unequalCard1 = new Card
            {
                CardSuit = Suit.Spade,
                CardValue = CardValue.Two
            };
            Card unequalCard2 = new Card
            {
                CardSuit = Suit.Club,
                CardValue = CardValue.Three
            };

            Assert.IsTrue(card1.Equals(card2));
            Assert.IsTrue(!card1.Equals(unequalCard1));
            Assert.IsTrue(!card1.Equals(unequalCard2));
        }

        /// <summary>
        /// Verifies the Equality operator on the Card object
        /// </summary>
        [TestMethod]
        public void Equalality()
        {
            Card card1 = new Card
            {
                CardSuit = Suit.Spade,
                CardValue = CardValue.Three
            };
            Card card2 = new Card
            {
                CardSuit = Suit.Spade,
                CardValue = CardValue.Three
            };
            Card unequalCard1 = new Card
            {
                CardSuit = Suit.Spade,
                CardValue = CardValue.Two
            };
            Card unequalCard2 = new Card
            {
                CardSuit = Suit.Club,
                CardValue = CardValue.Three
            };

            Assert.AreEqual<Card>(card1, card2);
            Assert.AreNotEqual<Card>(card1, unequalCard1);
            Assert.AreNotEqual<Card>(card1, unequalCard2);
        }

        /// <summary>
        /// Verifies the not equal operator on the Card object
        /// </summary>
        [TestMethod]
        public void NotEqual()
        {
            Card card1 = new Card
            {
                CardSuit = Suit.Spade,
                CardValue = CardValue.Three
            };
            Card unequalCard1 = new Card
            {
                CardSuit = Suit.Spade,
                CardValue = CardValue.Two
            };
            Card unequalCard2 = new Card
            {
                CardSuit = Suit.Club,
                CardValue = CardValue.Three
            };

            Assert.AreNotEqual<Card>(card1, unequalCard1);
            Assert.AreNotEqual<Card>(card1, unequalCard2);
        }

        /// <summary>
        /// Verifies the greater than operator on the Card object
        /// </summary>
        [TestMethod]
        public void GreaterThan()
        {
            Card card1 = new Card
            {
                CardSuit = Suit.Club,
                CardValue = CardValue.Three
            };
            Card card2 = new Card
            {
                CardSuit = Suit.Club,
                CardValue = CardValue.Two
            };

            Assert.IsTrue(card1 > card2);
        }

        /// <summary>
        /// Verifies the less than operator on the Card object
        /// </summary>
        [TestMethod]
        public void LessThan()
        {
            Card card1 = new Card
            {
                CardSuit = Suit.Club,
                CardValue = CardValue.Two
            };
            Card card2 = new Card
            {
                CardSuit = Suit.Club,
                CardValue = CardValue.Three
            };

            Assert.IsTrue(card1 < card2);
        }

        /// <summary>
        /// Verifies the greater than or equal operator on the Card object
        /// </summary>
        [TestMethod]
        public void GreaterThanOrEqual()
        {
            Card card1 = new Card
            {
                CardValue = CardValue.Three,
                CardSuit = Suit.Club
            };
            Card card2 = new Card
            {
                CardValue = CardValue.Three,
                CardSuit = Suit.Diamond
            };
            Card card3 = new Card
            {
                CardValue = CardValue.Two,
                CardSuit = Suit.Diamond
            };

            Assert.IsTrue(card1 >= card2);
            Assert.IsTrue(card1 >= card3);
            Assert.IsTrue(!(card3 >= card1));
        }

        /// <summary>
        /// Verifies the less than or equal operator on the Card object
        /// </summary>
        [TestMethod]
        public void LessThanOrEqual()
        {
            Card card1 = new Card
            {
                CardValue = CardValue.Two,
                CardSuit = Suit.Club
            };
            Card card2 = new Card
            {
                CardValue = CardValue.Two,
                CardSuit = Suit.Diamond
            };
            Card card3 = new Card
            {
                CardValue = CardValue.Three,
                CardSuit = Suit.Diamond
            };

            Assert.IsTrue(card1 <= card2);
            Assert.IsTrue(card1 <= card3);
            Assert.IsTrue(!(card3 <= card1));
        }

        #endregion
    }
}
