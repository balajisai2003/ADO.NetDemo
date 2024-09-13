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
using System.Runtime.InteropServices;
using System.IO;

namespace AOD.NetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DBConn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = "Server=.\\sqlexpress;database=MSNetDemoDB;integrated security=true"; //User id/uid=sa;password/pwd= winwire,server,   erver/Data Source
            conn.ConnectionString = Helper.ConnStr;
            try
            {
                //conn.Open();
                MessageBox.Show("Opened");
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Failed - "+ ex.Message);
            }
            finally
            {
                if (conn.State != ConnectionState.Open) 
                { 
                    conn.Close();
                    MessageBox.Show("Closed");
                }
            }

            
        }

        private void ArrConn_Click(object sender, EventArgs e)
        {
            SqlConnection[] connarr = new SqlConnection[100];
            for (int i = 0; i < connarr.Length; i++)
            {
                connarr[i] = new SqlConnection(Helper.ConnStr);
                connarr[i].Open();
                //connarr[i].Close();
            }
            MessageBox.Show("Done");

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Helper.ConnStr);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn;
            string sql = $"Insert into Emply(EmpName,EmpSalary,DeptId) Values('{textEmpName.Text.Replace("'","''")}',{textEmpSalary.Text},{textDeptId.Text})";
            sqlCommand.CommandText = sql;
            conn.Open();
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Inserted");
            sqlCommand.CommandText = "Select @@Identity";
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            MessageBox.Show(id.ToString());
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Helper.ConnStr);
            string sql = $"Update Emp set EmpName = '{textEmpName.Text.Replace("'", "''")}',EmpSalary = {textEmpSalary.Text} where EmpId = {textEmpID.Text}";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            conn.Open();
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Updated");
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Helper.ConnStr);
            string sql = $"Delete from Emp Where EmpId = {textEmpID.Text} ";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            conn.Open();
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Deleted");
            conn.Close();
        }

        private void btnGetEmployees_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection((string)Helper.ConnStr);
            
            SqlCommand sqlCommand = new SqlCommand("select * from emp", conn);

            conn.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            string s = "";
            int Indxid = reader.GetOrdinal("EmpId");
            int IndxEmpName = reader.GetOrdinal("EmpName");
            int IndxEmpSalary = reader.GetOrdinal("EmpSalary");
            while (reader.Read())
            {
                int id = reader.GetInt32(Indxid);
                
                string EmpName = reader.GetString(IndxEmpName);
                decimal EmpSalary = 0;
                if (!reader.IsDBNull(IndxEmpSalary))
                {
                    EmpSalary = reader.GetDecimal(IndxEmpSalary);
                }
                s = s + $"{id}\t{EmpName}\t{EmpSalary}\n";
            }
            reader.Close();
            conn.Close();
            MessageBox.Show(s);

        }

        private void getEmpSalary_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Helper.ConnStr);
            SqlCommand sqlCommand = new SqlCommand($"Select EmpID, EmpName, EmpSalary From Emp where EmpSalary >= {textEmpSalary.Text}",conn);
            conn.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            int indxId = reader.GetOrdinal("EmpId");
            int indxEmpName = reader.GetOrdinal("EmpName");
            int indxEmpSalary = reader.GetOrdinal("EmpSalary");
            string s = "";
            while(reader.Read())
            {
                int id = reader.GetInt32(indxId);
                string name = reader.GetString(indxEmpName);
                decimal empSalary = 0;
                if (!reader.IsDBNull(indxEmpSalary))
                {
                    empSalary = reader.GetDecimal(indxEmpSalary);

                }
                s += $"{id}\t{name}\t{empSalary}\n";
                
            }
            reader.Close ();
            conn.Close();
            MessageBox.Show(s);

        }

        private void btnEmpDept_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection (Helper.ConnStr);
            SqlCommand sqlCommand = new SqlCommand("Select EmpName,EmpSalary,DeptName from Emply join dept on Emply.deptid = dept.deptid",conn);
            conn.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            string s = "";
            while (reader.Read())
            {
                s += reader["Empname"] + "\t" + reader["EmpSalary"] + "\t" + reader["DeptName"] + "\n";
            }
            MessageBox.Show(s);
            reader.Close();
            conn.Close();

        }

        private void btnInsrtPrms_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Helper.ConnStr);
            string sql = "Insert into Emply(EmpName,EmpSalary,DeptId) Values (@EmpName, @EmpSalary, @DeptId); Select @Empid=@@Identity ";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlParameter parEmpId = sqlCommand.Parameters.Add("@Empid", SqlDbType.Int);
            SqlParameter parEmpName = new SqlParameter("@EmpName", SqlDbType.VarChar, 50);
            SqlParameter parEmpSalary = new SqlParameter("@EmpSalary", SqlDbType.Money);
            SqlParameter parDepId = new SqlParameter("@DeptId", SqlDbType.Int);
            parEmpId.Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(parEmpName);
            sqlCommand.Parameters.Add(parEmpSalary);
            sqlCommand.Parameters.Add(parDepId);

            List<Emp> lstEmps = new List<Emp>()
                    {
                        new Emp() { EmpName = "EN11", EmpSalary = 5787654, deptId = 3 },
                        new Emp() { EmpName = "EN21", EmpSalary = 5787654, deptId = 2 },
                        new Emp() { EmpName = "EN31", EmpSalary = 5787654, deptId = 1 },
                        new Emp() { EmpName = "EN41", EmpSalary = 5787654, deptId = 4 },
                        new Emp() { EmpName = "EN51", EmpSalary = 5787654, deptId = 2 },
                        new Emp() { EmpName = "EN61", EmpSalary = 5787654, deptId = 2 }
                    };

            conn.Open();
            sqlCommand.Prepare();
            foreach (Emp emp in lstEmps)
            {
                parEmpName.Value = emp.EmpName;
                parEmpSalary.Value = emp.EmpSalary;
                parDepId.Value = emp.deptId;
                sqlCommand.ExecuteNonQuery();
                emp.id = Convert.ToInt32(parEmpId.Value);
            }
            conn.Close();
            string s = "";
            foreach (Emp emp in lstEmps)
            {
                s += emp.id + " " + emp.EmpName + " " + emp.EmpSalary + " " + emp.deptId+"\n";
            }
            MessageBox.Show(s);
        }


        byte[] buffer = null;


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(dlg.FileName, FileMode.Open);
                buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();
                pictureBox1.Load(dlg.FileName);
            }

        }

        private void btnInsertImg_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Helper.ConnStr);
            string sql = "Insert into Emply(EmpName,EmpSalary,DeptId,img) Values (@EmpName, @EmpSalary, @DeptId, @img); Select @Empid=@@Identity ";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlParameter parEmpId = new SqlParameter("@EmpId", SqlDbType.Int);
            SqlParameter parEmpName = new SqlParameter("@EmpName", SqlDbType.VarChar, 50);
            SqlParameter parEmpSalary = new SqlParameter("@EmpSalary", SqlDbType.Money);
            SqlParameter parDepId = new SqlParameter("@DeptId", SqlDbType.Int);
            SqlParameter parImg = new SqlParameter("@img",SqlDbType.Image);
            parEmpId.Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(parEmpName);
            sqlCommand.Parameters.Add(parEmpSalary);
            sqlCommand.Parameters.Add(parDepId);
            sqlCommand.Parameters.Add(parEmpId);
            sqlCommand.Parameters.Add(parImg);

            parEmpName.Value = textEmpName.Text;
            parEmpSalary.Value = textEmpSalary.Text;
            parDepId.Value = textDeptId.Text;
            if (buffer != null)
            {
                parImg.Value = buffer;
            }
            else
            {
                parImg.Value = DBNull.Value;
            }
            conn.Open();
            sqlCommand.ExecuteNonQuery();
            conn.Close();
            textEmpID.Text = parEmpId.Value.ToString();
        }

        private void btnGetImg_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Helper.ConnStr);
            SqlCommand sqlCommand = new SqlCommand($"Select img from emply where empid = {textEmpID.Text}",conn);
            conn.Open();
            byte[] buffer = (byte[]) sqlCommand.ExecuteScalar();
            conn.Close();
            MemoryStream ms = new MemoryStream(buffer);
            pictureBox1.Image = new Bitmap(ms);
        }

        private void btnGetSalViaProce_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(Helper.ConnStr);
            //SqlCommand sqlCommand = new SqlCommand();
            //sqlCommand.Connection = conn;
            //sqlCommand.CommandText = "GetSalary";
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            //SqlParameter parEmpId = ("@id", SqlDbType.Int);
            //SqlParameter parSal = sqlCommand.Parameters.Add("@salary", SqlDbType.Money);
            SqlParameter parEmpId = new SqlParameter("@id", SqlDbType.Int);
            SqlParameter parSal = new SqlParameter("@salary", SqlDbType.Money);

            parSal.Direction = ParameterDirection.Output;
            parEmpId.Value = textEmpID.Text;

            DBUtil.ExeStrdProcedureNonQuery("GetSalary", parEmpId, parSal);
            //conn.Open();
            //sqlCommand.ExecuteNonQuery();
            if (parSal.Value == DBNull.Value)
            {
                MessageBox.Show("Invalid EmpId");
            }
            else
            {
                MessageBox.Show(parSal.Value.ToString());
            }

            //conn.Close();
        }

        private void btnInsertStoredProc_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Helper.ConnStr);
            SqlCommand sqlCommand = new SqlCommand("InsertEmp",conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter parEmpName = sqlCommand.Parameters.Add("@name", SqlDbType.VarChar, 50);
            SqlParameter parEmpId = sqlCommand.Parameters.Add("@id",SqlDbType.Int);
            SqlParameter parEmpSalary = sqlCommand.Parameters.Add("@salary", SqlDbType.Money);
            SqlParameter parDeptId = sqlCommand.Parameters.Add("@Deptid", SqlDbType.Int);
            SqlParameter parImg = sqlCommand.Parameters.Add("@img", SqlDbType.Image);
            parEmpId.Direction = ParameterDirection.Output;
            parEmpName.Value = textEmpName.Text;
            parEmpSalary.Value = textEmpSalary.Text;
            parDeptId.Value = textDeptId.Text;

            if (buffer != null)
            {
                parImg.Value = buffer;
            }
            else
            {
                parImg.Value = DBNull.Value;
            }   

            conn.Open();
            sqlCommand.ExecuteNonQuery();
            textEmpID.Text = parEmpId.Value.ToString();
            conn.Close();
        }

        private void btnGetEmpProce_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(Helper.ConnStr);
            //SqlCommand sqlCommand = new SqlCommand("GetEmps", conn);
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            
            //conn.Open();
            //SqlDataReader reader = sqlCommand.ExecuteReader();
            SqlDataReader reader = DBUtil.ExeSPReader("GetEmps");
            reader.Read();
            MessageBox.Show(reader[0].ToString());
            reader.NextResult();

            string s = "";
            while (reader.Read())
            {
                s += reader["EmpName"] + "\t" + reader["EmpSalary"] + "\t" + reader["DeptName"] + "\n";
            }
            MessageBox.Show(s);
            reader.Close();//this makes connection close

           

        }
    }
    //test
    class Emp
    {
        public int id;
        public string EmpName;
        public decimal EmpSalary;
        public int deptId;
    }


}
