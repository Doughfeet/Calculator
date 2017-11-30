using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public string OperationPerformed { get; set; } = "";
        public double ResultValue { get; set; } = 0;
        public bool IsOperationPerformed { get; set; } = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if ((TextBoxResult.Text == "0") || (IsOperationPerformed))
            {
                TextBoxResult.Clear();
            }
            IsOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ",")
            {
                if (!TextBoxResult.Text.Contains(","))
                {
                    TextBoxResult.Text = TextBoxResult.Text + button.Text;
                }
            }
            else
            {
                TextBoxResult.Text = TextBoxResult.Text + button.Text;
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (ResultValue != 0)
            {
                button20.PerformClick();
                OperationPerformed = button.Text;
                labelCurrentOperation.Text = ResultValue + " " + OperationPerformed;
                IsOperationPerformed = true;
            }
            else
            {
                OperationPerformed = button.Text;
                ResultValue = double.Parse(TextBoxResult.Text);
                labelCurrentOperation.Text = ResultValue + " " + OperationPerformed;
                IsOperationPerformed = true;
            }
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = "0";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = "0";
            ResultValue = 0;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            switch (OperationPerformed)
            {
                case "+": TextBoxResult.Text = (ResultValue + double.Parse(TextBoxResult.Text)).ToString();
                    break;
                case "-":
                    TextBoxResult.Text = (ResultValue - double.Parse(TextBoxResult.Text)).ToString();
                    break;
                case "/":
                    TextBoxResult.Text = (ResultValue / double.Parse(TextBoxResult.Text)).ToString();
                    break;
                case "*":
                    TextBoxResult.Text = (ResultValue * double.Parse(TextBoxResult.Text)).ToString();
                    break;

                default:
                    break;
            }
            ResultValue = double.Parse(TextBoxResult.Text);
            labelCurrentOperation.Text = "";
        }
    }
}
