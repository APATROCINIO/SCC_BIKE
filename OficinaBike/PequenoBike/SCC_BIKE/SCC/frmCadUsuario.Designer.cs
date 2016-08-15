namespace SCC
{
    partial class frmCadUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadUsuario));
            this.maskDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.maskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdUsuario = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.grbStatus.SuspendLayout();
            this.gbrPerfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskDataCadastro
            // 
            this.maskDataCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.maskDataCadastro.Enabled = false;
            this.maskDataCadastro.Location = new System.Drawing.Point(134, 57);
            this.maskDataCadastro.Name = "maskDataCadastro";
            this.maskDataCadastro.ReadOnly = true;
            this.maskDataCadastro.Size = new System.Drawing.Size(67, 20);
            this.maskDataCadastro.TabIndex = 90;
            this.maskDataCadastro.Text = "__/__/____";
            // 
            // maskCPF
            // 
            this.maskCPF.Location = new System.Drawing.Point(467, 110);
            this.maskCPF.Name = "maskCPF";
            this.maskCPF.Size = new System.Drawing.Size(99, 20);
            this.maskCPF.TabIndex = 3;
            this.maskCPF.Text = "__.___.____-__";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblIdUsuario.Location = new System.Drawing.Point(58, 57);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblIdUsuario.TabIndex = 3;
            this.lblIdUsuario.Text = "...      ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Cadastro";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(20, 110);
            this.txtNome.MaxLength = 45;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(239, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(265, 110);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(196, 20);
            this.txtSobrenome.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sobrenome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "CPF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(157, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(160, 149);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(99, 20);
            this.txtSenha.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Confirma Senha";
            // 
            // txtCSenha
            // 
            this.txtCSenha.Location = new System.Drawing.Point(265, 149);
            this.txtCSenha.Name = "txtCSenha";
            this.txtCSenha.Size = new System.Drawing.Size(101, 20);
            this.txtCSenha.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(16, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Pesquisar Usuário";
            // 
            // txtNomePesqisa
            // 
            this.txtNomePesqisa.Location = new System.Drawing.Point(18, 196);
            this.txtNomePesqisa.Name = "txtNomePesqisa";
            this.txtNomePesqisa.Size = new System.Drawing.Size(113, 20);
            this.txtNomePesqisa.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(369, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(372, 149);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // dataGridUsuarios
            // 
            this.dataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuarios.Location = new System.Drawing.Point(19, 221);
            this.dataGridUsuarios.Name = "dataGridUsuarios";
            this.dataGridUsuarios.Size = new System.Drawing.Size(708, 150);
            this.dataGridUsuarios.TabIndex = 20;
            this.dataGridUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsuarios_CellClick);
            this.dataGridUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsuarios_CellDoubleClick);
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
            this.grbStatus.Location = new System.Drawing.Point(249, 42);
            this.grbStatus.Name = "grbStatus";
            this.grbStatus.Size = new System.Drawing.Size(200, 49);
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
            this.gbrPerfil.Location = new System.Drawing.Point(581, 42);
            this.gbrPerfil.Name = "gbrPerfil";
            this.gbrPerfil.Size = new System.Drawing.Size(146, 127);
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
            this.label4.Location = new System.Drawing.Point(17, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(20, 149);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(134, 20);
            this.txtLogin.TabIndex = 4;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(160, 192);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 91;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 378);
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
            this.Controls.Add(this.lblIdUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskCPF);
            this.Controls.Add(this.maskDataCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadUsuario";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskDataCadastro;
        private System.Windows.Forms.MaskedTextBox maskCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdUsuario;
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
    }
}