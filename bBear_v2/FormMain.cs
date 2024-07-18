using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bBear_v2
{
    public partial class FormMain : Form
    {


        // P/Invoke สำหรับการเลื่อนฟอร์ม
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private string _server;
        private string _companycode;
        private string _username;

        // Property หรือ Field สำหรับเก็บค่า server
        public string Server
        {
            get { return _server; }
            set { _server = value; }
        }

        public string CompanyCode
        {
            get => _companycode;
            set { _companycode = value; }
        }

        public string UserName
        {
            get => _username;
            set { _username = value; }
        }



        public FormMain(string server, string username)
        {
            InitializeComponent();
            _server = server;
            _username = username;

            lblUser.Text = "ผู้ใช้งาน  : " + _username;



            ShowUserControl(new usctrDashboard());

        }

        //กดเมาส์ค้างที่ titlebar เพื่อเลือนโปรแกรม
        private void TitleBarpanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            }
        }

        //Title Controlbox
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_MouseHover(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.BackColor = Color.LightGray; // เปลี่ยนสีเมื่อเมาส์อยู่เหนือปุ่ม
                button.ForeColor = Color.Black;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.BackColor = Color.Black; // กลับเป็นสีปกติเมื่อเมาส์ออกจากปุ่ม
                button.ForeColor = Color.Gainsboro;
            }
        }

        private void btnFiles_Click(object sender, EventArgs e)
        {

            usctrFile1 = new usctrFile();
            ShowUserControl(usctrFile1);

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (ustrDashboard1 != null)
            {
                ShowUserControl(ustrDashboard1);
                if (ustrDashboard1 is usctrDashboard dashboard)
                {
                    dashboard.ShowData(); // เรียกใช้งานเมทอด ShowData ของ usctrDashboard
                }
            }

        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            usctrRecord1 = new usctrRecordBy();
            ShowUserControl(usctrRecord1);
        }

        private void ShowUserControl(UserControl userControl)
        {
            userControl.Tag = _server; // ส่งค่า server ไปยัง UserControl
            panelContainer.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
            userControl.Show();

            // Call the Load event explicitly if needed
            if (userControl is usctrDashboard dashboard)
            {
                dashboard.Load += (sender, e) =>
                {
                    // Perform additional setup or operations after usctrDashboard has loaded
                    dashboard.ShowData(); // Example: Call a method in usctrDashboard to load data
                };
            }
        }
    }
}
