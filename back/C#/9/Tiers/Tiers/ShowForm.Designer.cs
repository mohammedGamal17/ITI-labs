namespace Tiers
{
    partial class ShowForm
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
            cmbDepartments = new ComboBox();
            cmbStudents = new ComboBox();
            btnInsertDep = new Button();
            btnInsertStu = new Button();
            SuspendLayout();
            // 
            // cmbDepartments
            // 
            cmbDepartments.FormattingEnabled = true;
            cmbDepartments.Location = new Point(112, 77);
            cmbDepartments.Name = "cmbDepartments";
            cmbDepartments.Size = new Size(205, 28);
            cmbDepartments.TabIndex = 0;
            cmbDepartments.SelectedIndexChanged += cmbDepartments_SelectedIndexChanged;
            // 
            // cmbStudents
            // 
            cmbStudents.FormattingEnabled = true;
            cmbStudents.Location = new Point(112, 150);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(205, 28);
            cmbStudents.TabIndex = 1;
            // 
            // btnInsertDep
            // 
            btnInsertDep.Location = new Point(112, 358);
            btnInsertDep.Name = "btnInsertDep";
            btnInsertDep.Size = new Size(205, 29);
            btnInsertDep.TabIndex = 2;
            btnInsertDep.Text = "Insert Department";
            btnInsertDep.UseVisualStyleBackColor = true;
            btnInsertDep.Click += btnInsertDep_Click;
            // 
            // btnInsertStu
            // 
            btnInsertStu.Location = new Point(112, 393);
            btnInsertStu.Name = "btnInsertStu";
            btnInsertStu.Size = new Size(205, 29);
            btnInsertStu.TabIndex = 3;
            btnInsertStu.Text = "Insert Student";
            btnInsertStu.UseVisualStyleBackColor = true;
            btnInsertStu.Click += btnInsertStu_Click;
            // 
            // ShowForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(408, 450);
            Controls.Add(btnInsertStu);
            Controls.Add(btnInsertDep);
            Controls.Add(cmbStudents);
            Controls.Add(cmbDepartments);
            Name = "ShowForm";
            Text = "Show Page";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbDepartments;
        private ComboBox cmbStudents;
        private Button btnInsertDep;
        private Button btnInsertStu;
    }
}