using System;
using System.Windows.Forms;

namespace Calculator {
    public partial class Calculator : Form {

        private string display = null;                      //set display string to null
        private bool newNumberFlag = true;                  //set newNumberFlag to true
        private int errorFlag = 0;                          //set errorFlag to 0

        private Calculator1 calculon = new Calculator1();
        public Calculator() {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(form_key);                      //keypress events for the form
            this.displayBox.Enter += new EventHandler(displayBox_Enter);        //keeps the focus out of the displaybox, hate that ugly blip
            UpdateDisplay();                                                    //update display to set it to 0
        }

        private void displayBox_Enter(object sender, EventArgs e) {         //method to prevent displaybox from being select
            displayBox.Enabled = false;                                         //disables textbox so focus is pushed away
            displayBox.Enabled = true;                                          //reenables textbox
        }

        private void UpdateDisplay() {
            if (newNumberFlag == true) {                                //if newNumberFlag is true
                display = null;                                             //clear the display field
                switch (errorFlag) {                                        //if there is an error
                    case 1:                                                     //first error
                        displayBox.Text = "Can't divide by zero.";                  //display error
                        errorFlag = 0;                                              //reset error flag
                        break;
                    case 2:                                                     //second error
                        displayBox.Text = "Overflow error.";                        //display error
                        errorFlag = 0;                                              //reset flag
                        break;
                    default:                                                    //if no error
                        displayBox.Text = calculon.CurrentValue.ToString("G23");    //otherwise display value up to 23 values
                        break;                                                      
                }
            } else {                                                    //if newNumberFlag is false
                if (display.Length > 23) {                                  //if display is greater than 23
                   display = display.Substring(0, 23);                      //trim to 23 characters
                }
                displayBox.Text = display;                              //set displayBox.Text to display
            }
            EqualsButton.Focus();               //focus on EqualsButton
        }

        private void addButton_Click(object sender, EventArgs e) {  //method for addButton
            calculon.Add(VerifyNumber());                               //pass value returned from VerifyNumber to calculon.Add()
            newNumberFlag = true;                                       //set newNumberFlag to true
            UpdateDisplay();                                            //update display
        }

        private void subtractButton_Click(object sender, EventArgs e) { //method for subtractButton
            calculon.Subtract(VerifyNumber());                              //pass value returned from VerifyNumber to calculon.Subtract()
            newNumberFlag = true;                                           //set newNumberFlag to true
            UpdateDisplay();                                                //update display
        }


        private void multiplyButton_Click(object sender, EventArgs e) { //method for multiplyButton
            calculon.Multiply(VerifyNumber());                              //pass value returned from VerifyNumber to calculon.Multiply()
            newNumberFlag = true;                                           //set newNumber flag to true
            UpdateDisplay();                                                //update display
        }

