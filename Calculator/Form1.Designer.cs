namespace Calculator {
    partial class Calculator {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.SqrtButton = new System.Windows.Forms.Button();
            this.ReciprocalButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.PlusMinusButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.TextBox();
            this.ClearEntryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.ForeColor = System.Drawing.Color.Red;
            this.btnCalculate.Location = new System.Drawing.Point(12, 38);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(102, 30);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.TabStop = false;
            this.btnCalculate.Text = "Back";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.ForeColor = System.Drawing.Color.Red;
            this.ClearButton.Location = new System.Drawing.Point(156, 38);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(30, 30);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.TabStop = false;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.ForeColor = System.Drawing.Color.Blue;
            this.SevenButton.Location = new System.Drawing.Point(12, 74);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(30, 30);
            this.SevenButton.TabIndex = 3;
            this.SevenButton.TabStop = false;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightButton.ForeColor = System.Drawing.Color.Blue;
            this.EightButton.Location = new System.Drawing.Point(48, 74);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(30, 30);
            this.EightButton.TabIndex = 4;
            this.EightButton.TabStop = false;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideButton.ForeColor = System.Drawing.Color.Red;
            this.DivideButton.Location = new System.Drawing.Point(120, 74);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(30, 30);
            this.DivideButton.TabIndex = 6;
            this.DivideButton.TabStop = false;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineButton.ForeColor = System.Drawing.Color.Blue;
            this.NineButton.Location = new System.Drawing.Point(84, 74);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(30, 30);
            this.NineButton.TabIndex = 5;
            this.NineButton.TabStop = false;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // SqrtButton
            // 
            this.SqrtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqrtButton.Location = new System.Drawing.Point(156, 74);
            this.SqrtButton.Name = "SqrtButton";
            this.SqrtButton.Size = new System.Drawing.Size(30, 30);
            this.SqrtButton.TabIndex = 7;
            this.SqrtButton.TabStop = false;
            this.SqrtButton.Text = "sqrt";
            this.SqrtButton.UseVisualStyleBackColor = true;
            this.SqrtButton.Click += new System.EventHandler(this.sqrtButton_Click);
            // 
            // ReciprocalButton
            // 
            this.ReciprocalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReciprocalButton.ForeColor = System.Drawing.Color.Blue;
            this.ReciprocalButton.Location = new System.Drawing.Point(156, 110);
            this.ReciprocalButton.Name = "ReciprocalButton";
            this.ReciprocalButton.Size = new System.Drawing.Size(30, 30);
            this.ReciprocalButton.TabIndex = 12;
            this.ReciprocalButton.TabStop = false;
            this.ReciprocalButton.Text = "1/x";
            this.ReciprocalButton.UseVisualStyleBackColor = true;
            this.ReciprocalButton.Click += new System.EventHandler(this.oneTenthButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyButton.ForeColor = System.Drawing.Color.Red;
            this.MultiplyButton.Location = new System.Drawing.Point(120, 110);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(30, 30);
            this.MultiplyButton.TabIndex = 11;
            this.MultiplyButton.TabStop = false;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixButton.ForeColor = System.Drawing.Color.Blue;
            this.SixButton.Location = new System.Drawing.Point(84, 110);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(30, 30);
            this.SixButton.TabIndex = 10;
            this.SixButton.TabStop = false;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveButton.ForeColor = System.Drawing.Color.Blue;
            this.FiveButton.Location = new System.Drawing.Point(48, 110);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(30, 30);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.TabStop = false;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourButton.ForeColor = System.Drawing.Color.Blue;
            this.FourButton.Location = new System.Drawing.Point(12, 110);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(30, 30);
            this.FourButton.TabIndex = 8;
            this.FourButton.TabStop = false;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualsButton.ForeColor = System.Drawing.Color.Red;
            this.EqualsButton.Location = new System.Drawing.Point(156, 146);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(30, 64);
            this.EqualsButton.TabIndex = 17;
            this.EqualsButton.TabStop = false;
            this.EqualsButton.Text = "&=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractButton.ForeColor = System.Drawing.Color.Red;
            this.SubtractButton.Location = new System.Drawing.Point(120, 146);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(30, 30);
            this.SubtractButton.TabIndex = 16;
            this.SubtractButton.TabStop = false;
            this.SubtractButton.Text = "-";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeButton.ForeColor = System.Drawing.Color.Blue;
            this.ThreeButton.Location = new System.Drawing.Point(84, 146);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(30, 30);
            this.ThreeButton.TabIndex = 15;
            this.ThreeButton.TabStop = false;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoButton.ForeColor = System.Drawing.Color.Blue;
            this.TwoButton.Location = new System.Drawing.Point(48, 146);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(30, 30);
            this.TwoButton.TabIndex = 14;
            this.TwoButton.TabStop = false;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneButton.ForeColor = System.Drawing.Color.Blue;
            this.OneButton.Location = new System.Drawing.Point(12, 146);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(30, 30);
            this.OneButton.TabIndex = 13;
            this.OneButton.TabStop = false;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.Red;
            this.AddButton.Location = new System.Drawing.Point(120, 182);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(30, 30);
            this.AddButton.TabIndex = 21;
            this.AddButton.TabStop = false;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecimalButton.ForeColor = System.Drawing.Color.Blue;
            this.DecimalButton.Location = new System.Drawing.Point(84, 182);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(30, 30);
            this.DecimalButton.TabIndex = 20;
            this.DecimalButton.TabStop = false;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = true;
            this.DecimalButton.Click += new System.EventHandler(this.decimalButton_Click);
            // 
            // PlusMinusButton
            // 
            this.PlusMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusMinusButton.ForeColor = System.Drawing.Color.Blue;
            this.PlusMinusButton.Location = new System.Drawing.Point(48, 182);
            this.PlusMinusButton.Name = "PlusMinusButton";
            this.PlusMinusButton.Size = new System.Drawing.Size(30, 30);
            this.PlusMinusButton.TabIndex = 19;
            this.PlusMinusButton.TabStop = false;
            this.PlusMinusButton.Text = "+/-";
            this.PlusMinusButton.UseVisualStyleBackColor = true;
            this.PlusMinusButton.Click += new System.EventHandler(this.plusMinusButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.ForeColor = System.Drawing.Color.Blue;
            this.ZeroButton.Location = new System.Drawing.Point(12, 182);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(30, 30);
            this.ZeroButton.TabIndex = 18;
            this.ZeroButton.TabStop = false;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // displayBox
            // 
            this.displayBox.Location = new System.Drawing.Point(12, 12);
            this.displayBox.Name = "displayBox";
            this.displayBox.ReadOnly = true;
            this.displayBox.Size = new System.Drawing.Size(174, 20);
            this.displayBox.TabIndex = 23;
            this.displayBox.TabStop = false;
            this.displayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.displayBox.WordWrap = false;
            // 
            // ClearEntryButton
            // 
            this.ClearEntryButton.ForeColor = System.Drawing.Color.Red;
            this.ClearEntryButton.Location = new System.Drawing.Point(120, 38);
            this.ClearEntryButton.Name = "ClearEntryButton";
            this.ClearEntryButton.Size = new System.Drawing.Size(30, 30);
            this.ClearEntryButton.TabIndex = 24;
            this.ClearEntryButton.TabStop = false;
            this.ClearEntryButton.Text = "CE";
            this.ClearEntryButton.UseVisualStyleBackColor = true;
            this.ClearEntryButton.Click += new System.EventHandler(this.ClearEntry_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 222);
            this.Controls.Add(this.ClearEntryButton);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DecimalButton);
            this.Controls.Add(this.PlusMinusButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.ReciprocalButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.SqrtButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.btnCalculate);
            this.ForeColor = System.Drawing.Color.Red;
            this.KeyPreview = true;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button SqrtButton;
        private System.Windows.Forms.Button ReciprocalButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button PlusMinusButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.TextBox displayBox;
        private System.Windows.Forms.Button ClearEntryButton;
    }
}

