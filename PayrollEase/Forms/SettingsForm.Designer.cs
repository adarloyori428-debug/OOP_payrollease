namespace PayrollEase
{
    partial class SettingsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabsSettings = new System.Windows.Forms.TabControl();
            this.pnlSaveBar = new System.Windows.Forms.Panel();
            this.tabCompany = new System.Windows.Forms.TabPage();
            this.tabSchedule = new System.Windows.Forms.TabPage();
            this.tabRules = new System.Windows.Forms.TabPage();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.tabData = new System.Windows.Forms.TabPage();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnRestoreDefaults = new System.Windows.Forms.Button();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.txtCompanyAddress = new System.Windows.Forms.TextBox();
            this.lblCompanyContact = new System.Windows.Forms.Label();
            this.txtCompanyContact = new System.Windows.Forms.TextBox();
            this.lblWorkStart = new System.Windows.Forms.Label();
            this.dtpWorkStart = new System.Windows.Forms.DateTimePicker();
            this.lblWorkEnd = new System.Windows.Forms.Label();
            this.dtpWorkEnd = new System.Windows.Forms.DateTimePicker();
            this.lblBreakHours = new System.Windows.Forms.Label();
            this.txtBreakHours = new System.Windows.Forms.TextBox();
            this.lblGraceMinutes = new System.Windows.Forms.Label();
            this.txtGraceMinutes = new System.Windows.Forms.TextBox();
            this.lblHalfDayHours = new System.Windows.Forms.Label();
            this.txtHalfDayHours = new System.Windows.Forms.TextBox();
            this.lblMinOvertimeMinutes = new System.Windows.Forms.Label();
            this.txtMinOvertimeMinutes = new System.Windows.Forms.TextBox();
            this.lblWorkDaysPerWeek = new System.Windows.Forms.Label();
            this.cmbWorkDaysPerWeek = new System.Windows.Forms.ComboBox();
            this.lblHoursPerDay = new System.Windows.Forms.Label();
            this.txtHoursPerDay = new System.Windows.Forms.TextBox();
            this.lblPayPeriodsPerMonth = new System.Windows.Forms.Label();
            this.cmbPayPeriodsPerMonth = new System.Windows.Forms.ComboBox();
            this.lblOvertimeMultiplier = new System.Windows.Forms.Label();
            this.txtOvertimeMultiplier = new System.Windows.Forms.TextBox();
            this.chkDeductLate = new System.Windows.Forms.CheckBox();
            this.chkApplySSS = new System.Windows.Forms.CheckBox();
            this.chkApplyPhilHealth = new System.Windows.Forms.CheckBox();
            this.chkApplyPagIbig = new System.Windows.Forms.CheckBox();
            this.chkApplyTax = new System.Windows.Forms.CheckBox();
            this.lblSSSRate = new System.Windows.Forms.Label();
            this.txtSSSRate = new System.Windows.Forms.TextBox();
            this.lblSSSMinMSC = new System.Windows.Forms.Label();
            this.txtSSSMinMSC = new System.Windows.Forms.TextBox();
            this.lblSSSMaxMSC = new System.Windows.Forms.Label();
            this.txtSSSMaxMSC = new System.Windows.Forms.TextBox();
            this.lblPhilHealthRate = new System.Windows.Forms.Label();
            this.txtPhilHealthRate = new System.Windows.Forms.TextBox();
            this.lblPhilHealthFloor = new System.Windows.Forms.Label();
            this.txtPhilHealthFloor = new System.Windows.Forms.TextBox();
            this.lblPhilHealthCeiling = new System.Windows.Forms.Label();
            this.txtPhilHealthCeiling = new System.Windows.Forms.TextBox();
            this.lblPagIbigRate = new System.Windows.Forms.Label();
            this.txtPagIbigRate = new System.Windows.Forms.TextBox();
            this.lblPagIbigMaxBase = new System.Windows.Forms.Label();
            this.txtPagIbigMaxBase = new System.Windows.Forms.TextBox();
            this.lblRulesNote = new System.Windows.Forms.Label();
            this.lblAccountInfo = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.txtUserFullName = new System.Windows.Forms.TextBox();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnResetUserPassword = new System.Windows.Forms.Button();
            this.btnToggleUser = new System.Windows.Forms.Button();
            this.btnClearUser = new System.Windows.Forms.Button();
            this.btnLoadDemo = new System.Windows.Forms.Button();
            this.btnRemoveDemo = new System.Windows.Forms.Button();
            this.lblDataNote = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tabsSettings.SuspendLayout();
            this.pnlSaveBar.SuspendLayout();
            this.tabCompany.SuspendLayout();
            this.tabSchedule.SuspendLayout();
            this.tabRules.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.tabData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsSettings
            // 
            this.tabsSettings.Controls.Add(this.tabCompany);
            this.tabsSettings.Controls.Add(this.tabSchedule);
            this.tabsSettings.Controls.Add(this.tabRules);
            this.tabsSettings.Controls.Add(this.tabAccount);
            this.tabsSettings.Controls.Add(this.tabUsers);
            this.tabsSettings.Controls.Add(this.tabData);
            this.tabsSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabsSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsSettings.Location = new System.Drawing.Point(0, 0);
            this.tabsSettings.Name = "tabsSettings";
            this.tabsSettings.Size = new System.Drawing.Size(1068, 600);
            this.tabsSettings.TabIndex = 0;
            // 
            // pnlSaveBar
            // 
            this.pnlSaveBar.Controls.Add(this.btnSaveSettings);
            this.pnlSaveBar.Controls.Add(this.btnRestoreDefaults);
            this.pnlSaveBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlSaveBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSaveBar.Location = new System.Drawing.Point(0, 640);
            this.pnlSaveBar.Name = "pnlSaveBar";
            this.pnlSaveBar.Size = new System.Drawing.Size(1068, 56);
            this.pnlSaveBar.TabIndex = 1;
            // 
            // tabCompany
            // 
            this.tabCompany.Controls.Add(this.lblCompanyName);
            this.tabCompany.Controls.Add(this.txtCompanyName);
            this.tabCompany.Controls.Add(this.lblCompanyAddress);
            this.tabCompany.Controls.Add(this.txtCompanyAddress);
            this.tabCompany.Controls.Add(this.lblCompanyContact);
            this.tabCompany.Controls.Add(this.txtCompanyContact);
            this.tabCompany.Text = "Company";
            this.tabCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabCompany.Location = new System.Drawing.Point(4, 30);
            this.tabCompany.Name = "tabCompany";
            this.tabCompany.Size = new System.Drawing.Size(1052, 560);
            this.tabCompany.TabIndex = 2;
            this.tabCompany.UseVisualStyleBackColor = false;
            // 
            // tabSchedule
            // 
            this.tabSchedule.Controls.Add(this.lblWorkStart);
            this.tabSchedule.Controls.Add(this.dtpWorkStart);
            this.tabSchedule.Controls.Add(this.lblWorkEnd);
            this.tabSchedule.Controls.Add(this.dtpWorkEnd);
            this.tabSchedule.Controls.Add(this.lblBreakHours);
            this.tabSchedule.Controls.Add(this.txtBreakHours);
            this.tabSchedule.Controls.Add(this.lblGraceMinutes);
            this.tabSchedule.Controls.Add(this.txtGraceMinutes);
            this.tabSchedule.Controls.Add(this.lblHalfDayHours);
            this.tabSchedule.Controls.Add(this.txtHalfDayHours);
            this.tabSchedule.Controls.Add(this.lblMinOvertimeMinutes);
            this.tabSchedule.Controls.Add(this.txtMinOvertimeMinutes);
            this.tabSchedule.Controls.Add(this.lblWorkDaysPerWeek);
            this.tabSchedule.Controls.Add(this.cmbWorkDaysPerWeek);
            this.tabSchedule.Controls.Add(this.lblHoursPerDay);
            this.tabSchedule.Controls.Add(this.txtHoursPerDay);
            this.tabSchedule.Text = "Work schedule";
            this.tabSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabSchedule.Location = new System.Drawing.Point(4, 30);
            this.tabSchedule.Name = "tabSchedule";
            this.tabSchedule.Size = new System.Drawing.Size(1052, 560);
            this.tabSchedule.TabIndex = 3;
            this.tabSchedule.UseVisualStyleBackColor = false;
            // 
            // tabRules
            // 
            this.tabRules.Controls.Add(this.lblPayPeriodsPerMonth);
            this.tabRules.Controls.Add(this.cmbPayPeriodsPerMonth);
            this.tabRules.Controls.Add(this.lblOvertimeMultiplier);
            this.tabRules.Controls.Add(this.txtOvertimeMultiplier);
            this.tabRules.Controls.Add(this.chkDeductLate);
            this.tabRules.Controls.Add(this.chkApplySSS);
            this.tabRules.Controls.Add(this.chkApplyPhilHealth);
            this.tabRules.Controls.Add(this.chkApplyPagIbig);
            this.tabRules.Controls.Add(this.chkApplyTax);
            this.tabRules.Controls.Add(this.lblSSSRate);
            this.tabRules.Controls.Add(this.txtSSSRate);
            this.tabRules.Controls.Add(this.lblSSSMinMSC);
            this.tabRules.Controls.Add(this.txtSSSMinMSC);
            this.tabRules.Controls.Add(this.lblSSSMaxMSC);
            this.tabRules.Controls.Add(this.txtSSSMaxMSC);
            this.tabRules.Controls.Add(this.lblPhilHealthRate);
            this.tabRules.Controls.Add(this.txtPhilHealthRate);
            this.tabRules.Controls.Add(this.lblPhilHealthFloor);
            this.tabRules.Controls.Add(this.txtPhilHealthFloor);
            this.tabRules.Controls.Add(this.lblPhilHealthCeiling);
            this.tabRules.Controls.Add(this.txtPhilHealthCeiling);
            this.tabRules.Controls.Add(this.lblPagIbigRate);
            this.tabRules.Controls.Add(this.txtPagIbigRate);
            this.tabRules.Controls.Add(this.lblPagIbigMaxBase);
            this.tabRules.Controls.Add(this.txtPagIbigMaxBase);
            this.tabRules.Controls.Add(this.lblRulesNote);
            this.tabRules.Text = "Payroll rules";
            this.tabRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabRules.Location = new System.Drawing.Point(4, 30);
            this.tabRules.Name = "tabRules";
            this.tabRules.Size = new System.Drawing.Size(1052, 560);
            this.tabRules.TabIndex = 4;
            this.tabRules.UseVisualStyleBackColor = false;
            // 
            // tabAccount
            // 
            this.tabAccount.Controls.Add(this.lblAccountInfo);
            this.tabAccount.Controls.Add(this.lblCurrentPassword);
            this.tabAccount.Controls.Add(this.txtCurrentPassword);
            this.tabAccount.Controls.Add(this.lblNewPassword);
            this.tabAccount.Controls.Add(this.txtNewPassword);
            this.tabAccount.Controls.Add(this.lblConfirmPassword);
            this.tabAccount.Controls.Add(this.txtConfirmPassword);
            this.tabAccount.Controls.Add(this.btnChangePassword);
            this.tabAccount.Text = "My account";
            this.tabAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabAccount.Location = new System.Drawing.Point(4, 30);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Size = new System.Drawing.Size(1052, 560);
            this.tabAccount.TabIndex = 5;
            this.tabAccount.UseVisualStyleBackColor = false;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.dgvUsers);
            this.tabUsers.Controls.Add(this.lblUserID);
            this.tabUsers.Controls.Add(this.txtUserID);
            this.tabUsers.Controls.Add(this.lblUserName);
            this.tabUsers.Controls.Add(this.txtUserName);
            this.tabUsers.Controls.Add(this.lblUserFullName);
            this.tabUsers.Controls.Add(this.txtUserFullName);
            this.tabUsers.Controls.Add(this.lblUserRole);
            this.tabUsers.Controls.Add(this.cmbUserRole);
            this.tabUsers.Controls.Add(this.lblUserPassword);
            this.tabUsers.Controls.Add(this.txtUserPassword);
            this.tabUsers.Controls.Add(this.btnAddUser);
            this.tabUsers.Controls.Add(this.btnUpdateUser);
            this.tabUsers.Controls.Add(this.btnResetUserPassword);
            this.tabUsers.Controls.Add(this.btnToggleUser);
            this.tabUsers.Controls.Add(this.btnClearUser);
            this.tabUsers.Text = "Users";
            this.tabUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabUsers.Location = new System.Drawing.Point(4, 30);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Size = new System.Drawing.Size(1052, 560);
            this.tabUsers.TabIndex = 6;
            this.tabUsers.UseVisualStyleBackColor = false;
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.btnLoadDemo);
            this.tabData.Controls.Add(this.btnRemoveDemo);
            this.tabData.Controls.Add(this.lblDataNote);
            this.tabData.Controls.Add(this.lblDatabase);
            this.tabData.Text = "Data";
            this.tabData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabData.Location = new System.Drawing.Point(4, 30);
            this.tabData.Name = "tabData";
            this.tabData.Size = new System.Drawing.Size(1052, 560);
            this.tabData.TabIndex = 7;
            this.tabData.UseVisualStyleBackColor = false;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.btnSaveSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveSettings.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSettings.Text = "Save settings";
            this.btnSaveSettings.FlatAppearance.BorderSize = 0;
            this.btnSaveSettings.Location = new System.Drawing.Point(0, 10);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(170, 40);
            this.btnSaveSettings.TabIndex = 8;
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnRestoreDefaults
            // 
            this.btnRestoreDefaults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRestoreDefaults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnRestoreDefaults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreDefaults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestoreDefaults.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreDefaults.Text = "Restore defaults";
            this.btnRestoreDefaults.FlatAppearance.BorderSize = 1;
            this.btnRestoreDefaults.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnRestoreDefaults.Location = new System.Drawing.Point(182, 10);
            this.btnRestoreDefaults.Name = "btnRestoreDefaults";
            this.btnRestoreDefaults.Size = new System.Drawing.Size(170, 40);
            this.btnRestoreDefaults.TabIndex = 9;
            this.btnRestoreDefaults.UseVisualStyleBackColor = false;
            this.btnRestoreDefaults.Click += new System.EventHandler(this.btnRestoreDefaults_Click);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Text = "COMPANY NAME";
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCompanyName.Location = new System.Drawing.Point(24, 20);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.TabIndex = 10;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(24, 40);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(556, 27);
            this.txtCompanyName.TabIndex = 11;
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.AutoSize = true;
            this.lblCompanyAddress.Text = "ADDRESS";
            this.lblCompanyAddress.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCompanyAddress.Location = new System.Drawing.Point(24, 88);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.TabIndex = 12;
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyAddress.Location = new System.Drawing.Point(24, 108);
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Size = new System.Drawing.Size(556, 27);
            this.txtCompanyAddress.TabIndex = 13;
            // 
            // lblCompanyContact
            // 
            this.lblCompanyContact.AutoSize = true;
            this.lblCompanyContact.Text = "CONTACT (PHONE OR EMAIL)";
            this.lblCompanyContact.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCompanyContact.Location = new System.Drawing.Point(24, 156);
            this.lblCompanyContact.Name = "lblCompanyContact";
            this.lblCompanyContact.TabIndex = 14;
            // 
            // txtCompanyContact
            // 
            this.txtCompanyContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyContact.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyContact.Location = new System.Drawing.Point(24, 176);
            this.txtCompanyContact.Name = "txtCompanyContact";
            this.txtCompanyContact.Size = new System.Drawing.Size(556, 27);
            this.txtCompanyContact.TabIndex = 15;
            // 
            // lblWorkStart
            // 
            this.lblWorkStart.AutoSize = true;
            this.lblWorkStart.Text = "SHIFT START";
            this.lblWorkStart.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblWorkStart.Location = new System.Drawing.Point(24, 20);
            this.lblWorkStart.Name = "lblWorkStart";
            this.lblWorkStart.TabIndex = 16;
            // 
            // dtpWorkStart
            // 
            this.dtpWorkStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWorkStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWorkStart.CustomFormat = "hh:mm tt";
            this.dtpWorkStart.ShowUpDown = true;
            this.dtpWorkStart.Location = new System.Drawing.Point(24, 40);
            this.dtpWorkStart.Name = "dtpWorkStart";
            this.dtpWorkStart.Size = new System.Drawing.Size(200, 27);
            this.dtpWorkStart.TabIndex = 17;
            // 
            // lblWorkEnd
            // 
            this.lblWorkEnd.AutoSize = true;
            this.lblWorkEnd.Text = "SHIFT END";
            this.lblWorkEnd.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblWorkEnd.Location = new System.Drawing.Point(320, 20);
            this.lblWorkEnd.Name = "lblWorkEnd";
            this.lblWorkEnd.TabIndex = 18;
            // 
            // dtpWorkEnd
            // 
            this.dtpWorkEnd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWorkEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWorkEnd.CustomFormat = "hh:mm tt";
            this.dtpWorkEnd.ShowUpDown = true;
            this.dtpWorkEnd.Location = new System.Drawing.Point(320, 40);
            this.dtpWorkEnd.Name = "dtpWorkEnd";
            this.dtpWorkEnd.Size = new System.Drawing.Size(200, 27);
            this.dtpWorkEnd.TabIndex = 19;
            // 
            // lblBreakHours
            // 
            this.lblBreakHours.AutoSize = true;
            this.lblBreakHours.Text = "UNPAID BREAK (HOURS)";
            this.lblBreakHours.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblBreakHours.Location = new System.Drawing.Point(24, 88);
            this.lblBreakHours.Name = "lblBreakHours";
            this.lblBreakHours.TabIndex = 20;
            // 
            // txtBreakHours
            // 
            this.txtBreakHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBreakHours.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreakHours.Location = new System.Drawing.Point(24, 108);
            this.txtBreakHours.Name = "txtBreakHours";
            this.txtBreakHours.Size = new System.Drawing.Size(200, 27);
            this.txtBreakHours.TabIndex = 21;
            // 
            // lblGraceMinutes
            // 
            this.lblGraceMinutes.AutoSize = true;
            this.lblGraceMinutes.Text = "LATE GRACE (MINUTES)";
            this.lblGraceMinutes.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraceMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblGraceMinutes.Location = new System.Drawing.Point(320, 88);
            this.lblGraceMinutes.Name = "lblGraceMinutes";
            this.lblGraceMinutes.TabIndex = 22;
            // 
            // txtGraceMinutes
            // 
            this.txtGraceMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGraceMinutes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGraceMinutes.Location = new System.Drawing.Point(320, 108);
            this.txtGraceMinutes.Name = "txtGraceMinutes";
            this.txtGraceMinutes.Size = new System.Drawing.Size(200, 27);
            this.txtGraceMinutes.TabIndex = 23;
            // 
            // lblHalfDayHours
            // 
            this.lblHalfDayHours.AutoSize = true;
            this.lblHalfDayHours.Text = "HALF DAY IF WORKED UNDER (HOURS)";
            this.lblHalfDayHours.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHalfDayHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblHalfDayHours.Location = new System.Drawing.Point(24, 156);
            this.lblHalfDayHours.Name = "lblHalfDayHours";
            this.lblHalfDayHours.TabIndex = 24;
            // 
            // txtHalfDayHours
            // 
            this.txtHalfDayHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHalfDayHours.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHalfDayHours.Location = new System.Drawing.Point(24, 176);
            this.txtHalfDayHours.Name = "txtHalfDayHours";
            this.txtHalfDayHours.Size = new System.Drawing.Size(250, 27);
            this.txtHalfDayHours.TabIndex = 25;
            // 
            // lblMinOvertimeMinutes
            // 
            this.lblMinOvertimeMinutes.AutoSize = true;
            this.lblMinOvertimeMinutes.Text = "MINIMUM OVERTIME (MINUTES)";
            this.lblMinOvertimeMinutes.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinOvertimeMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblMinOvertimeMinutes.Location = new System.Drawing.Point(320, 156);
            this.lblMinOvertimeMinutes.Name = "lblMinOvertimeMinutes";
            this.lblMinOvertimeMinutes.TabIndex = 26;
            // 
            // txtMinOvertimeMinutes
            // 
            this.txtMinOvertimeMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinOvertimeMinutes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinOvertimeMinutes.Location = new System.Drawing.Point(320, 176);
            this.txtMinOvertimeMinutes.Name = "txtMinOvertimeMinutes";
            this.txtMinOvertimeMinutes.Size = new System.Drawing.Size(250, 27);
            this.txtMinOvertimeMinutes.TabIndex = 27;
            // 
            // lblWorkDaysPerWeek
            // 
            this.lblWorkDaysPerWeek.AutoSize = true;
            this.lblWorkDaysPerWeek.Text = "WORK DAYS PER WEEK";
            this.lblWorkDaysPerWeek.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkDaysPerWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblWorkDaysPerWeek.Location = new System.Drawing.Point(24, 224);
            this.lblWorkDaysPerWeek.Name = "lblWorkDaysPerWeek";
            this.lblWorkDaysPerWeek.TabIndex = 28;
            // 
            // cmbWorkDaysPerWeek
            // 
            this.cmbWorkDaysPerWeek.Items.AddRange(new object[] {
            "5",
            "6"});
            this.cmbWorkDaysPerWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkDaysPerWeek.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWorkDaysPerWeek.FormattingEnabled = true;
            this.cmbWorkDaysPerWeek.Location = new System.Drawing.Point(24, 244);
            this.cmbWorkDaysPerWeek.Name = "cmbWorkDaysPerWeek";
            this.cmbWorkDaysPerWeek.Size = new System.Drawing.Size(200, 27);
            this.cmbWorkDaysPerWeek.TabIndex = 29;
            // 
            // lblHoursPerDay
            // 
            this.lblHoursPerDay.AutoSize = true;
            this.lblHoursPerDay.Text = "PAID HOURS PER DAY";
            this.lblHoursPerDay.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursPerDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblHoursPerDay.Location = new System.Drawing.Point(320, 224);
            this.lblHoursPerDay.Name = "lblHoursPerDay";
            this.lblHoursPerDay.TabIndex = 30;
            // 
            // txtHoursPerDay
            // 
            this.txtHoursPerDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoursPerDay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoursPerDay.Location = new System.Drawing.Point(320, 244);
            this.txtHoursPerDay.Name = "txtHoursPerDay";
            this.txtHoursPerDay.Size = new System.Drawing.Size(200, 27);
            this.txtHoursPerDay.TabIndex = 31;
            // 
            // lblPayPeriodsPerMonth
            // 
            this.lblPayPeriodsPerMonth.AutoSize = true;
            this.lblPayPeriodsPerMonth.Text = "PAY PERIODS PER MONTH";
            this.lblPayPeriodsPerMonth.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayPeriodsPerMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPayPeriodsPerMonth.Location = new System.Drawing.Point(24, 14);
            this.lblPayPeriodsPerMonth.Name = "lblPayPeriodsPerMonth";
            this.lblPayPeriodsPerMonth.TabIndex = 32;
            // 
            // cmbPayPeriodsPerMonth
            // 
            this.cmbPayPeriodsPerMonth.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbPayPeriodsPerMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayPeriodsPerMonth.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPayPeriodsPerMonth.FormattingEnabled = true;
            this.cmbPayPeriodsPerMonth.Location = new System.Drawing.Point(24, 34);
            this.cmbPayPeriodsPerMonth.Name = "cmbPayPeriodsPerMonth";
            this.cmbPayPeriodsPerMonth.Size = new System.Drawing.Size(200, 27);
            this.cmbPayPeriodsPerMonth.TabIndex = 33;
            // 
            // lblOvertimeMultiplier
            // 
            this.lblOvertimeMultiplier.AutoSize = true;
            this.lblOvertimeMultiplier.Text = "OVERTIME RATE (x HOURLY RATE)";
            this.lblOvertimeMultiplier.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOvertimeMultiplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblOvertimeMultiplier.Location = new System.Drawing.Point(320, 14);
            this.lblOvertimeMultiplier.Name = "lblOvertimeMultiplier";
            this.lblOvertimeMultiplier.TabIndex = 34;
            // 
            // txtOvertimeMultiplier
            // 
            this.txtOvertimeMultiplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOvertimeMultiplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOvertimeMultiplier.Location = new System.Drawing.Point(320, 34);
            this.txtOvertimeMultiplier.Name = "txtOvertimeMultiplier";
            this.txtOvertimeMultiplier.Size = new System.Drawing.Size(200, 27);
            this.txtOvertimeMultiplier.TabIndex = 35;
            // 
            // chkDeductLate
            // 
            this.chkDeductLate.AutoSize = true;
            this.chkDeductLate.Text = "Deduct late and undertime from pay";
            this.chkDeductLate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeductLate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.chkDeductLate.UseVisualStyleBackColor = true;
            this.chkDeductLate.Location = new System.Drawing.Point(24, 84);
            this.chkDeductLate.Name = "chkDeductLate";
            this.chkDeductLate.TabIndex = 36;
            // 
            // chkApplySSS
            // 
            this.chkApplySSS.AutoSize = true;
            this.chkApplySSS.Text = "Deduct SSS (employee share)";
            this.chkApplySSS.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkApplySSS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.chkApplySSS.UseVisualStyleBackColor = true;
            this.chkApplySSS.Location = new System.Drawing.Point(24, 112);
            this.chkApplySSS.Name = "chkApplySSS";
            this.chkApplySSS.TabIndex = 37;
            // 
            // chkApplyPhilHealth
            // 
            this.chkApplyPhilHealth.AutoSize = true;
            this.chkApplyPhilHealth.Text = "Deduct PhilHealth (employee share)";
            this.chkApplyPhilHealth.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkApplyPhilHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.chkApplyPhilHealth.UseVisualStyleBackColor = true;
            this.chkApplyPhilHealth.Location = new System.Drawing.Point(24, 140);
            this.chkApplyPhilHealth.Name = "chkApplyPhilHealth";
            this.chkApplyPhilHealth.TabIndex = 38;
            // 
            // chkApplyPagIbig
            // 
            this.chkApplyPagIbig.AutoSize = true;
            this.chkApplyPagIbig.Text = "Deduct Pag-IBIG (employee share)";
            this.chkApplyPagIbig.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkApplyPagIbig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.chkApplyPagIbig.UseVisualStyleBackColor = true;
            this.chkApplyPagIbig.Location = new System.Drawing.Point(24, 168);
            this.chkApplyPagIbig.Name = "chkApplyPagIbig";
            this.chkApplyPagIbig.TabIndex = 39;
            // 
            // chkApplyTax
            // 
            this.chkApplyTax.AutoSize = true;
            this.chkApplyTax.Text = "Deduct withholding tax (TRAIN law table)";
            this.chkApplyTax.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkApplyTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.chkApplyTax.UseVisualStyleBackColor = true;
            this.chkApplyTax.Location = new System.Drawing.Point(24, 196);
            this.chkApplyTax.Name = "chkApplyTax";
            this.chkApplyTax.TabIndex = 40;
            // 
            // lblSSSRate
            // 
            this.lblSSSRate.AutoSize = true;
            this.lblSSSRate.Text = "SSS EMPLOYEE RATE (%)";
            this.lblSSSRate.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSSRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSSSRate.Location = new System.Drawing.Point(24, 242);
            this.lblSSSRate.Name = "lblSSSRate";
            this.lblSSSRate.TabIndex = 41;
            // 
            // txtSSSRate
            // 
            this.txtSSSRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSSSRate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSSRate.Location = new System.Drawing.Point(24, 262);
            this.txtSSSRate.Name = "txtSSSRate";
            this.txtSSSRate.Size = new System.Drawing.Size(200, 27);
            this.txtSSSRate.TabIndex = 42;
            // 
            // lblSSSMinMSC
            // 
            this.lblSSSMinMSC.AutoSize = true;
            this.lblSSSMinMSC.Text = "SSS MIN. MONTHLY SALARY CREDIT";
            this.lblSSSMinMSC.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSSMinMSC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSSSMinMSC.Location = new System.Drawing.Point(320, 242);
            this.lblSSSMinMSC.Name = "lblSSSMinMSC";
            this.lblSSSMinMSC.TabIndex = 43;
            // 
            // txtSSSMinMSC
            // 
            this.txtSSSMinMSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSSSMinMSC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSSMinMSC.Location = new System.Drawing.Point(320, 262);
            this.txtSSSMinMSC.Name = "txtSSSMinMSC";
            this.txtSSSMinMSC.Size = new System.Drawing.Size(250, 27);
            this.txtSSSMinMSC.TabIndex = 44;
            // 
            // lblSSSMaxMSC
            // 
            this.lblSSSMaxMSC.AutoSize = true;
            this.lblSSSMaxMSC.Text = "SSS MAX. MONTHLY SALARY CREDIT";
            this.lblSSSMaxMSC.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSSMaxMSC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSSSMaxMSC.Location = new System.Drawing.Point(24, 302);
            this.lblSSSMaxMSC.Name = "lblSSSMaxMSC";
            this.lblSSSMaxMSC.TabIndex = 45;
            // 
            // txtSSSMaxMSC
            // 
            this.txtSSSMaxMSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSSSMaxMSC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSSMaxMSC.Location = new System.Drawing.Point(24, 322);
            this.txtSSSMaxMSC.Name = "txtSSSMaxMSC";
            this.txtSSSMaxMSC.Size = new System.Drawing.Size(250, 27);
            this.txtSSSMaxMSC.TabIndex = 46;
            // 
            // lblPhilHealthRate
            // 
            this.lblPhilHealthRate.AutoSize = true;
            this.lblPhilHealthRate.Text = "PHILHEALTH EMPLOYEE RATE (%)";
            this.lblPhilHealthRate.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhilHealthRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPhilHealthRate.Location = new System.Drawing.Point(320, 302);
            this.lblPhilHealthRate.Name = "lblPhilHealthRate";
            this.lblPhilHealthRate.TabIndex = 47;
            // 
            // txtPhilHealthRate
            // 
            this.txtPhilHealthRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhilHealthRate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhilHealthRate.Location = new System.Drawing.Point(320, 322);
            this.txtPhilHealthRate.Name = "txtPhilHealthRate";
            this.txtPhilHealthRate.Size = new System.Drawing.Size(200, 27);
            this.txtPhilHealthRate.TabIndex = 48;
            // 
            // lblPhilHealthFloor
            // 
            this.lblPhilHealthFloor.AutoSize = true;
            this.lblPhilHealthFloor.Text = "PHILHEALTH SALARY FLOOR";
            this.lblPhilHealthFloor.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhilHealthFloor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPhilHealthFloor.Location = new System.Drawing.Point(24, 362);
            this.lblPhilHealthFloor.Name = "lblPhilHealthFloor";
            this.lblPhilHealthFloor.TabIndex = 49;
            // 
            // txtPhilHealthFloor
            // 
            this.txtPhilHealthFloor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhilHealthFloor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhilHealthFloor.Location = new System.Drawing.Point(24, 382);
            this.txtPhilHealthFloor.Name = "txtPhilHealthFloor";
            this.txtPhilHealthFloor.Size = new System.Drawing.Size(200, 27);
            this.txtPhilHealthFloor.TabIndex = 50;
            // 
            // lblPhilHealthCeiling
            // 
            this.lblPhilHealthCeiling.AutoSize = true;
            this.lblPhilHealthCeiling.Text = "PHILHEALTH SALARY CEILING";
            this.lblPhilHealthCeiling.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhilHealthCeiling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPhilHealthCeiling.Location = new System.Drawing.Point(320, 362);
            this.lblPhilHealthCeiling.Name = "lblPhilHealthCeiling";
            this.lblPhilHealthCeiling.TabIndex = 51;
            // 
            // txtPhilHealthCeiling
            // 
            this.txtPhilHealthCeiling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhilHealthCeiling.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhilHealthCeiling.Location = new System.Drawing.Point(320, 382);
            this.txtPhilHealthCeiling.Name = "txtPhilHealthCeiling";
            this.txtPhilHealthCeiling.Size = new System.Drawing.Size(200, 27);
            this.txtPhilHealthCeiling.TabIndex = 52;
            // 
            // lblPagIbigRate
            // 
            this.lblPagIbigRate.AutoSize = true;
            this.lblPagIbigRate.Text = "PAG-IBIG EMPLOYEE RATE (%)";
            this.lblPagIbigRate.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagIbigRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPagIbigRate.Location = new System.Drawing.Point(24, 422);
            this.lblPagIbigRate.Name = "lblPagIbigRate";
            this.lblPagIbigRate.TabIndex = 53;
            // 
            // txtPagIbigRate
            // 
            this.txtPagIbigRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPagIbigRate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagIbigRate.Location = new System.Drawing.Point(24, 442);
            this.txtPagIbigRate.Name = "txtPagIbigRate";
            this.txtPagIbigRate.Size = new System.Drawing.Size(200, 27);
            this.txtPagIbigRate.TabIndex = 54;
            // 
            // lblPagIbigMaxBase
            // 
            this.lblPagIbigMaxBase.AutoSize = true;
            this.lblPagIbigMaxBase.Text = "PAG-IBIG MAXIMUM BASE";
            this.lblPagIbigMaxBase.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagIbigMaxBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPagIbigMaxBase.Location = new System.Drawing.Point(320, 422);
            this.lblPagIbigMaxBase.Name = "lblPagIbigMaxBase";
            this.lblPagIbigMaxBase.TabIndex = 55;
            // 
            // txtPagIbigMaxBase
            // 
            this.txtPagIbigMaxBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPagIbigMaxBase.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagIbigMaxBase.Location = new System.Drawing.Point(320, 442);
            this.txtPagIbigMaxBase.Name = "txtPagIbigMaxBase";
            this.txtPagIbigMaxBase.Size = new System.Drawing.Size(200, 27);
            this.txtPagIbigMaxBase.TabIndex = 56;
            // 
            // lblRulesNote
            // 
            this.lblRulesNote.AutoSize = false;
            this.lblRulesNote.Text = "Defaults follow the current Philippine rates. Please verify them against the official SSS, PhilHealth, Pag-IBIG and BIR tables.";
            this.lblRulesNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRulesNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblRulesNote.Location = new System.Drawing.Point(24, 488);
            this.lblRulesNote.Name = "lblRulesNote";
            this.lblRulesNote.Size = new System.Drawing.Size(760, 20);
            this.lblRulesNote.TabIndex = 57;
            // 
            // lblAccountInfo
            // 
            this.lblAccountInfo.AutoSize = true;
            this.lblAccountInfo.Text = "";
            this.lblAccountInfo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblAccountInfo.Location = new System.Drawing.Point(24, 20);
            this.lblAccountInfo.Name = "lblAccountInfo";
            this.lblAccountInfo.TabIndex = 58;
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Text = "CURRENT PASSWORD";
            this.lblCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCurrentPassword.Location = new System.Drawing.Point(24, 64);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.TabIndex = 59;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            this.txtCurrentPassword.Location = new System.Drawing.Point(24, 84);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(320, 27);
            this.txtCurrentPassword.TabIndex = 60;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Text = "NEW PASSWORD (6+ CHARACTERS)";
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblNewPassword.Location = new System.Drawing.Point(24, 132);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.TabIndex = 61;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.Location = new System.Drawing.Point(24, 152);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(320, 27);
            this.txtNewPassword.TabIndex = 62;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Text = "CONFIRM NEW PASSWORD";
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblConfirmPassword.Location = new System.Drawing.Point(24, 200);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.TabIndex = 63;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.Location = new System.Drawing.Point(24, 220);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(320, 27);
            this.txtConfirmPassword.TabIndex = 64;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Text = "Change password";
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.Location = new System.Drawing.Point(24, 272);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(200, 40);
            this.btnChangePassword.TabIndex = 65;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.ColumnHeadersHeight = 38;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowTemplate.Height = 36;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.Location = new System.Drawing.Point(16, 16);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(650, 500);
            this.dgvUsers.TabIndex = 66;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Text = "USER ID";
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblUserID.Location = new System.Drawing.Point(690, 20);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.TabIndex = 67;
            // 
            // txtUserID
            // 
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.ReadOnly = true;
            this.txtUserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtUserID.Location = new System.Drawing.Point(690, 40);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(70, 27);
            this.txtUserID.TabIndex = 68;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Text = "USERNAME";
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblUserName.Location = new System.Drawing.Point(772, 20);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.TabIndex = 69;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(772, 40);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(238, 27);
            this.txtUserName.TabIndex = 70;
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.AutoSize = true;
            this.lblUserFullName.Text = "FULL NAME";
            this.lblUserFullName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblUserFullName.Location = new System.Drawing.Point(690, 88);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.TabIndex = 71;
            // 
            // txtUserFullName
            // 
            this.txtUserFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserFullName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserFullName.Location = new System.Drawing.Point(690, 108);
            this.txtUserFullName.Name = "txtUserFullName";
            this.txtUserFullName.Size = new System.Drawing.Size(320, 27);
            this.txtUserFullName.TabIndex = 72;
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Text = "ROLE";
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblUserRole.Location = new System.Drawing.Point(690, 156);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.TabIndex = 73;
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.Items.AddRange(new object[] {
            "Admin",
            "HR"});
            this.cmbUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserRole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Location = new System.Drawing.Point(690, 176);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(320, 27);
            this.cmbUserRole.TabIndex = 74;
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Text = "PASSWORD (NEW USER OR RESET)";
            this.lblUserPassword.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblUserPassword.Location = new System.Drawing.Point(690, 224);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.TabIndex = 75;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPassword.UseSystemPasswordChar = true;
            this.txtUserPassword.Location = new System.Drawing.Point(690, 244);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(320, 27);
            this.txtUserPassword.TabIndex = 76;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.btnAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Text = "Add new user";
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.Location = new System.Drawing.Point(690, 296);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(320, 38);
            this.btnAddUser.TabIndex = 77;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.Text = "Save name && role";
            this.btnUpdateUser.FlatAppearance.BorderSize = 1;
            this.btnUpdateUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnUpdateUser.Location = new System.Drawing.Point(690, 342);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(320, 38);
            this.btnUpdateUser.TabIndex = 78;
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnResetUserPassword
            // 
            this.btnResetUserPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnResetUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnResetUserPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetUserPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetUserPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetUserPassword.Text = "Reset password";
            this.btnResetUserPassword.FlatAppearance.BorderSize = 1;
            this.btnResetUserPassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnResetUserPassword.Location = new System.Drawing.Point(690, 388);
            this.btnResetUserPassword.Name = "btnResetUserPassword";
            this.btnResetUserPassword.Size = new System.Drawing.Size(320, 38);
            this.btnResetUserPassword.TabIndex = 79;
            this.btnResetUserPassword.UseVisualStyleBackColor = false;
            this.btnResetUserPassword.Click += new System.EventHandler(this.btnResetUserPassword_Click);
            // 
            // btnToggleUser
            // 
            this.btnToggleUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnToggleUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnToggleUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleUser.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleUser.Text = "Activate / deactivate";
            this.btnToggleUser.FlatAppearance.BorderSize = 1;
            this.btnToggleUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnToggleUser.Location = new System.Drawing.Point(690, 434);
            this.btnToggleUser.Name = "btnToggleUser";
            this.btnToggleUser.Size = new System.Drawing.Size(320, 38);
            this.btnToggleUser.TabIndex = 80;
            this.btnToggleUser.UseVisualStyleBackColor = false;
            this.btnToggleUser.Click += new System.EventHandler(this.btnToggleUser_Click);
            // 
            // btnClearUser
            // 
            this.btnClearUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClearUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnClearUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearUser.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearUser.Text = "Clear form";
            this.btnClearUser.FlatAppearance.BorderSize = 1;
            this.btnClearUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnClearUser.Location = new System.Drawing.Point(690, 480);
            this.btnClearUser.Name = "btnClearUser";
            this.btnClearUser.Size = new System.Drawing.Size(320, 38);
            this.btnClearUser.TabIndex = 81;
            this.btnClearUser.UseVisualStyleBackColor = false;
            this.btnClearUser.Click += new System.EventHandler(this.btnClearUser_Click);
            // 
            // btnLoadDemo
            // 
            this.btnLoadDemo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.btnLoadDemo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLoadDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadDemo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadDemo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDemo.Text = "Load sample data";
            this.btnLoadDemo.FlatAppearance.BorderSize = 0;
            this.btnLoadDemo.Location = new System.Drawing.Point(24, 30);
            this.btnLoadDemo.Name = "btnLoadDemo";
            this.btnLoadDemo.Size = new System.Drawing.Size(220, 40);
            this.btnLoadDemo.TabIndex = 82;
            this.btnLoadDemo.UseVisualStyleBackColor = false;
            this.btnLoadDemo.Click += new System.EventHandler(this.btnLoadDemo_Click);
            // 
            // btnRemoveDemo
            // 
            this.btnRemoveDemo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRemoveDemo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnRemoveDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDemo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveDemo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveDemo.Text = "Remove sample data";
            this.btnRemoveDemo.FlatAppearance.BorderSize = 1;
            this.btnRemoveDemo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnRemoveDemo.Location = new System.Drawing.Point(260, 30);
            this.btnRemoveDemo.Name = "btnRemoveDemo";
            this.btnRemoveDemo.Size = new System.Drawing.Size(220, 40);
            this.btnRemoveDemo.TabIndex = 83;
            this.btnRemoveDemo.UseVisualStyleBackColor = false;
            this.btnRemoveDemo.Click += new System.EventHandler(this.btnRemoveDemo_Click);
            // 
            // lblDataNote
            // 
            this.lblDataNote.AutoSize = false;
            this.lblDataNote.Text = "Sample data adds 8 employees (IDs start with DEMO-) with about 3 weeks of attendance. Removing it deletes only those employees and their records.";
            this.lblDataNote.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDataNote.Location = new System.Drawing.Point(24, 90);
            this.lblDataNote.Name = "lblDataNote";
            this.lblDataNote.Size = new System.Drawing.Size(720, 40);
            this.lblDataNote.TabIndex = 84;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Text = "";
            this.lblDatabase.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblDatabase.Location = new System.Drawing.Point(24, 150);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.TabIndex = 85;
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.tabsSettings);
            this.Controls.Add(this.pnlSaveBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Padding = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tabsSettings.ResumeLayout(false);
            this.pnlSaveBar.ResumeLayout(false);
            this.pnlSaveBar.PerformLayout();
            this.tabCompany.ResumeLayout(false);
            this.tabCompany.PerformLayout();
            this.tabSchedule.ResumeLayout(false);
            this.tabSchedule.PerformLayout();
            this.tabRules.ResumeLayout(false);
            this.tabRules.PerformLayout();
            this.tabAccount.ResumeLayout(false);
            this.tabAccount.PerformLayout();
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            this.tabData.ResumeLayout(false);
            this.tabData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabsSettings;
        private System.Windows.Forms.Panel pnlSaveBar;
        private System.Windows.Forms.TabPage tabCompany;
        private System.Windows.Forms.TabPage tabSchedule;
        private System.Windows.Forms.TabPage tabRules;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnRestoreDefaults;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyAddress;
        private System.Windows.Forms.TextBox txtCompanyAddress;
        private System.Windows.Forms.Label lblCompanyContact;
        private System.Windows.Forms.TextBox txtCompanyContact;
        private System.Windows.Forms.Label lblWorkStart;
        private System.Windows.Forms.DateTimePicker dtpWorkStart;
        private System.Windows.Forms.Label lblWorkEnd;
        private System.Windows.Forms.DateTimePicker dtpWorkEnd;
        private System.Windows.Forms.Label lblBreakHours;
        private System.Windows.Forms.TextBox txtBreakHours;
        private System.Windows.Forms.Label lblGraceMinutes;
        private System.Windows.Forms.TextBox txtGraceMinutes;
        private System.Windows.Forms.Label lblHalfDayHours;
        private System.Windows.Forms.TextBox txtHalfDayHours;
        private System.Windows.Forms.Label lblMinOvertimeMinutes;
        private System.Windows.Forms.TextBox txtMinOvertimeMinutes;
        private System.Windows.Forms.Label lblWorkDaysPerWeek;
        private System.Windows.Forms.ComboBox cmbWorkDaysPerWeek;
        private System.Windows.Forms.Label lblHoursPerDay;
        private System.Windows.Forms.TextBox txtHoursPerDay;
        private System.Windows.Forms.Label lblPayPeriodsPerMonth;
        private System.Windows.Forms.ComboBox cmbPayPeriodsPerMonth;
        private System.Windows.Forms.Label lblOvertimeMultiplier;
        private System.Windows.Forms.TextBox txtOvertimeMultiplier;
        private System.Windows.Forms.CheckBox chkDeductLate;
        private System.Windows.Forms.CheckBox chkApplySSS;
        private System.Windows.Forms.CheckBox chkApplyPhilHealth;
        private System.Windows.Forms.CheckBox chkApplyPagIbig;
        private System.Windows.Forms.CheckBox chkApplyTax;
        private System.Windows.Forms.Label lblSSSRate;
        private System.Windows.Forms.TextBox txtSSSRate;
        private System.Windows.Forms.Label lblSSSMinMSC;
        private System.Windows.Forms.TextBox txtSSSMinMSC;
        private System.Windows.Forms.Label lblSSSMaxMSC;
        private System.Windows.Forms.TextBox txtSSSMaxMSC;
        private System.Windows.Forms.Label lblPhilHealthRate;
        private System.Windows.Forms.TextBox txtPhilHealthRate;
        private System.Windows.Forms.Label lblPhilHealthFloor;
        private System.Windows.Forms.TextBox txtPhilHealthFloor;
        private System.Windows.Forms.Label lblPhilHealthCeiling;
        private System.Windows.Forms.TextBox txtPhilHealthCeiling;
        private System.Windows.Forms.Label lblPagIbigRate;
        private System.Windows.Forms.TextBox txtPagIbigRate;
        private System.Windows.Forms.Label lblPagIbigMaxBase;
        private System.Windows.Forms.TextBox txtPagIbigMaxBase;
        private System.Windows.Forms.Label lblRulesNote;
        private System.Windows.Forms.Label lblAccountInfo;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserFullName;
        private System.Windows.Forms.TextBox txtUserFullName;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnResetUserPassword;
        private System.Windows.Forms.Button btnToggleUser;
        private System.Windows.Forms.Button btnClearUser;
        private System.Windows.Forms.Button btnLoadDemo;
        private System.Windows.Forms.Button btnRemoveDemo;
        private System.Windows.Forms.Label lblDataNote;
        private System.Windows.Forms.Label lblDatabase;
    }
}
