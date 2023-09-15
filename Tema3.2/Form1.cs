using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema3._2
{
    public partial class Form1 : Form
    {
        private string currentCalculation = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;
            textBoxOutput.Text = currentCalculation;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            string formattedCalculation = currentCalculation.ToString().Replace("X", "*").ToString().Replace("&divide;", "/");

            try
            {
                textBoxOutput.Text = new DataTable().Compute(formattedCalculation, null).ToString();
                currentCalculation = textBoxOutput.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Intrare incorectă!");
                textBoxOutput.Text = "0";
                currentCalculation = "";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = "0";
            currentCalculation = "";
            MessageBox.Show("Stergere realizată cu succes!");
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            if (currentCalculation.Length > 0)
            {
                currentCalculation = currentCalculation.Remove(currentCalculation.Length - 1, 1);
            }
            textBoxOutput.Text = currentCalculation;
        }
    }
}
