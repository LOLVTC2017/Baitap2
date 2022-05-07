namespace Baitap2
{
    partial class Form1
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
            this.txt_khachhang = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qLBHDataSet = new Baitap2.QLBHDataSet();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACH_HANGTableAdapter = new Baitap2.QLBHDataSetTableAdapters.KHACH_HANGTableAdapter();
            this.qLBHDataSet1 = new Baitap2.QLBHDataSet1();
            this.pHIEUTHUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUTHUTableAdapter = new Baitap2.QLBHDataSet1TableAdapters.PHIEUTHUTableAdapter();
            this.pHIEUTHUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHHANGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUTHUBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHDataSet2 = new Baitap2.QLBHDataSet2();
            this.getSoCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getSoCTTableAdapter = new Baitap2.QLBHDataSet2TableAdapters.GetSoCTTableAdapter();
            this.qLBHDataSet3 = new Baitap2.QLBHDataSet3();
            this.reportByCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportByCTTableAdapter = new Baitap2.QLBHDataSet3TableAdapters.ReportByCTTableAdapter();
            this.qLBHDataSet5 = new Baitap2.QLBHDataSet5();
            this.getCustomerInPhieuThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getCustomerInPhieuThuTableAdapter = new Baitap2.QLBHDataSet5TableAdapters.GetCustomerInPhieuThuTableAdapter();
            this.qLBHDataSet6 = new Baitap2.QLBHDataSet6();
            this.getcustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getcustomerTableAdapter = new Baitap2.QLBHDataSet6TableAdapters.getcustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSoCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportByCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerInPhieuThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getcustomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_khachhang
            // 
            this.txt_khachhang.DataSource = this.getcustomerBindingSource;
            this.txt_khachhang.DisplayMember = "TenKHG";
            this.txt_khachhang.FormattingEnabled = true;
            this.txt_khachhang.Location = new System.Drawing.Point(12, 12);
            this.txt_khachhang.Name = "txt_khachhang";
            this.txt_khachhang.Size = new System.Drawing.Size(273, 21);
            this.txt_khachhang.TabIndex = 0;
            this.txt_khachhang.ValueMember = "MaKHG";
            this.txt_khachhang.SelectedIndexChanged += new System.EventHandler(this.txt_khachhang_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reportByCTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Baitap2.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 54);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(924, 583);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // qLBHDataSet
            // 
            this.qLBHDataSet.DataSetName = "QLBHDataSet";
            this.qLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACH_HANG";
            this.kHACHHANGBindingSource.DataSource = this.qLBHDataSet;
            // 
            // kHACH_HANGTableAdapter
            // 
            this.kHACH_HANGTableAdapter.ClearBeforeFill = true;
            // 
            // qLBHDataSet1
            // 
            this.qLBHDataSet1.DataSetName = "QLBHDataSet1";
            this.qLBHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHIEUTHUBindingSource
            // 
            this.pHIEUTHUBindingSource.DataMember = "PHIEUTHU";
            this.pHIEUTHUBindingSource.DataSource = this.qLBHDataSet1;
            // 
            // pHIEUTHUTableAdapter
            // 
            this.pHIEUTHUTableAdapter.ClearBeforeFill = true;
            // 
            // pHIEUTHUBindingSource1
            // 
            this.pHIEUTHUBindingSource1.DataMember = "PHIEUTHU";
            this.pHIEUTHUBindingSource1.DataSource = this.qLBHDataSet1;
            // 
            // kHACHHANGBindingSource1
            // 
            this.kHACHHANGBindingSource1.DataMember = "KHACH_HANG";
            this.kHACHHANGBindingSource1.DataSource = this.qLBHDataSet;
            // 
            // pHIEUTHUBindingSource2
            // 
            this.pHIEUTHUBindingSource2.DataMember = "PHIEUTHU";
            this.pHIEUTHUBindingSource2.DataSource = this.qLBHDataSet1;
            // 
            // qLBHDataSet2
            // 
            this.qLBHDataSet2.DataSetName = "QLBHDataSet2";
            this.qLBHDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getSoCTBindingSource
            // 
            this.getSoCTBindingSource.DataMember = "GetSoCT";
            this.getSoCTBindingSource.DataSource = this.qLBHDataSet2;
            // 
            // getSoCTTableAdapter
            // 
            this.getSoCTTableAdapter.ClearBeforeFill = true;
            // 
            // qLBHDataSet3
            // 
            this.qLBHDataSet3.DataSetName = "QLBHDataSet3";
            this.qLBHDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportByCTBindingSource
            // 
            this.reportByCTBindingSource.DataMember = "ReportByCT";
            this.reportByCTBindingSource.DataSource = this.qLBHDataSet3;
            // 
            // reportByCTTableAdapter
            // 
            this.reportByCTTableAdapter.ClearBeforeFill = true;
            // 
            // qLBHDataSet5
            // 
            this.qLBHDataSet5.DataSetName = "QLBHDataSet5";
            this.qLBHDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getCustomerInPhieuThuBindingSource
            // 
            this.getCustomerInPhieuThuBindingSource.DataMember = "GetCustomerInPhieuThu";
            this.getCustomerInPhieuThuBindingSource.DataSource = this.qLBHDataSet5;
            // 
            // getCustomerInPhieuThuTableAdapter
            // 
            this.getCustomerInPhieuThuTableAdapter.ClearBeforeFill = true;
            // 
            // qLBHDataSet6
            // 
            this.qLBHDataSet6.DataSetName = "QLBHDataSet6";
            this.qLBHDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getcustomerBindingSource
            // 
            this.getcustomerBindingSource.DataMember = "getcustomer";
            this.getcustomerBindingSource.DataSource = this.qLBHDataSet6;
            // 
            // getcustomerTableAdapter
            // 
            this.getcustomerTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 637);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.txt_khachhang);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSoCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportByCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerInPhieuThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getcustomerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox txt_khachhang;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLBHDataSet qLBHDataSet;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private QLBHDataSetTableAdapters.KHACH_HANGTableAdapter kHACH_HANGTableAdapter;
        private System.Windows.Forms.BindingSource pHIEUTHUBindingSource;
        private QLBHDataSet1 qLBHDataSet1;
        private QLBHDataSet1TableAdapters.PHIEUTHUTableAdapter pHIEUTHUTableAdapter;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource1;
        private System.Windows.Forms.BindingSource pHIEUTHUBindingSource2;
        private System.Windows.Forms.BindingSource pHIEUTHUBindingSource1;
        private System.Windows.Forms.BindingSource getSoCTBindingSource;
        private QLBHDataSet2 qLBHDataSet2;
        private QLBHDataSet2TableAdapters.GetSoCTTableAdapter getSoCTTableAdapter;
        private System.Windows.Forms.BindingSource reportByCTBindingSource;
        private QLBHDataSet3 qLBHDataSet3;
        private QLBHDataSet3TableAdapters.ReportByCTTableAdapter reportByCTTableAdapter;
        private QLBHDataSet5 qLBHDataSet5;
        private System.Windows.Forms.BindingSource getCustomerInPhieuThuBindingSource;
        private QLBHDataSet5TableAdapters.GetCustomerInPhieuThuTableAdapter getCustomerInPhieuThuTableAdapter;
        private QLBHDataSet6 qLBHDataSet6;
        private System.Windows.Forms.BindingSource getcustomerBindingSource;
        private QLBHDataSet6TableAdapters.getcustomerTableAdapter getcustomerTableAdapter;
    }
}

