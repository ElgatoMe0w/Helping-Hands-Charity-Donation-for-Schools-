using System;
using System.Windows.Forms;

namespace CharityDonation
{
    public partial class Progression : Form
    {
        private double totalDonation;
       

        public Progression(double totalDonation)
        {
            InitializeComponent();
            this.totalDonation = totalDonation;
            UpdateTotalDonationLabel();
        }

        private void UpdateTotalDonationLabel()
        {
            lblTotalDonation.Text = "Total Donation: ₱" + totalDonation.ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuyMore_Click(object sender, EventArgs e)
        {
            NewForm newForm = new NewForm("Batangas Elementary School", totalDonation); 
            newForm.Show();
            this.Hide();
        }

        void ProgressionLoad(object sender, EventArgs e)
        {
            // Code to run when Progression form loads, if any
        }

        void LblTotalDonationClick(object sender, EventArgs e)
        {
            // Code for label click, if any
        }

        void LblProgressClick(object sender, EventArgs e)
        {
            // Code for label click, if any
        }
		
		void BtnExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void BtnBuyMoreClick(object sender, EventArgs e)
		{
			NewForm newForm = new NewForm("Batangas Elementary School", totalDonation); // Adjust as necessary
            newForm.Show();
            this.Hide();
		}
    }
}
