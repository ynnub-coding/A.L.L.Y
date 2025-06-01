using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace A.L.L.Y.Forms
{
    public partial class FlashCards : Form
    {
        private List<Deck> decks = new List<Deck>();


        public FlashCards()
        {
            InitializeComponent();
        }
        private void RefreshDecksListBox()
        {
            lstbDecks.Items.Clear();
            foreach (Deck deck in decks)
            {
                // This will use the Deck.ToString() method (which returns its Title)
                lstbDecks.Items.Add(deck);
            }
        }
        private void btnAddDeck_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please enter a deck title.");
                return;
            }
            Deck newDeck = new Deck(title);
            decks.Add(newDeck);
            lstbDecks.Items.Add(newDeck);

            txtTitle.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstbDecks.SelectedItem is Deck selectedDeck)
            {
                decks.Remove(selectedDeck);
                lstbDecks.Items.Remove(selectedDeck);
            }
            else
            {
                MessageBox.Show("Please select a deck to delete.");
            }
        }

        private void lstbDecks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbDecks.SelectedItem is Deck selectedDeck)
            {
                FlashcardsCreationForm cardForm = new FlashcardsCreationForm(selectedDeck);
                openSubForm(cardForm); // Pass the form to the helper method
            }
            else
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                    activeForm = null;
                }
                pnlContent.Controls.Clear();
            }
        }

        //reuse lang code sa main dashboard
        private Form activeForm = null;
        private void openSubForm(Form subform)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = subform;
            subform.TopLevel = false;
            subform.FormBorderStyle = FormBorderStyle.None;
            subform.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(subform);
            pnlContent.Tag = subform;
            subform.BringToFront();
            subform.Show();

        }
    }
    //STORING CARDS HERE
    // paltan mo ng database josh, mas mabilis pala mag organize pag database
    // gawin mong yung adding decks pinaka name nung table tapos every table na cinecreate ay nagawa ng 2 columns
    public class Card
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public List<string> IncorrectChoices { get; set; } = new List<string>();
        public Card(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }
        public Card(string question, string answer, List<string> incorrectChoices)
        {
            Question = question;
            Answer = answer;
            IncorrectChoices = incorrectChoices;
        }

        public List<string> GetAllShuffledChoices()
        {
            List<string> allChoices = new List<string>();
            allChoices.Add(Answer);
            allChoices.AddRange(IncorrectChoices);

            // Shuffle the list
            Random rng = new Random();
            return allChoices.OrderBy(a => rng.Next()).ToList();
        }
        public override string ToString() { return $"{Question} | {Answer}"; }
    }

    public class Deck
    {
        public string Title { get; set; }
        public List<Card> Cards { get; set; } = new List<Card>();

        public Deck(string title) { Title = title; }
        public override string ToString() { return Title; }
    }
}
