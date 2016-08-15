using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SCC_BIKE
{
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;
        public int varIdUsuario = 5;
        public MDIPrincipal()
        {
            InitializeComponent();
        }


        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            ValidarPermissoesUsuarios(MainClass.PerfilUsuario);

            toolStripStatusLabel2.Text = "Usuário - " + MainClass.NomeUsuario + " - Data: " + DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();

        }

        private void ValidarPermissoesUsuarios(int IdPerfil)
        {
            // 1-Administrador
            // 2-Gestor Negócio
            // 3-Usuário Tecnico
            // 4-Usuário Atendente

            switch (IdPerfil)
            {
                case 1: // 1-Administrador

                    break;

                case 2: // 2-Gestor Negócio

                    break;

                case 3: // 3-Usuário Tecnico
                    ChamadoAutorizacaoToolStripMenuItem.Enabled = false;
                    ChamadoBaixaToolStripMenuItem1.Enabled = false;
                    chamadosToolStripMenuItem.Enabled = false;
                    cadastroToolStripMenuItem.Enabled = false;
                    consultaToolStripMenuItem.Enabled = false;
                    relatóriosToolStripMenuItem.Enabled = false;

                    break;

                case 4: // 4-Usuário Atendente
                    ChamadoApontamentoToolStripMenuItem.Enabled = false;

                    break;

                default:
                    break;

            }

        }

        private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(frmCadUsuarios));
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(frmCadClientes));
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(frmCadFornecedores));
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(frmCadProdutos));
        }
        
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(frmCadChamados));
        }

        private void padrãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(frmChamadosApontamentoTecnico));
        }

        private void ChamadoAutorizacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(frmAutorizacaoChamados));
        }

        private void ChamadoBaixaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(frmChamadosBaixa));
        }

        private void ChamadoApontamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(frmChamadosApontamentoTecnico));
        }



        private void relatórioDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir relatório de usuários
            OpenForm(typeof(Relatorios.frmRelatorioUsuariosCadastrados));

        }

        public void chamadoPadrãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir relatório de usuários
            OpenForm(typeof(Relatorios.frmRelatorioChamadoPadrao));
        }

        private void chamadosEmAbertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Impressão de Chamados
            OpenForm(typeof(frmConsultaChamados));

        }

        private void situaçãoChamadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Consulta sitação dos Chamados
            OpenForm(typeof(frmConsultaSituacaoChamado));
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
