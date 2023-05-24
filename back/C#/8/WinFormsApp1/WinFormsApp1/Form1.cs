using Microsoft.Data.SqlClient;
using Microsoft.Data;
using System.Data;
using System.Windows.Forms;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlDataAdapter adapter;
        DataTable dt;

        string comboboxSelectedValue = string.Empty;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string conString = "server=DESKTOP-LF4H1O8;database=NorthWind;Integrated Security=true;encrypt=false;";

                adapter = new SqlDataAdapter("select * from Products", conString);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.DeleteCommand = builder.GetDeleteCommand();
                adapter.InsertCommand = builder.GetInsertCommand();

                dt = new DataTable();
                adapter.Fill(dt);
                BindingSource source = new BindingSource(dt, "");
                BindingNavigator navigator = new BindingNavigator(source);
                navigator.Dock = DockStyle.Top;
                Controls.Add(navigator);

                dgvProducts.DataSource = source;

                dgvProducts.Columns["ProductId"].ReadOnly = true;
                dgvProducts.Columns["CategoryId"].Visible = false;

                SqlDataAdapter catAdapter = new SqlDataAdapter("select * from categories", conString);
                DataTable catDT = new DataTable();
                catAdapter.Fill(catDT);

                DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
                comboBoxColumn.HeaderText = "Category Name";
                comboBoxColumn.DisplayMember = "CategoryName";
                comboBoxColumn.ValueMember = "CategoryId";
                comboBoxColumn.DataSource = catDT;
                comboBoxColumn.DataPropertyName = "CategoryId";
                dgvProducts.Columns.Add(comboBoxColumn);

                comboBox1.DisplayMember = "CategoryName";
                comboBox1.ValueMember = "CategoryId";
                comboBox1.DataSource = catDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.Update(dt);
                MessageBox.Show("Updated Successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //To avoid CurrencyManager exception error
                dgvProducts.CurrentCell = null;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgvProducts["CategoryId", i].Value) != Convert.ToInt32(comboBox1.SelectedValue))
                        dgvProducts.Rows[i].Visible = false;
                    else
                        dgvProducts.Rows[i].Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}