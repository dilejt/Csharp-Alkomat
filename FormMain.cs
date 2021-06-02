using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alkomat
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
            this.labelShow.Parent = this.pictureBoxAlko; //for transparent
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int bigBeer = 0;
            int smallBeer = 0;
            int vodka = 0;
            int wine = 0;
            double weight = 0;
            string gender = "";
            int isValidCount = 0;

            if (String.IsNullOrEmpty(this.textBoxBigBeer.Text))
            {
                textBoxBigBeer.Select(0, textBoxBigBeer.Text.Length);
                this.errorProvider.SetError(textBoxBigBeer, "Field is required.");
            }
            else
            {
                bigBeer = Convert.ToInt32(this.textBoxBigBeer.Text);
                isValidCount++;
            }

            if (String.IsNullOrEmpty(this.textBoxSmallBeer.Text))
            {
                textBoxSmallBeer.Select(0, textBoxSmallBeer.Text.Length);
                this.errorProvider.SetError(textBoxSmallBeer, "Field is required.");
            }
            else
            {
                smallBeer = Convert.ToInt32(this.textBoxSmallBeer.Text);
                isValidCount++;
            }
                
            if (String.IsNullOrEmpty(this.textBoxVodka.Text))
            {
                textBoxVodka.Select(0, textBoxVodka.Text.Length);
                this.errorProvider.SetError(textBoxVodka, "Field is required.");
            }
            else
            {
                vodka = Convert.ToInt32(this.textBoxVodka.Text);
                isValidCount++;
            }

            if (String.IsNullOrEmpty(this.textBoxWine.Text))
            {
                textBoxWine.Select(0, textBoxWine.Text.Length);
                this.errorProvider.SetError(textBoxWine, "Field is required.");
            }
            else
            {
                wine = Convert.ToInt32(this.textBoxWine.Text);
                isValidCount++;
            }

            if (String.IsNullOrEmpty(this.textBoxBodyMass.Text))
            {
                textBoxBodyMass.Select(0, textBoxBodyMass.Text.Length);
                this.errorProvider.SetError(textBoxBodyMass, "Field is required.");
            }
            else
            {
                weight = Convert.ToDouble(this.textBoxBodyMass.Text);
                isValidCount++;
            }

            if (Convert.ToBoolean(this.radioButtonFemale.Checked))
            {
                gender = "female";
            }
            else if (Convert.ToBoolean(this.radioButtonMale.Checked))
            {
                gender = "male";
            }

            if(isValidCount == 5)
            {
                Result result = new Result(bigBeer, smallBeer, vodka, wine, weight, gender);
                if (result.resultPromile > 4.5)
                {
                    this.labelShow.Text = "> 4.5";
                }
                else
                {
                    this.labelShow.Text = result.resultPromile.ToString();
                }

                FormInfo formInfo = new FormInfo(result);
                formInfo.ShowDialog();
            }

        }

        public bool ValidBodyMass(string bodyMass, out string errorMessage)
        {
            if (bodyMass.Length == 0)
            {
                errorMessage = "Field is required.";
                return false;
            }
            if (int.TryParse(bodyMass, out int weight))
            {
                if (weight > 0 && weight <= 600)
                {
                    errorMessage = "";
                    return true;
                }
                else
                {
                    errorMessage = "Wrong scope value";
                    return false;
                }

            }
            errorMessage = "Wrong input";
            return false;
        }
        public bool ValidDrinkInput(string input, out string errorMessage)
        {
            if (input.Length == 0)
            {
                errorMessage = "Field is required.";
                return false;
            }
            if (int.TryParse(input, out int quantity))
            {
                if (quantity >= 0 && quantity <= 50)
                {
                    errorMessage = "";
                    return true;
                }
                else
                {
                    errorMessage = "Wrong scope value";
                    return false;
                }

            }
            errorMessage = "Wrong input";
            return false;
        }
        private void textBoxBodyMass_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidBodyMass(textBoxBodyMass.Text, out string errorMsg))
            {
                e.Cancel = true;
                textBoxBodyMass.Select(0, textBoxBodyMass.Text.Length);

                this.errorProvider.SetError(textBoxBodyMass, errorMsg);
            }
        }
        private void textBoxBodyMass_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxBodyMass, "");
        }
        private void textBoxBigBeer_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidDrinkInput(textBoxBigBeer.Text, out string errorMsg))
            {
                e.Cancel = true;
                textBoxBigBeer.Select(0, textBoxBigBeer.Text.Length);

                this.errorProvider.SetError(textBoxBigBeer, errorMsg);
            }
        }
        private void textBoxBigBeer_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxBigBeer, "");
        }

        private void textBoxSmallBeer_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxSmallBeer, "");
        }

        private void textBoxSmallBeer_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidDrinkInput(textBoxSmallBeer.Text, out string errorMsg))
            {
                e.Cancel = true;
                textBoxSmallBeer.Select(0, textBoxSmallBeer.Text.Length);

                this.errorProvider.SetError(textBoxSmallBeer, errorMsg);
            }
        }

        private void textBoxWine_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxWine, "");
        }

        private void textBoxWine_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidDrinkInput(textBoxWine.Text, out string errorMsg))
            {
                e.Cancel = true;
                textBoxWine.Select(0, textBoxWine.Text.Length);

                this.errorProvider.SetError(textBoxWine, errorMsg);
            }
        }

        private void textBoxVodka_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxVodka, "");
        }

        private void textBoxVodka_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidDrinkInput(textBoxVodka.Text, out string errorMsg))
            {
                e.Cancel = true;
                textBoxVodka.Select(0, textBoxVodka.Text.Length);

                this.errorProvider.SetError(textBoxVodka, errorMsg);
            }
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false; //can close form even with validation
        }
    }

}
