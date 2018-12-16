using System;
using System.Collections.ObjectModel;
using System.Linq;
using Casino.Games.CardGames.Poker;
using Casino.Games.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Casino.CardGames.Tests
{
    /// <summary>
    /// Contains test methods for verifying various poker hand functionality
    /// </summary>
    [TestClass]
    public class PokerHandTests
    {
        #region Constructors

        public PokerHandTests()
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
        /// Verifies that the specified number of cards is dealt
        /// </summary>
        [TestMethod]
        public void DealSpecifiedNumberOfCards()
        {
            Random rand = new Random();
            int numCards = rand.Next(1, 52);
            DeckBase deck = new StandardDeck();
            Card[] cards;

            // Initialize the deck
            deck.Initialize(true);
            cards = deck.DealHand(numCards).ToArray();

            Assert.AreEqual(numCards, cards.Length);
        }

        /// <summary>
        /// Verifies that it is not possible to deal more cards than are available
        /// </summary>
        [TestMethod]
        public void OverDealCards()
        {
            bool failed = false;
            DeckBase deck = new StandardDeck();
            Card[] cards;

            // Initialize the deck
            deck.Initialize(true);

            try
            {
                cards = deck.DealHand(53).ToArray();
            }
            catch(InvalidOperationException)
            {
                failed = true;
            }

            Assert.IsTrue(failed);
        }

        /// <summary>
        /// Verifies the logic for High Cards
        /// </summary>
        [TestMethod]
        public void HighCard()
        {
            Collection<Card> cardsInHand;
            Collection<Card> cards = new Collection<Card>();

            cards.Add(
                new Card
                {
                    CardSuit = Suit.Club,
                    CardValue = CardValue.Ace
                });
            cards.Add(
                new Card
                {
                    CardSuit = Suit.Club,
                    CardValue = CardValue.Two
                });
            cards.Add(
                new Card
                {
                    CardSuit = Suit.Heart,
                    CardValue = CardValue.Six
                });
            cards.Add(
                new Card
                {
                    CardSuit = Suit.Diamond,
                    CardValue = CardValue.Eight
                });
            cards.Add(
                new Card
                {
                    CardSuit = Suit.Spade,
                    CardValue = CardValue.Ten
                });

            PokerHand hand = PokerUtility.DetermineHand(cards, out cardsInHand);

            Assert.AreEqual<PokerHand>(PokerHand.HighCards, hand);
            //Assert.AreEqual<Suit>(highCard.CardSuit, highCard.CardSuit);
        }

        #endregion
    }
}
