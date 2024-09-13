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
using System.Transactions;

namespace AOD.NetDemo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnTrnsc_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Helper.ConnStr);
            SqlCommand cmdSource= new SqlCommand($"Update AccTable set Balance=Balance-{textTrnsc.Text} where AccId=1",conn);
            SqlCommand cmdDest = new SqlCommand($"Update AccTable set Balance=Balance+{textTrnsc.Text} where AccId=2", conn);
            conn.Open();
            SqlTransaction trnsc = conn.BeginTransaction();
            cmdDest.Transaction = trnsc;
            cmdSource.Transaction = trnsc;
            try
            {
                cmdSource.ExecuteNonQuery();
                cmdDest.ExecuteNonQuery();
                trnsc.Commit();
                MessageBox.Show($"Rs{textTrnsc.Text}/- is transfered from Acc1 toAcc2");

            }
            catch (SqlException ex)
            {
                trnsc.Rollback();
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void btnDTCtrnsc_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Helper.ConnStr);
            SqlCommand cmdSource = new SqlCommand($"Update AccTable set Balance=Balance-{textTrnsc.Text} where AccId=1", conn);
            SqlCommand cmdDest = new SqlCommand($"Update AccTable set Balance=Balance+{textTrnsc.Text} where AccId=2", conn);
            conn.Open();
            SqlTransaction trnsc = conn.BeginTransaction();
            cmdDest.Transaction = trnsc;
            cmdSource.Transaction = trnsc;
            using (TransactionScope tsScope = new TransactionScope())
            {
                cmdSource.ExecuteNonQuery();
                cmdDest.ExecuteNonQuery();
                trnsc.Commit();
                MessageBox.Show($"Rs{textTrnsc.Text}/- is transfered from Acc1 toAcc2");
                conn.Close();
                tsScope.Complete();
            }
                

        }
    }
}
