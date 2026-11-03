namespace PayrollEase
{
    partial class AttendanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPunch = new System.Windows.Forms.Panel();
            this.pnlRules = new System.Windows.Forms.Panel();
            this.pnlRecords = new System.Windows.Forms.Panel();
            this.lblPunchTitle = new System.Windows.Forms.Label();
            this.lblBigClock = new System.Windows.Forms.Label();
            this.cmbPunchEmployee = new System.Windows.Forms.ComboBox();
            this.btnTimeIn = new System.Windows.Forms.Button();
            this.btnTimeOut = new System.Windows.Forms.Button();
            this.lblPunchResult = new System.Windows.Forms.Label();
            this.lblRulesTitle = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblEmpFilter = new System.Windows.Forms.Label();
            this.cmbEmployeeFilter = new System.Windows.Forms.ComboBox();
            this.lblStatusFilter = new System.Windows.Forms.Label();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.pnlEntry = new System.Windows.Forms.Panel();
            this.lblEntryTitle = new System.Windows.Forms.Label();
            this.lblRecordID = new System.Windows.Forms.Label();
            this.txtRecordID = new System.Windows.Forms.TextBox();
            this.lblEntryEmployee = new System.Windows.Forms.Label();
            this.cmbEntryEmployee = new System.Windows.Forms.ComboBox();
            this.lblEntryDate = new System.Windows.Forms.Label();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.lblEntryMode = new System.Windows.Forms.Label();
            this.cmbEntryMode = new System.Windows.Forms.ComboBox();
            this.lblEntryIn = new System.Windows.Forms.Label();
            this.dtpTimeIn = new System.Windows.Forms.DateTimePicker();
            this.lblEntryOut = new System.Windows.Forms.Label();
            this.dtpTimeOut = new System.Windows.Forms.DateTimePicker();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.pnlPunch.SuspendLayout();
            this.pnlRules.SuspendLayout();
            this.pnlRecords.SuspendLayout();
            this.pnlEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPunch
            // 
            this.pnlPunch.Controls.Add(this.lblPunchTitle);
            this.pnlPunch.Controls.Add(this.lblBigClock);
            this.pnlPunch.Controls.Add(this.cmbPunchEmployee);
            this.pnlPunch.Controls.Add(this.btnTimeIn);
            this.pnlPunch.Controls.Add(this.btnTimeOut);
            this.pnlPunch.Controls.Add(this.lblPunchResult);
            this.pnlPunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlPunch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlPunch.Location = new System.Drawing.Point(24, 18);
            this.pnlPunch.Name = "pnlPunch";
            this.pnlPunch.Size = new System.Drawing.Size(560, 128);
            this.pnlPunch.TabIndex = 0;
            // 
            // pnlRules
            // 
            this.pnlRules.Controls.Add(this.lblRulesTitle);
            this.pnlRules.Controls.Add(this.lblRules);
            this.pnlRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlRules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRules.Location = new System.Drawing.Point(596, 18);
            this.pnlRules.Name = "pnlRules";
            this.pnlRules.Size = new System.Drawing.Size(480, 128);
            this.pnlRules.TabIndex = 1;
            // 
            // pnlRecords
            // 
            this.pnlRecords.Controls.Add(this.lblFrom);
            this.pnlRecords.Controls.Add(this.dtpFrom);
            this.pnlRecords.Controls.Add(this.lblTo);
            this.pnlRecords.Controls.Add(this.dtpTo);
            this.pnlRecords.Controls.Add(this.lblEmpFilter);
            this.pnlRecords.Controls.Add(this.cmbEmployeeFilter);
            this.pnlRecords.Controls.Add(this.lblStatusFilter);
            this.pnlRecords.Controls.Add(this.cmbStatusFilter);
            this.pnlRecords.Controls.Add(this.dgvAttendance);
            this.pnlRecords.Controls.Add(this.pnlEntry);
            this.pnlRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRecords.Location = new System.Drawing.Point(24, 158);
            this.pnlRecords.Name = "pnlRecords";
            this.pnlRecords.Size = new System.Drawing.Size(1052, 518);
            this.pnlRecords.TabIndex = 2;
            // 
            // lblPunchTitle
            // 
            this.lblPunchTitle.AutoSize = true;
            this.lblPunchTitle.Text = "QUICK PUNCH";
            this.lblPunchTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunchTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPunchTitle.Location = new System.Drawing.Point(16, 10);
            this.lblPunchTitle.Name = "lblPunchTitle";
            this.lblPunchTitle.TabIndex = 3;
            // 
            // lblBigClock
            // 
            this.lblBigClock.AutoSize = true;
            this.lblBigClock.Text = "";
            this.lblBigClock.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBigClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblBigClock.Location = new System.Drawing.Point(14, 30);
            this.lblBigClock.Name = "lblBigClock";
            this.lblBigClock.TabIndex = 4;
            // 
            // cmbPunchEmployee
            // 
            this.cmbPunchEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPunchEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPunchEmployee.FormattingEnabled = true;
            this.cmbPunchEmployee.Location = new System.Drawing.Point(240, 30);
            this.cmbPunchEmployee.Name = "cmbPunchEmployee";
            this.cmbPunchEmployee.Size = new System.Drawing.Size(300, 27);
            this.cmbPunchEmployee.TabIndex = 5;
            // 
            // btnTimeIn
            // 
            this.btnTimeIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnTimeIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTimeIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeIn.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeIn.Text = "TIME IN";
            this.btnTimeIn.FlatAppearance.BorderSize = 0;
            this.btnTimeIn.Location = new System.Drawing.Point(240, 72);
            this.btnTimeIn.Name = "btnTimeIn";
            this.btnTimeIn.Size = new System.Drawing.Size(145, 40);
            this.btnTimeIn.TabIndex = 6;
            this.btnTimeIn.UseVisualStyleBackColor = false;
            this.btnTimeIn.Click += new System.EventHandler(this.btnTimeIn_Click);
            // 
            // btnTimeOut
            // 
            this.btnTimeOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnTimeOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTimeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeOut.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeOut.Text = "TIME OUT";
            this.btnTimeOut.FlatAppearance.BorderSize = 0;
            this.btnTimeOut.Location = new System.Drawing.Point(395, 72);
            this.btnTimeOut.Name = "btnTimeOut";
            this.btnTimeOut.Size = new System.Drawing.Size(145, 40);
            this.btnTimeOut.TabIndex = 7;
            this.btnTimeOut.UseVisualStyleBackColor = false;
            this.btnTimeOut.Click += new System.EventHandler(this.btnTimeOut_Click);
            // 
            // lblPunchResult
            // 
            this.lblPunchResult.AutoSize = false;
            this.lblPunchResult.Text = "Select an employee, then press Time In or Time Out.";
            this.lblPunchResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunchResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPunchResult.Location = new System.Drawing.Point(16, 74);
            this.lblPunchResult.Name = "lblPunchResult";
            this.lblPunchResult.Size = new System.Drawing.Size(210, 46);
            this.lblPunchResult.TabIndex = 8;
            // 
            // lblRulesTitle
            // 
            this.lblRulesTitle.AutoSize = true;
            this.lblRulesTitle.Text = "WORK SCHEDULE & RULES";
            this.lblRulesTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRulesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblRulesTitle.Location = new System.Drawing.Point(16, 10);
            this.lblRulesTitle.Name = "lblRulesTitle";
            this.lblRulesTitle.TabIndex = 9;
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Text = "";
            this.lblRules.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblRules.Location = new System.Drawing.Point(16, 34);
            this.lblRules.Name = "lblRules";
            this.lblRules.TabIndex = 10;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Text = "FROM";
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblFrom.Location = new System.Drawing.Point(16, 10);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.TabIndex = 11;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.CustomFormat = "MMM dd, yyyy";
            this.dtpFrom.Location = new System.Drawing.Point(16, 28);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(150, 27);
            this.dtpFrom.TabIndex = 12;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Text = "TO";
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTo.Location = new System.Drawing.Point(180, 10);
            this.lblTo.Name = "lblTo";
            this.lblTo.TabIndex = 13;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.CustomFormat = "MMM dd, yyyy";
            this.dtpTo.Location = new System.Drawing.Point(180, 28);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(150, 27);
            this.dtpTo.TabIndex = 14;
            this.dtpTo.ValueChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // lblEmpFilter
            // 
            this.lblEmpFilter.AutoSize = true;
            this.lblEmpFilter.Text = "EMPLOYEE";
            this.lblEmpFilter.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblEmpFilter.Location = new System.Drawing.Point(344, 10);
            this.lblEmpFilter.Name = "lblEmpFilter";
            this.lblEmpFilter.TabIndex = 15;
            // 
            // cmbEmployeeFilter
            // 
            this.cmbEmployeeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployeeFilter.FormattingEnabled = true;
            this.cmbEmployeeFilter.Location = new System.Drawing.Point(344, 28);
            this.cmbEmployeeFilter.Name = "cmbEmployeeFilter";
            this.cmbEmployeeFilter.Size = new System.Drawing.Size(250, 27);
            this.cmbEmployeeFilter.TabIndex = 16;
            this.cmbEmployeeFilter.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // lblStatusFilter
            // 
            this.lblStatusFilter.AutoSize = true;
            this.lblStatusFilter.Text = "STATUS";
            this.lblStatusFilter.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblStatusFilter.Location = new System.Drawing.Point(608, 10);
            this.lblStatusFilter.Name = "lblStatusFilter";
            this.lblStatusFilter.TabIndex = 17;
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.Items.AddRange(new object[] {
            "All",
            "Present",
            "Late",
            "Half Day",
            "Absent",
            "Leave"});
            this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Location = new System.Drawing.Point(608, 28);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(140, 27);
            this.cmbStatusFilter.TabIndex = 18;
            this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.AllowUserToResizeRows = false;
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAttendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAttendance.ColumnHeadersHeight = 38;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAttendance.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAttendance.EnableHeadersVisualStyles = false;
            this.dgvAttendance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvAttendance.MultiSelect = false;
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.RowTemplate.Height = 36;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAttendance.Location = new System.Drawing.Point(16, 68);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.Size = new System.Drawing.Size(1018, 290);
            this.dgvAttendance.TabIndex = 19;
            this.dgvAttendance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendance_CellClick);
            // 
            // pnlEntry
            // 
            this.pnlEntry.Controls.Add(this.lblEntryTitle);
            this.pnlEntry.Controls.Add(this.lblRecordID);
            this.pnlEntry.Controls.Add(this.txtRecordID);
            this.pnlEntry.Controls.Add(this.lblEntryEmployee);
            this.pnlEntry.Controls.Add(this.cmbEntryEmployee);
            this.pnlEntry.Controls.Add(this.lblEntryDate);
            this.pnlEntry.Controls.Add(this.dtpEntryDate);
            this.pnlEntry.Controls.Add(this.lblEntryMode);
            this.pnlEntry.Controls.Add(this.cmbEntryMode);
            this.pnlEntry.Controls.Add(this.lblEntryIn);
            this.pnlEntry.Controls.Add(this.dtpTimeIn);
            this.pnlEntry.Controls.Add(this.lblEntryOut);
            this.pnlEntry.Controls.Add(this.dtpTimeOut);
            this.pnlEntry.Controls.Add(this.lblRemarks);
            this.pnlEntry.Controls.Add(this.txtRemarks);
            this.pnlEntry.Controls.Add(this.btnAdd);
            this.pnlEntry.Controls.Add(this.btnUpdate);
            this.pnlEntry.Controls.Add(this.btnDelete);
            this.pnlEntry.Controls.Add(this.btnClear);
            this.pnlEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEntry.Location = new System.Drawing.Point(16, 368);
            this.pnlEntry.Name = "pnlEntry";
            this.pnlEntry.Size = new System.Drawing.Size(1018, 138);
            this.pnlEntry.TabIndex = 20;
            // 
            // lblEntryTitle
            // 
            this.lblEntryTitle.AutoSize = true;
            this.lblEntryTitle.Text = "MANUAL ENTRY / EDIT  (click a row in the table to edit it)";
            this.lblEntryTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblEntryTitle.Location = new System.Drawing.Point(0, 0);
            this.lblEntryTitle.Name = "lblEntryTitle";
            this.lblEntryTitle.TabIndex = 21;
            // 
            // lblRecordID
            // 
            this.lblRecordID.AutoSize = true;
            this.lblRecordID.Text = "RECORD ID";
            this.lblRecordID.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblRecordID.Location = new System.Drawing.Point(0, 24);
            this.lblRecordID.Name = "lblRecordID";
            this.lblRecordID.TabIndex = 22;
            // 
            // txtRecordID
            // 
            this.txtRecordID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecordID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecordID.ReadOnly = true;
            this.txtRecordID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtRecordID.Location = new System.Drawing.Point(0, 42);
            this.txtRecordID.Name = "txtRecordID";
            this.txtRecordID.Size = new System.Drawing.Size(60, 27);
            this.txtRecordID.TabIndex = 23;
            // 
            // lblEntryEmployee
            // 
            this.lblEntryEmployee.AutoSize = true;
            this.lblEntryEmployee.Text = "EMPLOYEE";
            this.lblEntryEmployee.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblEntryEmployee.Location = new System.Drawing.Point(70, 24);
            this.lblEntryEmployee.Name = "lblEntryEmployee";
            this.lblEntryEmployee.TabIndex = 24;
            // 
            // cmbEntryEmployee
            // 
            this.cmbEntryEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntryEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEntryEmployee.FormattingEnabled = true;
            this.cmbEntryEmployee.Location = new System.Drawing.Point(70, 42);
            this.cmbEntryEmployee.Name = "cmbEntryEmployee";
            this.cmbEntryEmployee.Size = new System.Drawing.Size(230, 27);
            this.cmbEntryEmployee.TabIndex = 25;
            // 
            // lblEntryDate
            // 
            this.lblEntryDate.AutoSize = true;
            this.lblEntryDate.Text = "DATE";
            this.lblEntryDate.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblEntryDate.Location = new System.Drawing.Point(312, 24);
            this.lblEntryDate.Name = "lblEntryDate";
            this.lblEntryDate.TabIndex = 26;
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntryDate.CustomFormat = "MMM dd, yyyy";
            this.dtpEntryDate.Location = new System.Drawing.Point(312, 42);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(130, 27);
            this.dtpEntryDate.TabIndex = 27;
            // 
            // lblEntryMode
            // 
            this.lblEntryMode.AutoSize = true;
            this.lblEntryMode.Text = "STATUS";
            this.lblEntryMode.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblEntryMode.Location = new System.Drawing.Point(454, 24);
            this.lblEntryMode.Name = "lblEntryMode";
            this.lblEntryMode.TabIndex = 28;
            // 
            // cmbEntryMode
            // 
            this.cmbEntryMode.Items.AddRange(new object[] {
            "Auto (use time in / out)",
            "Absent",
            "Leave"});
            this.cmbEntryMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntryMode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEntryMode.FormattingEnabled = true;
            this.cmbEntryMode.Location = new System.Drawing.Point(454, 42);
            this.cmbEntryMode.Name = "cmbEntryMode";
            this.cmbEntryMode.Size = new System.Drawing.Size(190, 27);
            this.cmbEntryMode.TabIndex = 29;
            this.cmbEntryMode.SelectedIndexChanged += new System.EventHandler(this.cmbEntryMode_SelectedIndexChanged);
            // 
            // lblEntryIn
            // 
            this.lblEntryIn.AutoSize = true;
            this.lblEntryIn.Text = "TIME IN";
            this.lblEntryIn.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblEntryIn.Location = new System.Drawing.Point(656, 24);
            this.lblEntryIn.Name = "lblEntryIn";
            this.lblEntryIn.TabIndex = 30;
            // 
            // dtpTimeIn
            // 
            this.dtpTimeIn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeIn.CustomFormat = "hh:mm tt";
            this.dtpTimeIn.ShowUpDown = true;
            this.dtpTimeIn.ShowCheckBox = true;
            this.dtpTimeIn.Location = new System.Drawing.Point(656, 42);
            this.dtpTimeIn.Name = "dtpTimeIn";
            this.dtpTimeIn.Size = new System.Drawing.Size(120, 27);
            this.dtpTimeIn.TabIndex = 31;
            // 
            // lblEntryOut
            // 
            this.lblEntryOut.AutoSize = true;
            this.lblEntryOut.Text = "TIME OUT";
            this.lblEntryOut.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblEntryOut.Location = new System.Drawing.Point(788, 24);
            this.lblEntryOut.Name = "lblEntryOut";
            this.lblEntryOut.TabIndex = 32;
            // 
            // dtpTimeOut
            // 
            this.dtpTimeOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeOut.CustomFormat = "hh:mm tt";
            this.dtpTimeOut.ShowUpDown = true;
            this.dtpTimeOut.ShowCheckBox = true;
            this.dtpTimeOut.Location = new System.Drawing.Point(788, 42);
            this.dtpTimeOut.Name = "dtpTimeOut";
            this.dtpTimeOut.Size = new System.Drawing.Size(120, 27);
            this.dtpTimeOut.TabIndex = 33;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Text = "REMARKS";
            this.lblRemarks.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblRemarks.Location = new System.Drawing.Point(0, 80);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.TabIndex = 34;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(0, 98);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(400, 27);
            this.txtRemarks.TabIndex = 35;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Text = "Add";
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Location = new System.Drawing.Point(414, 94);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 36);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Text = "Update";
            this.btnUpdate.FlatAppearance.BorderSize = 1;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnUpdate.Location = new System.Drawing.Point(524, 94);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 36);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Text = "Delete";
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Location = new System.Drawing.Point(634, 94);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 36);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Text = "Clear";
            this.btnClear.FlatAppearance.BorderSize = 1;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnClear.Location = new System.Drawing.Point(744, 94);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 36);
            this.btnClear.TabIndex = 39;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tmrClock
            // 
            this.tmrClock.Interval = 1000;
            this.tmrClock.Enabled = true;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // AttendanceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnlPunch);
            this.Controls.Add(this.pnlRules);
            this.Controls.Add(this.pnlRecords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AttendanceForm";
            this.Text = "Attendance";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.pnlPunch.ResumeLayout(false);
            this.pnlPunch.PerformLayout();
            this.pnlRules.ResumeLayout(false);
            this.pnlRules.PerformLayout();
            this.pnlRecords.ResumeLayout(false);
            this.pnlRecords.PerformLayout();
            this.pnlEntry.ResumeLayout(false);
            this.pnlEntry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPunch;
        private System.Windows.Forms.Panel pnlRules;
        private System.Windows.Forms.Panel pnlRecords;
        private System.Windows.Forms.Label lblPunchTitle;
        private System.Windows.Forms.Label lblBigClock;
        private System.Windows.Forms.ComboBox cmbPunchEmployee;
        private System.Windows.Forms.Button btnTimeIn;
        private System.Windows.Forms.Button btnTimeOut;
        private System.Windows.Forms.Label lblPunchResult;
        private System.Windows.Forms.Label lblRulesTitle;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblEmpFilter;
        private System.Windows.Forms.ComboBox cmbEmployeeFilter;
        private System.Windows.Forms.Label lblStatusFilter;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Panel pnlEntry;
        private System.Windows.Forms.Label lblEntryTitle;
        private System.Windows.Forms.Label lblRecordID;
        private System.Windows.Forms.TextBox txtRecordID;
        private System.Windows.Forms.Label lblEntryEmployee;
        private System.Windows.Forms.ComboBox cmbEntryEmployee;
        private System.Windows.Forms.Label lblEntryDate;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.Label lblEntryMode;
        private System.Windows.Forms.ComboBox cmbEntryMode;
        private System.Windows.Forms.Label lblEntryIn;
        private System.Windows.Forms.DateTimePicker dtpTimeIn;
        private System.Windows.Forms.Label lblEntryOut;
        private System.Windows.Forms.DateTimePicker dtpTimeOut;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Timer tmrClock;
    }
}
