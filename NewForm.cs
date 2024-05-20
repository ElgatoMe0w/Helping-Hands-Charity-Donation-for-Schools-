using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace CharityDonation
{
    public partial class NewForm : Form
    {
        // Define class-level variables to store choices and prices
        private List<string> selectedItems = new List<string>();
        private List<double> selectedPrices = new List<double>();
        private string chosenSchoolName;
        private double previousTotalDonation;
        

        // Constructor to receive and store the school name and previous total donation
        public NewForm(string schoolName, double previousTotalDonation)
        {
            InitializeComponent();
            chosenSchoolName = schoolName;
            this.previousTotalDonation = previousTotalDonation;
            lblSchoolName.Text = "Chosen School: " + chosenSchoolName;
        }

        // Default constructor (for designer support)
        public NewForm()
        {
            InitializeComponent();
        }

        // Method to retrieve the stored school name
        public string GetSchoolName()
        {
            return chosenSchoolName;
        }

        // Event handlers for adding items
        void Button1Click(object sender, EventArgs e)
        {
            string btnBook = "Books";
            double price = 5000.00;
            selectedItems.Add(btnBook);
            selectedPrices.Add(price);
        }

        void BtnPencilClick(object sender, EventArgs e)
        {
            string btnPencil = "Pencil";
            double price = 50.00;
            selectedItems.Add(btnPencil);
            selectedPrices.Add(price);
        }

        void BtnBagClick(object sender, EventArgs e)
        {
            string btnBag = "Bag";
            double price = 350.00;
            selectedItems.Add(btnBag);
            selectedPrices.Add(price);
        }

        void BtnNotebookClick(object sender, EventArgs e)
        {
            string btnNoteBook = "Notebook";
            double price = 100.00;
            selectedItems.Add(btnNoteBook);
            selectedPrices.Add(price);
        }

        void BtnBallpenClick(object sender, EventArgs e)
        {
            string btnBallpen = "Ballpen";
            double price = 20.00;
            selectedItems.Add(btnBallpen);
            selectedPrices.Add(price);
        }

        void BtnStoryClick(object sender, EventArgs e)
        {
            string btnStory = "Story Books";
            double price = 75.00;
            selectedItems.Add(btnStory);
            selectedPrices.Add(price);
        }

        void BtnPurchaseClick(object sender, EventArgs e)
        {
            string btnCrayons = "Crayons";
            double price = 50.00;
            selectedItems.Add(btnCrayons);
            selectedPrices.Add(price);
        }

        void BtnColoringClick(object sender, EventArgs e)
        {
            string btnColoring = "Coloring Book";
            double price = 100.00;
            selectedItems.Add(btnColoring);
            selectedPrices.Add(price);
        }

        void BtnPapersClick(object sender, EventArgs e)
        {
            string btnPapers = "Papers";
            double price = 30.00;
            selectedItems.Add(btnPapers);
            selectedPrices.Add(price);
        }

        // Confirm button click event
        void BtnConfirmClick(object sender, EventArgs e)
        {
            double totalAmount = previousTotalDonation;
            StringBuilder purchaseSummary = new StringBuilder();

            for (int i = 0; i < selectedItems.Count; i++)
            {
                purchaseSummary.AppendLine("Item: " + selectedItems[i] + ", Price: ₱" + selectedPrices[i]);
                totalAmount += selectedPrices[i];
            }

            // Display the purchase summary and total amount
            string message = "Your purchases:\n" + purchaseSummary + "\nTotal Amount: ₱" + totalAmount;
            MessageBox.Show(message, "Purchase Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Show the thank you message with the chosen school name
            string thankYouMessage = "Thank you for donating!! This will be donated to your chosen school (" + GetSchoolName() + ").";
            MessageBox.Show(thankYouMessage, "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Show the progression form with the updated total donation amount
            Progression progression = new Progression(totalAmount);
            progression.Show();

            // Clear the selected items and prices for the next transaction
            selectedItems.Clear();
            selectedPrices.Clear();

            this.Close();
        }

        // Open the DonationForm
        void BtnDonateMoneyFormClick(object sender, EventArgs e)
        {
            DonationForm donationForm = new DonationForm(chosenSchoolName);
            donationForm.Show();
        }
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			
		}
		
		void LblStoryClick(object sender, EventArgs e)
		{
			
		}
		
		void PictureBox8Click(object sender, EventArgs e)
		{
			
		}
		
		void PictureBox6Click(object sender, EventArgs e)
		{
			
		}
		
		
		void NewFormLoad(object sender, EventArgs e)
		{
			
		}
    }
}
