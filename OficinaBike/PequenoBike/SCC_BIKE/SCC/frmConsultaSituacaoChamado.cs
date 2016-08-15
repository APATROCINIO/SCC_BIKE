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
    public partial class frmConsultaSituacaoChamado : Form
    {
        public frmConsultaSituacaoChamado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChamadoDTO objChamadoDTO = new ChamadoDTO();

            DateTime varAtendimentoDe = dateTimePickerAtendimentoDe.Value;
            DateTime varAtendimentoAte = dateTimePickerAtendimentoAte.Value;
            DateTime varAgendamentoDe = dateTimePickerAgendamentoDe.Value;
            DateTime varAgendamentoAte = dateTimePickerAgendamentoAte.Value;

            if (rdAtendidos.Checked==true)
            {
                dataGridChamados.DataSource = new ChamadoModel().ConsultarChamadosAtendidos(varAtendimentoDe, varAtendimentoAte, varAgendamentoDe, varAgendamentoAte);
            }
            if (rdNaoAutorizados.Checked==true)
            {
                dataGridChamados.DataSource = new ChamadoModel().ConsultarChamadosNaoAutorizados(varAtendimentoDe, varAtendimentoAte, varAgendamentoDe, varAgendamentoAte);
            }
            if (rdPendentes.Checked==true)
            {
                dataGridChamados.DataSource = new ChamadoModel().ConsultarChamadosPendentes(varAtendimentoDe, varAtendimentoAte, varAgendamentoDe, varAgendamentoAte);
            }
        }
    }
}
