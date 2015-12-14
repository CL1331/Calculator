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
    public partial class frmCalculator : Form
    {

        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;



        public frmCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = "";
            input += "0";
            this.txtDisplay.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = "";
            input += "9";
            this.txtDisplay.Text += input;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                
                result = num1 + num2;
                txtDisplay.Text = result.ToString();
                String stringNum1 = Convert.ToString(num1);
                String stringNum2 = Convert.ToString(num2);
                StringBuilder sb = new StringBuilder();
                sb.Append(stringNum1);
                sb.Append("+");
                sb.Append(stringNum2);
                this.lblDisplay.Text = "";               
                lblDisplay.Text += sb;
              

            }
            else if (operation == '-')
            {
                result = num1 - num2;
                txtDisplay.Text = result.ToString();
                String stringNum1 = Convert.ToString(num1);
                String stringNum2 = Convert.ToString(num2);
                StringBuilder sb = new StringBuilder();
                sb.Append(stringNum1);
                sb.Append("-");
                sb.Append(stringNum2);
                this.lblDisplay.Text = "";
                lblDisplay.Text += sb;






            }
            else if (operation == '*')
            {
                result = num1 * num2;
                txtDisplay.Text = result.ToString();
                String stringNum1 = Convert.ToString(num1);
                String stringNum2 = Convert.ToString(num2);
                StringBuilder sb = new StringBuilder();
                sb.Append(stringNum1);
                sb.Append("*");
                sb.Append(stringNum2);
                this.lblDisplay.Text = "";
                lblDisplay.Text += sb;




            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    txtDisplay.Text = result.ToString();
                    String stringNum1 = Convert.ToString(num1);
                    String stringNum2 = Convert.ToString(num2);
                    StringBuilder sb = new StringBuilder();
                    sb.Append(stringNum1);
                    sb.Append("/");
                    sb.Append(stringNum2);
                    this.lblDisplay.Text = "";
                    lblDisplay.Text += sb;
                }
                else
                {
                    txtDisplay.Text = "Div/Zero!";
                   
                }
            }

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = "";
            input += "1";
            this.txtDisplay.Text += input;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = "";
            input += "2";
            this.txtDisplay.Text += input;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = "";
            input += "3";
            this.txtDisplay.Text += input;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = "";
            input += "4";
            this.txtDisplay.Text += input;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = "";
            input += "5";
            this.txtDisplay.Text += input;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = "";
            input += "6";
            this.txtDisplay.Text += input;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = "";
            input += "7";
            this.txtDisplay.Text += input;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = "";
            input += "8";
            this.txtDisplay.Text += input;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = "";
            input += ".";
            this.txtDisplay.Text += input;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lblDisplay.Text = "";
            this.txtDisplay.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            btnOff.FlatStyle = FlatStyle.Flat;
            btnOff.FlatAppearance.BorderSize = 1;
            btnOff.FlatAppearance.BorderColor = Color.White;
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {
           
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}