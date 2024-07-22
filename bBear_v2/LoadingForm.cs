using System.Windows.Forms;

namespace bBear_v2
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            this.ControlBox = false; // ซ่อนปุ่มปิดหน้าต่าง
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Loading...";
        }
    }
}
