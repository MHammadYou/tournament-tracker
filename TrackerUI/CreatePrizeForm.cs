using System;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text,
                    placeNumberValue.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text
                    );
                
                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }

                    placeNameValue.Text = "";
                    placeNumberValue.Text = "";
                    prizeAmountValue.Text = "0";
                    prizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("Form is invalid");
            }
        }

        private bool ValidateForm()
        {
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

            if (!placeNumberValidNumber || placeNumber < 1)
            {
                return false;
            }

            if (placeNameValue.Text.Length == 0)
            {
                return false;
            }

            decimal prizeAmount = 0;
            int prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = int.TryParse(prizePercentageValue.Text, out prizePercentage);

            if (!prizeAmountValid || !prizePercentageValid)
            {
                return false;
            }
            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                return false;
            }
            if (prizePercentage < 0 || prizeAmount > 100)
            {
                return false;
            }

            
            return true;
        }
    }
}