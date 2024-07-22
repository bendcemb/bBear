using System;
using System.Windows.Forms;

namespace bBear_v2
{
    public partial class usctrRecordBy : UserControl
    {

        public usctrRecordBy()
        {
            InitializeComponent();
        }

        private void ShowUserControl(UserControl userControl)
        {

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

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            addInvoice1 = new AddInvoice();
            ShowUserControl(addInvoice1);
        }

        private void btnAddPeriod_Click(object sender, EventArgs e)
        {

            //subusctrAddPeriod1 = new subusctrAddPeriod();
            //ShowUserControl(subusctrAddPeriod1);
        }

        private void btnReciept_Click(object sender, EventArgs e)
        {
            addReciept1 = new AddReciept();
            ShowUserControl(addReciept1);
        }
    }
}
