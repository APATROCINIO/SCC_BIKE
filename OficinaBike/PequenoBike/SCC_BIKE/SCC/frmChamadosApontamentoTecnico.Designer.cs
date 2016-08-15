namespace SCC_BIKE
{
    partial class frmChamadosApontamentoTecnico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChamadosApontamentoTecnico));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.rtxObsAtendente = new System.Windows.Forms.RichTextBox();
            this.dataGridChamados = new System.Windows.Forms.DataGridView();
            this.idItemChamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idChamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAtendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObsItemChamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObsAtendenteChamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PadraoMarcaModeloSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObsItemTecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.rtxObsItemChamado = new System.Windows.Forms.RichTextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbCarrega = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChamados)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnSalvar,
            this.toolStripSeparator1,
            this.btnCancelar,
            this.btnExcluir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(874, 25);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(23, 22);
            this.btnNovo.Text = "Novo Usuário";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(23, 22);
            this.btnSalvar.Text = "Salvar Usuário";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar Usuário";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(23, 22);
            this.btnExcluir.Text = "Excluir Usuário";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.rtxObsAtendente);
            this.panel2.Controls.Add(this.dataGridChamados);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(6, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 227);
            this.panel2.TabIndex = 118;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(562, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 16);
            this.label6.TabIndex = 134;
            this.label6.Text = "Observação do Atendente";
            // 
            // rtxObsAtendente
            // 
            this.rtxObsAtendente.Location = new System.Drawing.Point(566, 38);
            this.rtxObsAtendente.MaxLength = 500;
            this.rtxObsAtendente.Name = "rtxObsAtendente";
            this.rtxObsAtendente.Size = new System.Drawing.Size(297, 186);
            this.rtxObsAtendente.TabIndex = 133;
            this.rtxObsAtendente.Text = "";
            // 
            // dataGridChamados
            // 
            this.dataGridChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridChamados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idItemChamado,
            this.idChamado,
            this.idCliente,
            this.NomeCliente,
            this.idProduto,
            this.NomeProduto,
            this.DataAtendimento,
            this.ObsItemChamado,
            this.ObsAtendenteChamado,
            this.PadraoMarcaModeloSerie,
            this.ObsItemTecnico});
            this.dataGridChamados.Location = new System.Drawing.Point(3, 22);
            this.dataGridChamados.Name = "dataGridChamados";
            this.dataGridChamados.Size = new System.Drawing.Size(553, 202);
            this.dataGridChamados.TabIndex = 98;
            this.dataGridChamados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridChamados_CellClick);
            // 
            // idItemChamado
            // 
            this.idItemChamado.DataPropertyName = "idItemChamado";
            this.idItemChamado.HeaderText = "item do Chamado";
            this.idItemChamado.Name = "idItemChamado";
            this.idItemChamado.Visible = false;
            // 
            // idChamado
            // 
            this.idChamado.DataPropertyName = "idChamado";
            this.idChamado.HeaderText = "Cód Chamado";
            this.idChamado.Name = "idChamado";
            this.idChamado.ReadOnly = true;
            this.idChamado.Width = 80;
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "idCliente";
            this.idCliente.HeaderText = "Cód Cliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.Visible = false;
            // 
            // NomeCliente
            // 
            this.NomeCliente.DataPropertyName = "NomeCliente";
            this.NomeCliente.HeaderText = "Cliente";
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.ReadOnly = true;
            this.NomeCliente.Visible = false;
            this.NomeCliente.Width = 160;
            // 
            // idProduto
            // 
            this.idProduto.DataPropertyName = "idProduto";
            this.idProduto.HeaderText = "Cód Produto";
            this.idProduto.Name = "idProduto";
            this.idProduto.ReadOnly = true;
            this.idProduto.Visible = false;
            // 
            // NomeProduto
            // 
            this.NomeProduto.DataPropertyName = "NomeProduto";
            this.NomeProduto.HeaderText = "Produto";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            this.NomeProduto.Width = 150;
            // 
            // DataAtendimento
            // 
            this.DataAtendimento.DataPropertyName = "DataAtendimento";
            this.DataAtendimento.HeaderText = "Data Atendimento";
            this.DataAtendimento.Name = "DataAtendimento";
            this.DataAtendimento.ReadOnly = true;
            // 
            // ObsItemChamado
            // 
            this.ObsItemChamado.DataPropertyName = "ObsItemChamado";
            this.ObsItemChamado.HeaderText = "Obs Sobre o Item";
            this.ObsItemChamado.Name = "ObsItemChamado";
            this.ObsItemChamado.ReadOnly = true;
            this.ObsItemChamado.Visible = false;
            this.ObsItemChamado.Width = 120;
            // 
            // ObsAtendenteChamado
            // 
            this.ObsAtendenteChamado.DataPropertyName = "ObsAtendenteChamado";
            this.ObsAtendenteChamado.HeaderText = "Observação do Atendente";
            this.ObsAtendenteChamado.Name = "ObsAtendenteChamado";
            this.ObsAtendenteChamado.ReadOnly = true;
            this.ObsAtendenteChamado.Visible = false;
            // 
            // PadraoMarcaModeloSerie
            // 
            this.PadraoMarcaModeloSerie.DataPropertyName = "PadraoMarcaModeloSerie";
            this.PadraoMarcaModeloSerie.HeaderText = "Marca Modelo e Série";
            this.PadraoMarcaModeloSerie.Name = "PadraoMarcaModeloSerie";
            this.PadraoMarcaModeloSerie.ReadOnly = true;
            this.PadraoMarcaModeloSerie.Visible = false;
            this.PadraoMarcaModeloSerie.Width = 150;
            // 
            // ObsItemTecnico
            // 
            this.ObsItemTecnico.DataPropertyName = "ObsItemTecnico";
            this.ObsItemTecnico.HeaderText = "Apontamento Técnico";
            this.ObsItemTecnico.Name = "ObsItemTecnico";
            this.ObsItemTecnico.Width = 160;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 13);
            this.label10.TabIndex = 97;
            this.label10.Text = "Informações do Chamado";
            // 
            // rtxObsItemChamado
            // 
            this.rtxObsItemChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxObsItemChamado.Location = new System.Drawing.Point(8, 349);
            this.rtxObsItemChamado.MaxLength = 500;
            this.rtxObsItemChamado.Name = "rtxObsItemChamado";
            this.rtxObsItemChamado.Size = new System.Drawing.Size(854, 127);
            this.rtxObsItemChamado.TabIndex = 119;
            this.rtxObsItemChamado.Text = "";
            this.rtxObsItemChamado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxObsItemChamado_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Red;
            this.lblCodigo.Location = new System.Drawing.Point(104, 258);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(28, 24);
            this.lblCodigo.TabIndex = 121;
            this.lblCodigo.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 120;
            this.label1.Text = "Chamado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 122;
            this.label2.Text = "Cód Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 123;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 124;
            this.label4.Text = "Cód Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 125;
            this.label5.Text = "Produto";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(10, 312);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(72, 24);
            this.txtIdCliente.TabIndex = 126;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(88, 312);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(203, 24);
            this.txtNomeCliente.TabIndex = 127;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(386, 311);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(254, 24);
            this.txtNomeProduto.TabIndex = 129;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProduto.Location = new System.Drawing.Point(301, 312);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(79, 24);
            this.txtIdProduto.TabIndex = 128;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.Color.Red;
            this.lblItem.Location = new System.Drawing.Point(316, 258);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(24, 20);
            this.lblItem.TabIndex = 130;
            this.lblItem.Text = "...";
            this.lblItem.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbCarrega
            // 
            this.pbCarrega.Location = new System.Drawing.Point(8, 480);
            this.pbCarrega.Maximum = 5000;
            this.pbCarrega.Name = "pbCarrega";
            this.pbCarrega.Size = new System.Drawing.Size(854, 10);
            this.pbCarrega.TabIndex = 131;
            // 
            // frmChamadosApontamentoTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 493);
            this.Controls.Add(this.pbCarrega);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxObsItemChamado);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmChamadosApontamentoTecnico";
            this.Text = "Apontamento Técnico";
            this.Load += new System.EventHandler(this.frmChamadosApontamentoTecnico_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChamados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridChamados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtxObsItemChamado;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtxObsAtendente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItemChamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idChamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAtendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObsItemChamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObsAtendenteChamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn PadraoMarcaModeloSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObsItemTecnico;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pbCarrega;
        private System.Windows.Forms.Timer timer2;
    }
}