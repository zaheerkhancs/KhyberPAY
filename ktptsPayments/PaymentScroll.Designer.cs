namespace ktptsPayments
{
    partial class PaymentScroll
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
            this.vwPaymentScrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ktptsPaymentsDataSet = new ktptsPayments.ktptsPaymentsDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vwPaymentScrollTableAdapter = new ktptsPayments.ktptsPaymentsDataSetTableAdapters.vwPaymentScrollTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vwPaymentScrollBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ktptsPaymentsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // vwPaymentScrollBindingSource
            // 
            this.vwPaymentScrollBindingSource.DataMember = "vwPaymentScroll";
            this.vwPaymentScrollBindingSource.DataSource = this.ktptsPaymentsDataSet;
            // 
            // ktptsPaymentsDataSet
            // 
            this.ktptsPaymentsDataSet.DataSetName = "ktptsPaymentsDataSet";
            this.ktptsPaymentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "rptDs";
            reportDataSource1.Value = this.vwPaymentScrollBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "";
            this.reportViewer1.LocalReport.ReportPath = "rptPaymentScroll.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(957, 474);
            this.reportViewer1.TabIndex = 0;
            // 
            // vwPaymentScrollTableAdapter
            // 
            this.vwPaymentScrollTableAdapter.ClearBeforeFill = true;
            // 
            // PaymentScroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 474);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PaymentScroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PaymentScroll";
            this.Load += new System.EventHandler(this.PaymentScroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwPaymentScrollBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ktptsPaymentsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vwPaymentScrollBindingSource;
        private ktptsPaymentsDataSet ktptsPaymentsDataSet;
        private ktptsPaymentsDataSetTableAdapters.vwPaymentScrollTableAdapter vwPaymentScrollTableAdapter;
    }
}