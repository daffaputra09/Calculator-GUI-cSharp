using System.Data;
using System;

namespace CalculatorGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + button9.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text.EndsWith("+") || TxtDisplay.Text.EndsWith("-") || TxtDisplay.Text.EndsWith("*") || TxtDisplay.Text.EndsWith("/"))
            {
                TxtDisplay.Text = TxtDisplay.Text.Remove(TxtDisplay.Text.Length - 1);
                TxtDisplay.Text = TxtDisplay.Text + "+";
            } else TxtDisplay.Text = TxtDisplay.Text + "+";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text.EndsWith("+") || TxtDisplay.Text.EndsWith("-") || TxtDisplay.Text.EndsWith("*") || TxtDisplay.Text.EndsWith("/"))
            {
                TxtDisplay.Text = TxtDisplay.Text.Remove(TxtDisplay.Text.Length - 1);
                TxtDisplay.Text = TxtDisplay.Text + "-";
            }
            else TxtDisplay.Text = TxtDisplay.Text + "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text.EndsWith("+") || TxtDisplay.Text.EndsWith("-") || TxtDisplay.Text.EndsWith("*") || TxtDisplay.Text.EndsWith("/"))
            {
                TxtDisplay.Text = TxtDisplay.Text.Remove(TxtDisplay.Text.Length - 1);
                TxtDisplay.Text = TxtDisplay.Text + "*";
            }
            else TxtDisplay.Text = TxtDisplay.Text + "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text.EndsWith("+") || TxtDisplay.Text.EndsWith("-") || TxtDisplay.Text.EndsWith("*") || TxtDisplay.Text.EndsWith("/"))
            {
                TxtDisplay.Text = TxtDisplay.Text.Remove(TxtDisplay.Text.Length - 1);
                TxtDisplay.Text = TxtDisplay.Text + "/";
            }
            else TxtDisplay.Text = TxtDisplay.Text + "/";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text.EndsWith("+") || TxtDisplay.Text.EndsWith("-"))
            {
                TxtDisplay.Text = TxtDisplay.Text + "0";
            }
            else if (TxtDisplay.Text.EndsWith("*") || TxtDisplay.Text.EndsWith("/"))
            {
                TxtDisplay.Text = TxtDisplay.Text + "1";
            }
            string value = new DataTable().Compute(TxtDisplay.Text, null).ToString();
            TxtDisplay.Text = value;

            TxtDisplay.Text = TxtDisplay.Text.Replace(",0", "");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = "";
        }

        private void TxtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            if(TxtDisplay.Text.Length > 0)
            {
                TxtDisplay.Text = TxtDisplay.Text.Remove(TxtDisplay.Text.Length - 1);
            }  

        }
    }
}