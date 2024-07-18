using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace bBear_v2
{
    public partial class usctrDashboard : UserControl
    {
        //private string CompanyName;
        private string conStr;

        private DataTable dataTable; // สำหรับเก็บข้อมูลทั้งหมด
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
                    //string query = "SELECT A.RO_CODE เลขที่ห้อง, A.RO_DEPT อาคาร, A.RO_OWNER รหัสเจ้าของ , B.PE_NAME FROM CMM_ROOM A LEFT JOIN CMM_CUST B ON A.RO_OWNER = B.PE_CODE";

                    //SqlDataAdapter da = new SqlDataAdapter(query, con);
                    //dataTable = new DataTable();
                    //da.Fill(dataTable);
                    //totalPage = (int)Math.Ceiling(dataTable.Rows.Count / (double)pageSize); // คำนวณจำนวนหน้าทั้งหมด
                    //DisplayPage(currentPage);


                    string queryGetTableRoom = "GetTableRoom";
                    SqlCommand cmd = new SqlCommand(queryGetTableRoom, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dataTable = new DataTable();
                    da.Fill(dataTable);
                    totalPage = (int)Math.Ceiling(dataTable.Rows.Count / (double)pageSize); // คำนวณจำนวนหน้าทั้งหมด
                    DisplayPage(currentPage);



                    //แสดงจำนวนห้อง
                    string queryCountRoom = "SELECT COUNT(RO_CODE) FROM CMM_ROOM";
                    SqlCommand cmdCountRoom = new SqlCommand(queryCountRoom, con);
                    int roomCount = (int)cmdCountRoom.ExecuteScalar();
                    lblCountRoom.Text = roomCount.ToString("N0");

                    //แสดงจำนวนเจ้าของ
                    string queryCountOwner = "SELECT COUNT(DISTINCT PE_NAME) FROM CMM_CUST";
                    SqlCommand cmdCountOwner = new SqlCommand(queryCountOwner, con);
                    int ownerCount = (int)cmdCountOwner.ExecuteScalar();
                    lblOwner.Text = ownerCount.ToString("N0");

                    //แสดงหนี้ค้างทั้งหมด
                    //string querytotalOutstandingDebts = @"SELECT SUM(A.AR_TOTAL) - (SELECT SUM(B.RC_AMOUNT) FROM CMT_RCDL B WHERE B.RC_ARNO IS NOT NULL) FROM CMT_ARHD A;";
                    //SqlCommand cmdtotalOutstandingDebts = new SqlCommand(querytotalOutstandingDebts, con);
                    //object result = cmdtotalOutstandingDebts.ExecuteScalar();

                    //if (result == null)
                    //{
                    //    lblTotalOutstandingDebts.Text = "ไม่พบข้อมูล";
                    //}
                    //else
                    //{
                    //    decimal totalOutstandingDebts = Convert.ToDecimal(result);
                    //    lblTotalOutstandingDebts.Text = totalOutstandingDebts.ToString("N2");
                    //}

                    string queryGetTotalDebts = "GetTotalDebts";
                    SqlCommand cmd_GetTotalDebts = new SqlCommand(queryGetTotalDebts, con);
                    cmd_GetTotalDebts.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da_GetTotalDebts = new SqlDataAdapter(cmd_GetTotalDebts);
                    DataTable dt_GetTotalDebts = new DataTable();
                    da_GetTotalDebts.Fill(dt_GetTotalDebts);

                    if (dt_GetTotalDebts.Rows.Count == 0)
                    {
                        lblTotalOutstandingDebts.Text = "ไม่พบข้อมูล";
                    }
                    else
                    {
                        decimal totalOutstandingDebts = Convert.ToDecimal(dt_GetTotalDebts.Rows[0][0]);
                        lblTotalOutstandingDebts.Text = totalOutstandingDebts.ToString("N2");
                    }

                    //แสดงชำระเดือนปัจจุบัน
                    //string queryPaidCurrentMonth = @"SELECT SUM(RC_AMOUNT) AS TotalPaidCurrentMonth FROM CMT_RCDL WHERE RC_ARNO IS NOT NULL AND RC_ARYEAR = (SELECT MAX(RC_ARYEAR) FROM CMT_RCDL WHERE RC_ARNO IS NOT NULL) AND RC_ARMONTH = (SELECT MAX(RC_ARMONTH) FROM CMT_RCDL WHERE RC_ARNO IS NOT NULL AND RC_ARYEAR = (SELECT MAX(RC_ARYEAR) FROM CMT_RCDL WHERE RC_ARNO IS NOT NULL))";
                    //SqlCommand cmd2 = new SqlCommand(queryPaidCurrentMonth, con);
                    //object result2 = cmd2.ExecuteScalar();

                    //if (result2 == DBNull.Value || result2 == null)
                    //{
                    //    lblCurrentMonthCash.Text = "ไม่พบข้อมูล";
                    //}
                    //else
                    //{
                    //    decimal PaidCurrentMonth = Convert.ToDecimal(result2);
                    //    lblCurrentMonthCash.Text = PaidCurrentMonth.ToString("N2");
                    //}

                    string queryGetTotalLastPaid = "GetTotalLastPaid";
                    SqlCommand cmd3 = new SqlCommand(queryGetTotalLastPaid, con);
                    cmd3.CommandType = CommandType.StoredProcedure;
                    object result3 = cmd3.ExecuteScalar();
                    if(result3 ==  DBNull.Value || result3 == null)
                    {
                        lblCurrentMonthCash.Text = "ไม่พบข้อมูล";
                    }
                    else
                    {
                        decimal PaidCurrentMonth = Convert.ToDecimal(result3);
                        lblCurrentMonthCash.Text = PaidCurrentMonth.ToString("N2");
                    }

                    string qrLastYearPaid = "SELECT MAX(RC_ARYEAR) FROM CMT_RCDL WHERE RC_ARNO IS NOT NULL";
                    string qrLastMonthPaid = "SELECT MAX(RC_ARMONTH) FROM CMT_RCDL WHERE RC_ARNO IS NOT NULL";

                    SqlCommand cmdLastYearPaid = new SqlCommand(qrLastYearPaid, con);
                    SqlCommand cmdLastMONTHPaid = new SqlCommand(qrLastMonthPaid, con);
                    object result = cmdLastYearPaid.ExecuteScalar();
                    object resultLastM = cmdLastMONTHPaid.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        int LastYearPaid = Convert.ToInt32(result);
                        int LastMonthPaid = Convert.ToInt32(resultLastM);
                        lblBox4_2.Text = "ล่าสุด : " + LastMonthPaid.ToString() + "/" + LastYearPaid.ToString();

                    }
                    else
                    {
                        // Handle case where no valid integer value was returned
                        lblBox4_2.Text = "N/A"; // or any appropriate message
                    }


                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ระบบผิดพลาด! : " + ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        public void DisplayData()
        {
            DisplayPage(currentPage);
        }

        private void DisplayPage(int page)
        {
            int startIndex = (page - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, dataTable.Rows.Count);

            DataTable pageTable = dataTable.Clone(); // สร้างโครงสร้าง DataTable ใหม่
            for (int i = startIndex; i < endIndex; i++)
            {
                pageTable.ImportRow(dataTable.Rows[i]);
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
