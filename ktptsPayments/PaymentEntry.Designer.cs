namespace ktptsPayments
{
    partial class PaymentEntry
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
            this.components = new System.ComponentModel.Container();
            this.dtPurchase = new System.Windows.Forms.DateTimePicker();
            this.dtPayment = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.vwGrid = new System.Windows.Forms.DataGridView();
            this.txtvcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVoucherCode = new System.Windows.Forms.TextBox();
            this.dtPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.txtGrowerName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtReAmount = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtDepot = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtVoucherID = new System.Windows.Forms.TextBox();
            this.cmbAttachment = new System.Windows.Forms.ComboBox();
            this.chkFlag = new System.Windows.Forms.CheckBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbPaidBy = new System.Windows.Forms.ComboBox();
            this.dtDatePaid = new System.Windows.Forms.DateTimePicker();
            this.dtPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtGrowerID = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.vwGridMaster = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vwGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwGridMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPurchase
            // 
            this.dtPurchase.AllowDrop = true;
            this.dtPurchase.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPurchase.Location = new System.Drawing.Point(142, 45);
            this.dtPurchase.Name = "dtPurchase";
            this.dtPurchase.Size = new System.Drawing.Size(88, 20);
            this.dtPurchase.TabIndex = 1;
            this.dtPurchase.Value = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            // 
            // dtPayment
            // 
            this.dtPayment.AllowDrop = true;
            this.dtPayment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPayment.Location = new System.Drawing.Point(236, 46);
            this.dtPayment.Name = "dtPayment";
            this.dtPayment.Size = new System.Drawing.Size(117, 20);
            this.dtPayment.TabIndex = 2;
            this.dtPayment.Value = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Purchase Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Payment Date";
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(21, 45);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(109, 21);
            this.cmbDatabase.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Depot";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(460, 43);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(93, 23);
            this.btnDisplay.TabIndex = 8;
            this.btnDisplay.Text = "Filter";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // vwGrid
            // 
            this.vwGrid.AllowUserToAddRows = false;
            this.vwGrid.AllowUserToDeleteRows = false;
            this.vwGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwGrid.Location = new System.Drawing.Point(21, 72);
            this.vwGrid.Name = "vwGrid";
            this.vwGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vwGrid.Size = new System.Drawing.Size(532, 351);
            this.vwGrid.TabIndex = 9;
            this.vwGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwGrid_CellClick);
            // 
            // txtvcode
            // 
            this.txtvcode.Location = new System.Drawing.Point(360, 46);
            this.txtvcode.Name = "txtvcode";
            this.txtvcode.Size = new System.Drawing.Size(93, 20);
            this.txtvcode.TabIndex = 10;
            this.txtvcode.Text = "null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Vocher Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(915, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(571, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Voucher Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(668, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Payment Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(776, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Grower";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(977, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Re-Enter";
            // 
            // txtVoucherCode
            // 
            this.txtVoucherCode.Enabled = false;
            this.txtVoucherCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucherCode.Location = new System.Drawing.Point(571, 43);
            this.txtVoucherCode.Name = "txtVoucherCode";
            this.txtVoucherCode.Size = new System.Drawing.Size(91, 23);
            this.txtVoucherCode.TabIndex = 18;
            // 
            // dtPaymentDate
            // 
            this.dtPaymentDate.AllowDrop = true;
            this.dtPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPaymentDate.Location = new System.Drawing.Point(664, 43);
            this.dtPaymentDate.Name = "dtPaymentDate";
            this.dtPaymentDate.Size = new System.Drawing.Size(103, 23);
            this.dtPaymentDate.TabIndex = 19;
            this.dtPaymentDate.Value = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            // 
            // txtGrowerName
            // 
            this.txtGrowerName.Enabled = false;
            this.txtGrowerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrowerName.Location = new System.Drawing.Point(771, 43);
            this.txtGrowerName.Name = "txtGrowerName";
            this.txtGrowerName.Size = new System.Drawing.Size(125, 23);
            this.txtGrowerName.TabIndex = 20;
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(899, 43);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(75, 23);
            this.txtAmount.TabIndex = 21;
            // 
            // txtReAmount
            // 
            this.txtReAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReAmount.ForeColor = System.Drawing.Color.White;
            this.txtReAmount.Location = new System.Drawing.Point(980, 44);
            this.txtReAmount.Name = "txtReAmount";
            this.txtReAmount.Size = new System.Drawing.Size(78, 24);
            this.txtReAmount.TabIndex = 22;
            this.txtReAmount.TextChanged += new System.EventHandler(this.txtReAmount_TextChanged);
            this.txtReAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReAmount_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(1063, 44);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save/F1";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 451);
            this.splitter1.TabIndex = 24;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 451);
            this.splitter2.TabIndex = 25;
            this.splitter2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txtDepot);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtVoucherID);
            this.groupBox1.Controls.Add(this.cmbAttachment);
            this.groupBox1.Controls.Add(this.chkFlag);
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.cmbPaidBy);
            this.groupBox1.Controls.Add(this.dtDatePaid);
            this.groupBox1.Controls.Add(this.dtPurchaseDate);
            this.groupBox1.Controls.Add(this.txtMobile);
            this.groupBox1.Controls.Add(this.txtCNIC);
            this.groupBox1.Controls.Add(this.txtFatherName);
            this.groupBox1.Controls.Add(this.txtGrowerID);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(567, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 186);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Other Details";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(329, 142);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 13);
            this.label22.TabIndex = 43;
            this.label22.Text = "Location:";
            // 
            // txtDepot
            // 
            this.txtDepot.Location = new System.Drawing.Point(384, 140);
            this.txtDepot.Name = "txtDepot";
            this.txtDepot.Size = new System.Drawing.Size(147, 20);
            this.txtDepot.TabIndex = 42;
            this.txtDepot.Text = "Depot";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(318, 120);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 13);
            this.label21.TabIndex = 41;
            this.label21.Text = "Voucher ID:";
            // 
            // txtVoucherID
            // 
            this.txtVoucherID.Location = new System.Drawing.Point(384, 117);
            this.txtVoucherID.Name = "txtVoucherID";
            this.txtVoucherID.Size = new System.Drawing.Size(149, 20);
            this.txtVoucherID.TabIndex = 40;
            // 
            // cmbAttachment
            // 
            this.cmbAttachment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAttachment.FormattingEnabled = true;
            this.cmbAttachment.Items.AddRange(new object[] {
            "CNIC",
            "Stamp Paper",
            "Reference Letter",
            "Others"});
            this.cmbAttachment.Location = new System.Drawing.Point(78, 110);
            this.cmbAttachment.Name = "cmbAttachment";
            this.cmbAttachment.Size = new System.Drawing.Size(152, 21);
            this.cmbAttachment.TabIndex = 39;
            // 
            // chkFlag
            // 
            this.chkFlag.AutoSize = true;
            this.chkFlag.Enabled = false;
            this.chkFlag.Location = new System.Drawing.Point(80, 164);
            this.chkFlag.Name = "chkFlag";
            this.chkFlag.Size = new System.Drawing.Size(15, 14);
            this.chkFlag.TabIndex = 38;
            this.chkFlag.UseVisualStyleBackColor = true;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(78, 134);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(152, 20);
            this.txtRemarks.TabIndex = 37;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Paid",
            "Pending",
            "Disputed",
            "Misplaced",
            "Others"});
            this.cmbStatus.Location = new System.Drawing.Point(384, 93);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(149, 21);
            this.cmbStatus.TabIndex = 36;
            // 
            // cmbPaidBy
            // 
            this.cmbPaidBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaidBy.FormattingEnabled = true;
            this.cmbPaidBy.Location = new System.Drawing.Point(384, 69);
            this.cmbPaidBy.MaxDropDownItems = 10;
            this.cmbPaidBy.Name = "cmbPaidBy";
            this.cmbPaidBy.Size = new System.Drawing.Size(149, 21);
            this.cmbPaidBy.TabIndex = 35;
            // 
            // dtDatePaid
            // 
            this.dtDatePaid.AllowDrop = true;
            this.dtDatePaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDatePaid.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDatePaid.Location = new System.Drawing.Point(384, 44);
            this.dtDatePaid.Name = "dtDatePaid";
            this.dtDatePaid.Size = new System.Drawing.Size(149, 23);
            this.dtDatePaid.TabIndex = 34;
            this.dtDatePaid.Value = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            // 
            // dtPurchaseDate
            // 
            this.dtPurchaseDate.AllowDrop = true;
            this.dtPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPurchaseDate.Location = new System.Drawing.Point(384, 16);
            this.dtPurchaseDate.Name = "dtPurchaseDate";
            this.dtPurchaseDate.Size = new System.Drawing.Size(149, 23);
            this.dtPurchaseDate.TabIndex = 33;
            this.dtPurchaseDate.Value = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(78, 89);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(152, 20);
            this.txtMobile.TabIndex = 31;
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(78, 67);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(152, 20);
            this.txtCNIC.TabIndex = 30;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(78, 45);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(152, 20);
            this.txtFatherName.TabIndex = 29;
            // 
            // txtGrowerID
            // 
            this.txtGrowerID.Location = new System.Drawing.Point(78, 23);
            this.txtGrowerID.Name = "txtGrowerID";
            this.txtGrowerID.Size = new System.Drawing.Size(152, 20);
            this.txtGrowerID.TabIndex = 28;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(48, 163);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 13);
            this.label20.TabIndex = 27;
            this.label20.Text = "Flag:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 113);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 13);
            this.label19.TabIndex = 27;
            this.label19.Text = "Attachment:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 136);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "Remarks:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(338, 96);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "Status:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(332, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Paid By:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(321, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Date Paid:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Mobile:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Grower ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(297, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Purchase Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "CNIC:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Father Name:";
            // 
            // vwGridMaster
            // 
            this.vwGridMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwGridMaster.Location = new System.Drawing.Point(567, 262);
            this.vwGridMaster.Name = "vwGridMaster";
            this.vwGridMaster.Size = new System.Drawing.Size(573, 161);
            this.vwGridMaster.TabIndex = 27;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PaymentEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 451);
            this.Controls.Add(this.vwGridMaster);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtReAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtGrowerName);
            this.Controls.Add(this.dtPaymentDate);
            this.Controls.Add(this.txtVoucherCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtvcode);
            this.Controls.Add(this.vwGrid);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDatabase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtPayment);
            this.Controls.Add(this.dtPurchase);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PaymentEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PaymentEntry";
            this.Load += new System.EventHandler(this.PaymentEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwGridMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPurchase;
        private System.Windows.Forms.DateTimePicker dtPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.DataGridView vwGrid;
        private System.Windows.Forms.TextBox txtvcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVoucherCode;
        private System.Windows.Forms.DateTimePicker dtPaymentDate;
        private System.Windows.Forms.TextBox txtGrowerName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtReAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbPaidBy;
        private System.Windows.Forms.DateTimePicker dtDatePaid;
        private System.Windows.Forms.DateTimePicker dtPurchaseDate;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtGrowerID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkFlag;
        private System.Windows.Forms.DataGridView vwGridMaster;
        private System.Windows.Forms.ComboBox cmbAttachment;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtVoucherID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtDepot;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}