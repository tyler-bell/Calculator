using System;
using System.Windows.Forms;

namespace Calculator {
    class Calculator1 {
        private enum Operator { Add, Subtract, Multiply, Divide, None };        //setting enum Operator with possible outcomes and None for default
        private decimal currentValue = 0;                                       //private decimal to hold currentValue                             
        private decimal operand1 = 0;                                           //private decimal to hold operand1
        private decimal operand2 = 0;                                           //private decimal to hold operand2
        private Operator op;                                                    //private Operator to hold the operator from the enum
        
        public Calculator1() {
            Op = Operator.None;                         //set Op to Operator.None to start
        }

        public decimal CurrentValue { get => currentValue; set => currentValue = value; }       //setter/getter for currentValue
        private Operator Op { get => op; set => op = value; }                                   //setter/getter for op



        /*  I finished this last week before the 27th and made minimal changes other than comments and one stupid error I noticed.
         *  Looking back over it, I blame the heat for a lot of the stupid ways I did stuff
         *  I should have at least made another method to call for each +-/* method to tidy those up
         */
         
        public void Add(decimal? displayValue) {        //method for Add receiving displayValue as a decimal or null
            if (displayValue != null) {                     //if displayValue isn't null
                if (operand1 > 0) {                             //if operand1 has a value
                    Equals(displayValue);                           //pass displayValue to Equals()
                } else {                                        //if operand1 doesn't have a value
                    operand1 = (decimal)displayValue;               //set operand1 to displayValue after casting as decimal
                    CurrentValue = (decimal)displayValue;           //set operand2 to displayValue after casting as decimal
                }
            }
            Op = Operator.Add;                              //set op to Operator.Add
        }
        
        public void Subtract(decimal? displayValue) {
            if (displayValue != null) {                     //if displayValue isn't null
                if (operand1 > 0) {                             //if operand1 has a value
                    Equals(displayValue);                           //pass displayValue to Equals()
                } else {                                        //if operand1 doesn't have a value
                    operand1 = (decimal)displayValue;               //set operand1 to displayValue after casting as decimal
                    CurrentValue = (decimal)displayValue;           //set operand2 to displayValue after casting as decimal
                }
            }
            Op = Operator.Subtract;                              //set op to Operator.Subtract
        }

        public void Multiply(decimal? displayValue) {
            if (displayValue != null) {                     //if displayValue isn't null
                if (operand1 > 0) {                             //if operand1 has a value
                    Equals(displayValue);                           //pass displayValue to Equals()
                } else {                                        //if operand1 doesn't have a value
                    operand1 = (decimal)displayValue;               //set operand1 to displayValue after casting as decimal
                    CurrentValue = (decimal)displayValue;           //set operand2 to displayValue after casting as decimal
                }
            }
            Op = Operator.Multiply;                              //set op to Operator.Multiply
        }

        public void Divide(decimal? displayValue) {
            if (displayValue != null) {                     //if displayValue isn't null
                if (operand1 > 0) {                             //if operand1 has a value
                    Equals(displayValue);                           //pass displayValue to Equals()
                } else {                                        //if operand1 doesn't have a value
                    operand1 = (decimal)displayValue;               //set operand1 to displayValue after casting as decimal
                    CurrentValue = (decimal)displayValue;           //set operand2 to displayValue after casting as decimal
                }
            }
            Op = Operator.Divide;                              //set op to Operator.Divide
        }

        public void Equals() {                              //equals method when both operand1 and operand2 have values
            switch (Op) {                                       //switch case based on what op is set to
                case Operator.Add:                                  //if op is Operator.Add
                    operand1 = operand1 + operand2;                     //store result as operand1
                    CurrentValue = operand1;                            //set currentValue to operand1
                    break;
                case Operator.Subtract:                             //if op is Operator.Subtract
                    operand1 = operand1 - operand2;                     //store result as operand1
                    CurrentValue = operand1;                            //set currentValue to operand1
                    break;
                case Operator.Multiply:                             //if op is Operator.Multiply
                    operand1 = operand1 * operand2;                     //store result as operand1
                    CurrentValue = operand1;                            //set currentValue to operand1
                    break;
                case Operator.Divide:                               //if op is Operator.Divide
                    operand1 = operand1 / operand2;                     //store result as operand1
                    CurrentValue = operand1;                            //set currentValue to operand1
                    break;
                case Operator.None:                                 //if op is Operator.None
                    break;
            }
        }
        public void Equals(decimal? displayValue) {         //equals method accepting a decimal or null
            if (displayValue != null) {                         //if displayValue isn't null
                operand2 = (decimal)displayValue;                   //set operand2 as displayValue casted as decimal
            }
            if (operand2 == 0) {                                //if operand2 is zero and display is null (allows you to go 5+=10 and instead of 5+5=10)
                operand2 = operand1;                                //set operand2 to operand1
            }   
            Equals();                                       //call Equals()
        }

        public void SquareRoot(decimal? displayValue) {     //method for SquareRoot accepting decimal or null
            Op = Operator.None;                                 //set op to Operator.None
            if (displayValue != null) {                         //if displayValue isn't null
                double temp = (double)displayValue;                 //create a double called temp and set as displayValue cast as double
                CurrentValue = (decimal)Math.Sqrt(temp);            //set currentValue to the Sqrt of temp using Math and cast as decimal
            } else {                                            //if displayValue is null
                double temp = (double)CurrentValue;                 //create a double called temp and set as displayValue cast as double
                CurrentValue = (decimal)Math.Sqrt(temp);            //set currentValue to the Sqrt of temp using Math and cast as decimal
            }
            operand1 = CurrentValue;                            //set operand1 to currentValue
        }

        public void Reciprocal(decimal? displayValue) {     //method for Reciprocal accepting decimal or null
            Op = Operator.None;                                 //set op to Operator.None
            if (displayValue != null) {                         //if displayValue isn't null
                CurrentValue = 1/ (decimal)displayValue;            //set currentValue as 1 divided by the displayValue cast as a decimal
            } else {                                            //if displayValue is null
                CurrentValue = 1/CurrentValue;                      //set currentValue as 1 divided by the currentValue
            }
            operand1 = CurrentValue;                            //set operand1 to currentValue
        }
        
        public void Clear() {                           //method to clear stored values
            CurrentValue = 0;                               //set currentValue to 0
            operand1 = 0;                                   //set operand1 to 0
            operand2 = 0;                                   //set operand2 to 0
        }

    
    }
}
