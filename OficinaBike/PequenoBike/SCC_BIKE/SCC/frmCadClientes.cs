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
    public partial class frmCadClientes : Form
    {
        public frmCadClientes()
        {
            InitializeComponent();
        }

        public static bool Atualizaregistro = true;

        #region "EVENTOS DA TELA"

        private void frmCadClientes_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
            HabilitarBotoes("");
            dataGridClientes.DataSource = new ClienteModel().BuscarClientes();
            this.txtNomeCliente.KeyPress += new KeyPressEventHandler(this.txtNomeCliente_KeyPress);
            this.txtClientePesqisa.KeyPress += new KeyPressEventHandler(this.txtClientePesqisa_KeyPress);
            this.txtUF.KeyPress += new KeyPressEventHandler(this.txtUF_KeyPress);
            this.txtEmpresa.KeyPress += new KeyPressEventHandler(this.txtEmpresa_KeyPress);
            this.txtEmail.KeyPress += new KeyPressEventHandler(this.txtEmail_KeyPress);
            this.txtRua.KeyPress += new KeyPressEventHandler(this.txtRua_KeyPress);
            this.txtBairro.KeyPress += new KeyPressEventHandler(this.txtBairro_KeyPress);
            this.txtCidade.KeyPress += new KeyPressEventHandler(this.txtCidade_KeyPress);
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

        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtRua_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtUF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtClientePesqisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;
            
            //Se for selecionado um item fora da coleção o grid recarrega
            if (Convert.ToString(dataGridClientes.Rows[e.RowIndex].Cells[1].Value) == "")
                return;


            Atualizaregistro = false;
            DesabilitarCampos();
            HabilitarBotoes("");

            lblCodigo.Text = dataGridClientes["idcLIENTE", e.RowIndex].Value.ToString();

            if (dataGridClientes["DataCadastro", e.RowIndex].Value.ToString() == null)
            {
                maskDataCadastro.Text = dataGridClientes["DataCadastro", e.RowIndex].Value.ToString();
            }
            else
            {
                maskDataCadastro.Text = Convert.ToString(DateTime.Now);
            }

            txtNomeCliente.Text = dataGridClientes["NomeCliente", e.RowIndex].Value.ToString();
            txtEmpresa.Text = dataGridClientes["Empresa", e.RowIndex].Value.ToString();
            maskCPFCNPJ.Text = dataGridClientes["Cpf_cnpj", e.RowIndex].Value.ToString();
            txtRua.Text = dataGridClientes["Rua", e.RowIndex].Value.ToString();
            txtEmail.Text = dataGridClientes["Email", e.RowIndex].Value.ToString();
            txtNumero.Text = dataGridClientes["Numero", e.RowIndex].Value.ToString();
            txtBairro.Text = dataGridClientes["Bairro", e.RowIndex].Value.ToString();
            txtUF.Text = dataGridClientes["Uf", e.RowIndex].Value.ToString();
            txtCidade.Text = dataGridClientes["Cidade", e.RowIndex].Value.ToString();
            txtCelularOi.Text = dataGridClientes["Celular1", e.RowIndex].Value.ToString();
            txtFxo1.Text = dataGridClientes["TelFixo1", e.RowIndex].Value.ToString();
            txtCelularOutraOP.Text = dataGridClientes["Celular2", e.RowIndex].Value.ToString();
            txtFxo2.Text = dataGridClientes["TelFixo2", e.RowIndex].Value.ToString();
            
        }

        private void dataGridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarBotoes("Novo");
            HabilitarCampos();
            Atualizaregistro = true;
        }

