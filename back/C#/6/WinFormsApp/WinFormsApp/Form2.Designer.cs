namespace WinFormsApp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            showText = new Button();
            Close = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // showText
            // 
            showText.Location = new Point(149, 293);
            showText.Name = "showText";
            showText.Size = new Size(149, 51);
            showText.TabIndex = 0;
            showText.Text = "Change Header";
            showText.UseVisualStyleBackColor = true;
            showText.Click += showText_Click;
            // 
            // Close
            // 
            Close.Location = new Point(726, 12);
            Close.Name = "Close";
            Close.Size = new Size(62, 51);
            Close.TabIndex = 1;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // button1
            // 
            button1.Location = new Point(386, 293);
            button1.Name = "button1";
            button1.Size = new Size(149, 51);
            button1.TabIndex = 2;
            button1.Text = "Change BKG";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 235);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(Close);
            Controls.Add(showText);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button showText;
        private Button Close;
        private Button button1;
        private TextBox textBox1;
    }
}