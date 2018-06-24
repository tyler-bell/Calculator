using System;
using System.Windows.Forms;

namespace Calculator {
    public partial class Calculator : Form {

        private string display = null;
        private bool newNumberFlag = true;
        private int errorFlag = 0;

        private Calculator1 calculon = new Calculator1();
        public Calculator() {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(form_key);                      //keypress events for the form
            this.displayBox.Enter += new EventHandler(displayBox_Enter);        //keeps the focus out of the displaybox, hate that ugly blip
            UpdateDisplay();
        }

        private void displayBox_Enter(object sender, EventArgs e) {             //method to prevent displaybox from being select
            displayBox.Enabled = false;                                         //disables textbox so focus is pushed away
            displayBox.Enabled = true;                                          //reenables textbox
        }

        private void UpdateDisplay() {
            if (newNumberFlag == true) {
                display = null;
                switch (errorFlag) {
                    case 1:
                        displayBox.Text = "Can't divide by zero.";
                        errorFlag = 0;
                        break;
                    case 2:
                        displayBox.Text = "Overflow error.";
                        errorFlag = 0;
                        break;
                    default:
                        displayBox.Text = calculon.CurrentValue.ToString("G25");
                        break;
                }
            } else {
                int length = display.Length;
                if (length > 25) {
                   display = display.Substring(0, 25);
                }
                displayBox.Text = display;
            }
            EqualsButton.Focus();
        }

        private void addButton_Click(object sender, EventArgs e) {
            calculon.Add(VerifyNumber());
            newNumberFlag = true;
            UpdateDisplay();
        }

        private void subtractButton_Click(object sender, EventArgs e) {
            calculon.Subtract(VerifyNumber());
            newNumberFlag = true;
            UpdateDisplay();
        }


        private void multiplyButton_Click(object sender, EventArgs e) {
            calculon.Multiply(VerifyNumber());
            newNumberFlag = true;
            UpdateDisplay();
        }

        private void divisionButton_Click(object sender, EventArgs e) {
            calculon.Divide(VerifyNumber());
            newNumberFlag = true;
            UpdateDisplay();
        }
        private void equalsButton_Click(object sender, EventArgs e) {
            if (display == "5318008") {
                Form2 f2 = new Form2();
                f2.Show();
            } else {
                Decimal.TryParse(display, out decimal temp);
                try {
                    calculon.Equals(VerifyNumber());
                } catch (DivideByZeroException) {
                    errorFlag = 1;
                    calculon.Clear();
                } catch (OverflowException) {
                    errorFlag = 2;
                    calculon.Clear();
                }
                newNumberFlag = true;
                UpdateDisplay();
            }
        }
        private decimal? VerifyNumber() {
            if (display == null) {
                decimal? temp2 = null;
                return temp2;
            } else {
                Decimal.TryParse(display, out decimal temp);
                return temp;
            }
        }
        private void backButton_Click(object sender, EventArgs e) {
            if (display != null) {
                if (display.Length <= 1) {
                    newNumberFlag = true;
                } else {
                    display = display.Remove(display.Length - 1, 1);
                }
            }
            UpdateDisplay();
        }
        private void ClearEntry_Click(object sender, EventArgs e) {
            display = "0";
            //UpdateDisplay();    //can't use UpdateDisplay because newNumberFlag forces display back to zero, bad coding :(
            displayBox.Text = display;
            newNumberFlag = true;
        }

        private void clearButton_Click(object sender, EventArgs e) {
            calculon.Clear();
            display = "0";
            newNumberFlag = true;
            UpdateDisplay();
        }

        private void sevenButton_Click(object sender, EventArgs e) {
            if (newNumberFlag == true) {
                display = "7";
                newNumberFlag = false;
            } else {
                display += "7";
            }
            UpdateDisplay();
        }

        private void eightButton_Click(object sender, EventArgs e) {
            if (newNumberFlag == true) {
                display = "8";
                newNumberFlag = false;
            } else {
                display += "8";
            }
            UpdateDisplay();
        }

        private void nineButton_Click(object sender, EventArgs e) {
            if (newNumberFlag == true) {
                display = "9";
                newNumberFlag = false;
            } else {
                display += "9";
            }
            UpdateDisplay();
        }

        private void fourButton_Click(object sender, EventArgs e) {
            if (newNumberFlag == true) {
                display = "4";
                newNumberFlag = false;
            } else {
                display += "4";
            }
            UpdateDisplay();
        }