        private void divisionButton_Click(object sender, EventArgs e) { //method for divisionButton
            calculon.Divide(VerifyNumber());                                //pass value returned from VerifyNumber to calculon.Divide()
            newNumberFlag = true;                                           //set newNumberFlag to true
            UpdateDisplay();                                                //update display
        }
        private void equalsButton_Click(object sender, EventArgs e) {   //method for equalsButton
            if (display == "5318008") {                                     //easter egg, if display equals 5318008
                Form2 f2 = new Form2();                                     //create Form2 object called f2
                f2.Show();                                                  //show f2
            } else {                                                    //otherwise
                Decimal.TryParse(display, out decimal temp);                //parse display as a decimal and output as temp
                try {                                                           //try to equals, catching exceptions
                    calculon.Equals(VerifyNumber());                                //pass value returned from VerifyNumber to calculon.Equals()
                } catch (DivideByZeroException) {                               //catch DivideByZero exceptions
                    errorFlag = 1;                                                  //set errorFlag to 1 to display error
                    calculon.Clear();                                               //call Calculon.Clear() to clear any stored values
                } catch (OverflowException) {                                   //catch OverFlowException
                    errorFlag = 2;                                                  //set errorFlag to 2 to display error
                    calculon.Clear();                                               //call Calculon.Clear() to clear any stored values
                }
                newNumberFlag = true;                                       //set newNumberFlag to true
                UpdateDisplay();                                            //update display
            }
        }
        private decimal? VerifyNumber() {       //method to verify number returning a decimal with possibility of null
            if (display == null) {                  //if display is null
                decimal? temp2 = null;                  //create a decimal called temp2, but leave it null
                return temp2;                           //return temp2
            } else {                                //if display isn't null
                Decimal.TryParse(display, out decimal temp);    //parse display as a deciaml and output as temp
                return temp;                             //return temp
            }

        }
        private void backButton_Click(object sender, EventArgs e) {     //method for back button
            if (display != null) {                                          //if display isn't null
                if (display.Length <= 1) {                                      //if display length is less than or equal to 1
                    newNumberFlag = true;                                           //set newNumberFlag to true (UpdateDisplay() will clear the value since we only have 1 digit)
                } else {                                                        //if display length is greater than 1
                    display = display.Remove(display.Length - 1, 1);                //remove the last character from display
                }
            }
            UpdateDisplay();                                                //update display
        }
        private void ClearEntry_Click(object sender, EventArgs e) {     //method for clear entry button
            display = "0";                                                  //set display to zero
            displayBox.Text = display;                                      //set displayBox.Text to display
            newNumberFlag = true;                                           //set newNumberFlag to true
        }

        private void clearButton_Click(object sender, EventArgs e) {    //method for clear button
            calculon.Clear();                                               //call calculon.Clear() to clear stored values
            display = "0";                                                  //set display to zero
            newNumberFlag = true;                                           //set newNumberFlag to true
            UpdateDisplay();                                                //update display
        }

        private void sevenButton_Click(object sender, EventArgs e) {    //method for number 7 button
            if (newNumberFlag == true) {                                    //if newNumberFlag is true
                display = "7";                                                  //set display to 7
                newNumberFlag = false;                                          //set newNumberFlag to false
            } else {                                                        //if newNumberFlag is false
                display += "7";                                                 //add 7 to the display string
            }
            UpdateDisplay();                                                //update display
        }

        private void eightButton_Click(object sender, EventArgs e) {    //method for number 8 button
            if (newNumberFlag == true) {                                    //if newNumberFlag is true
                display = "8";                                                  //set display to 8
                newNumberFlag = false;                                          //set newNumberFlag to false
            } else {                                                        //if newNumberFlag is false
                display += "8";                                                 //add 8 to the display string
            }
            UpdateDisplay();                                                //update display
        }

        private void nineButton_Click(object sender, EventArgs e) {     //method for number 9 button
            if (newNumberFlag == true) {                                    //if newNumberFlag is true
                display = "9";                                                  //set display to 9
                newNumberFlag = false;                                          //set newNumberFlag to false
            } else {                                                        //if newNumberFlag is false
                display += "9";                                                 //add 9 to the display string
            }
            UpdateDisplay();                                                //update display
        }

        private void fourButton_Click(object sender, EventArgs e) {    //method for number 4 button
            if (newNumberFlag == true) {                                    //if newNumberFlag is true
                display = "4";                                                  //set display to 4
                newNumberFlag = false;                                          //set newNumberFlag to false
            } else {                                                        //if newNumberFlag is false
                display += "4";                                                 //add 4 to the display string
            }
            UpdateDisplay();                                                //update display
        }

        private void fiveButton_Click(object sender, EventArgs e) {    //method for number 5 button
            if (newNumberFlag == true) {                                    //if newNumberFlag is true
                display = "5";                                                  //set display to 5
                newNumberFlag = false;                                          //set newNumberFlag to false
            } else {                                                        //if newNumberFlag is false
                display += "5";                                                 //add 5 to the display string
            }
            UpdateDisplay();                                                //update display
        }

