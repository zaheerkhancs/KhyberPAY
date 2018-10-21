namespace ktptsPayments
{
    partial class CenterWisePaymentScrollRpt
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.getPaymentReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cwPaymentRpt = new ktptsPayments.cwPaymentRpt();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtPayment = new System.Windows.Forms.DateTimePicker();
            this.dtPurchase = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.getPaymentReportTableAdapter = new ktptsPayments.cwPaymentRptTableAdapters.getPaymentReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.getPaymentReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwPaymentRpt)).BeginInit();
            this.SuspendLayout();
            // 
            // getPaymentReportBindingSource
            // 
            this.getPaymentReportBindingSource.DataMember = "getPaymentReport";
            this.getPaymentReportBindingSource.DataSource = this.cwPaymentRpt;
            // 
            // cwPaymentRpt
            // 
            this.cwPaymentRpt.DataSetName = "cwPaymentRpt";
            this.cwPaymentRpt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsCWPayment";
            reportDataSource1.Value = this.getPaymentReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "";
            this.reportViewer1.LocalReport.ReportPath = "rptcwPayment.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 53);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1167, 543);
            this.reportViewer1.TabIndex = 0;
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(12, 26);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(109, 21);
            this.cmbDatabase.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Payment Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Purchase Date";
            // 
            // dtPayment
            // 
            this.dtPayment.AllowDrop = true;
            this.dtPayment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPayment.Location = new System.Drawing.Point(226, 28);
            this.dtPayment.Name = "dtPayment";
            this.dtPayment.Size = new System.Drawing.Size(117, 20);
            this.dtPayment.TabIndex = 8;
            this.dtPayment.Value = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            // 
            // dtPurchase
            // 
            this.dtPurchase.AllowDrop = true;
            this.dtPurchase.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPurchase.Location = new System.Drawing.Point(132, 27);
            this.dtPurchase.Name = "dtPurchase";
            this.dtPurchase.Size = new System.Drawing.Size(88, 20);
            this.dtPurchase.TabIndex = 7;
            this.dtPurchase.Value = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Depot";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(349, 27);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(93, 23);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "Show Report";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // getPaymentReportTableAdapter
            // 
            this.getPaymentReportTableAdapter.ClearBeforeFill = true;
            // 
            // CenterWisePaymentScrollRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 608);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtPayment);
            this.Controls.Add(this.dtPurchase);
            this.Controls.Add(this.cmbDatabase);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CenterWisePaymentScrollRpt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PaymentScrollRpt";
            this.Load += new System.EventHandler(this.PaymentScrollRpt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getPaymentReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cwPaymentRpt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPayment;
        private System.Windows.Forms.DateTimePicker dtPurchase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.BindingSource getPaymentReportBindingSource;
        private cwPaymentRpt cwPaymentRpt;
        private cwPaymentRptTableAdapters.getPaymentReportTableAdapter getPaymentReportTableAdapter;
    }
}