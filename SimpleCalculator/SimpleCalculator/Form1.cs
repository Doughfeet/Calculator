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

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (TextBoxResult.Text == "0")
            {
                TextBoxResult.Clear();
            }
            Button button = (Button)sender;
            TextBoxResult.Text = TextBoxResult.Text + button.Text;
        }


    }
}
