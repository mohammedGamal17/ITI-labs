namespace WinFormsApp1
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
            dgvDept = new DataGridView();
            btnSave = new Button();
            lblName = new Label();
            txtbxName = new TextBox();
            lblDecription = new Label();
            txtbxDesc = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDept).BeginInit();
            SuspendLayout();
            // 
            // dgvDept
            // 
            dgvDept.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDept.Location = new Point(12, 12);
            dgvDept.Name = "dgvDept";
            dgvDept.RowHeadersWidth = 51;
            dgvDept.RowTemplate.Height = 29;
            dgvDept.Size = new Size(432, 426);
            dgvDept.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(690, 284);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(594, 171);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // txtbxName
            // 
            txtbxName.Location = new Point(690, 172);
            txtbxName.Name = "txtbxName";
            txtbxName.Size = new Size(160, 27);
            txtbxName.TabIndex = 3;
            // 
            // lblDecription
            // 
            lblDecription.AutoSize = true;
            lblDecription.Location = new Point(594, 222);
            lblDecription.Name = "lblDecription";
            lblDecription.Size = new Size(85, 20);
            lblDecription.TabIndex = 4;
            lblDecription.Text = "Description";
            // 
            // txtbxDesc
            // 
            txtbxDesc.Location = new Point(690, 222);
            txtbxDesc.Name = "txtbxDesc";
            txtbxDesc.Size = new Size(160, 27);
            txtbxDesc.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(710, 99);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 6;
            label1.Text = "Add Department";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 450);
            Controls.Add(label1);
            Controls.Add(txtbxDesc);
            Controls.Add(lblDecription);
            Controls.Add(txtbxName);
            Controls.Add(lblName);
            Controls.Add(btnSave);
            Controls.Add(dgvDept);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDept).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDept;
        private Button btnSave;
        private Label lblName;
        private TextBox txtbxName;
        private Label lblDecription;
        private TextBox txtbxDesc;
        private Label label1;
    }
}