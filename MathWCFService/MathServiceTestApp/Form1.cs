using System;
using System.Windows.Forms;
using MathServiceTestApp.MathService;

namespace MathServiceTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            MathServiceClient client=new MathServiceClient();

            int no1 = Convert.ToInt32(txtNo1.Text.Trim());
            int no2 = Convert.ToInt32(txtNo2.Text.Trim());
            if (comboBox1.Text.Equals("Add",StringComparison.OrdinalIgnoreCase))
            {
                txtResult.Text = (client.Add(no1, no2)).ToString();
            }
            else if(comboBox1.Text.Equals("Substract",StringComparison.OrdinalIgnoreCase))
            {
                txtResult.Text = (client.Subtract(no1, no2)).ToString();
            }
            else if (comboBox1.Text.Equals("Multiply", StringComparison.OrdinalIgnoreCase))
            {
                txtResult.Text = (client.Multiple(no1, no2)).ToString();
            }
            else
            {
                txtResult.Text = (client.Divide(no1, no2)).ToString();
            }
        }

    }
}
