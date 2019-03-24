using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Registration : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Farhan Labib\Documents\Visual Studio 2017\Projects\WindowsFormsApp1\Database\LoginDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public Registration()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "" && txtID.Text != "" && txtCG.Text != "")
            {
                sqlcon.Open();
                string query = "insert into RegisterDB values ('" + txtName.Text.Trim() + "', '" + txtID.Text.Trim() + "', '" + txtCG.Text.Trim() + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Registered Successfully");
            }
            else
            {
                MessageBox.Show("Fill The Exery Box Correctly");
            }
        }
    }
}
