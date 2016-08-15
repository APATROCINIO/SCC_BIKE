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
    public partial class frmAutorizacaoChamados : Form
    {
        public frmAutorizacaoChamados()
        {
            InitializeComponent();
        }

        ChamadoDTO objChamadoDTO = new ChamadoDTO();
        ChamadoItemDTO objChamadoItemDTO = new ChamadoItemDTO();
        private string modo = "";
        private decimal dcmValorChamado = 0;
        public static bool bolAtualizar = false;


        #region "EVENTOS DA TELA"


        private void frmAutorizacaoChamados_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
            HabilitarBotoes("");
            dataGridChamados.DataSource = new ChamadoModel().BuscarChamadoAutorizarServico();
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

            DesabilitarCampos();
            HabilitarBotoes("");

            lblItem.Text = dataGridChamados["idItemChamado", e.RowIndex].Value.ToString();
            lblCodigo.Text = dataGridChamados["idChamado", e.RowIndex].Value.ToString();

            txtIdCliente.Text = dataGridChamados["idCliente", e.RowIndex].Value.ToString();
            txtNomeCliente.Text = dataGridChamados["NomeCliente", e.RowIndex].Value.ToString();
            txtIdProduto.Text = dataGridChamados["idProduto", e.RowIndex].Value.ToString();
            txtNomeProduto.Text = dataGridChamados["NomeProduto", e.RowIndex].Value.ToString();

            txtValorItemChamado.Text = Decimal.Parse(dataGridChamados["ValorItem", e.RowIndex].Value.ToString()).ToString("N2");
            txtValorItemChamado.Focus();

            modo = "Novo";
            InicializarModo();

            dcmValorChamado = ValidarAutorizacaoChamado();
        }

        private void monthCalendarAgendamento_DateSelected(object sender, DateRangeEventArgs e)
        {
            maskAgendamento.Text = Convert.ToString(monthCalendarAgendamento.SelectionRange.End);
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

                    int x = 0;
                    int xx = 0;


                    try
                    {

                        if (maskAgendamento.Text != "  /  /")
                        {

                            //Aualizar Data de Agendamento do Chamado
                            objChamadoDTO.Codigo = Convert.ToInt32(lblCodigo.Text);
                            objChamadoDTO.ValorTotal = dcmValorChamado;
                            objChamadoDTO.DataAgendamento = Convert.ToDateTime(maskAgendamento.Text);

                            xx = new ChamadoModel().AgendarChmado(objChamadoDTO);

                            if (xx == 1)
                            {

                                //Aualizar valor do Item do Chamado
                                objChamadoItemDTO.Chamados_idChamado = Convert.ToInt32(lblCodigo.Text);
                                //objChamadoItemDTO.Codigo = Convert.ToInt32(lblItem.Text);
                                objChamadoItemDTO.ServicoAutorizado = "S";
                                //objChamadoItemDTO.ValorItem = Convert.ToDecimal(txtValorItemChamado.Text); //esta informação será preenchida posteriormente ao cadastro do Chamado

                                x = new ChamadoItemModel().AtualizarStatusItemChmado(objChamadoItemDTO);

                                if (x >= 1)
                                {
                                    MessageBox.Show("Autorização concluída com sucesso! ");
                                    HabilitarBotoes(modo);
                                    LimparCampos();
                                    DesabilitarCampos();
                                    dataGridChamados.DataSource = new ChamadoModel().BuscarChamadoAutorizarServico();

                                }                                

                            }


                        }
                        else
                        {
                            //Aualizar valor do Item do Chamado
                            objChamadoItemDTO.Codigo = Convert.ToInt32(lblItem.Text);
                            objChamadoItemDTO.ValorItem = Convert.ToDecimal(txtValorItemChamado.Text); //esta informação será preenchida posteriormente ao cadastro do Chamado

                            x = new ChamadoItemModel().AtualizarValorItemChmado(objChamadoItemDTO);

                            if (x == 1)
                            {
                                MessageBox.Show("Atualização efetuada com sucesso! ");
                                HabilitarBotoes(modo);
                                LimparCampos();
                                DesabilitarCampos();
                                dataGridChamados.DataSource = new ChamadoModel().BuscarChamadoAutorizarServico();

                            }

                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao atualizar este Chamado! " + ex.Message);
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
            maskAgendamento.Enabled = true;
            maskAgendamento.ReadOnly = false;
            monthCalendarAgendamento.Enabled = true;
            txtValorItemChamado.Enabled = true;
            txtValorItemChamado.ReadOnly = false;

        }

        private void LimparCampos()
        {
            maskAgendamento.Text = "";
        }

        private void DesabilitarCampos()
        {
            //pnlAutorizacao.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtIdCliente.Enabled = false;
            txtIdProduto.Enabled = false;
            txtNomeProduto.Enabled = false;
            maskAgendamento.Enabled = false;
            maskAgendamento.ReadOnly = true;
            txtValorItemChamado.Enabled = false;
            monthCalendarAgendamento.Enabled = false;

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

        private decimal ValidarAutorizacaoChamado()
        {
            int i = 0;
            bool habilitaDataAgendamento = true;
            decimal dcmValor = 0;


            DataGridViewRow row = new DataGridViewRow();

            for (i = 0; i < dataGridChamados.RowCount; i++)
            {
                row = dataGridChamados.Rows[i];

                if ((Convert.ToInt32(row.Cells[2].Value) == Convert.ToInt32(lblCodigo.Text)) && (Convert.ToInt32(row.Cells[9].Value) == 0))
                {
                    habilitaDataAgendamento = false;

                }

                if ((Convert.ToInt32(row.Cells[2].Value) == Convert.ToInt32(lblCodigo.Text)) && (Convert.ToDecimal(row.Cells[9].Value) > 0))
                {
                    dcmValor = dcmValor + Convert.ToDecimal(row.Cells[9].Value);

                }
                
            }

            if (habilitaDataAgendamento == true)
            {

                maskAgendamento.Enabled = true;
                maskAgendamento.ReadOnly = false;
                monthCalendarAgendamento.Enabled = true;
                maskAgendamento.Focus();
            }
            else
            {
                
                maskAgendamento.Enabled = false;
                maskAgendamento.ReadOnly = true;
                monthCalendarAgendamento.Enabled = false;
            }

            return dcmValor;
        }

        #endregion

 
    }
}
