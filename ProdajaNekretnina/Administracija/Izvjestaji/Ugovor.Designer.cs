namespace Administracija.Izvjestaji
{
    partial class Ugovor
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
            this.esp_Izlazi_Ugovor1_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.esp_Izlazi_Ugovor1_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // esp_Izlazi_Ugovor1_ResultBindingSource
            // 
            this.esp_Izlazi_Ugovor1_ResultBindingSource.DataSource = typeof(SistemNekretnine.DB.esp_Izlazi_Ugovor1_Result);
            this.esp_Izlazi_Ugovor1_ResultBindingSource.CurrentChanged += new System.EventHandler(this.esp_Izlazi_Ugovor1_ResultBindingSource_CurrentChanged);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.esp_Izlazi_Ugovor1_ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Administracija.Izvjestaji.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(750, 504);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Print += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.reportViewer1_Print);
            // 
            // Ugovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 523);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Ugovor";
            this.Text = "Ugovor";
            this.Load += new System.EventHandler(this.Ugovor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.esp_Izlazi_Ugovor1_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource esp_Izlazi_Ugovor1_ResultBindingSource;
    }
}