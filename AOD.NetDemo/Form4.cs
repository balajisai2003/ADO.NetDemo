using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOD.NetDemo
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnSyncExe_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Helper.ConnStr);
            SqlCommand cmd = new SqlCommand("GetAllEmps",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            string s = "";
            while (reader.Read())
            {
                s += reader[0]+"\n";
            }
            reader.Close();
            conn.Close();
            MessageBox.Show(s); 
        }

        private void btnAsyncExe_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(Helper.ConnStr);
            SqlCommand cmd = new SqlCommand("GetAllEmps", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            IAsyncResult ar = cmd.BeginExecuteNonQuery();
            MessageBox.Show("Contionue.........");
            while (!ar.IsCompleted)
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
            SqlDataReader reader = cmd.EndExecuteReader(ar);
            string s = "";
            while (reader.Read())
            {
                s += reader[0] + "\n";
            }
            reader.Close();
            conn.Close();
            MessageBox.Show(s);
        }

        private async void btnAsyncWait_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Helper.ConnStr);
            SqlCommand cmd = new SqlCommand("GetAllEmps", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //Task<SqlDataReader> task = cmd.ExecuteReaderAsync();
            //SqlDataReader reader = await task;
            SqlDataReader reader = await cmd.ExecuteReaderAsync();
            string s = "";
            while (reader.Read())
            {
                s += reader[0] + "\n";
            }
            reader.Close();
            conn.Close();
            MessageBox.Show(s);
        }
    }
}