        private void fiveButton_Click(object sender, EventArgs e) {
            if (newNumberFlag == true) {
                display = "5";
                newNumberFlag = false;
            } else {
                display += "5";
            }
            UpdateDisplay();
        }

        private void sixButton_Click(object sender, EventArgs e) {
            if (newNumberFlag == true) {
                display = "6";
                newNumberFlag = false;
            } else {
                display += "6";
            }
            UpdateDisplay();
        }

        private void oneButton_Click(object sender, EventArgs e) {
            if (newNumberFlag == true) {
                display = "1";
                newNumberFlag = false;
            } else {
                display += "1";
            }
            UpdateDisplay();
        }

        private void twoButton_Click(object sender, EventArgs e) {
            if (newNumberFlag == true) {
                display = "2";
                newNumberFlag = false;
            } else {
                display += "2";
            }
            UpdateDisplay();
        }

        private void threeButton_Click(object sender, EventArgs e) {
            if (newNumberFlag == true) {
                display = "3";
                newNumberFlag = false;
            } else {
                display += "3";
            }
            UpdateDisplay();
        }

        private void zeroButton_Click(object sender, EventArgs e) {
            if (newNumberFlag == true) {
                display = "0";
                newNumberFlag = false;
            } else {
                display += "0";
            }
            UpdateDisplay();
        }

        private void decimalButton_Click(object sender, EventArgs e) {
            if (newNumberFlag == true) {
                display = "0.";
                newNumberFlag = false;
            } else if (display.Contains(".") == false) {
                display += ".";
            }
            UpdateDisplay();
        }

        private void plusMinusButton_Click(object sender, EventArgs e) {
            decimal flip = Decimal.Parse(display);
            if (Decimal.Parse(display) > 0) {
                flip = flip - flip * 2;
            } else if (flip < 0) {
                flip = flip - flip * 2;
            }
            display = flip.ToString();
            UpdateDisplay();
        }

        private void sqrtButton_Click(object sender, EventArgs e) {
            calculon.SquareRoot(VerifyNumber());
            newNumberFlag = true;
            UpdateDisplay();
        }

        private void oneTenthButton_Click(object sender, EventArgs e) {
            try {
                calculon.Reciprocal(VerifyNumber());
            } catch (DivideByZeroException) {
                errorFlag = 1;
                calculon.Clear();
            }
            newNumberFlag = true;
            UpdateDisplay();
        }

        private void form_key(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Return:
                    equalsButton_Click(this, new EventArgs());
                    break;
                case Keys.NumPad0:
                case Keys.D0:
                    zeroButton_Click(this, new EventArgs());
                    break;
                case Keys.NumPad1:
                case Keys.D1:
                    oneButton_Click(this, new EventArgs());
                    break;
                case Keys.NumPad2:
                case Keys.D2:
                    twoButton_Click(this, new EventArgs());
                    break;
                case Keys.NumPad3:
                case Keys.D3:
                    threeButton_Click(this, new EventArgs());
                    break;
                case Keys.NumPad4:
                case Keys.D4:
                    fourButton_Click(this, new EventArgs());
                    break;
                case Keys.NumPad5:
                case Keys.D5:
                    fiveButton_Click(this, new EventArgs());
                    break;
                case Keys.NumPad6:
                case Keys.D6:
                    sixButton_Click(this, new EventArgs());
                    break;
                case Keys.NumPad7:
                case Keys.D7:
                    sevenButton_Click(this, new EventArgs());
                    break;
                case Keys.NumPad8:
                case Keys.D8:
                    eightButton_Click(this, new EventArgs());
                    break;
                case Keys.NumPad9:
                case Keys.D9:
                    nineButton_Click(this, new EventArgs());
                    break;
                case Keys.Divide:
                    divisionButton_Click(this, new EventArgs());
                    break;
                case Keys.Add:
                    addButton_Click(this, new EventArgs());
                    break;
                case Keys.Subtract:
                    subtractButton_Click(this, new EventArgs());
                    break;
                case Keys.Multiply:
                    multiplyButton_Click(this, new EventArgs());
                    break;
                case Keys.Back:
                    backButton_Click(this, new EventArgs());
                    break;
                case Keys.Decimal:
                    decimalButton_Click(this, new EventArgs());
                    break;
            }

           
        }


    }
}
