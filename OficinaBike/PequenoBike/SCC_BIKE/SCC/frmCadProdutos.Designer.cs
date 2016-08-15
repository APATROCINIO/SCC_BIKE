namespace SCC_BIKE
{
    partial class frmCadProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadProdutos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.dataGridProdutos = new System.Windows.Forms.DataGridView();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataUltimaAtualizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosCategoria_idProdutoCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosCategoria_GrupoEmpresas_idGrupoEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomePesqisa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.lblInfPesquisa = new System.Windows.Forms.Label();
            this.cboProdutoCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGrupoEmpresa = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCodGrupoEmpresa = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(729, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
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
            // dataGridProdutos
            // 
            this.dataGridProdutos.AllowUserToAddRows = false;
            this.dataGridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduto,
            this.NomeProduto,
            this.DataCadastro,
            this.DataUltimaAtualizacao,
            this.ProdutosCategoria_idProdutoCategoria,
            this.ProdutosCategoria_GrupoEmpresas_idGrupoEmpresa});
            this.dataGridProdutos.Location = new System.Drawing.Point(8, 160);
            this.dataGridProdutos.Name = "dataGridProdutos";
            this.dataGridProdutos.ReadOnly = true;
            this.dataGridProdutos.Size = new System.Drawing.Size(718, 235);
            this.dataGridProdutos.TabIndex = 24;
            this.dataGridProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProdutos_CellClick);
            this.dataGridProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProdutos_CellDoubleClick);
            // 
            // idProduto
            // 
            this.idProduto.DataPropertyName = "idProduto";
            this.idProduto.HeaderText = "idProduto";
            this.idProduto.Name = "idProduto";
            this.idProduto.ReadOnly = true;
            // 
            // NomeProduto
            // 
            this.NomeProduto.DataPropertyName = "NomeProduto";
            this.NomeProduto.HeaderText = "Produto";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            this.NomeProduto.Width = 200;
            // 
            // DataCadastro
            // 
            this.DataCadastro.DataPropertyName = "DataCadastro";
            this.DataCadastro.HeaderText = "Data Cadastro";
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.ReadOnly = true;
            this.DataCadastro.Width = 120;
            // 
            // DataUltimaAtualizacao
            // 
            this.DataUltimaAtualizacao.DataPropertyName = "DataUltimaAtualizacao";
            this.DataUltimaAtualizacao.HeaderText = "Data Ultima Atualizacao";
            this.DataUltimaAtualizacao.Name = "DataUltimaAtualizacao";
            this.DataUltimaAtualizacao.ReadOnly = true;
            this.DataUltimaAtualizacao.Visible = false;
            // 
            // ProdutosCategoria_idProdutoCategoria
            // 
            this.ProdutosCategoria_idProdutoCategoria.DataPropertyName = "ProdutosCategoria_idProdutoCategoria";
            this.ProdutosCategoria_idProdutoCategoria.HeaderText = "ProdutosCategoria_idProdutoCategoria";
            this.ProdutosCategoria_idProdutoCategoria.Name = "ProdutosCategoria_idProdutoCategoria";
            this.ProdutosCategoria_idProdutoCategoria.ReadOnly = true;
            this.ProdutosCategoria_idProdutoCategoria.Visible = false;
            // 
            // ProdutosCategoria_GrupoEmpresas_idGrupoEmpresa
            // 
            this.ProdutosCategoria_GrupoEmpresas_idGrupoEmpresa.DataPropertyName = "ProdutosCategoria_GrupoEmpresas_idGrupoEmpresa";
            this.ProdutosCategoria_GrupoEmpresas_idGrupoEmpresa.HeaderText = "ProdutosCategoria_GrupoEmpresas_idGrupoEmpresa";
            this.ProdutosCategoria_GrupoEmpresas_idGrupoEmpresa.Name = "ProdutosCategoria_GrupoEmpresas_idGrupoEmpresa";
            this.ProdutosCategoria_GrupoEmpresas_idGrupoEmpresa.ReadOnly = true;
            this.ProdutosCategoria_GrupoEmpresas_idGrupoEmpresa.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(150, 130);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(72, 23);
            this.btnPesquisar.TabIndex = 94;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            this.btnPesquisar.MouseLeave += new System.EventHandler(this.btnPesquisar_MouseLeave);
            this.btnPesquisar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPesquisar_MouseMove);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(8, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 93;
            this.label10.Text = "Pesquisar Produto";
            // 
            // txtNomePesqisa
            // 
            this.txtNomePesqisa.Location = new System.Drawing.Point(10, 131);
            this.txtNomePesqisa.Name = "txtNomePesqisa";
            this.txtNomePesqisa.Size = new System.Drawing.Size(134, 20);
            this.txtNomePesqisa.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 102;
            this.label3.Text = "DATA CADASTRO";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Red;
            this.lblCodigo.Location = new System.Drawing.Point(61, 44);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(19, 13);
            this.lblCodigo.TabIndex = 101;
            this.lblCodigo.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "CÓDIGO";
            // 
            // maskDataCadastro
            // 
            this.maskDataCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.maskDataCadastro.Enabled = false;
            this.maskDataCadastro.Location = new System.Drawing.Point(121, 44);
            this.maskDataCadastro.Name = "maskDataCadastro";
            this.maskDataCadastro.ReadOnly = true;
            this.maskDataCadastro.Size = new System.Drawing.Size(95, 20);
            this.maskDataCadastro.TabIndex = 103;
            this.maskDataCadastro.Text = "__/__/____";
            // 
            // lblInfPesquisa
            // 
            this.lblInfPesquisa.AutoSize = true;
            this.lblInfPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfPesquisa.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblInfPesquisa.Location = new System.Drawing.Point(255, 130);
            this.lblInfPesquisa.Name = "lblInfPesquisa";
            this.lblInfPesquisa.Size = new System.Drawing.Size(194, 15);
            this.lblInfPesquisa.TabIndex = 104;
            this.lblInfPesquisa.Text = "Pesquisa pelo nome do produto ...";
            this.lblInfPesquisa.Visible = false;
            // 
            // cboProdutoCategoria
            // 
            this.cboProdutoCategoria.FormattingEnabled = true;
            this.cboProdutoCategoria.Location = new System.Drawing.Point(234, 43);
            this.cboProdutoCategoria.Name = "cboProdutoCategoria";
            this.cboProdutoCategoria.Size = new System.Drawing.Size(244, 21);
            this.cboProdutoCategoria.TabIndex = 105;
            this.cboProdutoCategoria.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cboProdutoCategoria_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 106;
            this.label2.Text = "CATEGORIA";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(12, 84);
            this.txtNomeProduto.MaxLength = 100;
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(466, 20);
            this.txtNomeProduto.TabIndex = 107;
            this.txtNomeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeProduto_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 108;
            this.label4.Text = "PRODUTO";
            // 
            // lblGrupoEmpresa
            // 
            this.lblGrupoEmpresa.AutoSize = true;
            this.lblGrupoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupoEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblGrupoEmpresa.Location = new System.Drawing.Point(586, 51);
            this.lblGrupoEmpresa.Name = "lblGrupoEmpresa";
            this.lblGrupoEmpresa.Size = new System.Drawing.Size(19, 13);
            this.lblGrupoEmpresa.TabIndex = 110;
            this.lblGrupoEmpresa.Text = "...";
            this.lblGrupoEmpresa.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(489, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 111;
            this.label7.Text = "Grupo Empresa :";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(489, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 112;
            this.label8.Text = "Codigo Grupo Empresa";
            this.label8.Visible = false;
            // 
            // lblCodGrupoEmpresa
            // 
            this.lblCodGrupoEmpresa.AutoSize = true;
            this.lblCodGrupoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodGrupoEmpresa.ForeColor = System.Drawing.Color.Red;
            this.lblCodGrupoEmpresa.Location = new System.Drawing.Point(631, 84);
            this.lblCodGrupoEmpresa.Name = "lblCodGrupoEmpresa";
            this.lblCodGrupoEmpresa.Size = new System.Drawing.Size(19, 13);
            this.lblCodGrupoEmpresa.TabIndex = 113;
            this.lblCodGrupoEmpresa.Text = "...";
            this.lblCodGrupoEmpresa.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 398);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(729, 25);
            this.statusStrip1.TabIndex = 114;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(160, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // frmCadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 423);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblCodGrupoEmpresa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblGrupoEmpresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboProdutoCategoria);
            this.Controls.Add(this.lblInfPesquisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskDataCadastro);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNomePesqisa);
            this.Controls.Add(this.dataGridProdutos);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadProdutos";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmCadProdutos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridProdutos;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomePesqisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskDataCadastro;
        private System.Windows.Forms.Label lblInfPesquisa;
        private System.Windows.Forms.ComboBox cboProdutoCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGrupoEmpresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCodGrupoEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataUltimaAtualizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutosCategoria_idProdutoCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutosCategoria_GrupoEmpresas_idGrupoEmpresa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}