using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bBear_v2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            LoadForm();
        }



        public void LoadForm()
        {
            comboBoxServer.Items.Add("Office");
            comboBoxServer.Items.Add("MyRoom");
            comboBoxServer.SelectedIndex = 0;


        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string selectedServer = "";
            string userName = "admin";
            string password = "admin";

            if (comboBoxServer.SelectedIndex == 0)
            {
                selectedServer = "C259-003\\SQLEXPRESS";
            }
            else if (comboBoxServer.SelectedIndex == 1)
            {
                selectedServer = "BENDCEMB-LT\\SQLEXPRESS";
            }



            if (userName == "admin" && password == "admin")
            {
                this.Hide();
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();

                // ใช้ Task.Run เพื่อโหลด FormMain ในเธรดแยกต่างหาก
                await Task.Run(() =>
                {
                    selectedServer = "BENDCEMB-LT\\SQLEXPRESS"; //หลัง dev ลบทิ้ง

                    FormMain mainForm = new FormMain(selectedServer, userName);
                    mainForm.Load += (s, args) => loadingForm.Invoke(new Action(() => loadingForm.Close())); // ปิดฟอร์มการโหลดเมื่อโหลดเสร็จ
                    mainForm.FormClosed += (s, args) => this.Invoke(new Action(() => this.Close())); // ปิดโปรแกรมเมื่อ MainForm ถูกปิด
                    mainForm.ShowDialog();


                });
            }
            else
            {
                this.Show();
            }
        }

    }
}
