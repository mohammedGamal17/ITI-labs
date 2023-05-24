using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlDataAdapter adapter;
        DataTable dt;
        BindingSource source;
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                adapter = new SqlDataAdapter("select * from Categories", "server=DESKTOP-LF4H1O8;database=NorthWind;Integrated Security=true;encrypt=false;");
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
                adapter.UpdateCommand = sqlCommandBuilder.GetUpdateCommand();
                adapter.DeleteCommand = sqlCommandBuilder.GetDeleteCommand();
                adapter.InsertCommand = sqlCommandBuilder.GetInsertCommand();

                dt = new DataTable();
                adapter.Fill(dt);

                source = new BindingSource(dt, "");
                BindingNavigator nav = new BindingNavigator(source);
                nav.Dock = DockStyle.Top;
                Controls.Add(nav);

                listBox1.DisplayMember = "CategoryName";
                listBox1.ValueMember = "CategoryId";
                listBox1.DataSource = source;

                label1.DataBindings.Add("Text", source, "CategoryId");
                textBox1.DataBindings.Add("Text", source, "CategoryName");
                textBox2.DataBindings.Add("Text", source, "Description");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (label1.Text == "" && textBox1.Text != "" && textBox2.Text != "")
                {
                    source.EndEdit();
                    adapter.Update(dt);
                    MessageBox.Show("Updated Successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("There's an error!","ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
