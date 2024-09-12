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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Helper.ConnStr);
            SqlCommand cmd = new SqlCommand($"Insert into EmpLoginReg(EmpEmail,EmpPwd) values('{textEmpEmail.Text}','{textPwd.Text}')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Created");
            conn.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(Helper.ConnStr);
            SqlCommand Cmd = new SqlCommand($"Select empemail, emppwd from emploginreg where empid = {textEmpId.Text}",Conn);
            Conn.Open();
            SqlDataReader reader = Cmd.ExecuteReader();
            if (reader.Read())
            {
                if (!(reader.IsDBNull(0) && reader.IsDBNull(1)))
                {
                    if (textEmpEmail.Text == reader.GetString(0) && textPwd.Text == reader.GetString(1))
                    {
                        MessageBox.Show("Login Successful!!! Yayy!!!");
                    }
                    else
                    {
                        MessageBox.Show("Failed -_-");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Invaid Creds");
                }
            }
            Conn.Close();
        }
    }
}
