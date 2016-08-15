using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SCC.DTO;
using SCC.Model;

namespace SCC
{
    public partial class frmCadUsuario : Form
    {
        public frmCadUsuario()
        {
            InitializeComponent();

        }

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
            HabilitarBotoes("");
            dataGridUsuarios.DataSource = new UsuarioModel().BuscarUsuarios();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            modo = "Novo";
            InicializarModo();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            modo = "Salvar";
            InicializarModo();

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

                        if (lblIdUsuario.Text != "...")
                        {
                            if(Convert.ToInt32(lblIdUsuario.Text) > 0)
                            {
                                bolAtualizar = true;
                                objUsuarioDTO.Codigo = Convert.ToInt32(lblIdUsuario.Text);
                            }
                        }
                        objUsuarioDTO.DataCadastro = Convert.ToDateTime(maskDataCadastro.Text);
                        objUsuarioDTO.Nome = txtNome.Text;
                        objUsuarioDTO.Sobrenome = txtSobrenome.Text;
                        objUsuarioDTO.Senha = txtSenha.Text;
                        objUsuarioDTO.Login = txtLogin.Text;
                        objUsuarioDTO.Email = txtEmail.Text;
                        objUsuarioDTO.Cpf = maskCPF.Text;
                        objUsuarioDTO.DataCadastro = Convert.ToDateTime(maskDataCadastro.Text);

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
                        else
                        {
                            MessageBox.Show("Favor selecionar um perfil!");
                            break;
                        }

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
                                MessageBox.Show(string.Format("O Usuário {0}, foi incluído com sucesso!", txtNome.Text));
                                HabilitarBotoes(modo);
                                dataGridUsuarios.DataSource = new UsuarioModel().BuscarUsuarios(); 
                            }
                            else
                            {
                                MessageBox.Show("Ocorreu um erro ao Salvar o usuário!");
                            }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao Salvar o usuário! " + ex.Message);
                    }

                    break;

                case "Pesquisar":

                    DesabilitarCampos();
                    HabilitarBotoes("");
                    dataGridUsuarios.DataSource = new UsuarioModel().ConsultarUsuarios(txtNomePesqisa.Text);
                    
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

                    break;

                case "Salvar":
                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnExcluir.Enabled = true;
                    
                    break;

                case "Cancelar":
                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnExcluir.Enabled = true;
                    
                    break;

                default:
                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnExcluir.Enabled = true;
                    
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
            lblIdUsuario.Text = "...";
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

        private void dataGridUsuarios_Click(object sender, DataGridViewCellEventArgs e)
        {
            lblIdUsuario.Text = Convert.ToString(dataGridUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex]);
        }

        private void dataGridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            lblIdUsuario.Text = dataGridUsuarios["idUsuario",e.RowIndex].Value.ToString();

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
        }

    }
}
