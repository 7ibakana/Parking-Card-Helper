using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_Card_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /* Calculate the number of days of parking, any remaining credit,
             * for an amount of credit added to a campus card*/

            bool creditValid = Double.TryParse(txtCreditAdded.Text, out double creditAdded); //inline variable creation
            bool costOneParkWithCardValid = Double.TryParse(txtOneParkWithCard.Text, out double costOneParkWithCard);

            if (creditValid && costOneParkWithCardValid) // check both are valid
            {
                // Calculate number of times user can park, and any remaining credit
                int daysParking = (int) (creditAdded/costOneParkWithCard);
                double creditRemaining = creditAdded % costOneParkWithCard;
                txtDaysParking.Text = daysParking.ToString(); //Must set Text to a String
                txtCreditRemaining.Text = creditRemaining.ToString("c"); // Use currency formatting
            }
            else
            {
                MessageBox.Show("Please enter numbers", "Error");
            }
        }
    }
}
