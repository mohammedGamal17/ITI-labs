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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn0 = new Button();
            btnPlus = new Button();
            btnMin = new Button();
            btnDiv = new Button();
            btnMul = new Button();
            btnEqual = new Button();
            input = new TextBox();
            output = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 450);
            btn1.Name = "btn1";
            btn1.Size = new Size(71, 73);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(89, 450);
            btn2.Name = "btn2";
            btn2.Size = new Size(71, 73);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(166, 450);
            btn3.Name = "btn3";
            btn3.Size = new Size(71, 73);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button3_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(166, 371);
            btn6.Name = "btn6";
            btn6.Size = new Size(71, 73);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += button6_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(89, 371);
            btn5.Name = "btn5";
            btn5.Size = new Size(71, 73);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += button5_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 371);
            btn4.Name = "btn4";
            btn4.Size = new Size(71, 73);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += button4_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(166, 292);
            btn9.Name = "btn9";
            btn9.Size = new Size(71, 73);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += button9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(89, 292);
            btn8.Name = "btn8";
            btn8.Size = new Size(71, 73);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += button8_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 292);
            btn7.Name = "btn7";
            btn7.Size = new Size(71, 73);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button7_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(250, 452);
            btn0.Name = "btn0";
            btn0.Size = new Size(81, 71);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += button0_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(250, 371);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(81, 73);
            btnPlus.TabIndex = 11;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += buttonPlus_Click;
            // 
            // btnMin
            // 
            btnMin.Location = new Point(348, 371);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(80, 73);
            btnMin.TabIndex = 12;
            btnMin.Text = "-";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += buttonSub_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(348, 292);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(80, 73);
            btnDiv.TabIndex = 14;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += buttonDiv_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(250, 292);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(81, 73);
            btnMul.TabIndex = 13;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += buttonMul_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(347, 452);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(81, 71);
            btnEqual.TabIndex = 15;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += buttonEqual_Click;
            // 
            // input
            // 
            input.Location = new Point(12, 244);
            input.Name = "input";
            input.Size = new Size(416, 27);
            input.TabIndex = 16;
            input.TextChanged += input_TextChanged;
            // 
            // output
            // 
            output.AutoSize = true;
            output.BackColor = SystemColors.ActiveBorder;
            output.Location = new Point(118, 9);
            output.Name = "output";
            output.Padding = new Padding(100);
            output.Size = new Size(200, 220);
            output.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(12, 9);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 18;
            button1.Text = "History";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 535);
            Controls.Add(button1);
            Controls.Add(output);
            Controls.Add(input);
            Controls.Add(btnEqual);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnMin);
            Controls.Add(btnPlus);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn0;
        private Button btnPlus;
        private Button btnMin;
        private Button btnDiv;
        private Button btnMul;
        private Button btnEqual;
        private TextBox input;
        private Label output;
        private Button button1;
    }
}