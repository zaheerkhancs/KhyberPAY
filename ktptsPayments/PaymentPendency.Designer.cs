namespace ktptsPayments
{
    partial class PaymentPendency
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vwGrid = new System.Windows.Forms.DataGridView();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtr2 = new System.Windows.Forms.DateTimePicker();
            this.dtr1 = new System.Windows.Forms.DateTimePicker();
            this.vwGridPaid = new System.Windows.Forms.DataGridView();
            this.vwGridUnpaid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDepotP = new System.Windows.Forms.TextBox();
            this.txtPurdateP = new System.Windows.Forms.TextBox();
            this.txtPaydateP = new System.Windows.Forms.TextBox();
            this.txtDepotUnp = new System.Windows.Forms.TextBox();
            this.txtPaydateUnp = new System.Windows.Forms.TextBox();
            this.txtPurdateUnp = new System.Windows.Forms.TextBox();
            this.txtAmountUnp = new System.Windows.Forms.TextBox();
            this.txtAmountPaidUnp = new System.Windows.Forms.TextBox();
            this.txtNoVoucherUnpid = new System.Windows.Forms.TextBox();
            this.txtAmountPaidP = new System.Windows.Forms.TextBox();
            this.txtAmountP = new System.Windows.Forms.TextBox();
            this.txtNoVp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vwGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGridPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGridUnpaid)).BeginInit();
            this.SuspendLayout();
            // 
            // vwGrid
            // 
            this.vwGrid.AllowUserToAddRows = false;
            this.vwGrid.AllowUserToDeleteRows = false;
            this.vwGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.vwGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.vwGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwGrid.Location = new System.Drawing.Point(12, 77);
            this.vwGrid.MultiSelect = false;
            this.vwGrid.Name = "vwGrid";
            this.vwGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vwGrid.ShowCellErrors = false;
            this.vwGrid.ShowCellToolTips = false;
            this.vwGrid.ShowEditingIcon = false;
            this.vwGrid.ShowRowErrors = false;
            this.vwGrid.Size = new System.Drawing.Size(504, 343);
            this.vwGrid.TabIndex = 20;
            this.vwGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwGrid_CellClick);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(400, 27);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(116, 23);
            this.btnDisplay.TabIndex = 19;
            this.btnDisplay.Text = "Filter";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Depot";
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(12, 25);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(154, 21);
            this.cmbDatabase.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Purchase Date";
            // 
            // dtr2
            // 
            this.dtr2.AllowDrop = true;
            this.dtr2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtr2.Location = new System.Drawing.Point(276, 27);
            this.dtr2.Name = "dtr2";
            this.dtr2.Size = new System.Drawing.Size(117, 20);
            this.dtr2.TabIndex = 14;
            this.dtr2.Value = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            // 
            // dtr1
            // 
            this.dtr1.AllowDrop = true;
            this.dtr1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtr1.Location = new System.Drawing.Point(179, 27);
            this.dtr1.Name = "dtr1";
            this.dtr1.Size = new System.Drawing.Size(88, 20);
            this.dtr1.TabIndex = 13;
            this.dtr1.Value = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            // 
            // vwGridPaid
            // 
            this.vwGridPaid.AllowUserToAddRows = false;
            this.vwGridPaid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.vwGridPaid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.vwGridPaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwGridPaid.Location = new System.Drawing.Point(522, 77);
            this.vwGridPaid.Name = "vwGridPaid";
            this.vwGridPaid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vwGridPaid.Size = new System.Drawing.Size(734, 158);
            this.vwGridPaid.TabIndex = 21;
            // 
            // vwGridUnpaid
            // 
            this.vwGridUnpaid.AllowUserToAddRows = false;
            this.vwGridUnpaid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.vwGridUnpaid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.vwGridUnpaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwGridUnpaid.Location = new System.Drawing.Point(522, 255);
            this.vwGridUnpaid.Name = "vwGridUnpaid";
            this.vwGridUnpaid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vwGridUnpaid.Size = new System.Drawing.Size(734, 188);
            this.vwGridUnpaid.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(682, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Depot:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(989, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "No of Voucher:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1022, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(998, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Amount Paid:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(639, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Purchase Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(642, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Payment Date:";
            // 
            // txtDepotP
            // 
            this.txtDepotP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtDepotP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepotP.Enabled = false;
            this.txtDepotP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepotP.ForeColor = System.Drawing.Color.Red;
            this.txtDepotP.Location = new System.Drawing.Point(718, 6);
            this.txtDepotP.Name = "txtDepotP";
            this.txtDepotP.Size = new System.Drawing.Size(119, 21);
            this.txtDepotP.TabIndex = 29;
            // 
            // txtPurdateP
            // 
            this.txtPurdateP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPurdateP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurdateP.Enabled = false;
            this.txtPurdateP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurdateP.ForeColor = System.Drawing.Color.Red;
            this.txtPurdateP.Location = new System.Drawing.Point(718, 28);
            this.txtPurdateP.Name = "txtPurdateP";
            this.txtPurdateP.Size = new System.Drawing.Size(119, 21);
            this.txtPurdateP.TabIndex = 30;
            // 
            // txtPaydateP
            // 
            this.txtPaydateP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPaydateP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaydateP.Enabled = false;
            this.txtPaydateP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaydateP.ForeColor = System.Drawing.Color.Red;
            this.txtPaydateP.Location = new System.Drawing.Point(718, 50);
            this.txtPaydateP.Name = "txtPaydateP";
            this.txtPaydateP.Size = new System.Drawing.Size(119, 21);
            this.txtPaydateP.TabIndex = 31;
            // 
            // txtDepotUnp
            // 
            this.txtDepotUnp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtDepotUnp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepotUnp.Enabled = false;
            this.txtDepotUnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepotUnp.ForeColor = System.Drawing.Color.Red;
            this.txtDepotUnp.Location = new System.Drawing.Point(840, 6);
            this.txtDepotUnp.Name = "txtDepotUnp";
            this.txtDepotUnp.Size = new System.Drawing.Size(118, 21);
            this.txtDepotUnp.TabIndex = 32;
            // 
            // txtPaydateUnp
            // 
            this.txtPaydateUnp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPaydateUnp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaydateUnp.Enabled = false;
            this.txtPaydateUnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaydateUnp.ForeColor = System.Drawing.Color.Red;
            this.txtPaydateUnp.Location = new System.Drawing.Point(840, 52);
            this.txtPaydateUnp.Name = "txtPaydateUnp";
            this.txtPaydateUnp.Size = new System.Drawing.Size(118, 21);
            this.txtPaydateUnp.TabIndex = 33;
            // 
            // txtPurdateUnp
            // 
            this.txtPurdateUnp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPurdateUnp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurdateUnp.Enabled = false;
            this.txtPurdateUnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurdateUnp.ForeColor = System.Drawing.Color.Red;
            this.txtPurdateUnp.Location = new System.Drawing.Point(840, 29);
            this.txtPurdateUnp.Name = "txtPurdateUnp";
            this.txtPurdateUnp.Size = new System.Drawing.Size(118, 21);
            this.txtPurdateUnp.TabIndex = 34;
            // 
            // txtAmountUnp
            // 
            this.txtAmountUnp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAmountUnp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountUnp.Enabled = false;
            this.txtAmountUnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountUnp.ForeColor = System.Drawing.Color.Red;
            this.txtAmountUnp.Location = new System.Drawing.Point(1163, 30);
            this.txtAmountUnp.Name = "txtAmountUnp";
            this.txtAmountUnp.Size = new System.Drawing.Size(90, 21);
            this.txtAmountUnp.TabIndex = 40;
            // 
            // txtAmountPaidUnp
            // 
            this.txtAmountPaidUnp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAmountPaidUnp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountPaidUnp.Enabled = false;
            this.txtAmountPaidUnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPaidUnp.ForeColor = System.Drawing.Color.Red;
            this.txtAmountPaidUnp.Location = new System.Drawing.Point(1163, 53);
            this.txtAmountPaidUnp.Name = "txtAmountPaidUnp";
            this.txtAmountPaidUnp.Size = new System.Drawing.Size(90, 21);
            this.txtAmountPaidUnp.TabIndex = 39;
            // 
            // txtNoVoucherUnpid
            // 
            this.txtNoVoucherUnpid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtNoVoucherUnpid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoVoucherUnpid.Enabled = false;
            this.txtNoVoucherUnpid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoVoucherUnpid.ForeColor = System.Drawing.Color.Red;
            this.txtNoVoucherUnpid.Location = new System.Drawing.Point(1163, 7);
            this.txtNoVoucherUnpid.Name = "txtNoVoucherUnpid";
            this.txtNoVoucherUnpid.Size = new System.Drawing.Size(90, 21);
            this.txtNoVoucherUnpid.TabIndex = 38;
            // 
            // txtAmountPaidP
            // 
            this.txtAmountPaidP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAmountPaidP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountPaidP.Enabled = false;
            this.txtAmountPaidP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPaidP.ForeColor = System.Drawing.Color.Red;
            this.txtAmountPaidP.Location = new System.Drawing.Point(1067, 51);
            this.txtAmountPaidP.Name = "txtAmountPaidP";
            this.txtAmountPaidP.Size = new System.Drawing.Size(90, 21);
            this.txtAmountPaidP.TabIndex = 37;
            // 
            // txtAmountP
            // 
            this.txtAmountP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAmountP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountP.Enabled = false;
            this.txtAmountP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountP.ForeColor = System.Drawing.Color.Red;
            this.txtAmountP.Location = new System.Drawing.Point(1067, 29);
            this.txtAmountP.Name = "txtAmountP";
            this.txtAmountP.Size = new System.Drawing.Size(90, 21);
            this.txtAmountP.TabIndex = 36;
            // 
            // txtNoVp
            // 
            this.txtNoVp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtNoVp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoVp.Enabled = false;
            this.txtNoVp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoVp.ForeColor = System.Drawing.Color.Red;
            this.txtNoVp.Location = new System.Drawing.Point(1067, 7);
            this.txtNoVp.Name = "txtNoVp";
            this.txtNoVp.Size = new System.Drawing.Size(90, 21);
            this.txtNoVp.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Depot";
            // 
            // PaymentPendency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 521);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAmountUnp);
            this.Controls.Add(this.txtAmountPaidUnp);
            this.Controls.Add(this.txtNoVoucherUnpid);
            this.Controls.Add(this.txtAmountPaidP);
            this.Controls.Add(this.txtAmountP);
            this.Controls.Add(this.txtNoVp);
            this.Controls.Add(this.txtPurdateUnp);
            this.Controls.Add(this.txtPaydateUnp);
            this.Controls.Add(this.txtDepotUnp);
            this.Controls.Add(this.txtPaydateP);
            this.Controls.Add(this.txtPurdateP);
            this.Controls.Add(this.txtDepotP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vwGridUnpaid);
            this.Controls.Add(this.vwGridPaid);
            this.Controls.Add(this.vwGrid);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtr2);
            this.Controls.Add(this.dtr1);
            this.Name = "PaymentPendency";
            this.Text = "PaymentPendency";
            this.Load += new System.EventHandler(this.PaymentPendency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGridPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGridUnpaid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vwGrid;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtr2;
        private System.Windows.Forms.DateTimePicker dtr1;
        private System.Windows.Forms.DataGridView vwGridPaid;
        private System.Windows.Forms.DataGridView vwGridUnpaid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDepotP;
        private System.Windows.Forms.TextBox txtPurdateP;
        private System.Windows.Forms.TextBox txtPaydateP;
        private System.Windows.Forms.TextBox txtDepotUnp;
        private System.Windows.Forms.TextBox txtPaydateUnp;
        private System.Windows.Forms.TextBox txtPurdateUnp;
        private System.Windows.Forms.TextBox txtAmountUnp;
        private System.Windows.Forms.TextBox txtAmountPaidUnp;
        private System.Windows.Forms.TextBox txtNoVoucherUnpid;
        private System.Windows.Forms.TextBox txtAmountPaidP;
        private System.Windows.Forms.TextBox txtAmountP;
        private System.Windows.Forms.TextBox txtNoVp;
        private System.Windows.Forms.Label label9;
    }
}