using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
