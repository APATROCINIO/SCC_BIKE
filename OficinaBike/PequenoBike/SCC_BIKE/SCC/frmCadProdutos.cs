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
    public partial class frmCadProdutos : Form
    {
        public frmCadProdutos()
        {
            InitializeComponent();
        }

        public static bool Atualizaregistro = true;
        public static bool bolAtualizar = false;

        #region "EVENTOS DA TELA"

        private void frmCadProdutos_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
            HabilitarBotoes("");
            CarregaCombo();
            dataGridProdutos.DataSource = new ProdutoModel().BuscarProdutos();
            this.txtNomeProduto.KeyPress += new KeyPressEventHandler(this.txtNomeProduto_KeyPress);
            
        }

        private void txtNomeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void btnPesquisar_MouseMove(object sender, MouseEventArgs e)
        {
            lblInfPesquisa.Visible = true;
        }

        private void btnPesquisar_MouseLeave(object sender, EventArgs e)
        {
            lblInfPesquisa.Visible = false;
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

        private void cboProdutoCategoria_MouseDown(object sender, MouseEventArgs e)
        {
            int itemSelecionado = Convert.ToInt32(cboProdutoCategoria.SelectedValue.ToString());
            CarregarGrupoEmpresa(itemSelecionado);
        }

        private void dataGridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se for selecionado um item fora da coleção o grid recarrega
            if (Convert.ToString(dataGridProdutos.Rows[e.RowIndex].Cells[2].Value) == "")
                return;

            if (e.RowIndex < 0)
                return;            

            Atualizaregistro = false;
            DesabilitarCampos();
            HabilitarBotoes("");

            lblCodigo.Text = dataGridProdutos["idProduto", e.RowIndex].Value.ToString();

            if (dataGridProdutos["DataCadastro", e.RowIndex].Value.ToString() == null)
            {
                maskDataCadastro.Text = dataGridProdutos["DataCadastro", e.RowIndex].Value.ToString();
            }
            //else
            //{
            //    maskDataCadastro.Text = Convert.ToString(DateTime.Now);
            //    cboProdutoCategoria.SelectedValue = Convert.ToInt32(dataGridProdutos["ProdutosCategoria_idProdutoCategoria", e.RowIndex].Value.ToString());
            //    CarregarGrupoEmpresa(Convert.ToInt32(dataGridProdutos["ProdutosCategoria_GrupoEmpresas_idGrupoEmpresa", e.RowIndex].Value.ToString()));
            //}

            txtNomeProduto.Text = dataGridProdutos["NomeProduto", e.RowIndex].Value.ToString();
        }

        private void dataGridProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarBotoes("Novo");
            HabilitarCampos();
            Atualizaregistro = true;
        }

        #endregion

        #region "MÉTODOS DA TELA"

        ProdutoDTO objProdutoDTO = new ProdutoDTO();
        private string modo = "";

        private void InicializarModo()
        {
            switch (modo)
            {
                case "Novo":

                    LimparCampos();
                    HabilitarCampos();
                    HabilitarBotoes(modo);
                    
                    int itemSelecionado = Convert.ToInt32(cboProdutoCategoria.SelectedValue.ToString());
                    CarregarGrupoEmpresa(itemSelecionado);

                    maskDataCadastro.Text = Convert.ToString(DateTime.Now);
                    txtNomeProduto.Focus();
                    break;

                case "Salvar":

                    HabilitarBotoes("Salvar");
                    bolAtualizar = false;

                    try
                    {
                        if (lblCodigo.Text != "...")
                        {
                            if (Convert.ToInt32(lblCodigo.Text) > 0)
                            {
                                bolAtualizar = true;
                                objProdutoDTO.Codigo = Convert.ToInt32(lblCodigo.Text);

                            }
                        }

                        objProdutoDTO.NomeProduto = txtNomeProduto.Text;
                        objProdutoDTO.DataCadastro = Convert.ToDateTime(maskDataCadastro.Text);
                        objProdutoDTO.DataUltimaAtualizacao = Convert.ToDateTime(DateTime.Now);
                        objProdutoDTO.GrupoEmpresas_idGrupoEmpresa = Convert.ToInt32(lblCodGrupoEmpresa.Text);

                        if (txtNomeProduto.Text == "")
                        {
                            MessageBox.Show("Favor Informar a descrição do Produto!");
                            txtNomeProduto.Text = "";
                            txtNomeProduto.Focus();
                            break;
                        }

                        int x = 0;
                        if (bolAtualizar == false)
                        {
                            //A variavel x (criada logo abaixo, recebe o retorno da 
                            //classe Model se algum registro foi afetado no Banco caso 
                            //contrario retorna 0)
                            x = new ProdutoModel().IncluirProduto(objProdutoDTO);
                        }
                        else
                        {
                            x = new ProdutoModel().AtualizarProduto(objProdutoDTO);
                        }
                        //x = new ProdutoModel().IncluirProduto(objProdutoDTO);

                        if (x > 0)
                        {
                            //MessageBox.Show(string.Format("O Produto {0}, foi incluído com sucesso!", txtNomeProduto.Text));
                            this.toolStripStatusLabel1.Visible = true;
                            this.toolStripStatusLabel1.Text = string.Format("O Produto {0}, foi incluído com sucesso!", txtNomeProduto.Text);
                            dataGridProdutos.DataSource = new ProdutoModel().BuscarProdutos();
                            LimparCampos();
                            DesabilitarCampos();
                            HabilitarBotoes(modo);
                        }
                        else
                        {
                            MessageBox.Show("Ocorreu um erro ao salvar o Produto. Favor entrar em contato com o suporte técnico.");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao salvar o Produto. Favor entrar em contato com o suporte técnico. " + ex.Message);
                    }

                    break;

                case "Pesquisar":

                    DesabilitarCampos();
                    HabilitarBotoes("");
                    //dataGridClientes.DataSource = new ClienteModel().ConsultarClientes(txtClientePesqisa.Text);

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

        private void CarregaCombo()
        {
            //ParallelEnumerable que object grid seja carregado, o UsuarioDTO deverá fazer parte de uma mpresa que tenha dataGridProdutos cadastrados
            cboProdutoCategoria.DataSource = new ProdutoCategoriaModel().BuscarProdutoCategorias(MainClass.CodEmpresaUsuario);
            cboProdutoCategoria.DisplayMember = ("NomeProdutoCategoria");
            cboProdutoCategoria.ValueMember = ("idProdutoCategoria");

        }

        private void CarregaGrid()
        {
            dataGridProdutos.DataSource = new ProdutoModel().BuscarProdutos();
        }

        private void CarregarGrupoEmpresa(int input)
        {

            DataTable dtjGrupoEmpresa = new GrupoEmpresasModel().BuscarGrupoEmpresas(input);

            lblCodGrupoEmpresa.Text = dtjGrupoEmpresa.Rows[0].ItemArray[0].ToString();
            lblGrupoEmpresa.Text = dtjGrupoEmpresa.Rows[0].ItemArray[1].ToString(); 

        }

        private void HabilitarCampos()
        {
            txtNomeProduto.Enabled = true;
            cboProdutoCategoria.Enabled = true;
            maskDataCadastro.Enabled = true;

        }

        private void LimparCampos()
        {
            txtNomeProduto.Text = "";
            maskDataCadastro.Text = "";
            lblGrupoEmpresa.Text = "";
            lblCodGrupoEmpresa.Text = "";
            lblCodigo.Text = "...";
            CarregaCombo();
        }

        private void DesabilitarCampos()
        {
            txtNomeProduto.Enabled = false;
            cboProdutoCategoria.Enabled = false;
            maskDataCadastro.Enabled = false;

        }


        #endregion

    }
}
