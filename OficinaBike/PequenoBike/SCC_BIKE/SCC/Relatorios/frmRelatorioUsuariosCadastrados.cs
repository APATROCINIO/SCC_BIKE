﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SCC_BIKE.Relatorios
{
    public partial class frmRelatorioUsuariosCadastrados : Form
    {
        public frmRelatorioUsuariosCadastrados()
        {
            InitializeComponent();
        }

        private void frmRelatorioUsuariosCadastrados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbSCC_BIKEDataSet.usuarios' table. You can move, or remove it, as needed.
            //this.usuariosTableAdapter.Fill(this.dbSCC_BIKEDataSet.usuarios);

            this.reportViewer1.RefreshReport();
        }

        private void frmRelatorioUsuariosCadastrados_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
