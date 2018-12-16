using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Casino.Games.Common;

namespace CardShuffler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DeckBase deck = new StandardDeck();

            deck.Initialize(true);
            this.dataGridView1.DataSource = deck.Cards;
        }
    }
}