using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using My .Data;
//using MySql.Data.MySqlClient;

using SCC_BIKE.DTO;
using SCC_BIKE.Model;


namespace SCC_BIKE
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblReturnLogin.Text = "Seja bem vindo!";
            txtSenha.PasswordChar = '*';
            txtLogin.Text = "ADM";
            txtSenha.Text = "TESTE";
        }

        private void btLogar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLogin.Text == "")
                {
                    MessageBox.Show("Campo Usuário não pode estar vazio.!");
                    txtLogin.Focus();
                    return;
                }

                if (txtSenha.Text == "")
                {
                    MessageBox.Show("Campo Senha não pode estar vazio.");
                    txtSenha.Focus();
                    return;
                }

                UsuarioDTO objUsuario = new UsuarioDTO();
                objUsuario.Login = txtLogin.Text;
                objUsuario.Senha = txtSenha.Text;

                objUsuario = new UsuarioModel().AutenticarUsuarioSenha(objUsuario);

                MainClass.IdUsuario = objUsuario.Codigo;
                MainClass.CodEmpresaUsuario = "1"; //Verificar dados da empresa do usuário, para não conflitar com dados de empresas diferentes na Internet
                MainClass.PerfilUsuario = objUsuario.Perfil;
                 MainClass.NomeUsuario= objUsuario.Nome;


                if (objUsuario.Login == null)
                {
                    lblReturnLogin.Text = "Usuario ou Senha Inválida!";
                    lblReturnLogin.ForeColor = Color.Red;
                    return;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao autenticar o usuário!" + ex.Message);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtLogin.CharacterCasing = CharacterCasing.Upper;
        }

    }
}
