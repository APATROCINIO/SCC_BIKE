using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SCC_BIKE.DTO;
using SCC_BIKE.Model;

namespace SCC_BIKE
{
    public partial class frmCadUsuarios : Form
    {
        public frmCadUsuarios()
        {
            InitializeComponent();

        }

        public static bool Atualizaregistro = true;

        #region "EVENOS DA TELA"

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
            HabilitarBotoes("");
            dataGridUsuarios.DataSource = new UsuarioModel().BuscarUsuarios();
            this.txtSenha.PasswordChar = '*';
            this.txtCSenha.PasswordChar = '*';
            this.txtNome.KeyPress += new KeyPressEventHandler(this.txtNome_KeyPress);
            this.txtNomePesqisa.KeyPress += new KeyPressEventHandler(this.txtNomePesqisa_KeyPress);
            this.txtSobrenome.KeyPress += new KeyPressEventHandler(this.txtSobrenome_KeyPress);
            this.txtEmail.KeyPress += new KeyPressEventHandler(this.txtEmail_KeyPress);
            this.txtLogin.KeyPress += new KeyPressEventHandler(this.txtLogin_KeyPress);
            this.ValidarPermissoesUsuarios(MainClass.PerfilUsuario);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            modo = "Novo";
            InicializarModo();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarDadosForm() == true)
            {
                modo = "Salvar";
                InicializarModo();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            modo = "Cancelar";
            InicializarModo();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            modo = "Pesquisar";
            InicializarModo();

        }

        private void btnPesquisar_MouseMove(object sender, MouseEventArgs e)
        {
            lblInfPesquisa.Visible = true;
        }

        private void btnPesquisar_MouseLeave(object sender, EventArgs e)
        {
            lblInfPesquisa.Visible = false;
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtNomePesqisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtSobrenome_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void dataGridUsuarios_Click(object sender, DataGridViewCellEventArgs e)
        {
            lblCodigo.Text = Convert.ToString(dataGridUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex]);
        }

        private void dataGridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            //Se for selecionado um item fora da coleção (campo nome vazio) o grid não gera erro 
            if (Convert.ToString(dataGridUsuarios.Rows[e.RowIndex].Cells[1].Value) == "")
                return;

            Atualizaregistro = false;
            DesabilitarCampos();
            HabilitarBotoes("");

            lblCodigo.Text = dataGridUsuarios["idUsuario", e.RowIndex].Value.ToString();

            if (dataGridUsuarios["DataCadastro", e.RowIndex].Value.ToString() == null)
            {
                maskDataCadastro.Text = dataGridUsuarios["DataCadastro", e.RowIndex].Value.ToString();
            }
            else
            {
                maskDataCadastro.Text = Convert.ToString(DateTime.Now);
            }

            txtNome.Text = dataGridUsuarios["Nome", e.RowIndex].Value.ToString();
            txtSobrenome.Text = dataGridUsuarios["SobreNome", e.RowIndex].Value.ToString();
            maskCPF.Text = dataGridUsuarios["Cpf", e.RowIndex].Value.ToString();
            txtLogin.Text = dataGridUsuarios["Login", e.RowIndex].Value.ToString();
            txtEmail.Text = dataGridUsuarios["Email", e.RowIndex].Value.ToString();
            txtSenha.Text = "";
            txtCSenha.Text = "";

            if (dataGridUsuarios["Status", e.RowIndex].Value.ToString() == "A")
            {
                rdbAtivo.Checked = true;
            }
            else
            {
                rdbInativo.Checked = true;
            }

