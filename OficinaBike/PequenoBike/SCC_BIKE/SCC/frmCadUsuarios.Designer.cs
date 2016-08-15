namespace SCC_BIKE
{
    partial class frmCadUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadUsuarios));
            this.maskDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.maskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCSenha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomePesqisa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dataGridUsuarios = new System.Windows.Forms.DataGridView();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.grbStatus = new System.Windows.Forms.GroupBox();
            this.rdbInativo = new System.Windows.Forms.RadioButton();
            this.rdbAtivo = new System.Windows.Forms.RadioButton();
            this.gbrPerfil = new System.Windows.Forms.GroupBox();
            this.rdbUsuAtendente = new System.Windows.Forms.RadioButton();
            this.rdbUsuTecnico = new System.Windows.Forms.RadioButton();
            this.rdbGNegocio = new System.Windows.Forms.RadioButton();
            this.rsbAdministrador = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblInfPesquisa = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.grbStatus.SuspendLayout();
            this.gbrPerfil.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskDataCadastro
            // 
            this.maskDataCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.maskDataCadastro.Enabled = false;
            this.maskDataCadastro.Location = new System.Drawing.Point(120, 57);
            this.maskDataCadastro.Name = "maskDataCadastro";
            this.maskDataCadastro.ReadOnly = true;
            this.maskDataCadastro.Size = new System.Drawing.Size(95, 20);
            this.maskDataCadastro.TabIndex = 90;
            this.maskDataCadastro.Text = "__/__/____";
            // 
            // maskCPF
            // 
            this.maskCPF.Location = new System.Drawing.Point(453, 110);
            this.maskCPF.Name = "maskCPF";
            this.maskCPF.Size = new System.Drawing.Size(96, 20);
            this.maskCPF.TabIndex = 3;
            this.maskCPF.Text = "__.___.____-__";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CÓDIGO";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Red;
            this.lblCodigo.Location = new System.Drawing.Point(59, 57);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "...      ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DATA CADASTRO";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 110);
            this.txtNome.MaxLength = 45;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(236, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(251, 110);
            this.txtSobrenome.MaxLength = 45;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(193, 20);
            this.txtSobrenome.TabIndex = 2;
            this.txtSobrenome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSobrenome_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "NOME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "SOBRENOME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(462, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "CPF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(143, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "SENHA";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(146, 149);
            this.txtSenha.MaxLength = 60;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(96, 20);
            this.txtSenha.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(248, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "CONFIRMA SENHA";
            // 
            // txtCSenha
            // 
            this.txtCSenha.Location = new System.Drawing.Point(251, 149);
            this.txtCSenha.MaxLength = 60;
            this.txtCSenha.Name = "txtCSenha";
            this.txtCSenha.Size = new System.Drawing.Size(98, 20);
            this.txtCSenha.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(4, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Pesquisar Usuário";
            // 
            // txtNomePesqisa
            // 
            this.txtNomePesqisa.Location = new System.Drawing.Point(6, 194);
            this.txtNomePesqisa.MaxLength = 45;
            this.txtNomePesqisa.Name = "txtNomePesqisa";
            this.txtNomePesqisa.Size = new System.Drawing.Size(134, 20);
            this.txtNomePesqisa.TabIndex = 16;
            this.txtNomePesqisa.Tag = "";
            this.txtNomePesqisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomePesqisa_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(355, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "EMAIL";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(358, 149);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 20);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // dataGridUsuarios
            // 
            this.dataGridUsuarios.AllowUserToAddRows = false;
            this.dataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.Nome,
            this.Sobrenome,
            this.Cpf,
            this.Login,
            this.Senha,
            this.Perfil,
            this.Email,
            this.DataCadastro,
            this.Status});
            this.dataGridUsuarios.Location = new System.Drawing.Point(5, 221);
            this.dataGridUsuarios.Name = "dataGridUsuarios";
            this.dataGridUsuarios.ReadOnly = true;
            this.dataGridUsuarios.Size = new System.Drawing.Size(705, 202);
            this.dataGridUsuarios.TabIndex = 20;
            this.dataGridUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsuarios_CellClick);
            this.dataGridUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsuarios_CellDoubleClick);
            // 
            // idUsuario
            // 
            this.idUsuario.DataPropertyName = "idUsuario";
            this.idUsuario.HeaderText = "Cód. Usuario";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Sobrenome
            // 
            this.Sobrenome.DataPropertyName = "Sobrenome";
            this.Sobrenome.HeaderText = "Sobrenome";
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.ReadOnly = true;
            // 
            // Cpf
            // 
            this.Cpf.DataPropertyName = "Cpf";
            this.Cpf.HeaderText = "Cpf";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Login";
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // Senha
            // 
            this.Senha.DataPropertyName = "Senha";
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            this.Senha.ReadOnly = true;
            // 
            // Perfil
            // 
            this.Perfil.DataPropertyName = "Perfil";
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.Name = "Perfil";
            this.Perfil.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // DataCadastro
            // 
            this.DataCadastro.DataPropertyName = "DataCadastro";
            this.DataCadastro.HeaderText = "Data Cadastro";
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
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
            this.toolStrip1.Size = new System.Drawing.Size(715, 25);
            this.toolStrip1.TabIndex = 21;
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
            // grbStatus
            // 
            this.grbStatus.Controls.Add(this.rdbInativo);
            this.grbStatus.Controls.Add(this.rdbAtivo);
            this.grbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbStatus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grbStatus.Location = new System.Drawing.Point(235, 42);
            this.grbStatus.Name = "grbStatus";
            this.grbStatus.Size = new System.Drawing.Size(197, 49);
            this.grbStatus.TabIndex = 30;
            this.grbStatus.TabStop = false;
            this.grbStatus.Text = "Status";
            // 
            // rdbInativo
            // 
            this.rdbInativo.AutoSize = true;
            this.rdbInativo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbInativo.Location = new System.Drawing.Point(118, 19);
            this.rdbInativo.Name = "rdbInativo";
            this.rdbInativo.Size = new System.Drawing.Size(64, 17);
            this.rdbInativo.TabIndex = 32;
            this.rdbInativo.TabStop = true;
            this.rdbInativo.Text = "Inativo";
            this.rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbAtivo.Location = new System.Drawing.Point(6, 19);
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.Size = new System.Drawing.Size(54, 17);
            this.rdbAtivo.TabIndex = 31;
            this.rdbAtivo.TabStop = true;
            this.rdbAtivo.Text = "Ativo";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // gbrPerfil
            // 
            this.gbrPerfil.Controls.Add(this.rdbUsuAtendente);
            this.gbrPerfil.Controls.Add(this.rdbUsuTecnico);
            this.gbrPerfil.Controls.Add(this.rdbGNegocio);
            this.gbrPerfil.Controls.Add(this.rsbAdministrador);
            this.gbrPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrPerfil.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbrPerfil.Location = new System.Drawing.Point(567, 42);
            this.gbrPerfil.Name = "gbrPerfil";
            this.gbrPerfil.Size = new System.Drawing.Size(143, 127);
            this.gbrPerfil.TabIndex = 8;
            this.gbrPerfil.TabStop = false;
            this.gbrPerfil.Text = "Perfil";
            // 
            // rdbUsuAtendente
            // 
            this.rdbUsuAtendente.AutoSize = true;
            this.rdbUsuAtendente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbUsuAtendente.Location = new System.Drawing.Point(6, 101);
            this.rdbUsuAtendente.Name = "rdbUsuAtendente";
            this.rdbUsuAtendente.Size = new System.Drawing.Size(130, 17);
            this.rdbUsuAtendente.TabIndex = 3;
            this.rdbUsuAtendente.TabStop = true;
            this.rdbUsuAtendente.Text = "Usuário Atendente";
            this.rdbUsuAtendente.UseVisualStyleBackColor = true;
            // 
            // rdbUsuTecnico
            // 
            this.rdbUsuTecnico.AutoSize = true;
            this.rdbUsuTecnico.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbUsuTecnico.Location = new System.Drawing.Point(6, 78);
            this.rdbUsuTecnico.Name = "rdbUsuTecnico";
            this.rdbUsuTecnico.Size = new System.Drawing.Size(118, 17);
            this.rdbUsuTecnico.TabIndex = 2;
            this.rdbUsuTecnico.TabStop = true;
            this.rdbUsuTecnico.Text = "Usuário Técnico";
            this.rdbUsuTecnico.UseVisualStyleBackColor = true;
            // 
            // rdbGNegocio
            // 
            this.rdbGNegocio.AutoSize = true;
            this.rdbGNegocio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbGNegocio.Location = new System.Drawing.Point(6, 55);
            this.rdbGNegocio.Name = "rdbGNegocio";
            this.rdbGNegocio.Size = new System.Drawing.Size(113, 17);
            this.rdbGNegocio.TabIndex = 1;
            this.rdbGNegocio.TabStop = true;
            this.rdbGNegocio.Text = "Gestor Negócio";
            this.rdbGNegocio.UseVisualStyleBackColor = true;
            // 
            // rsbAdministrador
            // 
            this.rsbAdministrador.AutoSize = true;
            this.rsbAdministrador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rsbAdministrador.Location = new System.Drawing.Point(6, 32);
            this.rsbAdministrador.Name = "rsbAdministrador";
            this.rsbAdministrador.Size = new System.Drawing.Size(101, 17);
            this.rsbAdministrador.TabIndex = 0;
            this.rsbAdministrador.TabStop = true;
            this.rsbAdministrador.Text = "Administrador";
            this.rsbAdministrador.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "LOGIN";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(6, 149);
            this.txtLogin.MaxLength = 45;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(131, 20);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(146, 192);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(72, 23);
            this.btnPesquisar.TabIndex = 91;
            this.btnPesquisar.Tag = "";
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            this.btnPesquisar.MouseLeave += new System.EventHandler(this.btnPesquisar_MouseLeave);
            this.btnPesquisar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPesquisar_MouseMove);
            // 
            // lblInfPesquisa
            // 
            this.lblInfPesquisa.AutoSize = true;
            this.lblInfPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfPesquisa.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblInfPesquisa.Location = new System.Drawing.Point(254, 192);
            this.lblInfPesquisa.Name = "lblInfPesquisa";
            this.lblInfPesquisa.Size = new System.Drawing.Size(190, 15);
            this.lblInfPesquisa.TabIndex = 92;
            this.lblInfPesquisa.Text = "Pesquisa pelo nome do usuário...";
            this.lblInfPesquisa.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 434);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(715, 25);
            this.statusStrip1.TabIndex = 93;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(160, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // frmCadUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 459);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblInfPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.gbrPerfil);
            this.Controls.Add(this.grbStatus);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridUsuarios);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNomePesqisa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCSenha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskCPF);
            this.Controls.Add(this.maskDataCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.frmCadUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grbStatus.ResumeLayout(false);
            this.grbStatus.PerformLayout();
            this.gbrPerfil.ResumeLayout(false);
            this.gbrPerfil.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskDataCadastro;
        private System.Windows.Forms.MaskedTextBox maskCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCSenha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomePesqisa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dataGridUsuarios;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.GroupBox grbStatus;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.RadioButton rdbInativo;
        private System.Windows.Forms.GroupBox gbrPerfil;
        private System.Windows.Forms.RadioButton rdbUsuAtendente;
        private System.Windows.Forms.RadioButton rdbUsuTecnico;
        private System.Windows.Forms.RadioButton rdbGNegocio;
        private System.Windows.Forms.RadioButton rsbAdministrador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblInfPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}