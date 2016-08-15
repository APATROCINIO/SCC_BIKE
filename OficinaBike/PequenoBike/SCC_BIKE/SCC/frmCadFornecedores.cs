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
    public partial class frmCadFornecedores : Form
    {
        public frmCadFornecedores()
        {
            InitializeComponent();
        }

        public static bool Atualizaregistro = true;

        #region "EVENTOS DA TELA"

        private void frmCadFornecedores_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
            HabilitarBotoes("");
            dataGridFornecedores.DataSource = new FornecedorModel().BuscarFornecedores();
            this.txtNomeFornecedor.KeyPress += new KeyPressEventHandler(this.txtNomeFornecedor_KeyPress);
            //this.txtClientePesqisa.KeyPress += new KeyPressEventHandler(this.txtClientePesqisa_KeyPress);
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            modo = "Excluir";
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

        private void dataGridFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //Se for selecionado um item fora da coleção o grid recarrega
            if (Convert.ToString(dataGridFornecedores.Rows[e.RowIndex].Cells[1].Value) == "")
                return;

            Atualizaregistro = false;
            DesabilitarCampos();
            HabilitarBotoes("");

            lblCodigo.Text = dataGridFornecedores["idFornecedor", e.RowIndex].Value.ToString();

            if (dataGridFornecedores["DataCadastro", e.RowIndex].Value.ToString() == null)
            {
                maskDataCadastro.Text = dataGridFornecedores["DataCadastro", e.RowIndex].Value.ToString();
            }
            else
            {
                maskDataCadastro.Text = Convert.ToString(DateTime.Now);
            }

            txtNomeFornecedor.Text = dataGridFornecedores["NomeFornecedor", e.RowIndex].Value.ToString();
            txtEmpresa.Text = dataGridFornecedores["Empresa", e.RowIndex].Value.ToString();
            maskCPFCNPJ.Text = dataGridFornecedores["Cpf_cnpj", e.RowIndex].Value.ToString();
            txtRua.Text = dataGridFornecedores["Rua", e.RowIndex].Value.ToString();
            txtEmail.Text = dataGridFornecedores["Email", e.RowIndex].Value.ToString();
            txtNumero.Text = dataGridFornecedores["Numero", e.RowIndex].Value.ToString();
            txtBairro.Text = dataGridFornecedores["Bairro", e.RowIndex].Value.ToString();
            txtUF.Text = dataGridFornecedores["Uf", e.RowIndex].Value.ToString();
            txtCidade.Text = dataGridFornecedores["Cidade", e.RowIndex].Value.ToString();
            txtCelularOi.Text = dataGridFornecedores["Celular1", e.RowIndex].Value.ToString();
            txtFxo1.Text = dataGridFornecedores["TelFixo1", e.RowIndex].Value.ToString();
            txtCelularOutraOP.Text = dataGridFornecedores["Celular2", e.RowIndex].Value.ToString();
            txtFxo2.Text = dataGridFornecedores["TelFixo2", e.RowIndex].Value.ToString();
        }

        private void dataGridFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarBotoes("Novo");
            HabilitarCampos();
            Atualizaregistro = true;
        }

        private void txtNomeFornecedor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNomePesqisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        #endregion


        #region "MÉTODOS DA TELA"

        FornecedorDTO objFornecedorDTO = new FornecedorDTO();
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
                    //txtNomeResponsavel.Focus();
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
                                objFornecedorDTO.Codigo = Convert.ToInt32(lblCodigo.Text);
                            }
                        }

                        objFornecedorDTO.NomeFornecedor = txtNomeFornecedor.Text;
                        objFornecedorDTO.Empresa = txtEmpresa.Text;
                        objFornecedorDTO.Cpf_cnpj = maskCPFCNPJ.Text;
                        objFornecedorDTO.Rua = txtRua.Text;
                        objFornecedorDTO.Email = txtEmail.Text;
                        objFornecedorDTO.Numero = txtNumero.Text;
                        objFornecedorDTO.Bairro = txtBairro.Text;
                        objFornecedorDTO.Cidade = txtCidade.Text;
                        objFornecedorDTO.Uf = txtUF.Text;
                        objFornecedorDTO.Celular1 = txtCelularOi.Text;
                        objFornecedorDTO.TelFixo1 = txtFxo1.Text;
                        objFornecedorDTO.Celular2 = txtCelularOutraOP.Text;
                        objFornecedorDTO.TelFixo2 = txtFxo2.Text;

                        //identificar usuario logado no sistema
                        objFornecedorDTO.Usuarios_idUsuario = MainClass.IdUsuario;
                        objFornecedorDTO.DataCadastro = Convert.ToDateTime(maskDataCadastro.Text);
                        objFornecedorDTO.DataUltimaAtualizacao = Convert.ToDateTime(DateTime.Now);

                        if ((txtNomeFornecedor.Text == null) || (txtNomeFornecedor.Text == ""))
                        {
                            MessageBox.Show("Favor informar o nome do Fornecedor!");
                            txtNomeFornecedor.Text = "";
                            txtNomeFornecedor.Focus();
                            break;
                        }

                        if ((txtFxo1.Text == null) || (txtFxo1.Text == ""))
                        {
                            MessageBox.Show("Favor informar o Telefone do Fornecedor!");
                            txtNomeFornecedor.Text = "";
                            txtNomeFornecedor.Focus();
                            break;
                        }
                        int x = 0;
                        if (bolAtualizar == false)
                        {
                            //A variavel x (criada logo abaixo, recebe o retorno da 
                            //classe Model se algum registro foi afetado no Banco caso 
                            //contrario retorna 0)
                            x = new FornecedorModel().IncluirFornecedor(objFornecedorDTO);
                        }
                        else
                        {
                            x = new FornecedorModel().AtualizarFornecedor(objFornecedorDTO);
                        }

                        if (x > 0)
                        {
                            //MessageBox.Show(string.Format("O Fornecedor {0}, foi incluído com sucesso!", txtNomeFornecedor.Text));
                            this.toolStripStatusLabel1.Visible = true;
                            this.toolStripStatusLabel1.Text = string.Format("O Fornecedor {0}, foi incluído com sucesso!", txtNomeFornecedor.Text);
                            HabilitarBotoes(modo);
                            RestaurarCampos();
                            dataGridFornecedores.DataSource = new FornecedorModel().BuscarFornecedores();
                            DesabilitarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Ocorreu um erro ao salvar o Fornecedor. Favor entrar em contato com o suporte técnico.");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao salvar o Fornecedor. Favor entrar em contato com o suporte técnico." + ex.Message);
                    }

                    break;

                case "Pesquisar":

                    DesabilitarCampos();
                    HabilitarBotoes("");
                    //dataGridFornecedores.DataSource = new FornecedorModel().ConsultarFornecedores(txtFornecedorPesqisa.Text);

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
                    this.btnNovo.Enabled = false;
                    this.btnSalvar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    this.btnExcluir.Enabled = false;
                    this.toolStripStatusLabel1.Visible = false;

                    break;

                case "Salvar":
                    this.btnNovo.Enabled = true;
                    this.btnSalvar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.btnExcluir.Enabled = true;
                    this.toolStripStatusLabel1.Visible = true;

                    break;

                case "Cancelar":
                    this.btnNovo.Enabled = true;
                    this.btnSalvar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.btnExcluir.Enabled = true;
                    this.toolStripStatusLabel1.Visible = false;

                    break;

                default:
                    this.btnNovo.Enabled = true;
                    this.btnSalvar.Enabled = false;
                    this.btnCancelar.Enabled = false;
                    this.btnExcluir.Enabled = true;
                    this.toolStripStatusLabel1.Visible = false;

                    break;

            }

        }

        private void HabilitarCampos()
        {
            this.txtNomeFornecedor.Enabled = true;
            this.txtEmpresa.Enabled = true;
            this.txtCidade.Enabled = true;
            this.txtCelularOi.Enabled = true;
            this.txtCelularOutraOP.Enabled = true;
            this.txtUF.Enabled = true;
            this.txtWhatsapp.Enabled = true;
            this.txtFxo1.Enabled = true;
            this.txtFxo2.Enabled = true;
            this.txtBairro.Enabled = true;
            this.txtRua.Enabled = true;
            this.txtEmail.Enabled = true;
            this.txtNumero.Enabled = true;
            this.maskDataCadastro.Enabled = true;
            this.maskCPFCNPJ.Enabled = true;

        }

        private void LimparCampos()
        {
            this.lblCodigo.Text = "...";
            this.txtNomeFornecedor.Text = "";
            this.txtEmpresa.Text = "";
            this.txtCidade.Text = "";
            this.txtCelularOi.Text = "";
            this.txtCelularOutraOP.Text = "";
            this.txtUF.Text = "";
            this.txtWhatsapp.Text = "";
            this.txtFxo1.Text = "";
            this.txtFxo2.Text = "";
            this.txtBairro.Text = "";
            this.txtEmail.Text = "";
            this.maskDataCadastro.Text = "";
            this.maskCPFCNPJ.Text = "";
            this.txtRua.Text = "";
            this.txtNumero.Text = "";

        }

        private void DesabilitarCampos()
        {
            this.txtNomeFornecedor.Enabled = false;
            this.txtCidade.Enabled = false;
            this.txtCelularOi.Enabled = false;
            this.txtEmpresa.Enabled = false;
            this.txtRua.Enabled = false;
            this.txtNumero.Enabled = false;
            this.txtCelularOutraOP.Enabled = false;
            this.txtUF.Enabled = false;
            this.txtWhatsapp.Enabled = false;
            this.txtFxo1.Enabled = false;
            this.txtFxo2.Enabled = false;
            this.txtEmail.Enabled = false;
            this.txtBairro.Enabled = false;
            this.maskDataCadastro.Enabled = false;
            this.maskCPFCNPJ.Enabled = false;

        }

        private bool ValidarDadosForm()
        {
            bool boolValor = true;

            if ((txtFxo1.Text == null) || (txtFxo1.Text == ""))
            {
                txtFxo1.BackColor = Color.Red;
                txtFxo1.Text = "";
                txtFxo1.Focus();
                boolValor = false;
            }

            if ((txtNomeFornecedor.Text == null) || (txtNomeFornecedor.Text == ""))
            {
                txtNomeFornecedor.BackColor = Color.Red;
                txtNomeFornecedor.Text = "";
                txtNomeFornecedor.Focus();
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
            txtNomeFornecedor.BackColor = System.Drawing.SystemColors.Control;
            txtFxo1.BackColor = System.Drawing.SystemColors.Control;
        }


        #endregion


     }
}
