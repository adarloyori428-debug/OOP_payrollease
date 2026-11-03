namespace PayrollEase
{
    partial class PayrollForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabsPayroll = new System.Windows.Forms.TabControl();
            this.tabPayroll = new System.Windows.Forms.TabPage();
            this.tabAdjust = new System.Windows.Forms.TabPage();
            this.lblStart = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblPay = new System.Windows.Forms.Label();
            this.dtpPayDate = new System.Windows.Forms.DateTimePicker();
            this.btnFirstHalf = new System.Windows.Forms.Button();
            this.btnSecondHalf = new System.Windows.Forms.Button();
            this.btnCompute = new System.Windows.Forms.Button();
            this.pnlSum1 = new System.Windows.Forms.Panel();
            this.pnlSumAccent1 = new System.Windows.Forms.Panel();
            this.lblSum1Title = new System.Windows.Forms.Label();
            this.lblSum1Value = new System.Windows.Forms.Label();
            this.pnlSum2 = new System.Windows.Forms.Panel();
            this.pnlSumAccent2 = new System.Windows.Forms.Panel();
            this.lblSum2Title = new System.Windows.Forms.Label();
            this.lblSum2Value = new System.Windows.Forms.Label();
            this.pnlSum3 = new System.Windows.Forms.Panel();
            this.pnlSumAccent3 = new System.Windows.Forms.Panel();
            this.lblSum3Title = new System.Windows.Forms.Label();
            this.lblSum3Value = new System.Windows.Forms.Label();
            this.pnlSum4 = new System.Windows.Forms.Panel();
            this.pnlSumAccent4 = new System.Windows.Forms.Panel();
            this.lblSum4Title = new System.Windows.Forms.Label();
            this.lblSum4Value = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.dgvPayroll = new System.Windows.Forms.DataGridView();
            this.lblHistory = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.btnSavePayroll = new System.Windows.Forms.Button();
            this.btnPayslip = new System.Windows.Forms.Button();
            this.btnAllPayslips = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnOpenPeriod = new System.Windows.Forms.Button();
            this.btnDeletePeriod = new System.Windows.Forms.Button();
            this.lblAdjEmployee = new System.Windows.Forms.Label();
            this.cmbAdjEmployee = new System.Windows.Forms.ComboBox();
            this.lblAdjType = new System.Windows.Forms.Label();
            this.cmbAdjType = new System.Windows.Forms.ComboBox();
            this.lblAdjDate = new System.Windows.Forms.Label();
            this.dtpAdjDate = new System.Windows.Forms.DateTimePicker();
            this.lblAdjDescription = new System.Windows.Forms.Label();
            this.txtAdjDescription = new System.Windows.Forms.TextBox();
            this.lblAdjAmount = new System.Windows.Forms.Label();
            this.txtAdjAmount = new System.Windows.Forms.TextBox();
            this.btnAddAdjustment = new System.Windows.Forms.Button();
            this.lblAdjNote = new System.Windows.Forms.Label();
            this.lblAdjFrom = new System.Windows.Forms.Label();
            this.dtpAdjFrom = new System.Windows.Forms.DateTimePicker();
            this.lblAdjTo = new System.Windows.Forms.Label();
            this.dtpAdjTo = new System.Windows.Forms.DateTimePicker();
            this.dgvAdjustments = new System.Windows.Forms.DataGridView();
            this.btnDeleteAdjustment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdjustments)).BeginInit();
            this.tabsPayroll.SuspendLayout();
            this.tabPayroll.SuspendLayout();
            this.tabAdjust.SuspendLayout();
            this.pnlSum1.SuspendLayout();
            this.pnlSumAccent1.SuspendLayout();
            this.pnlSum2.SuspendLayout();
            this.pnlSumAccent2.SuspendLayout();
            this.pnlSum3.SuspendLayout();
            this.pnlSumAccent3.SuspendLayout();
            this.pnlSum4.SuspendLayout();
            this.pnlSumAccent4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsPayroll
            // 
            this.tabsPayroll.Controls.Add(this.tabPayroll);
            this.tabsPayroll.Controls.Add(this.tabAdjust);
            this.tabsPayroll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabsPayroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsPayroll.Location = new System.Drawing.Point(0, 0);
            this.tabsPayroll.Name = "tabsPayroll";
            this.tabsPayroll.Size = new System.Drawing.Size(1068, 668);
            this.tabsPayroll.TabIndex = 0;
            this.tabsPayroll.SelectedIndexChanged += new System.EventHandler(this.tabsPayroll_SelectedIndexChanged);
            // 
            // tabPayroll
            // 
            this.tabPayroll.Controls.Add(this.lblStart);
            this.tabPayroll.Controls.Add(this.dtpStart);
            this.tabPayroll.Controls.Add(this.lblEnd);
            this.tabPayroll.Controls.Add(this.dtpEnd);
            this.tabPayroll.Controls.Add(this.lblPay);
            this.tabPayroll.Controls.Add(this.dtpPayDate);
            this.tabPayroll.Controls.Add(this.btnFirstHalf);
            this.tabPayroll.Controls.Add(this.btnSecondHalf);
            this.tabPayroll.Controls.Add(this.btnCompute);
            this.tabPayroll.Controls.Add(this.pnlSum1);
            this.tabPayroll.Controls.Add(this.pnlSum2);
            this.tabPayroll.Controls.Add(this.pnlSum3);
            this.tabPayroll.Controls.Add(this.pnlSum4);
            this.tabPayroll.Controls.Add(this.lblMode);
            this.tabPayroll.Controls.Add(this.dgvPayroll);
            this.tabPayroll.Controls.Add(this.lblHistory);
            this.tabPayroll.Controls.Add(this.dgvHistory);
            this.tabPayroll.Controls.Add(this.btnSavePayroll);
            this.tabPayroll.Controls.Add(this.btnPayslip);
            this.tabPayroll.Controls.Add(this.btnAllPayslips);
            this.tabPayroll.Controls.Add(this.btnRegister);
            this.tabPayroll.Controls.Add(this.btnOpenPeriod);
            this.tabPayroll.Controls.Add(this.btnDeletePeriod);
            this.tabPayroll.Text = "Payroll";
            this.tabPayroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.tabPayroll.Location = new System.Drawing.Point(4, 30);
            this.tabPayroll.Name = "tabPayroll";
            this.tabPayroll.Size = new System.Drawing.Size(1060, 634);
            this.tabPayroll.TabIndex = 1;
            this.tabPayroll.UseVisualStyleBackColor = false;
            // 
            // tabAdjust
            // 
            this.tabAdjust.Controls.Add(this.lblAdjEmployee);
            this.tabAdjust.Controls.Add(this.cmbAdjEmployee);
            this.tabAdjust.Controls.Add(this.lblAdjType);
            this.tabAdjust.Controls.Add(this.cmbAdjType);
            this.tabAdjust.Controls.Add(this.lblAdjDate);
            this.tabAdjust.Controls.Add(this.dtpAdjDate);
            this.tabAdjust.Controls.Add(this.lblAdjDescription);
            this.tabAdjust.Controls.Add(this.txtAdjDescription);
            this.tabAdjust.Controls.Add(this.lblAdjAmount);
            this.tabAdjust.Controls.Add(this.txtAdjAmount);
            this.tabAdjust.Controls.Add(this.btnAddAdjustment);
            this.tabAdjust.Controls.Add(this.lblAdjNote);
            this.tabAdjust.Controls.Add(this.lblAdjFrom);
            this.tabAdjust.Controls.Add(this.dtpAdjFrom);
            this.tabAdjust.Controls.Add(this.lblAdjTo);
            this.tabAdjust.Controls.Add(this.dtpAdjTo);
            this.tabAdjust.Controls.Add(this.dgvAdjustments);
            this.tabAdjust.Controls.Add(this.btnDeleteAdjustment);
            this.tabAdjust.Text = "Bonuses / deductions";
            this.tabAdjust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.tabAdjust.Location = new System.Drawing.Point(4, 30);
            this.tabAdjust.Name = "tabAdjust";
            this.tabAdjust.Size = new System.Drawing.Size(1060, 634);
            this.tabAdjust.TabIndex = 2;
            this.tabAdjust.UseVisualStyleBackColor = false;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Text = "PERIOD START";
            this.lblStart.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblStart.Location = new System.Drawing.Point(12, 12);
            this.lblStart.Name = "lblStart";
            this.lblStart.TabIndex = 3;
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.CustomFormat = "MMM dd, yyyy";
            this.dtpStart.Location = new System.Drawing.Point(12, 30);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(150, 27);
            this.dtpStart.TabIndex = 4;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Text = "PERIOD END";
            this.lblEnd.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblEnd.Location = new System.Drawing.Point(176, 12);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.TabIndex = 5;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.CustomFormat = "MMM dd, yyyy";
            this.dtpEnd.Location = new System.Drawing.Point(176, 30);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(150, 27);
            this.dtpEnd.TabIndex = 6;
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Text = "PAY DATE";
            this.lblPay.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPay.Location = new System.Drawing.Point(340, 12);
            this.lblPay.Name = "lblPay";
            this.lblPay.TabIndex = 7;
            // 
            // dtpPayDate
            // 
            this.dtpPayDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPayDate.CustomFormat = "MMM dd, yyyy";
            this.dtpPayDate.Location = new System.Drawing.Point(340, 30);
            this.dtpPayDate.Name = "dtpPayDate";
            this.dtpPayDate.Size = new System.Drawing.Size(150, 27);
            this.dtpPayDate.TabIndex = 8;
            // 
            // btnFirstHalf
            // 
            this.btnFirstHalf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFirstHalf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnFirstHalf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstHalf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirstHalf.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstHalf.Text = "1st - 15th";
            this.btnFirstHalf.FlatAppearance.BorderSize = 1;
            this.btnFirstHalf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnFirstHalf.Location = new System.Drawing.Point(506, 28);
            this.btnFirstHalf.Name = "btnFirstHalf";
            this.btnFirstHalf.Size = new System.Drawing.Size(110, 32);
            this.btnFirstHalf.TabIndex = 9;
            this.btnFirstHalf.UseVisualStyleBackColor = false;
            this.btnFirstHalf.Click += new System.EventHandler(this.btnFirstHalf_Click);
            // 
            // btnSecondHalf
            // 
            this.btnSecondHalf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSecondHalf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnSecondHalf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecondHalf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSecondHalf.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecondHalf.Text = "16th - end";
            this.btnSecondHalf.FlatAppearance.BorderSize = 1;
            this.btnSecondHalf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnSecondHalf.Location = new System.Drawing.Point(626, 28);
            this.btnSecondHalf.Name = "btnSecondHalf";
            this.btnSecondHalf.Size = new System.Drawing.Size(110, 32);
            this.btnSecondHalf.TabIndex = 10;
            this.btnSecondHalf.UseVisualStyleBackColor = false;
            this.btnSecondHalf.Click += new System.EventHandler(this.btnSecondHalf_Click);
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.btnCompute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompute.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.Text = "Compute payroll";
            this.btnCompute.FlatAppearance.BorderSize = 0;
            this.btnCompute.Location = new System.Drawing.Point(750, 26);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(176, 36);
            this.btnCompute.TabIndex = 11;
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // pnlSum1
            // 
            this.pnlSum1.Controls.Add(this.pnlSumAccent1);
            this.pnlSum1.Controls.Add(this.lblSum1Title);
            this.pnlSum1.Controls.Add(this.lblSum1Value);
            this.pnlSum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlSum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSum1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSum1.Location = new System.Drawing.Point(12, 74);
            this.pnlSum1.Name = "pnlSum1";
            this.pnlSum1.Size = new System.Drawing.Size(250, 62);
            this.pnlSum1.TabIndex = 12;
            // 
            // pnlSumAccent1
            // 
            this.pnlSumAccent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.pnlSumAccent1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSumAccent1.Location = new System.Drawing.Point(0, 0);
            this.pnlSumAccent1.Name = "pnlSumAccent1";
            this.pnlSumAccent1.Size = new System.Drawing.Size(5, 60);
            this.pnlSumAccent1.TabIndex = 13;
            // 
            // lblSum1Title
            // 
            this.lblSum1Title.AutoSize = true;
            this.lblSum1Title.Text = "EMPLOYEES";
            this.lblSum1Title.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSum1Title.Location = new System.Drawing.Point(16, 8);
            this.lblSum1Title.Name = "lblSum1Title";
            this.lblSum1Title.TabIndex = 14;
            // 
            // lblSum1Value
            // 
            this.lblSum1Value.AutoSize = true;
            this.lblSum1Value.Text = "0";
            this.lblSum1Value.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum1Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblSum1Value.Location = new System.Drawing.Point(14, 26);
            this.lblSum1Value.Name = "lblSum1Value";
            this.lblSum1Value.TabIndex = 15;
            // 
            // pnlSum2
            // 
            this.pnlSum2.Controls.Add(this.pnlSumAccent2);
            this.pnlSum2.Controls.Add(this.lblSum2Title);
            this.pnlSum2.Controls.Add(this.lblSum2Value);
            this.pnlSum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlSum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSum2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSum2.Location = new System.Drawing.Point(274, 74);
            this.pnlSum2.Name = "pnlSum2";
            this.pnlSum2.Size = new System.Drawing.Size(250, 62);
            this.pnlSum2.TabIndex = 16;
            // 
            // pnlSumAccent2
            // 
            this.pnlSumAccent2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.pnlSumAccent2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSumAccent2.Location = new System.Drawing.Point(0, 0);
            this.pnlSumAccent2.Name = "pnlSumAccent2";
            this.pnlSumAccent2.Size = new System.Drawing.Size(5, 60);
            this.pnlSumAccent2.TabIndex = 17;
            // 
            // lblSum2Title
            // 
            this.lblSum2Title.AutoSize = true;
            this.lblSum2Title.Text = "TOTAL GROSS PAY";
            this.lblSum2Title.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSum2Title.Location = new System.Drawing.Point(16, 8);
            this.lblSum2Title.Name = "lblSum2Title";
            this.lblSum2Title.TabIndex = 18;
            // 
            // lblSum2Value
            // 
            this.lblSum2Value.AutoSize = true;
            this.lblSum2Value.Text = "0";
            this.lblSum2Value.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum2Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblSum2Value.Location = new System.Drawing.Point(14, 26);
            this.lblSum2Value.Name = "lblSum2Value";
            this.lblSum2Value.TabIndex = 19;
            // 
            // pnlSum3
            // 
            this.pnlSum3.Controls.Add(this.pnlSumAccent3);
            this.pnlSum3.Controls.Add(this.lblSum3Title);
            this.pnlSum3.Controls.Add(this.lblSum3Value);
            this.pnlSum3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlSum3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSum3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSum3.Location = new System.Drawing.Point(536, 74);
            this.pnlSum3.Name = "pnlSum3";
            this.pnlSum3.Size = new System.Drawing.Size(250, 62);
            this.pnlSum3.TabIndex = 20;
            // 
            // pnlSumAccent3
            // 
            this.pnlSumAccent3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.pnlSumAccent3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSumAccent3.Location = new System.Drawing.Point(0, 0);
            this.pnlSumAccent3.Name = "pnlSumAccent3";
            this.pnlSumAccent3.Size = new System.Drawing.Size(5, 60);
            this.pnlSumAccent3.TabIndex = 21;
            // 
            // lblSum3Title
            // 
            this.lblSum3Title.AutoSize = true;
            this.lblSum3Title.Text = "TOTAL DEDUCTIONS";
            this.lblSum3Title.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSum3Title.Location = new System.Drawing.Point(16, 8);
            this.lblSum3Title.Name = "lblSum3Title";
            this.lblSum3Title.TabIndex = 22;
            // 
            // lblSum3Value
            // 
            this.lblSum3Value.AutoSize = true;
            this.lblSum3Value.Text = "0";
            this.lblSum3Value.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum3Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblSum3Value.Location = new System.Drawing.Point(14, 26);
            this.lblSum3Value.Name = "lblSum3Value";
            this.lblSum3Value.TabIndex = 23;
            // 
            // pnlSum4
            // 
            this.pnlSum4.Controls.Add(this.pnlSumAccent4);
            this.pnlSum4.Controls.Add(this.lblSum4Title);
            this.pnlSum4.Controls.Add(this.lblSum4Value);
            this.pnlSum4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlSum4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSum4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSum4.Location = new System.Drawing.Point(798, 74);
            this.pnlSum4.Name = "pnlSum4";
            this.pnlSum4.Size = new System.Drawing.Size(250, 62);
            this.pnlSum4.TabIndex = 24;
            // 
            // pnlSumAccent4
            // 
            this.pnlSumAccent4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.pnlSumAccent4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSumAccent4.Location = new System.Drawing.Point(0, 0);
            this.pnlSumAccent4.Name = "pnlSumAccent4";
            this.pnlSumAccent4.Size = new System.Drawing.Size(5, 60);
            this.pnlSumAccent4.TabIndex = 25;
            // 
            // lblSum4Title
            // 
            this.lblSum4Title.AutoSize = true;
            this.lblSum4Title.Text = "TOTAL NET PAY";
            this.lblSum4Title.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum4Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSum4Title.Location = new System.Drawing.Point(16, 8);
            this.lblSum4Title.Name = "lblSum4Title";
            this.lblSum4Title.TabIndex = 26;
            // 
            // lblSum4Value
            // 
            this.lblSum4Value.AutoSize = true;
            this.lblSum4Value.Text = "0";
            this.lblSum4Value.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum4Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblSum4Value.Location = new System.Drawing.Point(14, 26);
            this.lblSum4Value.Name = "lblSum4Value";
            this.lblSum4Value.TabIndex = 27;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = false;
            this.lblMode.Text = "Choose a pay period and press Compute payroll.";
            this.lblMode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblMode.Location = new System.Drawing.Point(12, 146);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(700, 22);
            this.lblMode.TabIndex = 28;
            // 
            // dgvPayroll
            // 
            this.dgvPayroll.AllowUserToAddRows = false;
            this.dgvPayroll.AllowUserToDeleteRows = false;
            this.dgvPayroll.AllowUserToResizeRows = false;
            this.dgvPayroll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvPayroll.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayroll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayroll.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPayroll.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayroll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPayroll.ColumnHeadersHeight = 38;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayroll.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayroll.EnableHeadersVisualStyles = false;
            this.dgvPayroll.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvPayroll.MultiSelect = false;
            this.dgvPayroll.ReadOnly = true;
            this.dgvPayroll.RowHeadersVisible = false;
            this.dgvPayroll.RowTemplate.Height = 36;
            this.dgvPayroll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayroll.Location = new System.Drawing.Point(12, 172);
            this.dgvPayroll.Name = "dgvPayroll";
            this.dgvPayroll.Size = new System.Drawing.Size(706, 400);
            this.dgvPayroll.TabIndex = 29;
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Text = "PAYROLL HISTORY";
            this.lblHistory.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHistory.Location = new System.Drawing.Point(732, 148);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.TabIndex = 30;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AllowUserToResizeRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistory.ColumnHeadersHeight = 38;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistory.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHistory.EnableHeadersVisualStyles = false;
            this.dgvHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvHistory.MultiSelect = false;
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.RowTemplate.Height = 36;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistory.Location = new System.Drawing.Point(732, 172);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.Size = new System.Drawing.Size(314, 400);
            this.dgvHistory.TabIndex = 31;
            this.dgvHistory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistory_CellDoubleClick);
            // 
            // btnSavePayroll
            // 
            this.btnSavePayroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnSavePayroll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSavePayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePayroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavePayroll.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePayroll.Text = "Save payroll";
            this.btnSavePayroll.FlatAppearance.BorderSize = 0;
            this.btnSavePayroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSavePayroll.Location = new System.Drawing.Point(12, 584);
            this.btnSavePayroll.Name = "btnSavePayroll";
            this.btnSavePayroll.Size = new System.Drawing.Size(150, 38);
            this.btnSavePayroll.TabIndex = 32;
            this.btnSavePayroll.UseVisualStyleBackColor = false;
            this.btnSavePayroll.Click += new System.EventHandler(this.btnSavePayroll_Click);
            // 
            // btnPayslip
            // 
            this.btnPayslip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPayslip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnPayslip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayslip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayslip.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayslip.Text = "Payslip";
            this.btnPayslip.FlatAppearance.BorderSize = 1;
            this.btnPayslip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnPayslip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPayslip.Location = new System.Drawing.Point(174, 584);
            this.btnPayslip.Name = "btnPayslip";
            this.btnPayslip.Size = new System.Drawing.Size(120, 38);
            this.btnPayslip.TabIndex = 33;
            this.btnPayslip.UseVisualStyleBackColor = false;
            this.btnPayslip.Click += new System.EventHandler(this.btnPayslip_Click);
            // 
            // btnAllPayslips
            // 
            this.btnAllPayslips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAllPayslips.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAllPayslips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllPayslips.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllPayslips.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllPayslips.Text = "All payslips";
            this.btnAllPayslips.FlatAppearance.BorderSize = 1;
            this.btnAllPayslips.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnAllPayslips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAllPayslips.Location = new System.Drawing.Point(306, 584);
            this.btnAllPayslips.Name = "btnAllPayslips";
            this.btnAllPayslips.Size = new System.Drawing.Size(140, 38);
            this.btnAllPayslips.TabIndex = 34;
            this.btnAllPayslips.UseVisualStyleBackColor = false;
            this.btnAllPayslips.Click += new System.EventHandler(this.btnAllPayslips_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Text = "Payroll register";
            this.btnRegister.FlatAppearance.BorderSize = 1;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegister.Location = new System.Drawing.Point(458, 584);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(160, 38);
            this.btnRegister.TabIndex = 35;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnOpenPeriod
            // 
            this.btnOpenPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.btnOpenPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOpenPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPeriod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenPeriod.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenPeriod.Text = "Open";
            this.btnOpenPeriod.FlatAppearance.BorderSize = 0;
            this.btnOpenPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPeriod.Location = new System.Drawing.Point(732, 584);
            this.btnOpenPeriod.Name = "btnOpenPeriod";
            this.btnOpenPeriod.Size = new System.Drawing.Size(150, 38);
            this.btnOpenPeriod.TabIndex = 36;
            this.btnOpenPeriod.UseVisualStyleBackColor = false;
            this.btnOpenPeriod.Click += new System.EventHandler(this.btnOpenPeriod_Click);
            // 
            // btnDeletePeriod
            // 
            this.btnDeletePeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnDeletePeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeletePeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePeriod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePeriod.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePeriod.Text = "Delete";
            this.btnDeletePeriod.FlatAppearance.BorderSize = 0;
            this.btnDeletePeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePeriod.Location = new System.Drawing.Point(896, 584);
            this.btnDeletePeriod.Name = "btnDeletePeriod";
            this.btnDeletePeriod.Size = new System.Drawing.Size(150, 38);
            this.btnDeletePeriod.TabIndex = 37;
            this.btnDeletePeriod.UseVisualStyleBackColor = false;
            this.btnDeletePeriod.Click += new System.EventHandler(this.btnDeletePeriod_Click);
            // 
            // lblAdjEmployee
            // 
            this.lblAdjEmployee.AutoSize = true;
            this.lblAdjEmployee.Text = "EMPLOYEE";
            this.lblAdjEmployee.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdjEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAdjEmployee.Location = new System.Drawing.Point(16, 16);
            this.lblAdjEmployee.Name = "lblAdjEmployee";
            this.lblAdjEmployee.TabIndex = 38;
            // 
            // cmbAdjEmployee
            // 
            this.cmbAdjEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdjEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAdjEmployee.FormattingEnabled = true;
            this.cmbAdjEmployee.Location = new System.Drawing.Point(16, 34);
            this.cmbAdjEmployee.Name = "cmbAdjEmployee";
            this.cmbAdjEmployee.Size = new System.Drawing.Size(300, 27);
            this.cmbAdjEmployee.TabIndex = 39;
            // 
            // lblAdjType
            // 
            this.lblAdjType.AutoSize = true;
            this.lblAdjType.Text = "TYPE";
            this.lblAdjType.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdjType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAdjType.Location = new System.Drawing.Point(16, 80);
            this.lblAdjType.Name = "lblAdjType";
            this.lblAdjType.TabIndex = 40;
            // 
            // cmbAdjType
            // 
            this.cmbAdjType.Items.AddRange(new object[] {
            "Earning",
            "Deduction"});
            this.cmbAdjType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdjType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAdjType.FormattingEnabled = true;
            this.cmbAdjType.Location = new System.Drawing.Point(16, 98);
            this.cmbAdjType.Name = "cmbAdjType";
            this.cmbAdjType.Size = new System.Drawing.Size(140, 27);
            this.cmbAdjType.TabIndex = 41;
            // 
            // lblAdjDate
            // 
            this.lblAdjDate.AutoSize = true;
            this.lblAdjDate.Text = "DATE";
            this.lblAdjDate.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdjDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAdjDate.Location = new System.Drawing.Point(176, 80);
            this.lblAdjDate.Name = "lblAdjDate";
            this.lblAdjDate.TabIndex = 42;
            // 
            // dtpAdjDate
            // 
            this.dtpAdjDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAdjDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAdjDate.CustomFormat = "MMM dd, yyyy";
            this.dtpAdjDate.Location = new System.Drawing.Point(176, 98);
            this.dtpAdjDate.Name = "dtpAdjDate";
            this.dtpAdjDate.Size = new System.Drawing.Size(140, 27);
            this.dtpAdjDate.TabIndex = 43;
            // 
            // lblAdjDescription
            // 
            this.lblAdjDescription.AutoSize = true;
            this.lblAdjDescription.Text = "DESCRIPTION";
            this.lblAdjDescription.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdjDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAdjDescription.Location = new System.Drawing.Point(16, 144);
            this.lblAdjDescription.Name = "lblAdjDescription";
            this.lblAdjDescription.TabIndex = 44;
            // 
            // txtAdjDescription
            // 
            this.txtAdjDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdjDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdjDescription.Location = new System.Drawing.Point(16, 162);
            this.txtAdjDescription.Name = "txtAdjDescription";
            this.txtAdjDescription.Size = new System.Drawing.Size(300, 27);
            this.txtAdjDescription.TabIndex = 45;
            // 
            // lblAdjAmount
            // 
            this.lblAdjAmount.AutoSize = true;
            this.lblAdjAmount.Text = "AMOUNT";
            this.lblAdjAmount.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdjAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAdjAmount.Location = new System.Drawing.Point(16, 208);
            this.lblAdjAmount.Name = "lblAdjAmount";
            this.lblAdjAmount.TabIndex = 46;
            // 
            // txtAdjAmount
            // 
            this.txtAdjAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdjAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdjAmount.Location = new System.Drawing.Point(16, 226);
            this.txtAdjAmount.Name = "txtAdjAmount";
            this.txtAdjAmount.Size = new System.Drawing.Size(300, 27);
            this.txtAdjAmount.TabIndex = 47;
            // 
            // btnAddAdjustment
            // 
            this.btnAddAdjustment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.btnAddAdjustment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddAdjustment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdjustment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAdjustment.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdjustment.Text = "Add entry";
            this.btnAddAdjustment.FlatAppearance.BorderSize = 0;
            this.btnAddAdjustment.Location = new System.Drawing.Point(16, 274);
            this.btnAddAdjustment.Name = "btnAddAdjustment";
            this.btnAddAdjustment.Size = new System.Drawing.Size(300, 40);
            this.btnAddAdjustment.TabIndex = 48;
            this.btnAddAdjustment.UseVisualStyleBackColor = false;
            this.btnAddAdjustment.Click += new System.EventHandler(this.btnAddAdjustment_Click);
            // 
            // lblAdjNote
            // 
            this.lblAdjNote.AutoSize = false;
            this.lblAdjNote.Text = "Entries are added to payroll when their date falls inside the pay period. Use Earning for holiday pay or bonuses, Deduction for cash advances.";
            this.lblAdjNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdjNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAdjNote.Location = new System.Drawing.Point(16, 330);
            this.lblAdjNote.Name = "lblAdjNote";
            this.lblAdjNote.Size = new System.Drawing.Size(300, 70);
            this.lblAdjNote.TabIndex = 49;
            // 
            // lblAdjFrom
            // 
            this.lblAdjFrom.AutoSize = true;
            this.lblAdjFrom.Text = "FROM";
            this.lblAdjFrom.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdjFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAdjFrom.Location = new System.Drawing.Point(350, 16);
            this.lblAdjFrom.Name = "lblAdjFrom";
            this.lblAdjFrom.TabIndex = 50;
            // 
            // dtpAdjFrom
            // 
            this.dtpAdjFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAdjFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAdjFrom.CustomFormat = "MMM dd, yyyy";
            this.dtpAdjFrom.Location = new System.Drawing.Point(350, 34);
            this.dtpAdjFrom.Name = "dtpAdjFrom";
            this.dtpAdjFrom.Size = new System.Drawing.Size(150, 27);
            this.dtpAdjFrom.TabIndex = 51;
            this.dtpAdjFrom.ValueChanged += new System.EventHandler(this.AdjFilter_Changed);
            // 
            // lblAdjTo
            // 
            this.lblAdjTo.AutoSize = true;
            this.lblAdjTo.Text = "TO";
            this.lblAdjTo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdjTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAdjTo.Location = new System.Drawing.Point(514, 16);
            this.lblAdjTo.Name = "lblAdjTo";
            this.lblAdjTo.TabIndex = 52;
            // 
            // dtpAdjTo
            // 
            this.dtpAdjTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAdjTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAdjTo.CustomFormat = "MMM dd, yyyy";
            this.dtpAdjTo.Location = new System.Drawing.Point(514, 34);
            this.dtpAdjTo.Name = "dtpAdjTo";
            this.dtpAdjTo.Size = new System.Drawing.Size(150, 27);
            this.dtpAdjTo.TabIndex = 53;
            this.dtpAdjTo.ValueChanged += new System.EventHandler(this.AdjFilter_Changed);
            // 
            // dgvAdjustments
            // 
            this.dgvAdjustments.AllowUserToAddRows = false;
            this.dgvAdjustments.AllowUserToDeleteRows = false;
            this.dgvAdjustments.AllowUserToResizeRows = false;
            this.dgvAdjustments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgvAdjustments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdjustments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdjustments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAdjustments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdjustments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAdjustments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAdjustments.ColumnHeadersHeight = 38;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdjustments.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAdjustments.EnableHeadersVisualStyles = false;
            this.dgvAdjustments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvAdjustments.MultiSelect = false;
            this.dgvAdjustments.ReadOnly = true;
            this.dgvAdjustments.RowHeadersVisible = false;
            this.dgvAdjustments.RowTemplate.Height = 36;
            this.dgvAdjustments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdjustments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdjustments.Location = new System.Drawing.Point(350, 76);
            this.dgvAdjustments.Name = "dgvAdjustments";
            this.dgvAdjustments.Size = new System.Drawing.Size(696, 490);
            this.dgvAdjustments.TabIndex = 54;
            // 
            // btnDeleteAdjustment
            // 
            this.btnDeleteAdjustment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnDeleteAdjustment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeleteAdjustment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAdjustment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAdjustment.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAdjustment.Text = "Delete selected";
            this.btnDeleteAdjustment.FlatAppearance.BorderSize = 0;
            this.btnDeleteAdjustment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteAdjustment.Location = new System.Drawing.Point(350, 580);
            this.btnDeleteAdjustment.Name = "btnDeleteAdjustment";
            this.btnDeleteAdjustment.Size = new System.Drawing.Size(170, 38);
            this.btnDeleteAdjustment.TabIndex = 55;
            this.btnDeleteAdjustment.UseVisualStyleBackColor = false;
            this.btnDeleteAdjustment.Click += new System.EventHandler(this.btnDeleteAdjustment_Click);
            // 
            // PayrollForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.tabsPayroll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Padding = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.Name = "PayrollForm";
            this.Text = "Payroll";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdjustments)).EndInit();
            this.tabsPayroll.ResumeLayout(false);
            this.tabPayroll.ResumeLayout(false);
            this.tabPayroll.PerformLayout();
            this.tabAdjust.ResumeLayout(false);
            this.tabAdjust.PerformLayout();
            this.pnlSum1.ResumeLayout(false);
            this.pnlSum1.PerformLayout();
            this.pnlSumAccent1.ResumeLayout(false);
            this.pnlSum2.ResumeLayout(false);
            this.pnlSum2.PerformLayout();
            this.pnlSumAccent2.ResumeLayout(false);
            this.pnlSum3.ResumeLayout(false);
            this.pnlSum3.PerformLayout();
            this.pnlSumAccent3.ResumeLayout(false);
            this.pnlSum4.ResumeLayout(false);
            this.pnlSum4.PerformLayout();
            this.pnlSumAccent4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabsPayroll;
        private System.Windows.Forms.TabPage tabPayroll;
        private System.Windows.Forms.TabPage tabAdjust;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.DateTimePicker dtpPayDate;
        private System.Windows.Forms.Button btnFirstHalf;
        private System.Windows.Forms.Button btnSecondHalf;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Panel pnlSum1;
        private System.Windows.Forms.Panel pnlSumAccent1;
        private System.Windows.Forms.Label lblSum1Title;
        private System.Windows.Forms.Label lblSum1Value;
        private System.Windows.Forms.Panel pnlSum2;
        private System.Windows.Forms.Panel pnlSumAccent2;
        private System.Windows.Forms.Label lblSum2Title;
        private System.Windows.Forms.Label lblSum2Value;
        private System.Windows.Forms.Panel pnlSum3;
        private System.Windows.Forms.Panel pnlSumAccent3;
        private System.Windows.Forms.Label lblSum3Title;
        private System.Windows.Forms.Label lblSum3Value;
        private System.Windows.Forms.Panel pnlSum4;
        private System.Windows.Forms.Panel pnlSumAccent4;
        private System.Windows.Forms.Label lblSum4Title;
        private System.Windows.Forms.Label lblSum4Value;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.DataGridView dgvPayroll;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Button btnSavePayroll;
        private System.Windows.Forms.Button btnPayslip;
        private System.Windows.Forms.Button btnAllPayslips;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnOpenPeriod;
        private System.Windows.Forms.Button btnDeletePeriod;
        private System.Windows.Forms.Label lblAdjEmployee;
        private System.Windows.Forms.ComboBox cmbAdjEmployee;
        private System.Windows.Forms.Label lblAdjType;
        private System.Windows.Forms.ComboBox cmbAdjType;
        private System.Windows.Forms.Label lblAdjDate;
        private System.Windows.Forms.DateTimePicker dtpAdjDate;
        private System.Windows.Forms.Label lblAdjDescription;
        private System.Windows.Forms.TextBox txtAdjDescription;
        private System.Windows.Forms.Label lblAdjAmount;
        private System.Windows.Forms.TextBox txtAdjAmount;
        private System.Windows.Forms.Button btnAddAdjustment;
        private System.Windows.Forms.Label lblAdjNote;
        private System.Windows.Forms.Label lblAdjFrom;
        private System.Windows.Forms.DateTimePicker dtpAdjFrom;
        private System.Windows.Forms.Label lblAdjTo;
        private System.Windows.Forms.DateTimePicker dtpAdjTo;
        private System.Windows.Forms.DataGridView dgvAdjustments;
        private System.Windows.Forms.Button btnDeleteAdjustment;
    }
}
