using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexBinDecCalculator
{
    public partial class Form1 : Form
    {
        string strHex1 = "";
        string strHex2 = "";
        string strHexAns = "";

        string strBin1 = "";
        string strBin2 = "";
        string strBinAns = "";

        int intDec1 = 0;
        int intDec2 = 0;
        int intDecAns = 0;

        string activeField = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void RadHex_CheckedChanged(object sender, EventArgs e)
        {
            SetFieldsToZero();

            // Make Hex fields active
            txtHex1.TabStop = true;
            txtHex1.Enabled = true;
            txtHex1.ReadOnly = false;
            txtHex2.TabStop = true;
            txtHex2.Enabled = true;
            txtHex2.ReadOnly = false;
            txtHex1.Focus();

            // Disable Dec and Bin fields
            txtDec1.TabStop = false;
            txtDec1.Enabled = false;
            txtDec1.ReadOnly = true;
            txtDec2.TabStop = false;
            txtDec2.Enabled = false;
            txtDec2.ReadOnly = true;
            txtBin1.TabStop = false;
            txtBin1.Enabled = false;
            txtBin1.ReadOnly = true;
            txtBin2.TabStop = false;
            txtBin2.Enabled = false;
            txtBin2.ReadOnly = true;

            // Enable btns A-F and btns 2-9
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnE.Enabled = true;
            btnF.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }
        private void RadBinary_CheckedChanged(object sender, EventArgs e)
        {
            SetFieldsToZero();

            // Make Binary fields active
            txtBin1.TabStop = true;
            txtBin1.Enabled = true;
            txtBin1.ReadOnly = false;
            txtBin2.TabStop = true;
            txtBin2.Enabled = true;
            txtBin2.ReadOnly = false;
            txtBin1.Focus();

            // Disable Dec and Hex fields
            txtDec1.TabStop = false;
            txtDec1.Enabled = false;
            txtDec1.ReadOnly = true;
            txtDec2.TabStop = false;
            txtDec2.Enabled = false;
            txtDec2.ReadOnly = true;
            txtHex1.TabStop = false;
            txtHex1.Enabled = false;
            txtHex1.ReadOnly = true;
            txtHex2.TabStop = false;
            txtHex2.Enabled = false;
            txtHex2.ReadOnly = true;

            //Disable btns A - F and 2-9
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }
        private void RadDecimal_CheckedChanged(object sender, EventArgs e)
        {
            SetFieldsToZero();

            // Make Decimal fields active
            txtDec1.TabStop = true;
            txtDec1.Enabled = true;
            txtDec1.ReadOnly = false;
            txtDec2.TabStop = true;
            txtDec2.Enabled = true;
            txtDec2.ReadOnly = false;
            txtDec1.Focus();

            // Disable Dec and Hex fields
            txtBin1.TabStop = false;
            txtBin1.Enabled = false;
            txtBin1.ReadOnly = true;
            txtBin2.TabStop = false;
            txtBin2.Enabled = false;
            txtBin2.ReadOnly = true;
            txtHex1.TabStop = false;
            txtHex1.Enabled = false;
            txtHex1.ReadOnly = true;
            txtHex2.TabStop = false;
            txtHex2.Enabled = false;
            txtHex2.ReadOnly = true;

            // Enable btn 2-9
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            //Disable btns A - F
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;

        }
        private void TxtFirstInput_TextChanged(object sender, EventArgs e)
        {
            // Validate input.
            if (!ValidateHexInput(txtHex1.Text))
            {
                MessageBox.Show("Invalid first input.");
                txtHex1.Clear();
                txtHex1.Focus();
            }

            //Save first argument as hex, bin and dec.
            strHex1 = txtHex1.Text;
            intDec1 = ConvertHexToDecimal(strHex1);
            strBin1 = ConvertDecToBinary(intDec1);

        }
        private void TxtSecondInput_TextChanged_1(object sender, EventArgs e)
        {

            // Validate input.
            if (!ValidateHexInput(txtHex2.Text))
            {
                MessageBox.Show("Invalid second input.");
                txtHex2.Clear();
                txtHex2.Focus();
            }

            //Save second argument as hex, bin and dec.
            strHex2 = txtHex2.Text;
            intDec2 = ConvertHexToDecimal(strHex2);
            strBin2 = ConvertDecToBinary(intDec2);

        }
        private void TxtFirstBinary_TextChanged(object sender, EventArgs e)
        {
            //Save input field
            activeField = "txtBin1";

            // Validate input.
            if (!ValidateBinInput(txtBin1.Text))
            {
                MessageBox.Show("Invalid first binary input.");
                txtBin1.Text = "0";
                txtBin1.Focus();
            }

            //Save first argument as hex, bin and dec.
            strBin1 = txtBin1.Text;
            intDec1 = ConvertBinToDecimal(strBin1);
            strHex1 = ConvertDecToHex(intDec1);
        }
        private void TxtSecondBinary_TextChanged(object sender, EventArgs e)
        { 
            //Save input field
            activeField = "txtBin2";

            // Validate input.
            if (!ValidateBinInput(txtBin2.Text))
            {
                MessageBox.Show("Invalid second binary input.");
                txtBin1.Text = "0";
                txtBin1.Focus();
            }

            //Save second argument as hex, bin and dec.
            strBin2 = txtBin2.Text;
            intDec2 = ConvertBinToDecimal(strBin2);
            strHex2 = ConvertDecToHex(intDec2);
        }
        private void TxtFirstDecimal_TextChanged(object sender, EventArgs e)
        {
            //Save input field
            activeField = "txtDec1";

            // Validate input.
            if (!ValidateDecInput(txtDec1.Text))
            {
                MessageBox.Show("Invalid first decimal input.");
                txtDec1.Text = "0";
                txtDec1.Focus();
            }

            //Save first argument as hex, bin and dec.
            intDec1 = int.Parse(txtDec1.Text);
            strBin1 = ConvertDecToBinary(intDec1);
            strHex1 = ConvertDecToHex(intDec1);
        }
        private void TxtSecondDecimal_TextChanged(object sender, EventArgs e)
        {
            //Save input field
            activeField = "txtDec2";

            // Validate input.
            if (!ValidateDecInput(txtDec2.Text))
            {
                MessageBox.Show("Invalid second decimal input.");
                txtDec2.Text = "0";
                txtDec2.Focus();
            }

            //Save second argument as hex, bin and dec.
            intDec2 = int.Parse(txtDec2.Text);
            strBin2 = ConvertDecToBinary(intDec2);
            strHex2 = ConvertDecToHex(intDec2);

        }
        private Boolean ValidateHexInput(string input)
        {
            if (int.TryParse(input, out int validInt))
            {
                // All integer values are valid Hex form, do nothing.
            }
            else
            {
                foreach (char c in input)
                {
                    if ((c >= 48 && c <= 59) || (c >= 65 && c <= 70) || (c >= 97 && c <= 102))
                    {
                        //Do nothing c is a value from 0-9 or A-Z or a-z
                    }
                    else
                    {
                        return false;
                    }
                }
            }
           
            return true;

        }
        private Boolean ValidateBinInput(string input)
        {
            foreach(char c in input)
            {
                if (c > '1' || c < '0')
                    return false;
            }
            return true;
        }
        private Boolean ValidateDecInput(string input)
        {
            if (!int.TryParse(input, out int validInt))
            {
                return false;
            }
                return true;
        }
        private int ConvertHexToDecimal(string hex)
        {
            int dec = 0;
            int exponent = hex.Length - 1;
            int n = 0;

            foreach (char c in hex)
            {
                //Convert c to numeric value
                // note: ascii value of a is 97, ascii value of A is 65;
                //       ascii value of f is 102, ascii value of F is 70;
                //       ascii value of 0 is 48;
                if (c >= 'a' && c <= 'f')
                    n = c - 87;
                else if (c >= 65 && c <= 'F')
                    n = c - 55;
                else
                    n = c-48;
               
                dec += n * (Convert.ToInt32(Math.Pow(16, exponent)));
                exponent--;
            }

            return dec;
        }
        private string ConvertDecToHex(int dec)
        {
            StringBuilder hex = new StringBuilder();
            int remainder = 0;
            char c;

            if (dec == 0)
                hex.Append("0");
            else
                while (dec != 0)
                {
                    remainder = dec % 16;
                    if (remainder < 10)
                    {
                        hex.Append(remainder.ToString());
                    }
                    else
                    {
                        c = (char)(remainder + 55);
                        hex.Append(c.ToString());
                    }
                    dec = dec / 16;
                }

            char[] charArray = hex.ToString().ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }
        private string ConvertDecToBinary(int dec)
        {
            StringBuilder bin = new StringBuilder();
            int remainder = 0;
            char[] charArray;

            if (dec == 0)
                return dec.ToString();
            else
                
                while (dec != 0)
                {
                    remainder = dec % 2;
                    bin.Append(remainder.ToString());
                    dec /= 2;
                }

                charArray = bin.ToString().ToCharArray();
                Array.Reverse(charArray);

                return new string(charArray);
        }
        private int ConvertBinToDecimal(string input)
        {
            double exponent = input.Length-1;
            int decimalValue = 0;
            double b = 0;
            foreach (char c in input)
            {
                b = (double)(c-48);         //character value of 0 is 48
                decimalValue += (int)(b * (Math.Pow(2.0, exponent)));
                exponent -= 1;
            }
           
            return decimalValue;
        }

        // GET INPUT METHODS

        private int Calculate()
        {
            //int intAnswer = 0;

            // Compute decimal answer
            char charOperator = cOperator.Text.ElementAt(0);

            switch (charOperator)
            {
                case '+':
                    intDecAns = intDec1 + intDec2;
                    break;
                case '-':
                    intDecAns = intDec1 - intDec2;
                    break;
                case '*':
                    intDecAns = intDec1 * intDec2;
                    break;
                case '/':
                    if (intDec2 == 0)
                    {
                        MessageBox.Show("Division by 0 is not allowed.");
                        txtHex1.Focus();
                        intDecAns = 0;
                    }
                    else
                    {
                        intDecAns = intDec1 / intDec2;
                    }
                    break;
                case '%':
                    if (intDec2 == 0)
                    {
                        MessageBox.Show("Division by 0 is not allowed.");
                        txtHex2.Focus();
                        intDecAns = 0;
                    }
                    else
                    {
                        intDecAns = intDec1 % intDec2;
                    }
                    break;
                default:
                    break;
            }

            return intDecAns;
        }
        private void BtnBottomEquals_Click(object sender, EventArgs e)
        {
            Calculate();

            // convert dec answer to hex and binary
            strBinAns = ConvertDecToBinary(intDecAns);
            strHexAns = ConvertDecToHex(intDecAns);
            DisplayAll();
        }
        private void BtnTopEquals_Click(object sender, EventArgs e)
        {
            BtnBottomEquals_Click(sender, e);
        }
        private void DisplayAll()
        {
            //Display Hex values.
            txtHex1.Text = strHex1;
            txtHex2.Text = strHex2;
            txtHexAns.Text = strHexAns;

            //Display binary values.
            txtBin1.Text = strBin1;
            txtBin2.Text = strBin2;
            txtBinAns.Text = strBinAns;

            // Display decimal values.
            txtDec1.Text = intDec1.ToString();
            txtDec2.Text = intDec2.ToString();
            txtDecAns.Text = intDecAns.ToString();
         
        }
        private void BtnModules_Click(object sender, EventArgs e)
        {
            cOperator.Text = "%";
        }
        private void ButDiv_Click(object sender, EventArgs e)
        {
            cOperator.Text = "/";
        }
        private void BtnMult_Click(object sender, EventArgs e)
        {
            cOperator.Text = "*";
        }
        private void BtnSub_Click(object sender, EventArgs e)
        {
            cOperator.Text = "-";
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            cOperator.Text = "+";
        }
        private void addTextToActiveTextBox(string num)
        {
            switch (activeField)
            {
                case "txtHex1":
                    txtHex1.Text += num;
                    break;
                case "txtHex2":
                    txtHex2.Text += num;
                    break;
                case "txtBin1":
                    break;
                case "txtBin2":
                    break;
                case "txtDec1":
                    break;
                case "txtDec2":
                    break;
                default:
                    MessageBox.Show("default on activeField");
                    break;
            }
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            addTextToActiveTextBox("1");
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            addTextToActiveTextBox("2");
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            addTextToActiveTextBox("3");
        }
        private void Btn4_Click(object sender, EventArgs e)
        {
            addTextToActiveTextBox("4");
        }
        private void Btn5_Click(object sender, EventArgs e)
        {
            addTextToActiveTextBox("5");
        }
        private void Btn6_Click(object sender, EventArgs e)
        {
            addTextToActiveTextBox("6");
        }
        private void Btn7_Click(object sender, EventArgs e)
        {
            addTextToActiveTextBox("7");
        }
        private void Btn8_Click(object sender, EventArgs e)
        {
            addTextToActiveTextBox("8");
        }
        private void Btn9_Click(object sender, EventArgs e)
        {
            addTextToActiveTextBox("9");
        }
        private void BtnA_Click(object sender, EventArgs e)
        {
            addTextToActiveTextBox("A");
        }
        private void BtnB_Click(object sender, EventArgs e)
        {
            addTextToActiveTextBox("B");
        }
        private void BtnC_Click(object sender, EventArgs e)
        {
            addTextToActiveTextBox("C");
        }
        private void BtnD_Click(object sender, EventArgs e)
        {
            addTextToActiveTextBox("D");
        }
        private void BtnE_Click(object sender, EventArgs e)
        {
            addTextToActiveTextBox("E");
        }
        private void BtnF_Click(object sender, EventArgs e)
        {
            addTextToActiveTextBox("F");
        }
        private void BtnCE_Click(object sender, EventArgs e)
        {
            SetFieldsToZero();
        }
        private void SetFieldsToZero()
        {
            // using the method .Clear() makes the input invalid,
            //  so the fields are set to 0 instead.

            // Clear Hex fields
            txtHex1.Text = "0";
            txtHex2.Text = "0";
            txtHexAns.Text = "0";

            // Clear Binary fields
            txtBin1.Text = "0";
            txtBin2.Text = "0";
            txtBinAns.Text = "0";

            // Clear Decimal fields
            txtDec1.Text = "0";
            txtDec2.Text = "0";
            txtDecAns.Text = "0";

        }

        private void test2(object sender, EventArgs e)
        {
            MessageBox.Show("Test Second");
        }

        private void set_txtHex1_to_active(object sender, EventArgs e)
        {
            activeField = "txtHex1";
        }
        private void set_txtHex2_to_active(object sender, EventArgs e)
        {
            activeField = "txtHex2";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetFieldsToZero();
        }
    }

}