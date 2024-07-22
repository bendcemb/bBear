using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bBear_v2
{
    public partial class usctrDashboard : UserControl
    {
        //private string CompanyName;
        private string conStr;

        private DataTable dttbl; // สำหรับเก็บข้อมูลทั้งหมด
        private int pageSize = 10; // จำนวนแถวต่อหน้า
        private int currentPage = 1; // หน้าปัจจุบัน
        private int totalPage; // จำนวนหน้าทั้งหมด


        public usctrDashboard()
        {
            InitializeComponent();
        }

        public void ShowData()
        {
            string server = this.Tag.ToString();
            string CompanyName = "KBF";
            conStr = $@"Server={server};Database={CompanyName};Integrated Security=True;";

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();

                    //แสดงตาราง
                    string queryGetTableRoom = "GetTableRoom";
                    SqlCommand cmdTR = new SqlCommand(queryGetTableRoom, con);
                    cmdTR.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmdTR);
                    dttbl = new DataTable();
                    da.Fill(dttbl);
                    totalPage = (int)Math.Ceiling(dttbl.Rows.Count / (double)pageSize); // คำนวณจำนวนหน้าทั้งหมด
                    DisplayPage(currentPage);

                    //แสดง Dashboard
                    string queryGetDashboard = "GetDashboard";
                    SqlCommand cmdGD = new SqlCommand(queryGetDashboard, con);
                    cmdGD.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter daGD = new SqlDataAdapter(cmdGD);
                    DataTable dataTable = new DataTable();
                    daGD.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow row = dataTable.Rows[0];

                        int totalRoom = int.Parse(row["TotalRoom"].ToString());
                        lblCountRoom.Text = totalRoom.ToString("N0");

                        int totalCust = int.Parse(row["TotalCust"].ToString());
                        lblOwner.Text = totalCust.ToString("N0");

                        decimal totalDebt = decimal.Parse(row["TotalDebt"].ToString());
                        lblTotalOutstandingDebts.Text = totalDebt.ToString("N2");

                        decimal lastPaid = decimal.Parse(row["LastPaid"].ToString());
                        lblCurrentMonthCash.Text = lastPaid.ToString("N2");

                        lblBox4_2.Text = row["LastMonth"].ToString() + "/" + row["LastYear"].ToString();

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ระบบผิดพลาด! : " + ex.Message);

            }
        }

        public void DisplayData()
        {
            DisplayPage(currentPage);
        }

        private void DisplayPage(int page)
        {
            int startIndex = (page - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, dttbl.Rows.Count);

            DataTable pageTable = dttbl.Clone(); // สร้างโครงสร้าง DataTable ใหม่
            for (int i = startIndex; i < endIndex; i++)
            {
                pageTable.ImportRow(dttbl.Rows[i]);
            }

            dtgvDashboard.DataSource = pageTable;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                DisplayPage(currentPage);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPage)
            {
                currentPage++;
                DisplayPage(currentPage);
            }
        }

    }
}
