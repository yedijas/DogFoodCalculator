using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogFoodCalculator
{
    public partial class MainForm : Form
    {
        double MeTotal = 0;
        double protein = 0;
        double fat = 0;
        double fiber = 0;
        double moisture = 10;
        double ash = 0;
        double carbs = 0;
        double dogWeight = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(tbFat.Text) ||
                string.IsNullOrEmpty(tbFiber.Text) ||
                string.IsNullOrEmpty(tbMoisture.Text) ||
                string.IsNullOrEmpty(tbWeight.Text) ||
                string.IsNullOrEmpty(tbProtein.Text) ||
                string.IsNullOrEmpty(tbAsh.Text))
            {
                MessageBox.Show("Please input the correct decimal numbers in the input fields.");
                return false;
            }
            else
            {
                double.TryParse(tbFat.Text, out fat);
                double.TryParse(tbFiber.Text, out fiber);
                double.TryParse(tbMoisture.Text, out moisture);
                double.TryParse(tbAsh.Text, out ash);
                double.TryParse(tbWeight.Text, out dogWeight);
                double.TryParse(tbProtein.Text, out protein);
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                CalculateDogDER();
                CalculateMETotal();
                CalculateTotalFoodNeeded();
            }
        }

        private void CalculateCarbs(object sender, EventArgs e)
        {
            double.TryParse(tbFat.Text, out fat);
            double.TryParse(tbFiber.Text, out fiber);
            double.TryParse(tbMoisture.Text, out moisture);
            double.TryParse(tbAsh.Text, out ash);
            double.TryParse(tbWeight.Text, out dogWeight);
            double.TryParse(tbProtein.Text, out protein);
            carbs = 100 - protein - fat - fiber - moisture - ash;
            tbCarbs.Text = carbs.ToString();
        }

        private void CalculateMETotal()
        {
            MeTotal = 0;
            MeTotal = ((protein * 3.5) + (fat * 8.5) + (carbs * 3.5)) * 10;
            tbME.Text = MeTotal.ToString("#0.0000");
        }

        private void CalculateDogDER()
        {
            double dogDER = 0;
            double thisDogDER;
            
            if (rbAct1.Checked) dogDER = 95;
            if (rbAct2.Checked) dogDER = 110;
            if (rbAct3.Checked) dogDER = 125;
            if (rbAct4.Checked) dogDER = 175;
            if (rbAct5.Checked) dogDER = 1240;

            thisDogDER = dogDER * (Math.Pow(dogWeight, 0.75)) * 1000;
            tbDER.Text = thisDogDER.ToString("#0.0000");
        }

        private void CalculateTotalFoodNeeded()
        {
            tbTotalFood.Text = (double.Parse(tbDER.Text) / double.Parse(tbME.Text)).ToString("#0.0");
        }
    }
}
