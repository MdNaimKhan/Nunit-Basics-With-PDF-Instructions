using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class Database
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Farhan Labib\Documents\Visual Studio 2017\Projects\WindowsFormsApp1\Database\LoginDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        
        public bool Checkdb(string name, string pass)
        {
            if(name=="" || pass=="")
            {
                throw new NullReferenceException("Field cannt be empty");
            }

            string query = "Select * from LoginDB Where username = '" + name.Trim() + "' and password = '" + pass.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        public bool inesertdb(string name, string id, string cgpa)
        {
            if(name == "" || id == "" || cgpa == "")
            {
                throw new NullReferenceException("Field cannt be empty");
            }
            else if( name != "" && id !="" && cgpa!="")
            {
                sqlcon.Open();
                string query = "insert into RegisterDB values ('" + name.Trim() + "', '" + id.Trim() + "', '" + cgpa.Trim() + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                sda.SelectCommand.ExecuteNonQuery();
                return true;

            }
            else
            {
                return false;
            }

        }


    }
}
