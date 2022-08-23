using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        private bool nonNumberEntered = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((label1.Text == "0") || (isOperationPerformed))
            {
                label1.Clear();
            }

            isOperationPerformed = false;
            Button button = (Button)sender;

            if (button.Text == ",")
            {
                if (!label1.Text.Contains(","))
                {
                    label1.Text = label1.Text + button.Text;
                }

            }
            else
            {
                label1.Text = label1.Text + button.Text;
            }

        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                buttonEsittir.PerformClick();
                operationPerformed = button.Text;
                labelCurrent.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(label1.Text);
                labelCurrent.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            resultValue = 0;
        }

        private void buttonEsittir_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "/":
                    label1.Text = (resultValue / Double.Parse(label1.Text)).ToString();
                    break;
                case "*":
                    label1.Text = (resultValue * Double.Parse(label1.Text)).ToString();
                    break;
                case "-":
                    label1.Text = (resultValue - Double.Parse(label1.Text)).ToString();
                    break;
                case "+":
                    label1.Text = (resultValue + Double.Parse(label1.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(label1.Text);
            labelCurrent.Text = "";
        }

        private void labelCurrent_Click(object sender, EventArgs e)
        {

        }

        private void buttonSilme_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 1)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1, 1);
            }
            else if (label1.Text.Length > 0)
            {
                label1.Text = "0";
            }
        }
    }
}
