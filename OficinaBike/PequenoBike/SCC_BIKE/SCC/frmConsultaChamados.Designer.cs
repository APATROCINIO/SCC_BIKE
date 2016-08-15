namespace SCC_BIKE
{
    partial class frmConsultaChamados
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
            this.dataGridChamados = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idChamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimirChamado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChamados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridChamados
            // 
            this.dataGridChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridChamados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.idChamado,
            this.idCliente,
            this.NomeCliente,
            this.ValorTotal});
            this.dataGridChamados.Location = new System.Drawing.Point(12, 42);
            this.dataGridChamados.Name = "dataGridChamados";
            this.dataGridChamados.Size = new System.Drawing.Size(830, 261);
            this.dataGridChamados.TabIndex = 102;
            this.dataGridChamados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridChamados_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Selecionar";
            this.Column1.Name = "Column1";
            // 
            // idChamado
            // 
            this.idChamado.DataPropertyName = "idChamado";
            this.idChamado.HeaderText = "Cód Chamado";
            this.idChamado.Name = "idChamado";
            this.idChamado.ReadOnly = true;
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "idCliente";
            this.idCliente.HeaderText = "Cód Cliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            // 
            // NomeCliente
            // 
            this.NomeCliente.DataPropertyName = "NomeCliente";
            this.NomeCliente.HeaderText = "Cliente";
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.ReadOnly = true;
            this.NomeCliente.Width = 160;
            // 
            // ValorTotal
            // 
            this.ValorTotal.DataPropertyName = "ValorTotal";
            this.ValorTotal.HeaderText = "Valor Total do Serviço";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            this.ValorTotal.Width = 180;
            // 
            // btnImprimirChamado
            // 
            this.btnImprimirChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirChamado.ForeColor = System.Drawing.Color.Blue;
            this.btnImprimirChamado.Location = new System.Drawing.Point(313, 311);
            this.btnImprimirChamado.Name = "btnImprimirChamado";
            this.btnImprimirChamado.Size = new System.Drawing.Size(245, 41);
            this.btnImprimirChamado.TabIndex = 103;
            this.btnImprimirChamado.Text = "Visualizar Chamado";
            this.btnImprimirChamado.UseVisualStyleBackColor = true;
            this.btnImprimirChamado.Click += new System.EventHandler(this.btnImprimirChamado_Click);
            // 
            // frmConsultaChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 363);
            this.Controls.Add(this.btnImprimirChamado);
            this.Controls.Add(this.dataGridChamados);
            this.Name = "frmConsultaChamados";
            this.Text = "Consultar Chamados";
            this.Load += new System.EventHandler(this.frmConsultaChmados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChamados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridChamados;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idChamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.Button btnImprimirChamado;

    }
}