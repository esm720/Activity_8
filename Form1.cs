using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Handles the exit button to close form.
        private void ExitBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Event handler for fat to calories convertion, invokes FatCalories for conversion.
        private void CaloriesBut_Click(object sender, EventArgs e)
        {
            try
            {
                int fatGrams = int.Parse(FatTextInput.Text);
                CaloriesFromFatOutput.Text = FatCalories(fatGrams).ToString();
                CaloriesFromFatOutput.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Please input an integer.");
            }
        }
        //Handles carbs to calories, invokes carbsCalories for converstion.
        private void CarbsBut_Click(object sender, EventArgs e)
        {
            try
            {
                int carbGrams = int.Parse(CarbsTextInput.Text);
                CaloriesFromCarbsOutput.Text = CarbCalories(carbGrams).ToString();
                CaloriesFromCarbsOutput.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Please input an integer.");
            }
        }
        //Method converts fat to calories and returns value
        private int FatCalories(int fat)
        {
            int fatCalories;
            fatCalories = fat * 9;
            return fatCalories;
        }
        //Method converts carbs to calories and returns value
        private int CarbCalories( int carbs)
        {
            int carbCalories;
            carbCalories = carbs * 4;
            return carbCalories;
        }

        /*
         * Enrique Sanchezmurillo
         * CST-150 Activity 8
         * 31 JUL 2022
         */
        
    }
}
