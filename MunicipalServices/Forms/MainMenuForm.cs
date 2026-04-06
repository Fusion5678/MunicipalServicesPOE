using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServices.Forms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            ReportIssuesForm reportForm = new ReportIssuesForm(this);
            this.Hide();
            reportForm.Show();
        }

        private void MainMenuForm_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(255, 182, 18), 4))
            {
                e.Graphics.DrawLine(pen, 0, pnlHeader.Bottom - 2, this.Width, pnlHeader.Bottom - 2);
            }
        }

        private void pnlLogoCircle_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (SolidBrush goldBrush = new SolidBrush(Color.FromArgb(255, 182, 18)))
                e.Graphics.FillEllipse(goldBrush, 2, 2, 76, 76);

            using (SolidBrush navyBrush = new SolidBrush(Color.FromArgb(0, 48, 135)))
                e.Graphics.FillEllipse(navyBrush, 8, 8, 64, 64);
        }

        private void pnlReportCard_MouseEnter(object sender, EventArgs e)
        {
            pnlReportCard.BackColor = Color.FromArgb(232, 240, 254);
        }

        private void pnlReportCard_MouseLeave(object sender, EventArgs e)
        {
            pnlReportCard.BackColor = Color.White;
        }

        private void pnlReportCard_Click(object sender, EventArgs e)
        {
            btnReportIssues_Click(sender, e);
        }

        private void lblReportCardIcon_Click(object sender, EventArgs e)
        {
            btnReportIssues_Click(sender, e);
        }

        private void lblReportCardTitle_Click(object sender, EventArgs e)
        {
            btnReportIssues_Click(sender, e);
        }

        private void lblReportCardDesc_Click(object sender, EventArgs e)
        {
            btnReportIssues_Click(sender, e);
        }

        private void lblStatusCardIcon_Click(object sender, EventArgs e)
        {

        }

        private void lblEventsCardIcon_Click(object sender, EventArgs e)
        {

        }

        private void btnEvents_Click(object sender, EventArgs e)
        {

        }
    }
}
