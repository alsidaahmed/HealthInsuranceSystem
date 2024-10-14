using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }
        private void policybutton_Click(object sender, System.EventArgs e)
        {
            this.menu_active.Location = new Point(policybutton.Location.X, policybutton.Location.Y);
            PolicyForm policy = new PolicyForm();
            policy.MdiParent = this;
            policy.FormBorderStyle = FormBorderStyle.None;
            policy.Dock = DockStyle.Fill;
            policy.Show();
        }
        private void claimbutton_Click(object sender, System.EventArgs e)
        {
            this.menu_active.Location = new Point(claimbutton.Location.X, claimbutton.Location.Y);
            ClaimForm claim = new ClaimForm();
            claim.MdiParent = this;
            claim.FormBorderStyle = FormBorderStyle.None;
            claim.Dock = DockStyle.Fill;
            claim.Show();
        }
        private void reportbutton_Click(object sender, System.EventArgs e)
        {
            this.menu_active.Location = new Point(reportbutton.Location.X, reportbutton.Location.Y);
            ReportingForm report = new ReportingForm();
            report.MdiParent = this;
            report.FormBorderStyle = FormBorderStyle.None;
            report.Dock = DockStyle.Fill;
            report.Show();
        }
        private void categorybutton_Click(object sender, System.EventArgs e)
        {
            this.menu_active.Location = new Point(categorybutton.Location.X, categorybutton.Location.Y);
            CategoryForm category = new CategoryForm();
            category.MdiParent = this;
            category.FormBorderStyle = FormBorderStyle.None;
            category.Dock = DockStyle.Fill;
            category.Show();

        }

        private void AdminProfile_Click(object sender, System.EventArgs e)
        {
            AdminProfile adminProfile = new AdminProfile();
            adminProfile.MdiParent = this;
            adminProfile.FormBorderStyle = FormBorderStyle.None;
            adminProfile.Dock = DockStyle.Fill;
            adminProfile.Show();

        }
    }
}