#endregion


        #region "MÉTODOS DA TELA"

        ClienteDTO objClienteDTO = new ClienteDTO();
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
                    txtNomeCliente.Focus();
                    break;

                case "Salvar":

                    HabilitarBotoes("Salvar");
                    bool bolAtualizar = false;

                    try
                    {

                        if (lblCodigo.Text != "...")
                        {
                            if (Convert.ToInt32(lblCodigo.Text) > 0)
                            {
                                bolAtualizar = true;
                                objClienteDTO.Codigo = Convert.ToInt32(lblCodigo.Text);
                            }
                        }

                        objClienteDTO.NomeCliente = txtNomeCliente.Text;
                        objClienteDTO.Empresa = txtEmpresa.Text;
                        objClienteDTO.Cpf_cnpj = maskCPFCNPJ.Text;
                        objClienteDTO.Rua = txtRua.Text;
                        objClienteDTO.Email = txtEmail.Text;
                        objClienteDTO.Numero = txtNumero.Text;
                        objClienteDTO.Bairro = txtBairro.Text;
                        objClienteDTO.Cidade = txtCidade.Text;
                        objClienteDTO.Uf = txtUF.Text;
                        objClienteDTO.Celular1 = txtCelularOi.Text;
                        objClienteDTO.TelFixo1 = txtFxo1.Text;
                        objClienteDTO.Celular2 = txtCelularOutraOP.Text;
                        objClienteDTO.TelFixo2 = txtFxo2.Text;

                        //identificar usuario logado no sistema
                        objClienteDTO.Usuarios_idUsuario = MainClass.IdUsuario;
                        objClienteDTO.DataCadastro = Convert.ToDateTime(maskDataCadastro.Text);
                        objClienteDTO.DataUltimaAtualizacao = Convert.ToDateTime(DateTime.Now); 

                        int x = 0;
                        if (bolAtualizar == false)
                        {
                            //A variavel x (criada logo abaixo, recebe o retorno da 
                            //classe Model se algum registro foi afetado no Banco caso 
                            //contrario retorna 0)
                            x = new ClienteModel().IncluirCliente(objClienteDTO);
                        }
                        else
                        {
                            x = new ClienteModel().AtualizarCliente(objClienteDTO);
                        }

                        if (x > 0)
                        {
                            //MessageBox.Show(string.Format("O Cliente {0}, foi incluído com sucesso!", txtNomeCliente.Text));
                            this.toolStripStatusLabel1.Visible = true;
                            this.toolStripStatusLabel1.Text = string.Format("O cliente {0}, foi incluído com sucesso!", txtNomeCliente.Text);
                            RestaurarCampos();
                            HabilitarBotoes(modo);
                            LimparCampos(modo);
                            DesabilitarCampos();
                            dataGridClientes.DataSource = new ClienteModel().BuscarClientes();
                        }
                        else
                        {
                            MessageBox.Show("Ocorreu um erro ao salvar o cliente. Favor entrar em contato com o suporte técnico.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao salvar o cliente. Favor entrar em contato com o suporte técnico. " + ex.Message);
                    }

                    break;

                case "Pesquisar":

                    DesabilitarCampos();
                    HabilitarBotoes("");
                    dataGridClientes.DataSource = new ClienteModel().PesquisarClientes(txtClientePesqisa.Text);
                    
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
            txtNomeCliente.Enabled = true;
            txtEmpresa.Enabled = true;
            txtCidade.Enabled = true;
            txtCelularOi.Enabled = true;
            txtCelularOutraOP.Enabled = true;
            txtUF.Enabled = true;
            txtWhatsapp.Enabled = true;
            txtFxo1.Enabled = true;
            txtFxo2.Enabled = true;
            txtBairro.Enabled = true;
            txtRua.Enabled = true;
            txtEmail.Enabled = true;
            txtNumero.Enabled = true;
            maskDataCadastro.Enabled = true;
            maskCPFCNPJ.Enabled = true;

        }

        private void LimparCampos()
        {
            lblCodigo.Text = "...";
            txtNomeCliente.Text = "";
            txtEmpresa.Text = "";
            txtCidade.Text = "";
            txtCelularOi.Text = "";
            txtCelularOutraOP.Text = "";
            txtUF.Text = "";
            txtWhatsapp.Text = "";
            txtFxo1.Text = "";
            txtFxo2.Text = "";
            txtBairro.Text = "";
            txtEmail.Text = "";
            maskDataCadastro.Text = "";
            maskCPFCNPJ.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
        }

        private void LimparCampos(string Valor)
        {
            switch (Valor)
            {
                
                case "Salvar":
                    this.toolStripStatusLabel1.Visible = true;
                    break;

                default:

                    this.toolStripStatusLabel1.Visible = false;
                    this.toolStripStatusLabel1.Text = "";

                    break;
            } 
            
        }

        private void DesabilitarCampos()
        {
            txtNomeCliente.Enabled = false;
            txtCidade.Enabled = false;
            txtCelularOi.Enabled = false;
            txtEmpresa.Enabled = false;
            txtRua.Enabled = false;
            txtNumero.Enabled = false;
            txtCelularOutraOP.Enabled = false;
            txtUF.Enabled = false;
            txtWhatsapp.Enabled = false;
            txtFxo1.Enabled = false;
            txtFxo2.Enabled = false;
            txtEmail.Enabled = false;
            txtBairro.Enabled = false;
            maskDataCadastro.Enabled = false;
            maskCPFCNPJ.Enabled = false;

        }

        private bool ValidarDadosForm()
        {
            bool boolValor = true;

            if ((txtEmail.Text == null) || (txtEmail.Text == ""))
            {
                txtEmail.BackColor = Color.Red;
                txtEmail.Text = "";
                txtEmail.Focus();
                boolValor = false;
            }

            if ((txtFxo1.Text == null) || (txtFxo1.Text == ""))
            {
                txtFxo1.BackColor = Color.Red;
                txtFxo1.Text = "";
                txtFxo1.Focus();
                boolValor = false;
            }

            if ((txtNomeCliente.Text == null) || (txtNomeCliente.Text == ""))
            {
                txtNomeCliente.BackColor = Color.Red;
                txtNomeCliente.Text = "";
                txtNomeCliente.Focus();
                boolValor = false;
            }


            if (boolValor == false)
            {
                MessageBox.Show("Favor preencher os campos em destacados no formulário!");
            }

            return boolValor;

        }

        private void RestaurarCampos()
        {
            txtEmail.BackColor = System.Drawing.SystemColors.Control;
            txtNomeCliente.BackColor = System.Drawing.SystemColors.Control;
            txtFxo1.BackColor = System.Drawing.SystemColors.Control;
        }

        #endregion


    }
}
