namespace MunicipalServices.Forms
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlLogoCircle = new System.Windows.Forms.Panel();
            this.lblLogoText = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblAppSubtitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlStatusCard = new System.Windows.Forms.Panel();
            this.lblStatusSoon = new System.Windows.Forms.Label();
            this.lblStatusCardIcon = new System.Windows.Forms.Label();
            this.lblStatusCardTitle = new System.Windows.Forms.Label();
            this.lblStatusCardDesc = new System.Windows.Forms.Label();
            this.btnStatus = new System.Windows.Forms.Button();
            this.pnlEventsCard = new System.Windows.Forms.Panel();
            this.lblEventsSoon = new System.Windows.Forms.Label();
            this.lblEventsCardIcon = new System.Windows.Forms.Label();
            this.lblEventsCardTitle = new System.Windows.Forms.Label();
            this.lblEventsCardDesc = new System.Windows.Forms.Label();
            this.btnEvents = new System.Windows.Forms.Button();
            this.pnlReportCard = new System.Windows.Forms.Panel();
            this.lblReportCardIcon = new System.Windows.Forms.Label();
            this.lblReportCardTitle = new System.Windows.Forms.Label();
            this.lblReportCardDesc = new System.Windows.Forms.Label();
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlLogoCircle.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlStatusCard.SuspendLayout();
            this.pnlEventsCard.SuspendLayout();
            this.pnlReportCard.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.pnlHeader.Controls.Add(this.pnlLogoCircle);
            this.pnlHeader.Controls.Add(this.lblAppTitle);
            this.pnlHeader.Controls.Add(this.lblAppSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1800, 220);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlLogoCircle
            // 
            this.pnlLogoCircle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.pnlLogoCircle.Controls.Add(this.lblLogoText);
            this.pnlLogoCircle.Location = new System.Drawing.Point(50, 55);
            this.pnlLogoCircle.Name = "pnlLogoCircle";
            this.pnlLogoCircle.Size = new System.Drawing.Size(110, 110);
            this.pnlLogoCircle.TabIndex = 0;
            this.pnlLogoCircle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogoCircle_Paint);
            // 
            // lblLogoText
            // 
            this.lblLogoText.Font = new System.Drawing.Font("Segoe UI Emoji", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoText.ForeColor = System.Drawing.Color.White;
            this.lblLogoText.Location = new System.Drawing.Point(7, 7);
            this.lblLogoText.Name = "lblLogoText";
            this.lblLogoText.Size = new System.Drawing.Size(96, 96);
            this.lblLogoText.TabIndex = 0;
            this.lblLogoText.Text = "🏛";
            this.lblLogoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(176, 46);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(1580, 100);
            this.lblAppTitle.TabIndex = 1;
            this.lblAppTitle.Text = "MUNICIPAL SERVICES";
            // 
            // lblAppSubtitle
            // 
            this.lblAppSubtitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(18)))));
            this.lblAppSubtitle.Location = new System.Drawing.Point(180, 154);
            this.lblAppSubtitle.Name = "lblAppSubtitle";
            this.lblAppSubtitle.Size = new System.Drawing.Size(1580, 52);
            this.lblAppSubtitle.TabIndex = 2;
            this.lblAppSubtitle.Text = "Serving South African Communities — Reporting Portal v1.0";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.pnlContent.Controls.Add(this.pnlStatusCard);
            this.pnlContent.Controls.Add(this.pnlEventsCard);
            this.pnlContent.Controls.Add(this.pnlReportCard);
            this.pnlContent.Controls.Add(this.lblWelcome);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 220);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1800, 810);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlStatusCard
            // 
            this.pnlStatusCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.pnlStatusCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatusCard.Controls.Add(this.lblStatusSoon);
            this.pnlStatusCard.Controls.Add(this.lblStatusCardIcon);
            this.pnlStatusCard.Controls.Add(this.lblStatusCardTitle);
            this.pnlStatusCard.Controls.Add(this.lblStatusCardDesc);
            this.pnlStatusCard.Controls.Add(this.btnStatus);
            this.pnlStatusCard.Location = new System.Drawing.Point(1235, 105);
            this.pnlStatusCard.Name = "pnlStatusCard";
            this.pnlStatusCard.Size = new System.Drawing.Size(460, 600);
            this.pnlStatusCard.TabIndex = 3;
            // 
            // lblStatusSoon
            // 
            this.lblStatusSoon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusSoon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblStatusSoon.Location = new System.Drawing.Point(16, 14);
            this.lblStatusSoon.Name = "lblStatusSoon";
            this.lblStatusSoon.Size = new System.Drawing.Size(220, 32);
            this.lblStatusSoon.TabIndex = 0;
            this.lblStatusSoon.Text = "● COMING SOON";
            // 
            // lblStatusCardIcon
            // 
            this.lblStatusCardIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCardIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblStatusCardIcon.Location = new System.Drawing.Point(0, 46);
            this.lblStatusCardIcon.Name = "lblStatusCardIcon";
            this.lblStatusCardIcon.Size = new System.Drawing.Size(460, 130);
            this.lblStatusCardIcon.TabIndex = 1;
            this.lblStatusCardIcon.Text = "📋";
            this.lblStatusCardIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusCardTitle
            // 
            this.lblStatusCardTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblStatusCardTitle.Location = new System.Drawing.Point(16, 190);
            this.lblStatusCardTitle.Name = "lblStatusCardTitle";
            this.lblStatusCardTitle.Size = new System.Drawing.Size(428, 110);
            this.lblStatusCardTitle.TabIndex = 2;
            this.lblStatusCardTitle.Text = "Service Request\nStatus";
            this.lblStatusCardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusCardDesc
            // 
            this.lblStatusCardDesc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCardDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblStatusCardDesc.Location = new System.Drawing.Point(20, 314);
            this.lblStatusCardDesc.Name = "lblStatusCardDesc";
            this.lblStatusCardDesc.Size = new System.Drawing.Size(420, 170);
            this.lblStatusCardDesc.TabIndex = 3;
            this.lblStatusCardDesc.Text = "Track the progress of your previously submitted service requests and issue report" +
    "s.";
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btnStatus.Cursor = System.Windows.Forms.Cursors.No;
            this.btnStatus.Enabled = false;
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnStatus.Location = new System.Drawing.Point(30, 532);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(400, 54);
            this.btnStatus.TabIndex = 4;
            this.btnStatus.Text = "Coming Soon";
            this.btnStatus.UseVisualStyleBackColor = false;
            // 
            // pnlEventsCard
            // 
            this.pnlEventsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.pnlEventsCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEventsCard.Controls.Add(this.lblEventsSoon);
            this.pnlEventsCard.Controls.Add(this.lblEventsCardIcon);
            this.pnlEventsCard.Controls.Add(this.lblEventsCardTitle);
            this.pnlEventsCard.Controls.Add(this.lblEventsCardDesc);
            this.pnlEventsCard.Controls.Add(this.btnEvents);
            this.pnlEventsCard.Location = new System.Drawing.Point(670, 105);
            this.pnlEventsCard.Name = "pnlEventsCard";
            this.pnlEventsCard.Size = new System.Drawing.Size(460, 600);
            this.pnlEventsCard.TabIndex = 2;
            // 
            // lblEventsSoon
            // 
            this.lblEventsSoon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventsSoon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblEventsSoon.Location = new System.Drawing.Point(16, 14);
            this.lblEventsSoon.Name = "lblEventsSoon";
            this.lblEventsSoon.Size = new System.Drawing.Size(220, 32);
            this.lblEventsSoon.TabIndex = 0;
            this.lblEventsSoon.Text = "● COMING SOON";
            // 
            // lblEventsCardIcon
            // 
            this.lblEventsCardIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventsCardIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblEventsCardIcon.Location = new System.Drawing.Point(0, 46);
            this.lblEventsCardIcon.Name = "lblEventsCardIcon";
            this.lblEventsCardIcon.Size = new System.Drawing.Size(460, 130);
            this.lblEventsCardIcon.TabIndex = 1;
            this.lblEventsCardIcon.Text = "📅";
            this.lblEventsCardIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEventsCardIcon.Click += new System.EventHandler(this.lblEventsCardIcon_Click);
            // 
            // lblEventsCardTitle
            // 
            this.lblEventsCardTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventsCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblEventsCardTitle.Location = new System.Drawing.Point(16, 190);
            this.lblEventsCardTitle.Name = "lblEventsCardTitle";
            this.lblEventsCardTitle.Size = new System.Drawing.Size(428, 110);
            this.lblEventsCardTitle.TabIndex = 2;
            this.lblEventsCardTitle.Text = "Local Events &&\nAnnouncements";
            this.lblEventsCardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEventsCardDesc
            // 
            this.lblEventsCardDesc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventsCardDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblEventsCardDesc.Location = new System.Drawing.Point(20, 314);
            this.lblEventsCardDesc.Name = "lblEventsCardDesc";
            this.lblEventsCardDesc.Size = new System.Drawing.Size(420, 170);
            this.lblEventsCardDesc.TabIndex = 3;
            this.lblEventsCardDesc.Text = "Stay informed about upcoming community events, public meetings, and official anno" +
    "uncements.";
            // 
            // btnEvents
            // 
            this.btnEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btnEvents.Cursor = System.Windows.Forms.Cursors.No;
            this.btnEvents.Enabled = false;
            this.btnEvents.FlatAppearance.BorderSize = 0;
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnEvents.Location = new System.Drawing.Point(30, 532);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(400, 54);
            this.btnEvents.TabIndex = 4;
            this.btnEvents.Text = "Coming Soon";
            this.btnEvents.UseVisualStyleBackColor = false;
            // 
            // pnlReportCard
            // 
            this.pnlReportCard.BackColor = System.Drawing.Color.White;
            this.pnlReportCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReportCard.Controls.Add(this.lblReportCardIcon);
            this.pnlReportCard.Controls.Add(this.lblReportCardTitle);
            this.pnlReportCard.Controls.Add(this.lblReportCardDesc);
            this.pnlReportCard.Controls.Add(this.btnReportIssues);
            this.pnlReportCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlReportCard.Location = new System.Drawing.Point(105, 105);
            this.pnlReportCard.Name = "pnlReportCard";
            this.pnlReportCard.Size = new System.Drawing.Size(460, 600);
            this.pnlReportCard.TabIndex = 1;
            this.pnlReportCard.Click += new System.EventHandler(this.pnlReportCard_Click);
            this.pnlReportCard.MouseEnter += new System.EventHandler(this.pnlReportCard_MouseEnter);
            this.pnlReportCard.MouseLeave += new System.EventHandler(this.pnlReportCard_MouseLeave);
            // 
            // lblReportCardIcon
            //
            this.lblReportCardIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportCardIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.lblReportCardIcon.Location = new System.Drawing.Point(0, 46);
            this.lblReportCardIcon.Name = "lblReportCardIcon";
            this.lblReportCardIcon.Size = new System.Drawing.Size(460, 130);
            this.lblReportCardIcon.TabIndex = 0;
            this.lblReportCardIcon.Text = "⚠️";
            this.lblReportCardIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReportCardIcon.Click += new System.EventHandler(this.lblReportCardIcon_Click);
            // 
            // lblReportCardTitle
            // 
            this.lblReportCardTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.lblReportCardTitle.Location = new System.Drawing.Point(16, 190);
            this.lblReportCardTitle.Name = "lblReportCardTitle";
            this.lblReportCardTitle.Size = new System.Drawing.Size(428, 110);
            this.lblReportCardTitle.TabIndex = 1;
            this.lblReportCardTitle.Text = "Report Issues";
            this.lblReportCardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReportCardTitle.Click += new System.EventHandler(this.lblReportCardTitle_Click);
            // 
            // lblReportCardDesc
            // 
            this.lblReportCardDesc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportCardDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblReportCardDesc.Location = new System.Drawing.Point(20, 314);
            this.lblReportCardDesc.Name = "lblReportCardDesc";
            this.lblReportCardDesc.Size = new System.Drawing.Size(420, 170);
            this.lblReportCardDesc.TabIndex = 2;
            this.lblReportCardDesc.Text = "Report potholes, sanitation problems, broken utilities, and other municipal issue" +
    "s in your area.";
            this.lblReportCardDesc.Click += new System.EventHandler(this.lblReportCardDesc_Click);
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnReportIssues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportIssues.FlatAppearance.BorderSize = 0;
            this.btnReportIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportIssues.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportIssues.ForeColor = System.Drawing.Color.White;
            this.btnReportIssues.Location = new System.Drawing.Point(30, 532);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(400, 54);
            this.btnReportIssues.TabIndex = 3;
            this.btnReportIssues.Text = "Get Started  →";
            this.btnReportIssues.UseVisualStyleBackColor = false;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.lblWelcome.Location = new System.Drawing.Point(0, 28);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1800, 60);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome! How can we assist you today?";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.pnlFooter.Controls.Add(this.lblDateTime);
            this.pnlFooter.Controls.Add(this.lblVersion);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 1030);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1800, 70);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(26, 18);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(80, 41);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "Date";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(18)))));
            this.lblVersion.Location = new System.Drawing.Point(1430, 18);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(368, 41);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version 1.0.0  |  PROG7312";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1800, 1100);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1400, 900);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SA Municipal Services";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMenuForm_Paint);
            this.pnlHeader.ResumeLayout(false);
            this.pnlLogoCircle.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlStatusCard.ResumeLayout(false);
            this.pnlEventsCard.ResumeLayout(false);
            this.pnlReportCard.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlLogoCircle;
        private System.Windows.Forms.Label lblLogoText;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblAppSubtitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlReportCard;
        private System.Windows.Forms.Label lblReportCardIcon;
        private System.Windows.Forms.Label lblReportCardTitle;
        private System.Windows.Forms.Label lblReportCardDesc;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Panel pnlEventsCard;
        private System.Windows.Forms.Label lblEventsCardIcon;
        private System.Windows.Forms.Label lblEventsCardTitle;
        private System.Windows.Forms.Label lblEventsCardDesc;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Label lblEventsSoon;
        private System.Windows.Forms.Panel pnlStatusCard;
        private System.Windows.Forms.Label lblStatusCardIcon;
        private System.Windows.Forms.Label lblStatusCardTitle;
        private System.Windows.Forms.Label lblStatusCardDesc;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Label lblStatusSoon;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblVersion;
    }
}
