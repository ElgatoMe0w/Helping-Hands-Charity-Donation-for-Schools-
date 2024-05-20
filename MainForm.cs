using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CharityDonation
{
    public partial class MainForm : Form
    {
        private double totalDonation = 0.0; // Field to store the total donation

        public MainForm()
        {
            InitializeComponent();
        }

        private void NavigateToSecondForm()
        {
            string schoolName = txtSchoolName.Text;
            
            if (string.IsNullOrWhiteSpace(schoolName))
            {
            	MessageBox.Show(" Please enter a school to donate. ", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            	return;
            }
            NewForm newForm = new NewForm(schoolName, totalDonation);
            newForm.Show();
            this.Hide();
        }

        private void BtnProceedClick(object sender, EventArgs e)
        {
            NavigateToSecondForm(); // Call the method to navigate to the second form
        }

        private void TxtSchoolNameTextChanged(object sender, EventArgs e)
        {
            // Handle text changed event if needed
        }

        private void TextBox1TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event if needed
        }
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			
		}
		
		void LblSchoolClick(object sender, EventArgs e)
		{
			
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
    }
}
