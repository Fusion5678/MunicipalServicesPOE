using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MunicipalServices.Models;

namespace MunicipalServices.Forms
{
    public partial class ReportIssuesForm : Form
    {
        public static List<IssueReport> IssueStore = new List<IssueReport>();

        private Form _parentForm;

        private string[] engagementMessages = new string[]
        {
            "Let us get started! Fill in the location of the issue below.",
            "Great start! Now choose a category that best describes the problem.",
            "You are halfway there! Please describe the issue in detail.",
            "Almost done! You can optionally attach photos or documents.",
            "Everything is filled in - press Submit to send your report!"
        };

        public ReportIssuesForm()
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                LoadCategories();
                UpdateProgress();
            }
        }

        public ReportIssuesForm(Form parent)
        {
            _parentForm = parent;
            InitializeComponent();
            if (!this.DesignMode)
            {
                LoadCategories();
                UpdateProgress();
            }
        }

        private void LoadCategories()
        {
            cboCategory.Items.Clear();
            cboCategory.Items.Add("-- Select a Category --");
            cboCategory.Items.Add("Roads & Potholes");
            cboCategory.Items.Add("Sanitation & Sewage");
            cboCategory.Items.Add("Water Supply");
            cboCategory.Items.Add("Electricity & Load Shedding");
            cboCategory.Items.Add("Waste & Refuse Removal");
            cboCategory.Items.Add("Street Lighting");
            cboCategory.Items.Add("Parks & Recreation");
            cboCategory.Items.Add("Public Safety");
            cboCategory.Items.Add("Stormwater Drainage");
            cboCategory.Items.Add("Building & Zoning");
            cboCategory.Items.Add("Other");
            cboCategory.SelectedIndex = 0;
        }

        private void UpdateProgress()
        {
            int score = 0;
            if (txtLocation.Text.Trim().Length > 0) score++;
            if (cboCategory.SelectedIndex > 0) score++;
            if (rtbDescription.Text.Trim().Length > 0) score++;
            if (lstAttachments.Items.Count > 0) score++;

            progressBar.Value = score * 25;
            lblProgressPercent.Text = (score * 25) + "%";
            lblEngagement.Text = engagementMessages[score];

            bool canSubmit = txtLocation.Text.Trim().Length > 0
                          && cboCategory.SelectedIndex > 0
                          && rtbDescription.Text.Trim().Length > 0;

            btnSubmit.Enabled = canSubmit;
            btnSubmit.BackColor = canSubmit ? Color.FromArgb(0, 122, 77) : Color.FromArgb(236, 236, 236);
            btnSubmit.ForeColor = canSubmit ? Color.White : Color.FromArgb(160, 160, 160);
        }

        private void txtLocation_TextChanged(object sender, EventArgs e) { UpdateProgress(); }
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e) { UpdateProgress(); }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {
            int count = rtbDescription.Text.Length;
            lblCharCount.Text = count + " / 1000 characters";
            lblCharCount.ForeColor = count > 1000 ? Color.Red : Color.Gray;
            UpdateProgress();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Attach Media";
            openFile.Multiselect = true;
            openFile.Filter = "Images & Documents|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.pdf;*.doc;*.docx;*.txt|All Files|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFile.FileNames)
                {
                    if (!lstAttachments.Items.Contains(file))
                        lstAttachments.Items.Add(file);
                }
                lblAttachCount.Text = lstAttachments.Items.Count + " file(s) attached";
                UpdateProgress();
            }
        }

        private void btnRemoveAttachment_Click(object sender, EventArgs e)
        {
            if (lstAttachments.SelectedIndex >= 0)
            {
                lstAttachments.Items.RemoveAt(lstAttachments.SelectedIndex);
                lblAttachCount.Text = lstAttachments.Items.Count + " file(s) attached";
                UpdateProgress();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtLocation.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the location of the issue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocation.Focus(); return;
            }
            if (cboCategory.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCategory.Focus(); return;
            }
            if (rtbDescription.Text.Trim() == "")
            {
                MessageBox.Show("Please provide a description of the issue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rtbDescription.Focus(); return;
            }
            if (rtbDescription.Text.Length > 1000)
            {
                MessageBox.Show("Description exceeds 1000 characters. Please shorten it.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rtbDescription.Focus(); return;
            }

            IssueReport report = new IssueReport();
            report.Location = txtLocation.Text.Trim();
            report.Category = cboCategory.SelectedItem.ToString();
            report.Description = rtbDescription.Text.Trim();
            foreach (string path in lstAttachments.Items)
                report.AttachedMediaPaths.Add(path);
            IssueStore.Add(report);

            progressBar.Value = 100;
            lblProgressPercent.Text = "100%";
            lblEngagement.Text = engagementMessages[4];

            MessageBox.Show(
                "Your issue has been submitted successfully!\n\n" +
                "Reference ID: #" + report.Id + "\n" +
                "Category: " + report.Category + "\n" +
                "Location: " + report.Location + "\n\n" +
                "A municipal officer will review your report shortly.",
                "Report Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear all entered data?", "Clear Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                ClearForm();
        }

        private void ClearForm()
        {
            txtLocation.Clear();
            cboCategory.SelectedIndex = 0;
            rtbDescription.Clear();
            lstAttachments.Items.Clear();
            lblAttachCount.Text = "0 file(s) attached";
            lblCharCount.Text = "0 / 1000 characters";
            UpdateProgress();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            bool hasData = txtLocation.Text.Trim().Length > 0
                        || cboCategory.SelectedIndex > 0
                        || rtbDescription.Text.Trim().Length > 0
                        || lstAttachments.Items.Count > 0;
            if (hasData)
            {
                if (MessageBox.Show("You have unsaved data. Return to the main menu?", "Unsaved Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
            }
            if (_parentForm != null) _parentForm.Show();
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (_parentForm != null && !_parentForm.Visible)
                _parentForm.Show();
        }
    }
}
