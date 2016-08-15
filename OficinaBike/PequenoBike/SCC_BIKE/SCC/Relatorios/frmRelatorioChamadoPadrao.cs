using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SCC_BIKE.Relatorios
{
    public partial class frmRelatorioChamadoPadrao : Form
    {
        //public event UnhandledExceptionEventHandler UnhandledException;
        public int valIdChamadoImpressao = 0;

        public frmRelatorioChamadoPadrao()
        {
            InitializeComponent();
        }

        public frmRelatorioChamadoPadrao(int valIdChamado)
        {
            InitializeComponent();
            valIdChamadoImpressao = valIdChamado;

        }    

        private void frmRelatorioChamadoPadrao_Load(object sender, EventArgs e)
        {

            if (valIdChamadoImpressao != 0)
            {
                textBox1.Text = Convert.ToString(valIdChamadoImpressao);

                // TODO: This line of code loads data into the 'dbSCC_BIKEDataSet1.view_chamadopadrao' table. You can move, or remove it, as needed.
                //this.view_chamadopadraoTableAdapter.Fill(this.dbSCC_BIKEDataSet1.view_chamadopadrao, valIdChamadoImpressao);
                this.reportViewer1.RefreshReport();
            }

        }

        private void frmRelatorioChamadoPadrao_FormClosed(object sender, FormClosedEventArgs e)
        {
             this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valIdChamadoImpressao == 0)
            {
                valIdChamadoImpressao = Convert.ToInt32(textBox1.Text);
            }
            if (valIdChamadoImpressao != 0)
            {
                textBox1.Text = Convert.ToString(valIdChamadoImpressao);

                // TODO: This line of code loads data into the 'dbSCC_BIKEDataSet1.view_chamadopadrao' table. You can move, or remove it, as needed.
                //this.view_chamadopadraoTableAdapter.Fill(this.dbSCC_BIKEDataSet1.view_chamadopadrao, Convert.ToInt32(valIdChamadoImpressao));


                this.reportViewer1.RefreshReport();
            }
        }



    }
}
