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
    public partial class frmConsultaChamados : Form
    {
        Form formMDI = new SCC_BIKE.MDIPrincipal();

        public frmConsultaChamados()
        {
            InitializeComponent();
        }

        private int codClinteSelecionado = 0;

        private void frmConsultaChmados_Load(object sender, EventArgs e)
        {
            //DesabilitarCampos();
            //HabilitarBotoes("Nenhum");
            dataGridChamados.DataSource = new ChamadoModel().BuscarChamadoImprimir();
        }

        private void HabilitarCampos()
        {
            btnImprimirChamado.Enabled = true;

        }

        private void LimparCampos()
        {

        }

        private void btnImprimirChamado_Click(object sender, EventArgs e)
        {
            if (ValidarChamadoSelecionado() == true)
            {
                Relatorios.frmRelatorioChamadoPadrao frmRelChamado = new Relatorios.frmRelatorioChamadoPadrao(codClinteSelecionado);
                frmRelChamado.MdiParent = formMDI.MdiParent;
                frmRelChamado.StartPosition = 0;
                frmRelChamado.Show();

            } else
            {
                MessageBox.Show("Selecione um Chamado para ser visualizado!");
            }

        }

        private void dataGridChamados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //verificar se existe um cliente selecionado
            int qtdChamados = dataGridChamados.RowCount;
            int i;

            for (i = 0; i < qtdChamados; i++)
            {
                if (e.RowIndex != i)
                {
                    if (dataGridChamados.Rows[i].Cells[0].Value != null)
                    {
                        //MessageBox.Show("Este Cliente foi selecionado " + dataGridClientes.Rows[i].Cells[2].Value);
                        dataGridChamados.Rows[i].Cells[0].Value = null;
                    }

                }
                else
                {
                    codClinteSelecionado = Convert.ToInt32(dataGridChamados.Rows[i].Cells[1].Value);
                }

            }


        }

        private bool ValidarChamadoSelecionado()
        {
            bool boolValor = false;

            int qtdChamados = dataGridChamados.RowCount;
            int i;

            for (i = 0; i < qtdChamados; i++)
            {
               
                if (dataGridChamados.Rows[i].Cells[0].Value != null)
                {
                    boolValor = true;
                }

            }

            return boolValor;
        }

        //Verifica se formlário está aberto
        public void OpenForm(Type frmType)
        {
            bool bolCtl = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType().Equals(frmType))
                {
                    form.MdiParent = this;
                    form.Show();
                    form.StartPosition = 0;
                    bolCtl = true;
                    break;
                }
            }

            if (!bolCtl)
            {
                Form frm = (Form)Activator.CreateInstance(frmType);
                frm.MdiParent = this;
                frm.StartPosition = 0;
                frm.Show();
            }
        }// Fim validar formulário aberto 

    }
}
