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
    public partial class frmChamadosBaixa : Form
    {
        public frmChamadosBaixa()
        {
            InitializeComponent();
        }

        ChamadoDTO objChamadoDTO = new ChamadoDTO();
        private string modo = "";
        public bool bolAtualizar = false;


        #region "EVENTOS DA TELA"

        private void frmBaixaChamados_Load(object sender, EventArgs e)
        {

            DesabilitarCampos();
            HabilitarBotoes("Nenhum");
            dataGridChamados.DataSource = new ChamadoModel().BuscarChamadoBaixa();
           
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

        private void dataGridChamados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            if (Convert.ToString(dataGridChamados.Rows[e.RowIndex].Cells[2].Value) == "")
                return;
            
            lblCodigo.Text = dataGridChamados["idChamado", e.RowIndex].Value.ToString();

            CarregarItensDoChamado(Convert.ToInt32(dataGridChamados.Rows[e.RowIndex].Cells[0].Value));

            modo = "Novo";
            InicializarModo();



        }

        private void btnFinalizarChamado_Click(object sender, EventArgs e)
        {
            modo = "Salvar";
            InicializarModo();
            DesabilitarCampos();
            HabilitarBotoes("Nenhum");
            DesabilitarGrid();
            dataGridChamados.DataSource = new ChamadoModel().BuscarChamadoBaixa();
        }

        #endregion

        #region "MÉTODOS DA TELA"

        private void InicializarModo()
        {
            switch (modo)
            {
                case "Novo":

                    LimparCampos();
                    HabilitarCampos();
                    HabilitarBotoes(modo);

                    break;

                case "Salvar":

                    HabilitarBotoes("Salvar");
                    bolAtualizar = false;

                    try
                    {
                        //Finalizar do Chamado
                        objChamadoDTO.Codigo = Convert.ToInt32(lblCodigo.Text);
                        objChamadoDTO.DataRetirada = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd H:mm:ss"));
                        objChamadoDTO.DataUltimaAtualizacao = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd H:mm:ss"));
                        objChamadoDTO.Usuarios_idUsuario = MainClass.IdUsuario;
                        objChamadoDTO.ChamadoFinalizado = "S";
                        
                        int x = new ChamadoModel().FinalizarChamado(objChamadoDTO);

                        if (x == 1)
                        {
                            MessageBox.Show("Chamado finalizado com sucesso! ");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao finalizar chamado atual! " + ex.Message);
                    }

                    break;

                case "Pesquisar":

                    DesabilitarCampos();
                    HabilitarBotoes("");
                    //dataGridClientes.DataSource = new ClienteModel().PesquisarClientes(txtClientePesqisa.Text);

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

        private void HabilitarCampos()
        {
            btnFinalizarChamado.Enabled = true;

        }

        private void LimparCampos()
        {

        }

        private void DesabilitarCampos()
        {
            btnFinalizarChamado.Enabled = false;
            

        }

        private void DesabilitarGrid()
        {
            CarregarItensDoChamado(0);
        }

        private void HabilitarBotoes(string Valor)
        {
            switch (Valor)
            {
                case "Novo":
                    //btnNovo.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnExcluir.Enabled = false;

                    break;

                case "Salvar":
                    //btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnExcluir.Enabled = true;

                    break;

                case "Cancelar":
                    //btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnExcluir.Enabled = true;

                    break;
                case "Nenhum":
                    btnSalvar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnExcluir.Enabled = false;

                    break;
                default:
                    //btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnExcluir.Enabled = true;

                    break;

            }

        }

        private void CarregarItensDoChamado(int parIdChamado)
        {
            ChamadoItemDTO objChamadoItemDTO = new ChamadoItemDTO();
            dataGridItemChamado.DataSource = new ChamadoItemModel().BuscarChamadoAutorizado(parIdChamado);

        }


        #endregion

    }
}
