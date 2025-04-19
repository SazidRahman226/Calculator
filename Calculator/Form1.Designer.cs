namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonClear = new Button();
            button0 = new Button();
            buttonAdd = new Button();
            buttonDivide = new Button();
            buttonSubtract = new Button();
            buttonMultiply = new Button();
            buttonEqual = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.AccessibleName = "textbox";
            textBox.BackColor = SystemColors.ControlLightLight;
            textBox.Location = new Point(12, 12);
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.Size = new Size(237, 23);
            textBox.TabIndex = 0;
            textBox.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 41);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(93, 41);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(174, 41);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 70);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(93, 70);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(173, 70);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 99);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(93, 99);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(174, 99);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(9, 219);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(236, 23);
            buttonClear.TabIndex = 10;
            buttonClear.Text = "clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += button10_Click;
            // 
            // button0
            // 
            button0.Location = new Point(93, 132);
            button0.Name = "button0";
            button0.Size = new Size(75, 23);
            button0.TabIndex = 11;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button11_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(93, 161);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 52);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(174, 132);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(75, 23);
            buttonDivide.TabIndex = 13;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Location = new Point(12, 132);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(75, 23);
            buttonSubtract.TabIndex = 14;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = true;
            buttonSubtract.Click += buttonSubtract_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(12, 161);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(75, 23);
            buttonMultiply.TabIndex = 15;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.Location = new Point(174, 161);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(75, 52);
            buttonEqual.TabIndex = 16;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // button10
            // 
            button10.Location = new Point(12, 190);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 17;
            button10.Text = ".";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 251);
            Controls.Add(button10);
            Controls.Add(buttonEqual);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonSubtract);
            Controls.Add(buttonDivide);
            Controls.Add(buttonAdd);
            Controls.Add(button0);
            Controls.Add(buttonClear);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonClear;
        private Button button0;
        private Button buttonAdd;
        private Button buttonDivide;
        private Button buttonSubtract;
        private Button buttonMultiply;
        private Button buttonEqual;
        private Button button10;
    }
}
