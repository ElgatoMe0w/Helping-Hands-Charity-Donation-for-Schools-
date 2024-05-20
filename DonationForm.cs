
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CharityDonation
{
    public partial class DonationForm : Form
    {
        private string chosenSchoolName;

        public DonationForm(string schoolName)
        {
            InitializeComponent();
            chosenSchoolName = schoolName;
           
        }

      
       

        private void TxtDonationAmountTextChanged(object sender, EventArgs e)
        {
            // Handle text changed event of the donation amount TextBox if needed
        }

        private void Label1Click(object sender, EventArgs e)
        {
            // Handle click event of the label if needed
        }
		
		
		
		void BtnDonateMoneyClick(object sender, EventArgs e)
		{
			// Retrieve the donation amount from the TextBox
    string donationAmountText = txtDonationAmount.Text;

    // Prompt the user with a message box asking for confirmation
    DialogResult result = MessageBox.Show("Are you sure you want to donate ₱" + donationAmountText + "?", "Confirm Donation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

    // Check if the user clicked Yes
    if (result == DialogResult.Yes)
    {
        // Display a thank you message
        MessageBox.Show("Thank you for donating ₱" + donationAmountText + "!", "Thank You and GOD Bless", MessageBoxButtons.OK, MessageBoxIcon.Information);
         Application.Exit();
    }
		}
    }
}
