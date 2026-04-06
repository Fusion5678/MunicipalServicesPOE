namespace MunicipalServices.Forms
{
    partial class ReportIssuesForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblFormSubtitle = new System.Windows.Forms.Label();
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.lblEngagement = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblProgressPercent = new System.Windows.Forms.Label();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlScrollOuter = new System.Windows.Forms.Panel();
            this.pnlScrollInner = new System.Windows.Forms.Panel();
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.lblLocationHint = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.lblCategoryHint = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.grpDescription = new System.Windows.Forms.GroupBox();
            this.lblDescHint = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.grpMedia = new System.Windows.Forms.GroupBox();
            this.lblMediaHint = new System.Windows.Forms.Label();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnRemoveAttachment = new System.Windows.Forms.Button();
            this.lstAttachments = new System.Windows.Forms.ListBox();
            this.lblAttachCount = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlProgress.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.pnlScrollOuter.SuspendLayout();
            this.pnlScrollInner.SuspendLayout();
            this.grpLocation.SuspendLayout();
            this.grpCategory.SuspendLayout();
            this.grpDescription.SuspendLayout();
            this.grpMedia.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.lblFormTitle);
            this.pnlHeader.Controls.Add(this.lblFormSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1180, 120);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(18)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(18)))));
            this.btnBack.Location = new System.Drawing.Point(8, 42);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 60);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "←  Back to Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(168, 16);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(800, 56);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "Report an Issue";
            // 
            // lblFormSubtitle
            // 
            this.lblFormSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(18)))));
            this.lblFormSubtitle.Location = new System.Drawing.Point(170, 78);
            this.lblFormSubtitle.Name = "lblFormSubtitle";
            this.lblFormSubtitle.Size = new System.Drawing.Size(800, 30);
            this.lblFormSubtitle.TabIndex = 2;
            this.lblFormSubtitle.Text = "Help us improve your community by reporting municipal problems";
            // 
            // pnlProgress
            // 
            this.pnlProgress.BackColor = System.Drawing.Color.White;
            this.pnlProgress.Controls.Add(this.lblEngagement);
            this.pnlProgress.Controls.Add(this.progressBar);
            this.pnlProgress.Controls.Add(this.lblProgressPercent);
            this.pnlProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProgress.Location = new System.Drawing.Point(0, 120);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(1180, 81);
            this.pnlProgress.TabIndex = 1;
            // 
            // lblEngagement
            // 
            this.lblEngagement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblEngagement.Location = new System.Drawing.Point(12, 3);
            this.lblEngagement.Name = "lblEngagement";
            this.lblEngagement.Size = new System.Drawing.Size(900, 30);
            this.lblEngagement.TabIndex = 0;
            this.lblEngagement.Text = "Let us get started! Fill in the location of the issue below.";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(10, 40);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1080, 20);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 1;
            // 
            // lblProgressPercent
            // 
            this.lblProgressPercent.AutoSize = true;
            this.lblProgressPercent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.lblProgressPercent.Location = new System.Drawing.Point(1108, 30);
            this.lblProgressPercent.Name = "lblProgressPercent";
            this.lblProgressPercent.Size = new System.Drawing.Size(49, 32);
            this.lblProgressPercent.TabIndex = 2;
            this.lblProgressPercent.Text = "0%";
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.White;
            this.pnlActions.Controls.Add(this.btnClear);
            this.pnlActions.Controls.Add(this.btnSubmit);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActions.Location = new System.Drawing.Point(0, 781);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(1180, 60);
            this.pnlActions.TabIndex = 3;
            this.pnlActions.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlActions_Paint);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnClear.Location = new System.Drawing.Point(410, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 42);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Enabled = false;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnSubmit.Location = new System.Drawing.Point(602, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 45);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit Report";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlScrollOuter
            // 
            this.pnlScrollOuter.AutoScroll = true;
            this.pnlScrollOuter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.pnlScrollOuter.Controls.Add(this.pnlScrollInner);
            this.pnlScrollOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScrollOuter.Location = new System.Drawing.Point(0, 201);
            this.pnlScrollOuter.Name = "pnlScrollOuter";
            this.pnlScrollOuter.Size = new System.Drawing.Size(1180, 580);
            this.pnlScrollOuter.TabIndex = 2;
            // 
            // pnlScrollInner
            // 
            this.pnlScrollInner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.pnlScrollInner.Controls.Add(this.grpLocation);
            this.pnlScrollInner.Controls.Add(this.grpCategory);
            this.pnlScrollInner.Controls.Add(this.grpDescription);
            this.pnlScrollInner.Controls.Add(this.grpMedia);
            this.pnlScrollInner.Location = new System.Drawing.Point(10, 10);
            this.pnlScrollInner.Name = "pnlScrollInner";
            this.pnlScrollInner.Size = new System.Drawing.Size(1160, 820);
            this.pnlScrollInner.TabIndex = 0;
            // 
            // grpLocation
            // 
            this.grpLocation.BackColor = System.Drawing.Color.White;
            this.grpLocation.Controls.Add(this.lblLocationHint);
            this.grpLocation.Controls.Add(this.txtLocation);
            this.grpLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.grpLocation.Location = new System.Drawing.Point(0, 6);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Size = new System.Drawing.Size(1150, 155);
            this.grpLocation.TabIndex = 0;
            this.grpLocation.TabStop = false;
            this.grpLocation.Text = "  1.  Location of Issue";
            this.grpLocation.Enter += new System.EventHandler(this.grpLocation_Enter);
            // 
            // lblLocationHint
            // 
            this.lblLocationHint.AutoSize = true;
            this.lblLocationHint.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblLocationHint.Location = new System.Drawing.Point(12, 35);
            this.lblLocationHint.Name = "lblLocationHint";
            this.lblLocationHint.Size = new System.Drawing.Size(601, 30);
            this.lblLocationHint.TabIndex = 0;
            this.lblLocationHint.Text = "Enter the street address, suburb, or landmarks near the issue:";
            this.lblLocationHint.Click += new System.EventHandler(this.lblLocationHint_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(12, 68);
            this.txtLocation.MaxLength = 250;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(1126, 43);
            this.txtLocation.TabIndex = 1;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // grpCategory
            // 
            this.grpCategory.BackColor = System.Drawing.Color.White;
            this.grpCategory.Controls.Add(this.lblCategoryHint);
            this.grpCategory.Controls.Add(this.cboCategory);
            this.grpCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.grpCategory.Location = new System.Drawing.Point(0, 172);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Size = new System.Drawing.Size(1150, 148);
            this.grpCategory.TabIndex = 1;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "  2.  Category";
            // 
            // lblCategoryHint
            // 
            this.lblCategoryHint.AutoSize = true;
            this.lblCategoryHint.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblCategoryHint.Location = new System.Drawing.Point(12, 35);
            this.lblCategoryHint.Name = "lblCategoryHint";
            this.lblCategoryHint.Size = new System.Drawing.Size(481, 30);
            this.lblCategoryHint.TabIndex = 0;
            this.lblCategoryHint.Text = "Select the category that best describes the issue:";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(17, 68);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(400, 45);
            this.cboCategory.TabIndex = 1;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // grpDescription
            // 
            this.grpDescription.BackColor = System.Drawing.Color.White;
            this.grpDescription.Controls.Add(this.lblDescHint);
            this.grpDescription.Controls.Add(this.rtbDescription);
            this.grpDescription.Controls.Add(this.lblCharCount);
            this.grpDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.grpDescription.Location = new System.Drawing.Point(0, 332);
            this.grpDescription.Name = "grpDescription";
            this.grpDescription.Size = new System.Drawing.Size(1150, 240);
            this.grpDescription.TabIndex = 2;
            this.grpDescription.TabStop = false;
            this.grpDescription.Text = "  3.  Description";
            // 
            // lblDescHint
            // 
            this.lblDescHint.AutoSize = true;
            this.lblDescHint.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblDescHint.Location = new System.Drawing.Point(12, 35);
            this.lblDescHint.Name = "lblDescHint";
            this.lblDescHint.Size = new System.Drawing.Size(640, 30);
            this.lblDescHint.TabIndex = 0;
            this.lblDescHint.Text = "Provide a detailed description of the issue (max 1000 characters):";
            // 
            // rtbDescription
            // 
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.Location = new System.Drawing.Point(12, 68);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbDescription.Size = new System.Drawing.Size(1126, 143);
            this.rtbDescription.TabIndex = 1;
            this.rtbDescription.Text = "";
            this.rtbDescription.TextChanged += new System.EventHandler(this.rtbDescription_TextChanged);
            // 
            // lblCharCount
            // 
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharCount.ForeColor = System.Drawing.Color.Gray;
            this.lblCharCount.Location = new System.Drawing.Point(12, 214);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(198, 30);
            this.lblCharCount.TabIndex = 2;
            this.lblCharCount.Text = "0 / 1000 characters";
            // 
            // grpMedia
            // 
            this.grpMedia.BackColor = System.Drawing.Color.White;
            this.grpMedia.Controls.Add(this.lblMediaHint);
            this.grpMedia.Controls.Add(this.btnAttach);
            this.grpMedia.Controls.Add(this.btnRemoveAttachment);
            this.grpMedia.Controls.Add(this.lstAttachments);
            this.grpMedia.Controls.Add(this.lblAttachCount);
            this.grpMedia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.grpMedia.Location = new System.Drawing.Point(0, 584);
            this.grpMedia.Name = "grpMedia";
            this.grpMedia.Size = new System.Drawing.Size(1150, 220);
            this.grpMedia.TabIndex = 3;
            this.grpMedia.TabStop = false;
            this.grpMedia.Text = "  4.  Media Attachments  (Optional)";
            this.grpMedia.Enter += new System.EventHandler(this.grpMedia_Enter);
            // 
            // lblMediaHint
            // 
            this.lblMediaHint.AutoSize = true;
            this.lblMediaHint.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblMediaHint.Location = new System.Drawing.Point(6, 28);
            this.lblMediaHint.Name = "lblMediaHint";
            this.lblMediaHint.Size = new System.Drawing.Size(866, 30);
            this.lblMediaHint.TabIndex = 0;
            this.lblMediaHint.Text = "Attach photos or documents to support your report (images, PDFs, Word files accep" +
    "ted):";
            // 
            // btnAttach
            // 
            this.btnAttach.BackColor = System.Drawing.Color.White;
            this.btnAttach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(135)))));
            this.btnAttach.Location = new System.Drawing.Point(3, 61);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(150, 48);
            this.btnAttach.TabIndex = 1;
            this.btnAttach.Text = "+ Attach File(s)";
            this.btnAttach.UseVisualStyleBackColor = false;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // btnRemoveAttachment
            // 
            this.btnRemoveAttachment.BackColor = System.Drawing.Color.White;
            this.btnRemoveAttachment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveAttachment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnRemoveAttachment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAttachment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAttachment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRemoveAttachment.Location = new System.Drawing.Point(159, 61);
            this.btnRemoveAttachment.Name = "btnRemoveAttachment";
            this.btnRemoveAttachment.Size = new System.Drawing.Size(150, 48);
            this.btnRemoveAttachment.TabIndex = 2;
            this.btnRemoveAttachment.Text = "Remove Selected";
            this.btnRemoveAttachment.UseVisualStyleBackColor = false;
            this.btnRemoveAttachment.Click += new System.EventHandler(this.btnRemoveAttachment_Click);
            // 
            // lstAttachments
            // 
            this.lstAttachments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAttachments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAttachments.FormattingEnabled = true;
            this.lstAttachments.ItemHeight = 32;
            this.lstAttachments.Location = new System.Drawing.Point(6, 115);
            this.lstAttachments.Name = "lstAttachments";
            this.lstAttachments.Size = new System.Drawing.Size(1126, 66);
            this.lstAttachments.TabIndex = 3;
            // 
            // lblAttachCount
            // 
            this.lblAttachCount.AutoSize = true;
            this.lblAttachCount.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttachCount.ForeColor = System.Drawing.Color.Gray;
            this.lblAttachCount.Location = new System.Drawing.Point(12, 184);
            this.lblAttachCount.Name = "lblAttachCount";
            this.lblAttachCount.Size = new System.Drawing.Size(172, 30);
            this.lblAttachCount.TabIndex = 4;
            this.lblAttachCount.Text = "0 file(s) attached";
            // 
            // ReportIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1180, 841);
            this.Controls.Add(this.pnlScrollOuter);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlProgress);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "ReportIssuesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report an Issue — Municipal Services";
            this.pnlHeader.ResumeLayout(false);
            this.pnlProgress.ResumeLayout(false);
            this.pnlProgress.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.pnlScrollOuter.ResumeLayout(false);
            this.pnlScrollInner.ResumeLayout(false);
            this.grpLocation.ResumeLayout(false);
            this.grpLocation.PerformLayout();
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            this.grpDescription.ResumeLayout(false);
            this.grpDescription.PerformLayout();
            this.grpMedia.ResumeLayout(false);
            this.grpMedia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblFormSubtitle;
        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.Label lblEngagement;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblProgressPercent;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlScrollOuter;
        private System.Windows.Forms.Panel pnlScrollInner;
        private System.Windows.Forms.GroupBox grpLocation;
        private System.Windows.Forms.Label lblLocationHint;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.Label lblCategoryHint;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.GroupBox grpDescription;
        private System.Windows.Forms.Label lblDescHint;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblCharCount;
        private System.Windows.Forms.GroupBox grpMedia;
        private System.Windows.Forms.Label lblMediaHint;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnRemoveAttachment;
        private System.Windows.Forms.ListBox lstAttachments;
        private System.Windows.Forms.Label lblAttachCount;
    }
}