            if (Convert.ToInt32(dataGridUsuarios["Perfil", e.RowIndex].Value.ToString()) == 1)
            {
                rsbAdministrador.Checked = true;
            }
            else if (Convert.ToInt32(dataGridUsuarios["Perfil", e.RowIndex].Value.ToString()) == 2)
            {
                rdbGNegocio.Checked = true;
            }
            else if (Convert.ToInt32(dataGridUsuarios["Perfil", e.RowIndex].Value.ToString()) == 3)
            {
                rdbUsuTecnico.Checked = true;
            }
            else if (Convert.ToInt32(dataGridUsuarios["Perfil", e.RowIndex].Value.ToString()) == 4)
            {
                rdbUsuAtendente.Checked = true;
            }
        }

        private void dataGridUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarBotoes("Novo");
            HabilitarCampos();
            Atualizaregistro = true;
        }

        #endregion

        #region "MÉTODOS DA TELA"

        UsuarioDTO objUsuarioDTO = new UsuarioDTO();
        private string modo = "";
        
        private void InicializarModo()
        {
            switch (modo)
            {
                case "Novo":

                    LimparCampos();
                    HabilitarCampos();
                    HabilitarBotoes(modo);
                    maskDataCadastro.Text = Convert.ToString(DateTime.Now);
                    txtNome.Focus();
                    rdbAtivo.Checked = true;
                    break;

                case "Salvar":

                    HabilitarBotoes("Salvar");
                    bool bolAtualizar = false;

                    try
                    {

                        if (lblCodigo.Text != "...")
                        {
                            if(Convert.ToInt32(lblCodigo.Text) > 0)
                            {
                                bolAtualizar = true;
                                objUsuarioDTO.Codigo = Convert.ToInt32(lblCodigo.Text);
                            }
                        }

                        objUsuarioDTO.Nome = txtNome.Text;
                        objUsuarioDTO.Sobrenome = txtSobrenome.Text;
                        objUsuarioDTO.Senha = txtSenha.Text;
                        objUsuarioDTO.Login = txtLogin.Text;
                        objUsuarioDTO.Email = txtEmail.Text;
                        objUsuarioDTO.Cpf = maskCPF.Text;
                        objUsuarioDTO.DataCadastro = Convert.ToDateTime(maskDataCadastro.Text);


                        if (txtSenha.Text != txtCSenha.Text) 
                        {
                            MessageBox.Show("Confirmação de senha incorreta!");
                            txtCSenha.Text = "";
                            txtSenha.Text = "";
                            txtSenha.Focus();
                            break;
                        }

                        int x = 0;
                        if (bolAtualizar == false)
                        {
                            //A variavel x (criada logo abaixo, recebe o retorno da 
                            //classe Model se algum registro foi afetado no Banco caso 
                            //contrario retorna 0)
                            x = new UsuarioModel().IncluirUsuario(objUsuarioDTO);
                        }
                        else
                        {
                            x = new UsuarioModel().AtualizarUsuario(objUsuarioDTO);
                        }

                            if (x > 0)
                            {
                                //MessageBox.Show(string.Format("O Usuário {0}, foi incluído com sucesso!", txtNome.Text));
                                this.toolStripStatusLabel1.Visible = true;
                                this.toolStripStatusLabel1.Text = string.Format("O Usuário {0}, foi incluído com sucesso!", txtNome.Text);
                                RestaurarCampos();
                                HabilitarBotoes(modo);
                                dataGridUsuarios.DataSource = new UsuarioModel().BuscarUsuarios(); 
                            }
                            else
                            {
                                MessageBox.Show("Ocorreu um erro ao salvar o usuário. Favor entrar em contato com o suporte técnico.");
                            }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao salvar o usuário. Favor entrar em contato com o suporte técnico. " + ex.Message);
                    }

                    break;

                case "Pesquisar":

                    DesabilitarCampos();
                    HabilitarBotoes("");
                    dataGridUsuarios.DataSource = new UsuarioModel().PesquisarUsuarios(txtNomePesqisa.Text);
                    
                    break;
                
                case "Cancelar":

                    LimparCampos();
                    DesabilitarCampos();
                    HabilitarBotoes(modo);
                    
                    break;

                default:

                    break;

            }

        }

        private void HabilitarBotoes(string Valor)
        {
            switch (Valor)
            {
                case "Novo":
                    btnNovo.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnExcluir.Enabled = false;
                    this.toolStripStatusLabel1.Visible = false;

                    break;

                case "Salvar":
                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnExcluir.Enabled = true;
                    this.toolStripStatusLabel1.Visible = true;
                    
                    break;

                case "Cancelar":
                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnExcluir.Enabled = true;
                    this.toolStripStatusLabel1.Visible = false;
                    
                    break;

                default:
                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnExcluir.Enabled = true;
                    this.toolStripStatusLabel1.Visible = false;
                    
                    break;

            }

        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtSobrenome.Enabled = true;
            txtSenha.Enabled = true;
            txtCSenha.Enabled = true;
            txtEmail.Enabled = true;
            txtLogin.Enabled = true;
            maskDataCadastro.Enabled = true;
            maskCPF.Enabled = true;
            grbStatus.Enabled = true;
            gbrPerfil.Enabled = true;

        }

        private void LimparCampos()
        {
            lblCodigo.Text = "...";
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtSenha.Text = "";
            txtCSenha.Text = "";
            txtEmail.Text = "";
            maskDataCadastro.Text = "";
            maskCPF.Text = "";
            txtLogin.Text = "";
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            txtCSenha.Enabled = false;
            txtSobrenome.Enabled = false;
            txtLogin.Enabled = false;
            txtEmail.Enabled = false;
            maskDataCadastro.Enabled = false;
            maskCPF.Enabled = false;
            grbStatus.Enabled = false;
            gbrPerfil.Enabled = false;

        }

        private bool ValidarDadosForm()
        {
            bool boolValor = true;

            if ((txtEmail.Text == null) || (txtEmail.Text == ""))
            {
                txtEmail.BackColor = Color.Red;
                txtEmail.Text = "";
                boolValor = false;
            }

            if ((txtLogin.Text == null) || (txtLogin.Text == ""))
            {
                txtLogin.BackColor = Color.Red;
                txtLogin.Text = "";
                boolValor = false;
            }


            if ((txtCSenha.Text == null) || (txtCSenha.Text == ""))
            {
                txtCSenha.BackColor = Color.Red;
                txtCSenha.Text = "";
                boolValor = false;
            }


            if ((txtSenha.Text == null) || (txtSenha.Text == ""))
            {
                txtSenha.BackColor = Color.Red;
                txtSenha.Text = "";
                boolValor = false;
            }

            if ((txtNome.Text == null) || (txtNome.Text == ""))
            {
                txtNome.BackColor = Color.Red;
                txtNome.Text = "";
                txtNome.Focus();
                boolValor = false;
            }

            if (rdbAtivo.Checked)
            {
                objUsuarioDTO.Status = Convert.ToChar("A");
            }
            else
            {
                objUsuarioDTO.Status = Convert.ToChar("I");
            }

            if (rsbAdministrador.Checked)
            {
                objUsuarioDTO.Perfil = 1;
            }
            else if (rdbGNegocio.Checked)
            {
                objUsuarioDTO.Perfil = 2;
            }
            else if (rdbUsuTecnico.Checked)
            {
                objUsuarioDTO.Perfil = 3;
            }
            else if (rdbUsuAtendente.Checked)
            {
                objUsuarioDTO.Perfil = 4;
            }
            else if (objUsuarioDTO.Perfil == 0)
            {
                //MessageBox.Show("Favor selecionar um perfil!");
                boolValor = false;
            }

            if (boolValor == false)
            {
                MessageBox.Show("Favor informar o perfil e preencher os campos destacados no formulário!");
            }

            return boolValor;

        }

        private void RestaurarCampos()
        {
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtNome.BackColor = System.Drawing.SystemColors.Control;
            this.txtSenha.BackColor = System.Drawing.SystemColors.Control;
            this.txtCSenha.BackColor = System.Drawing.SystemColors.Control;
            this.txtLogin.BackColor = System.Drawing.SystemColors.Control;
            this.txtNome.Focus();
        }


        private void ValidarPermissoesUsuarios(int IdPerfil)
        {
            // 1-Administrador
            // 2-Gestor Negócio
            // 3-Usuário Tecnico
            // 4-Usuário Atendente

            switch (IdPerfil)
            {
                case 1: // 1-Administrador
                    rsbAdministrador.Enabled = true;
                    rdbGNegocio.Enabled = true;
                    rdbUsuAtendente.Enabled = true;
                    rdbUsuTecnico.Enabled = true;

                    break;

                case 2: // 2-Gestor Negócio
                    rsbAdministrador.Enabled = false;
                    rdbGNegocio.Enabled = true;
                    rdbUsuAtendente.Enabled = true;
                    rdbUsuTecnico.Enabled = true;

                    break;

                case 3: // 3-Usuário Tecnico
                    rsbAdministrador.Enabled = false;
                    rdbGNegocio.Enabled = false;
                    rdbUsuAtendente.Enabled = false;
                    rdbUsuTecnico.Enabled = false;                    

                    break;

                case 4: // 4-Usuário Atendente
                    rsbAdministrador.Enabled = false;
                    rdbGNegocio.Enabled = false;
                    rdbUsuAtendente.Enabled = true;
                    rdbUsuTecnico.Enabled = true;  

                    break;

                default:
                    break;

            }

        }


        #endregion


    }
}
