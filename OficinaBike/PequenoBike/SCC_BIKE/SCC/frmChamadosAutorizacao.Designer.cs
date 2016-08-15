namespace SCC_BIKE
{
    partial class frmAutorizacaoChamados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutorizacaoChamados));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridChamados = new System.Windows.Forms.DataGridView();
            this.idItemChamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idChamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAtendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObsItemChamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomePesqisa = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskAgendamento = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtValorItemChamado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.monthCalendarAgendamento = new System.Windows.Forms.MonthCalendar();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChamados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(862, 25);
            this.toolStrip1.TabIndex = 23;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridChamados);
            this.panel2.Controls.Add(this.btnPesquisar);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtNomePesqisa);
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 202);
            this.panel2.TabIndex = 117;
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
            this.ValorItem});
            this.dataGridChamados.Location = new System.Drawing.Point(3, 51);
            this.dataGridChamados.Name = "dataGridChamados";
            this.dataGridChamados.Size = new System.Drawing.Size(841, 148);
            this.dataGridChamados.TabIndex = 100;
            this.dataGridChamados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridChamados_CellClick);
            // 
            // idItemChamado
            // 
            this.idItemChamado.DataPropertyName = "idItemChamado";
            this.idItemChamado.HeaderText = "Item do Chamado";
            this.idItemChamado.Name = "idItemChamado";
            this.idItemChamado.Visible = false;
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
            this.NomeProduto.Width = 160;
            // 
            // DataAtendimento
            // 
            this.DataAtendimento.DataPropertyName = "DataAtendimento";
            this.DataAtendimento.HeaderText = "Data Atendimento";
            this.DataAtendimento.Name = "DataAtendimento";
            this.DataAtendimento.ReadOnly = true;
            this.DataAtendimento.Width = 120;
            // 
            // ObsItemChamado
            // 
            this.ObsItemChamado.DataPropertyName = "ObsItemChamado";
            this.ObsItemChamado.HeaderText = "Obs Técnico";
            this.ObsItemChamado.Name = "ObsItemChamado";
            this.ObsItemChamado.ReadOnly = true;
            this.ObsItemChamado.Visible = false;
            this.ObsItemChamado.Width = 120;
            // 
            // ValorItem
            // 
            this.ValorItem.DataPropertyName = "ValorItem";
            this.ValorItem.HeaderText = "Valor Serviço";
            this.ValorItem.Name = "ValorItem";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(137, 21);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(72, 25);
            this.btnPesquisar.TabIndex = 99;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 97;
            this.label10.Text = "Pesquisar Chamado";
            // 
            // txtNomePesqisa
            // 
            this.txtNomePesqisa.Location = new System.Drawing.Point(5, 22);
            this.txtNomePesqisa.Name = "txtNomePesqisa";
            this.txtNomePesqisa.Size = new System.Drawing.Size(127, 20);
            this.txtNomePesqisa.TabIndex = 96;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Red;
            this.lblCodigo.Location = new System.Drawing.Point(117, 246);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(28, 24);
            this.lblCodigo.TabIndex = 165;
            this.lblCodigo.Text = "...";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(590, 306);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(263, 26);
            this.txtNomeProduto.TabIndex = 164;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProduto.Location = new System.Drawing.Point(477, 307);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(107, 26);
            this.txtIdProduto.TabIndex = 163;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(124, 306);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(279, 26);
            this.txtNomeCliente.TabIndex = 162;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(16, 306);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(102, 26);
            this.txtIdCliente.TabIndex = 161;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(586, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 160;
            this.label1.Text = "Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(472, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 159;
            this.label4.Text = "Cód Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 158;
            this.label3.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 157;
            this.label2.Text = "Cód Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 24);
            this.label8.TabIndex = 156;
            this.label8.Text = "Chamado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monthCalendarAgendamento);
            this.groupBox1.Controls.Add(this.maskAgendamento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(6, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 184);
            this.groupBox1.TabIndex = 167;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATA PREVISTA PARA ENTREGA";
            // 
            // maskAgendamento
            // 
            this.maskAgendamento.BackColor = System.Drawing.SystemColors.Window;
            this.maskAgendamento.Enabled = false;
            this.maskAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskAgendamento.Location = new System.Drawing.Point(239, 97);
            this.maskAgendamento.Mask = "00/00/0000";
            this.maskAgendamento.Name = "maskAgendamento";
            this.maskAgendamento.ReadOnly = true;
            this.maskAgendamento.Size = new System.Drawing.Size(141, 26);
            this.maskAgendamento.TabIndex = 145;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 144;
            this.label5.Text = "Data Agendamento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtValorItemChamado);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(477, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 184);
            this.groupBox2.TabIndex = 168;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VALOR DO ITEM SELECIONADO";
            // 
            // txtValorItemChamado
            // 
            this.txtValorItemChamado.Enabled = false;
            this.txtValorItemChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorItemChamado.Location = new System.Drawing.Point(113, 97);
            this.txtValorItemChamado.Name = "txtValorItemChamado";
            this.txtValorItemChamado.ReadOnly = true;
            this.txtValorItemChamado.Size = new System.Drawing.Size(137, 26);
            this.txtValorItemChamado.TabIndex = 149;
            this.txtValorItemChamado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(109, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 148;
            this.label7.Text = "Valor Atendimento";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.Color.Red;
            this.lblItem.Location = new System.Drawing.Point(303, 250);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(24, 20);
            this.lblItem.TabIndex = 169;
            this.lblItem.Text = "...";
            this.lblItem.Visible = false;
            // 
            // monthCalendarAgendamento
            // 
            this.monthCalendarAgendamento.Location = new System.Drawing.Point(5, 16);
            this.monthCalendarAgendamento.Name = "monthCalendarAgendamento";
            this.monthCalendarAgendamento.TabIndex = 146;
            this.monthCalendarAgendamento.TodayDate = new System.DateTime(2016, 7, 20, 0, 0, 0, 0);
            this.monthCalendarAgendamento.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarAgendamento_DateSelected);
            // 
            // frmAutorizacaoChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 532);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAutorizacaoChamados";
            this.Text = "Autorização de Serviços";
            this.Load += new System.EventHandler(this.frmAutorizacaoChamados_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChamados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomePesqisa;
        private System.Windows.Forms.DataGridView dataGridChamados;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskAgendamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtValorItemChamado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItemChamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idChamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAtendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObsItemChamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorItem;
        private System.Windows.Forms.MonthCalendar monthCalendarAgendamento;
    }
}