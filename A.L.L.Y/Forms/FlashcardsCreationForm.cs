using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A.L.L.Y.Forms
{
    public partial class FlashcardsCreationForm : Form
    {
        private Deck _currentDeck;

        public FlashcardsCreationForm() 
        {
            InitializeComponent();
        }
        public FlashcardsCreationForm(Deck deck)
        {
            InitializeComponent();

            _currentDeck = deck;

            this.Text = $"Manage Cards for: {_currentDeck.Title}";
            Label lblDeckNameControl = Controls.Find("lblDeckName", true).FirstOrDefault() as Label;
            if (lblDeckNameControl != null)
            {
                lblDeckNameControl.Text = $"Deck: {_currentDeck.Title}";
            }
            UpdateCardDisplay();
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            string front = txtQuestion.Text.Trim();
            string back = txtAnswer.Text.Trim();

            if (string.IsNullOrWhiteSpace(front) || string.IsNullOrWhiteSpace(back))
            {
                MessageBox.Show("Please enter both front and back text for the card.");
                return;
            }

            Card newCard = new Card(front, back);
            _currentDeck.Cards.Add(newCard);

            UpdateCardDisplay();
            txtQuestion.Clear();
            txtAnswer.Clear();
        }

        private void UpdateCardDisplay()
        {
            ListView cardListView = Controls.Find("lsvCards", true).FirstOrDefault() as ListView;

            if (cardListView == null)
            {
                MessageBox.Show("Error: 'lsvCards' ListView control not found on the form.");
                return;
            }


            cardListView.Items.Clear();

            foreach (Card card in _currentDeck.Cards)
            {
                ListViewItem lvi = new ListViewItem(card.Front);
                lvi.SubItems.Add(card.Back);
                lvi.Tag = card;
                cardListView.Items.Add(lvi);
            }
        }

        private void btnDeleteCard_Click(object sender, EventArgs e)
        {
            ListView cardListView = Controls.Find("lsvCards", true).FirstOrDefault() as ListView;

            if (cardListView == null)
            {
                return;
            }

            if (cardListView.SelectedItems.Count > 0) 
            {
                ListViewItem selectedLVI = cardListView.SelectedItems[0];
                Card selectedCard = selectedLVI.Tag as Card;
                if (selectedCard != null)
                {
                    _currentDeck.Cards.Remove(selectedCard);
                    UpdateCardDisplay();
                }
            }
            else
            {
                MessageBox.Show("Please select a card to delete.");
            }
        }
    }
}
