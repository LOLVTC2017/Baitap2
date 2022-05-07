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
namespace Baitap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn= new SqlConnection("Data Source=phu;Initial Catalog=QLBH;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHDataSet6.getcustomer' table. You can move, or remove it, as needed.
            this.getcustomerTableAdapter.Fill(this.qLBHDataSet6.getcustomer);
            // TODO: This line of code loads data into the 'qLBHDataSet5.GetCustomerInPhieuThu' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'qLBHDataSet.KHACH_HANG' table. You can move, or remove it, as needed.
            this.kHACH_HANGTableAdapter.Fill(this.qLBHDataSet.KHACH_HANG);
            this.reportByCTTableAdapter.Fill(this.qLBHDataSet3.ReportByCT, getCT(txt_khachhang.SelectedValue.ToString()));

            this.reportViewer1.RefreshReport();
        }

  
        private string getCT(string idCustomer )
        {
            string id = idCustomer;
            string mact = string.Format("GetSoCT '{0}'", id);
            SqlDataAdapter adapter = new SqlDataAdapter(mact, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows[0][0].ToString();
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void txt_khachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.reportByCTTableAdapter.Fill(this.qLBHDataSet3.ReportByCT, getCT(txt_khachhang.SelectedValue.ToString()));
            this.reportViewer1.RefreshReport();
        }

        private void txt_mact_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