        private void sixButton_Click(object sender, EventArgs e) {    //method for number 6 button
            if (newNumberFlag == true) {                                    //if newNumberFlag is true
                display = "6";                                                  //set display to 6
                newNumberFlag = false;                                          //set newNumberFlag to false
            } else {                                                        //if newNumberFlag is false
                display += "6";                                                 //add 6 to the display string
            }
            UpdateDisplay();                                                //update display
        }

        private void oneButton_Click(object sender, EventArgs e) {    //method for number 1 button
            if (newNumberFlag == true) {                                    //if newNumberFlag is true
                display = "1";                                                  //set display to 1
                newNumberFlag = false;                                          //set newNumberFlag to false
            } else {                                                        //if newNumberFlag is false
                display += "1";                                                 //add 1 to the display string
            }
            UpdateDisplay();                                                //update display
        }


        private void twoButton_Click(object sender, EventArgs e) {    //method for number 2 button
            if (newNumberFlag == true) {                                    //if newNumberFlag is true
                display = "2";                                                  //set display to 2
                newNumberFlag = false;                                          //set newNumberFlag to false
            } else {                                                        //if newNumberFlag is false
                display += "2";                                                 //add 2 to the display string
            }
            UpdateDisplay();                                                //update display
        }

        private void threeButton_Click(object sender, EventArgs e) {    //method for number 3 button
            if (newNumberFlag == true) {                                    //if newNumberFlag is true
                display = "3";                                                  //set display to 3
                newNumberFlag = false;                                          //set newNumberFlag to false
            } else {                                                        //if newNumberFlag is false
                display += "3";                                                 //add 3 to the display string
            }
            UpdateDisplay();                                                //update display
        }


        private void zeroButton_Click(object sender, EventArgs e) {    //method for number 0 button
            if (newNumberFlag == true) {                                    //if newNumberFlag is true
                display = "0";                                                  //set display to 0
                newNumberFlag = false;                                          //set newNumberFlag to false
            } else {                                                        //if newNumberFlag is false
                display += "0";                                                 //add 0 to the display string
            }
            UpdateDisplay();                                                //update display
        }

        private void decimalButton_Click(object sender, EventArgs e) {  //method for decimal button
            if (newNumberFlag == true) {                                    //if newNumberFlag is true
                display = "0.";                                                 //set display to 0.
                newNumberFlag = false;                                          //set newNumberFlag to false
            } else if (display.Contains(".") == false) {                    //if display doesn't already contain a decimal
                display += ".";                                                 //add a decimal to display string
            }
            UpdateDisplay();                                                //update display
        }

        private void plusMinusButton_Click(object sender, EventArgs e) {    //method for plus minus button
            Decimal.TryParse(display, out decimal flip);                        //try to parse display and output as decimal called flip
            flip = flip - flip * 2;                                             //flip sign by subtracting flip*2 from itself (5-5*2 = 5-10 = -5) 
            display = flip.ToString();                                          //set display as flip after converting to a string
            UpdateDisplay();                                                    //update display
        }

        private void sqrtButton_Click(object sender, EventArgs e) {     //method for square root
            calculon.SquareRoot(VerifyNumber());                            //pass value returned from VerifyNumber to calculon.SquareRoot
            newNumberFlag = true;                                           //set newNumberFlag to true
            UpdateDisplay();                                                //update display
        }

        private void oneTenthButton_Click(object sender, EventArgs e) {     //method for reciprocal (didn't know what it was called at first)
            try {                                                               //trys to use reciprocal catching DivideByZero exception
                calculon.Reciprocal(VerifyNumber());                                //pass value returned from VerifyNumber to calculon.Reciprocal
            } catch (DivideByZeroException) {                                   //catch DivideByZero exception
                errorFlag = 1;                                                      //set errorFlag to 1 to display error
                calculon.Clear();                                                   //clear stored values
            }   
            newNumberFlag = true;                                               //set newNumberFlag to true
            UpdateDisplay();                                                    //update display
        }

        private void form_key(object sender, KeyEventArgs e) {       //method for catching keypresses
            switch (e.KeyCode) {
                case Keys.Escape:                                       //escape button
                    this.Close();                                           //closes calculator
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
