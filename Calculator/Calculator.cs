using System;
using System.Windows.Forms;

namespace Calculator {
    class Calculator1 {
        private enum Operator { Add='+', Subtract='-', Multiply='*', Divide='/', None };
        private decimal currentValue = 0;
        private decimal operand1 = 0;
        private decimal operand2 = 0;
        private Operator op;
        
        public Calculator1() {
            Op = Operator.None;
        }

        public decimal CurrentValue { get => currentValue; set => currentValue = value; }

        private Operator Op { get => op; set => op = value; }

        public void Add(decimal? displayValue) {
            if (displayValue != null) {
                if (operand1 > 0) {
                    Equals(displayValue);
                } else {
                    operand1 = (decimal)displayValue;
                    CurrentValue = (decimal)displayValue;
                }
            }
            Op = Operator.Add;
        }
        
        public void Subtract(decimal? displayValue) {
            if (displayValue != null) {
                if (operand1 > 0) {
                    Equals(displayValue);
                } else {
                    operand1 = (decimal)displayValue;
                    CurrentValue = (decimal)displayValue;
                }
            }
            Op = Operator.Subtract;
        }
        public void Multiply(decimal? displayValue) {
            if (displayValue != null) {
                if (operand1 > 0) {
                    Equals(displayValue);
                } else {
                    operand1 = (decimal)displayValue;
                    CurrentValue = (decimal)displayValue;
                }
            }
            Op = Operator.Multiply;
        }
        public void Divide(decimal? displayValue) {
            if (displayValue != null) {
                if (operand1 > 0) {
                    Equals(displayValue);
                } else {
                    operand1 = (decimal)displayValue;
                    CurrentValue = (decimal)displayValue;
                }
            }
            Op = Operator.Divide;
        }
        public void Equals() {
            switch (Op) {
                case Operator.Add:
                    operand1 = operand1 + operand2;
                    CurrentValue = operand1;
                    break;
                case Operator.Subtract:
                    operand1 = operand1 - operand2;
                    CurrentValue = operand1;
                    break;
                case Operator.Multiply:
                    operand1 = operand1 * operand2;
                    CurrentValue = operand1;
                    break;
                case Operator.Divide:
                    operand1 = operand1 / operand2;
                    CurrentValue = operand1;
                    break;
                case Operator.None:
                    MessageBox.Show("OP set to none (should never see this)");
                    break;
            }
        }
        public void Equals(decimal? displayValue) {
            if (displayValue != null) {
                operand2 = (decimal)displayValue;
            }
            if (operand2 == 0) {
                operand2 = operand1;
            }
            Equals();
        }

        public void SquareRoot(decimal? displayValue) {
            Op = Operator.None;
            if (displayValue != null) {
                double temp = (double)displayValue;
                CurrentValue = (decimal)Math.Sqrt(temp);
            } else {
                double temp = (double)CurrentValue;
                CurrentValue = (decimal)Math.Sqrt(temp);
            }
            operand1 = CurrentValue;
        }

        public void Reciprocal(decimal? displayValue) {
            Op = Operator.None;
            if (displayValue != null) {
                CurrentValue = 1/ (decimal)displayValue;
            } else {
                CurrentValue = 1/CurrentValue;
            }
            operand1 = CurrentValue;
        }
        
        public void Clear() {
            CurrentValue = 0;
            operand1 = 0;
            operand2 = 0;
        }

    
    }
}
