namespace SCC_BIKE
{
    partial class frmCadFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadFornecedores));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.dataGridFornecedores = new System.Windows.Forms.DataGridView();
            this.idFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF_CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelFixo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelFixo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Whatsapp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataUltimaAtualizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuarios_idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomePesqisa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.lblInfPesquisa = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFxo2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFxo1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtWhatsapp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCelularOutraOP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCelularOi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.maskCPFCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedores)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(733, 25);
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
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dataGridFornecedores
            // 
            this.dataGridFornecedores.AllowUserToAddRows = false;
            this.dataGridFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFornecedor,
            this.NomeFornecedor,
            this.Empresa,
            this.CPF_CNPJ,
            this.Email,
            this.Rua,
            this.Numero,
            this.Bairro,
            this.Cidade,
            this.Uf,
            this.Celular1,
            this.TelFixo1,
            this.Celular2,
            this.TelFixo2,
            this.Whatsapp,
            this.DataCadastro,
            this.DataUltimaAtualizacao,
            this.Usuarios_idUsuario});
            this.dataGridFornecedores.Location = new System.Drawing.Point(5, 263);
            this.dataGridFornecedores.Name = "dataGridFornecedores";
            this.dataGridFornecedores.ReadOnly = true;
            this.dataGridFornecedores.Size = new System.Drawing.Size(721, 150);
            this.dataGridFornecedores.TabIndex = 23;
            this.dataGridFornecedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFornecedores_CellClick);
            this.dataGridFornecedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFornecedores_CellDoubleClick);
            // 
            // idFornecedor
            // 
            this.idFornecedor.DataPropertyName = "idFornecedor";
            this.idFornecedor.HeaderText = "Cód Fornecedor";
            this.idFornecedor.Name = "idFornecedor";
            this.idFornecedor.ReadOnly = true;
            this.idFornecedor.Width = 120;
            // 
            // NomeFornecedor
            // 
            this.NomeFornecedor.DataPropertyName = "NomeFornecedor";
            this.NomeFornecedor.HeaderText = "Fornecedor";
            this.NomeFornecedor.Name = "NomeFornecedor";
            this.NomeFornecedor.ReadOnly = true;
            // 
            // Empresa
            // 
            this.Empresa.DataPropertyName = "Empresa";
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            // 
            // CPF_CNPJ
            // 
            this.CPF_CNPJ.DataPropertyName = "CPF_CNPJ";
            this.CPF_CNPJ.HeaderText = "CPF ou CNPJ";
            this.CPF_CNPJ.Name = "CPF_CNPJ";
            this.CPF_CNPJ.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Rua
            // 
            this.Rua.DataPropertyName = "Rua";
            this.Rua.HeaderText = "Rua";
            this.Rua.Name = "Rua";
            this.Rua.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numero";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "Bairro";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "Cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // Uf
            // 
            this.Uf.DataPropertyName = "Uf";
            this.Uf.HeaderText = "Uf";
            this.Uf.Name = "Uf";
            this.Uf.ReadOnly = true;
            // 
            // Celular1
            // 
            this.Celular1.DataPropertyName = "Celular1";
            this.Celular1.HeaderText = "Celular Oi";
            this.Celular1.Name = "Celular1";
            this.Celular1.ReadOnly = true;
            // 
            // TelFixo1
            // 
            this.TelFixo1.DataPropertyName = "TelFixo1";
            this.TelFixo1.HeaderText = "TelFixo 01";
            this.TelFixo1.Name = "TelFixo1";
            this.TelFixo1.ReadOnly = true;
            // 
            // Celular2
            // 
            this.Celular2.DataPropertyName = "Celular2";
            this.Celular2.HeaderText = "Celular outra Op.";
            this.Celular2.Name = "Celular2";
            this.Celular2.ReadOnly = true;
            this.Celular2.Width = 120;
            // 
            // TelFixo2
            // 
            this.TelFixo2.DataPropertyName = "TelFixo2";
            this.TelFixo2.HeaderText = "TelFixo 02";
            this.TelFixo2.Name = "TelFixo2";
            this.TelFixo2.ReadOnly = true;
            // 
            // Whatsapp
            // 
            this.Whatsapp.DataPropertyName = "Whatsapp";
            this.Whatsapp.HeaderText = "Whatsapp";
            this.Whatsapp.Name = "Whatsapp";
            this.Whatsapp.ReadOnly = true;
            // 
            // DataCadastro
            // 
            this.DataCadastro.DataPropertyName = "DataCadastro";
            this.DataCadastro.HeaderText = "Data Cadastro";
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.ReadOnly = true;
            // 
            // DataUltimaAtualizacao
            // 
            this.DataUltimaAtualizacao.DataPropertyName = "DataUltimaAtualizacao";
            this.DataUltimaAtualizacao.HeaderText = "DataUltimaAtualizacao";
            this.DataUltimaAtualizacao.Name = "DataUltimaAtualizacao";
            this.DataUltimaAtualizacao.ReadOnly = true;
            this.DataUltimaAtualizacao.Visible = false;
            // 
            // Usuarios_idUsuario
            // 
            this.Usuarios_idUsuario.DataPropertyName = "Usuarios_idUsuario";
            this.Usuarios_idUsuario.HeaderText = "Usuarios_idUsuario";
            this.Usuarios_idUsuario.Name = "Usuarios_idUsuario";
            this.Usuarios_idUsuario.ReadOnly = true;
            this.Usuarios_idUsuario.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(148, 231);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(72, 23);
            this.btnPesquisar.TabIndex = 94;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.MouseLeave += new System.EventHandler(this.btnPesquisar_MouseLeave);
            this.btnPesquisar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPesquisar_MouseMove);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(6, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 13);
            this.label10.TabIndex = 93;
            this.label10.Text = "Pesquisar Fornecedor";
            // 
            // txtNomePesqisa
            // 
            this.txtNomePesqisa.Location = new System.Drawing.Point(8, 233);
            this.txtNomePesqisa.Name = "txtNomePesqisa";
            this.txtNomePesqisa.Size = new System.Drawing.Size(134, 20);
            this.txtNomePesqisa.TabIndex = 92;
            this.txtNomePesqisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomePesqisa_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 27);
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
            this.lblCodigo.Location = new System.Drawing.Point(72, 46);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 101;
            this.lblCodigo.Text = "...      ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "CÓDIGO";
            // 
            // maskDataCadastro
            // 
            this.maskDataCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.maskDataCadastro.Enabled = false;
            this.maskDataCadastro.Location = new System.Drawing.Point(632, 43);
            this.maskDataCadastro.Name = "maskDataCadastro";
            this.maskDataCadastro.ReadOnly = true;
            this.maskDataCadastro.Size = new System.Drawing.Size(94, 20);
            this.maskDataCadastro.TabIndex = 103;
            this.maskDataCadastro.Text = "__/__/____";
            this.maskDataCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblInfPesquisa
            // 
            this.lblInfPesquisa.AutoSize = true;
            this.lblInfPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfPesquisa.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblInfPesquisa.Location = new System.Drawing.Point(256, 231);
            this.lblInfPesquisa.Name = "lblInfPesquisa";
            this.lblInfPesquisa.Size = new System.Drawing.Size(211, 15);
            this.lblInfPesquisa.TabIndex = 105;
            this.lblInfPesquisa.Text = "Pesquisa pelo nome do fornecedor ...";
            this.lblInfPesquisa.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(492, 80);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 136;
            this.label17.Text = "EMAIL";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(495, 96);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 20);
            this.txtEmail.TabIndex = 135;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(251, 119);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 134;
            this.label16.Text = "Nº";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(254, 135);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(49, 20);
            this.txtNumero.TabIndex = 133;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(513, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 132;
            this.label15.Text = "FIXO 2";
            // 
            // txtFxo2
            // 
            this.txtFxo2.Location = new System.Drawing.Point(516, 179);
            this.txtFxo2.MaxLength = 10;
            this.txtFxo2.Name = "txtFxo2";
            this.txtFxo2.Size = new System.Drawing.Size(118, 20);
            this.txtFxo2.TabIndex = 131;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(388, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 130;
            this.label14.Text = "FIXO 1";
            // 
            // txtFxo1
            // 
            this.txtFxo1.Location = new System.Drawing.Point(391, 179);
            this.txtFxo1.MaxLength = 10;
            this.txtFxo1.Name = "txtFxo1";
            this.txtFxo1.Size = new System.Drawing.Size(118, 20);
            this.txtFxo1.TabIndex = 129;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(247, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 128;
            this.label13.Text = "WHATSAPP";
            // 
            // txtWhatsapp
            // 
            this.txtWhatsapp.Location = new System.Drawing.Point(250, 179);
            this.txtWhatsapp.MaxLength = 10;
            this.txtWhatsapp.Name = "txtWhatsapp";
            this.txtWhatsapp.Size = new System.Drawing.Size(135, 20);
            this.txtWhatsapp.TabIndex = 127;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(307, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 126;
            this.label12.Text = "BAIRRO";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(310, 135);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(179, 20);
            this.txtBairro.TabIndex = 125;
            this.txtBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBairro_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 124;
            this.label4.Text = "RUA/AV";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(13, 135);
            this.txtRua.MaxLength = 100;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(235, 20);
            this.txtRua.TabIndex = 114;
            this.txtRua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRua_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(117, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 13);
            this.label11.TabIndex = 123;
            this.label11.Text = "OUTRA OPERADORA";
            // 
            // txtCelularOutraOP
            // 
            this.txtCelularOutraOP.Location = new System.Drawing.Point(120, 179);
            this.txtCelularOutraOP.MaxLength = 10;
            this.txtCelularOutraOP.Name = "txtCelularOutraOP";
            this.txtCelularOutraOP.Size = new System.Drawing.Size(124, 20);
            this.txtCelularOutraOP.TabIndex = 117;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 122;
            this.label9.Text = "CELULAR OI";
            // 
            // txtCelularOi
            // 
            this.txtCelularOi.Location = new System.Drawing.Point(13, 179);
            this.txtCelularOi.MaxLength = 10;
            this.txtCelularOi.Name = "txtCelularOi";
            this.txtCelularOi.Size = new System.Drawing.Size(101, 20);
            this.txtCelularOi.TabIndex = 116;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(492, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 121;
            this.label8.Text = "CIDADE";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(495, 135);
            this.txtCidade.MaxLength = 100;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(198, 20);
            this.txtCidade.TabIndex = 115;
            this.txtCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCidade_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(632, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 120;
            this.label7.Text = "CPF/CNPJ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 119;
            this.label6.Text = "EMPRESA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 118;
            this.label5.Text = "NOME";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(310, 96);
            this.txtEmpresa.MaxLength = 100;
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(179, 20);
            this.txtEmpresa.TabIndex = 112;
            this.txtEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpresa_KeyPress);
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(13, 96);
            this.txtNomeFornecedor.MaxLength = 100;
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(287, 20);
            this.txtNomeFornecedor.TabIndex = 111;
            this.txtNomeFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeFornecedor_KeyPress);
            // 
            // maskCPFCNPJ
            // 
            this.maskCPFCNPJ.Location = new System.Drawing.Point(633, 96);
            this.maskCPFCNPJ.Name = "maskCPFCNPJ";
            this.maskCPFCNPJ.Size = new System.Drawing.Size(93, 20);
            this.maskCPFCNPJ.TabIndex = 113;
            this.maskCPFCNPJ.Text = "__.___.____-__";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(695, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 138;
            this.label2.Text = "UF";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(698, 135);
            this.txtUF.MaxLength = 2;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(28, 20);
            this.txtUF.TabIndex = 137;
            this.txtUF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUF_KeyPress);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 416);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(733, 25);
            this.statusStrip1.TabIndex = 139;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(160, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // frmCadFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 441);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtFxo2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtFxo1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtWhatsapp);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCelularOutraOP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCelularOi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtNomeFornecedor);
            this.Controls.Add(this.maskCPFCNPJ);
            this.Controls.Add(this.lblInfPesquisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskDataCadastro);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNomePesqisa);
            this.Controls.Add(this.dataGridFornecedores);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadFornecedores";
            this.Text = "Cadastro de Fornecedores";
            this.Load += new System.EventHandler(this.frmCadFornecedores_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedores)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridFornecedores;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomePesqisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskDataCadastro;
        private System.Windows.Forms.Label lblInfPesquisa;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFxo2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFxo1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtWhatsapp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCelularOutraOP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCelularOi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.MaskedTextBox maskCPFCNPJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF_CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelFixo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelFixo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Whatsapp;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataUltimaAtualizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuarios_idUsuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}