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
    public partial class frmChamadosApontamentoTecnico : Form
    {
        public frmChamadosApontamentoTecnico()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 100;
        }

        ChamadoDTO objChamadoDTO = new ChamadoDTO();
        ChamadoItemDTO objChamadoItemDTO = new ChamadoItemDTO();
        private string modo = "";
        public static bool Atualizaregistro = false;
        public static bool bolAtualizar = false;

        #region "EVENTOS DA TELA"

        private void frmChamadosApontamentoTecnico_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
            HabilitarBotoes("");
            dataGridChamados.DataSource = new ChamadoModel().BuscarChamadoApontamentoTecnico();
            this.rtxObsItemChamado.KeyPress += new KeyPressEventHandler(this.rtxObsItemChamado_KeyPress);
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

            if (Convert.ToString(dataGridChamados.Rows[e.RowIndex].Cells[2].Value) == "")
                return;

            if (e.RowIndex < 0)
                return;
            pbCarrega.Value = 0; //Reinicia contagem do tempo de execução do timer para verificar a existencia de novos chamados
            DesabilitarCampos();
            HabilitarBotoes("");

            lblItem.Text = dataGridChamados["idItemChamado", e.RowIndex].Value.ToString();
            lblCodigo.Text = dataGridChamados["idChamado", e.RowIndex].Value.ToString();

            txtIdCliente.Text = dataGridChamados["idCliente", e.RowIndex].Value.ToString();
            txtNomeCliente.Text = dataGridChamados["NomeCliente", e.RowIndex].Value.ToString();
            txtIdProduto.Text = dataGridChamados["idProduto", e.RowIndex].Value.ToString();
            txtNomeProduto.Text = dataGridChamados["NomeProduto", e.RowIndex].Value.ToString();
            rtxObsAtendente.Text = dataGridChamados["ObsAtendenteChamado", e.RowIndex].Value.ToString();
            rtxObsAtendente.ReadOnly = true;
            rtxObsAtendente.BackColor = System.Drawing.Color.White;

            rtxObsItemChamado.Text = dataGridChamados["ObsItemTecnico", e.RowIndex].Value.ToString();
            rtxObsItemChamado.Focus();

            modo = "Novo";
            InicializarModo();
        }

        private void rtxObsItemChamado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            pbCarrega.Value = 0; //Reinicia contagem do tempo de execução do timer para verificar a existencia de novos chamados
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



                        //bool bValor = false;
                        int x = 0;

                        //Incluir Segundo o Item do Chamado
                        objChamadoItemDTO.Codigo = Convert.ToInt32(lblItem.Text);
                        objChamadoItemDTO.ObsItemTecnico = rtxObsItemChamado.Text; //esta informação será preenchida posteriormente ao cadastro do Chamado
                        //objChamadoItemDTO.ValorItem = 0;

                        x = new ChamadoItemModel().AtualizarItemChmado(objChamadoItemDTO);

                        if (x == 1)
                        {
                            MessageBox.Show("Atualização Efetuada com sucesso! ");
                            HabilitarBotoes(modo);
                            LimparCampos();
                            DesabilitarCampos();
                            dataGridChamados.DataSource = new ChamadoModel().BuscarChamadoApontamentoTecnico();

                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao Atulizar Item! " + ex.Message);
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


        }

        private void LimparCampos()
        {

        }

        private void DesabilitarCampos()
        {

            txtNomeCliente.Enabled = false;
            txtIdCliente.Enabled = false;
            txtIdProduto.Enabled = false;
            txtNomeProduto.Enabled = false;

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

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbCarrega.Value < 5000)
            {
                pbCarrega.Value = pbCarrega.Value + 5;
            }
            else
            {
                timer1.Enabled = false;
                System.Media.SystemSounds.Beep.Play();
                this.Close();

            }            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            pbCarrega.Value = 0; //Reinicia contagem do tempo de execução do timer para verificar a existencia de novos chamados
        }

    }
}
