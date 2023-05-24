namespace Tiers
{
    partial class InsertDepartment
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
            lblDepertment = new Label();
            txtDepName = new TextBox();
            txtDepCapacity = new TextBox();
            btnInseret = new Button();
            label1 = new Label();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // lblDepertment
            // 
            lblDepertment.AutoSize = true;
            lblDepertment.ForeColor = Color.Transparent;
            lblDepertment.Location = new Point(149, 70);
            lblDepertment.Name = "lblDepertment";
            lblDepertment.Size = new Size(95, 20);
            lblDepertment.TabIndex = 0;
            lblDepertment.Text = "Depertments";
            // 
            // txtDepName
            // 
            txtDepName.Location = new Point(111, 177);
            txtDepName.Name = "txtDepName";
            txtDepName.Size = new Size(167, 27);
            txtDepName.TabIndex = 2;
            txtDepName.TextChanged += txtDepName_TextChanged;
            txtDepName.Validated += txtDepName_Validated;
            // 
            // txtDepCapacity
            // 
            txtDepCapacity.Location = new Point(111, 239);
            txtDepCapacity.Name = "txtDepCapacity";
            txtDepCapacity.Size = new Size(167, 27);
            txtDepCapacity.TabIndex = 3;
            txtDepCapacity.Validated += txtDepCapacity_Validated;
            // 
            // btnInseret
            // 
            btnInseret.Location = new Point(111, 365);
            btnInseret.Name = "btnInseret";
            btnInseret.Size = new Size(167, 29);
            btnInseret.TabIndex = 4;
            btnInseret.Text = "Insert Department";
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
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(12, 242);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 8;
            label2.Text = "Capacity";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // InsertDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(408, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnInseret);
            Controls.Add(txtDepCapacity);
            Controls.Add(txtDepName);
            Controls.Add(lblDepertment);
            Name = "InsertDepartment";
            Text = "Insert Department";
            Load += InsertDepartment_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDepertment;
        private TextBox txtDepName;
        private TextBox txtDepCapacity;
        private Button btnInseret;
        private Label label1;
        private Label label2;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}