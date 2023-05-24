namespace Tiers
{
    partial class InsertStudent
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
            components = new System.ComponentModel.Container();
            txtName = new TextBox();
            txtAge = new TextBox();
            lblDepertment = new Label();
            btnInseret = new Button();
            label1 = new Label();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(111, 177);
            txtName.Name = "txtName";
            txtName.Size = new Size(167, 27);
            txtName.TabIndex = 0;
            txtName.Validated += txtName_Validated;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(111, 239);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(167, 27);
            txtAge.TabIndex = 1;
            txtAge.Validated += txtAge_Validated;
            // 
            // lblDepertment
            // 
            lblDepertment.AutoSize = true;
            lblDepertment.ForeColor = Color.Transparent;
            lblDepertment.Location = new Point(149, 70);
            lblDepertment.Name = "lblDepertment";
            lblDepertment.Size = new Size(89, 20);
            lblDepertment.TabIndex = 3;
            lblDepertment.Text = "Depertment";
            // 
            // btnInseret
            // 
            btnInseret.Location = new Point(111, 365);
            btnInseret.Name = "btnInseret";
            btnInseret.Size = new Size(167, 29);
            btnInseret.TabIndex = 5;
            btnInseret.Text = "Insert Student";
            btnInseret.UseVisualStyleBackColor = true;
            btnInseret.Click += btnInseret_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(12, 180);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(12, 242);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 7;
            label2.Text = "Age";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // InsertStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(408, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnInseret);
            Controls.Add(lblDepertment);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Name = "InsertStudent";
            Text = "Insert Student";
            Load += InsertStudent_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtAge;
        private Label lblDepertment;
        private Button btnInseret;
        private Label label1;
        private Label label2;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}