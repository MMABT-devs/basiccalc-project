using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMABT_MTstore_BasicCalc
{
    public partial class BasicCalc : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public BasicCalc()
        {
            InitializeComponent();
        }
        private void btnClick1(object sender, EventArgs e)
        {
            if((textBoxResult.Text == "0") || (isOperationPerformed))
            {
                textBoxResult.Clear();
            }
            isOperationPerformed = false;
            textBoxResult.Text = textBoxResult.Text + "1";
        }

        private void btnClick2(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0") || (isOperationPerformed))
            {
                textBoxResult.Clear();
            }
            isOperationPerformed = false;
            textBoxResult.Text = textBoxResult.Text + "2";
        }
        private void btnClick3(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0") || (isOperationPerformed))
            {
                textBoxResult.Clear();
            }
            isOperationPerformed = false;
            textBoxResult.Text = textBoxResult.Text + "3";
        }

        private void btnClick4(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0") || (isOperationPerformed))
            {
                textBoxResult.Clear();
            }
            isOperationPerformed = false;
            textBoxResult.Text = textBoxResult.Text + "4";
        }
        private void btnClick5(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0") || (isOperationPerformed))
                {
                textBoxResult.Clear();
            }
            isOperationPerformed = false;
            textBoxResult.Text = textBoxResult.Text + "5";
        }

        private void btnClick6(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0") || (isOperationPerformed))
            {
                textBoxResult.Clear();
            }
            isOperationPerformed = false;
            textBoxResult.Text = textBoxResult.Text + "6";
        }

        private void btnClick7(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0") || (isOperationPerformed))
            {
                textBoxResult.Clear();
            }
            isOperationPerformed = false;
            textBoxResult.Text = textBoxResult.Text + "7";
        }

        private void btnClick8(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0") || (isOperationPerformed))
            {
                textBoxResult.Clear();
            }
            isOperationPerformed = false;
            textBoxResult.Text = textBoxResult.Text + "8";
        }

        private void btnClick9(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0") || (isOperationPerformed))
            {
                textBoxResult.Clear();
            }
            isOperationPerformed = false;
            textBoxResult.Text = textBoxResult.Text + "9";
        }

        private void btnClick0(object sender, EventArgs e)
        {
            isOperationPerformed = false;
            textBoxResult.Text = textBoxResult.Text + "0";
        }

        private void btnClickComma(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + ",";
        }

        private void btnClickOprt(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operationPerformed = btn.Text;
            resultValue = Double.Parse(textBoxResult.Text);
            labelCurrentOprt.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            resultValue = 0;
        }

        private void btnEqual(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    textBoxResult.Text = (resultValue + Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (resultValue - Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "×":
                    textBoxResult.Text = (resultValue * Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "÷":
                    textBoxResult.Text = (resultValue / Double.Parse(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
        private void btnClickMin(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0") || (isOperationPerformed))
            {
                textBoxResult.Clear();
            }
            isOperationPerformed = false;
            textBoxResult.Text = textBoxResult.Text + "-";
        }
    }
}
