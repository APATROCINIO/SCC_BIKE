namespace SCC_BIKE.Relatorios
{
    partial class frmRelatorioUsuariosCadastrados
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
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSCC_BIKEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSCC_BIKEDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.dbSCC_BIKEDataSetBindingSource;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_Usuarios";
            reportDataSource1.Value = this.usuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer1.Size = new System.Drawing.Size(734, 606);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomPercent = 80;
            // 
            // frmRelatorioUsuariosCadastrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 606);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorioUsuariosCadastrados";
            this.Text = "Relatório de Usuarios Cadastrados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRelatorioUsuariosCadastrados_FormClosed);
            this.Load += new System.EventHandler(this.frmRelatorioUsuariosCadastrados_Load);
            //((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSCC_BIKEDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dbSCC_BIKEDataSetBindingSource;
        //private dbSCC_BIKEDataSet dbSCC_BIKEDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        //private dbSCC_BIKEDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
    }
}