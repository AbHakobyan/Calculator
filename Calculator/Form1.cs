using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
            labelCurrentOperation.Text = " ";
            labelSecondOperation.Text = " ";
            labelOperation.Text = " ";
            textBox1.Text = " ";
        }

        private void btCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            labelCurrentOperation.Text = " ";
            labelSecondOperation.Text = " ";
            labelOperation.Text = " ";
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || (isOperationPerformed))
            {
                textBox1.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + button.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }
            if(operationPerformed == "+" || operationPerformed == "-" || operationPerformed == "*" || operationPerformed == "/")
            {
                
                labelSecondOperation.Text = textBox1.Text;
            }
        }

        private void btC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
            labelCurrentOperation.Text = " ";
            labelSecondOperation.Text = " ";
            labelOperation.Text = " ";
            operationPerformed = " ";
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;;
            if (result != 0)
            {
                btEquals.PerformClick();
                operationPerformed = button.Text;
                result = double.Parse(textBox1.Text);
                labelCurrentOperation.Text = result + "  " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                result = double.Parse(textBox1.Text);
                labelCurrentOperation.Text = result + "  " + operationPerformed;
                isOperationPerformed = true;
            }  
        }

        private void btEquals_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();                    break;
            }
            result = double.Parse(textBox1.Text);
            labelOperation.Text = " = " + result.ToString();
            labelCurrentOperation.Text = result.ToString();
            textBox1.Text = "0";
            result = 0;
            operationPerformed = " ";
            labelCurrentOperation.Text = " ";
            labelSecondOperation.Text = " ";
        }
        private void btDel_Click(object sender, EventArgs e)
        {
            int length = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void btMinPlus_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text) * (-1);
            textBox1.Text = result.ToString();
        }
    }
}
