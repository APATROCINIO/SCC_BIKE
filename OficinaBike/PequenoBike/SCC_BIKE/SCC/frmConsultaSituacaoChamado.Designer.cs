namespace SCC_BIKE
{
    partial class frmConsultaSituacaoChamado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridChamados = new System.Windows.Forms.DataGridView();
            this.idChamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAtendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAgendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdeProdutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdAtendidos = new System.Windows.Forms.RadioButton();
            this.rdPendentes = new System.Windows.Forms.RadioButton();
            this.rdNaoAutorizados = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerAtendimentoAte = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAtendimentoDe = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerAgendamentoAte = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAgendamentoDe = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChamados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridChamados
            // 
            this.dataGridChamados.AllowUserToAddRows = false;
            this.dataGridChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridChamados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idChamado,
            this.idCliente,
            this.NomeCliente,
            this.DataAtendimento,
            this.DataAgendamento,
            this.QtdeProdutos,
            this.ValorTotal});
            this.dataGridChamados.Location = new System.Drawing.Point(3, 118);
            this.dataGridChamados.Name = "dataGridChamados";
            this.dataGridChamados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridChamados.Size = new System.Drawing.Size(863, 242);
            this.dataGridChamados.TabIndex = 102;
            // 
            // idChamado
            // 
            this.idChamado.DataPropertyName = "idChamado";
            this.idChamado.HeaderText = "Cód Chamado";
            this.idChamado.Name = "idChamado";
            this.idChamado.ReadOnly = true;
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "idCliente";
            this.idCliente.HeaderText = "Cód Cliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            // 
            // NomeCliente
            // 
            this.NomeCliente.DataPropertyName = "NomeCliente";
            this.NomeCliente.HeaderText = "Cliente";
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.ReadOnly = true;
            this.NomeCliente.Width = 160;
            // 
            // DataAtendimento
            // 
            this.DataAtendimento.DataPropertyName = "DataAtendimento";
            this.DataAtendimento.HeaderText = "DataAtendimento";
            this.DataAtendimento.Name = "DataAtendimento";
            this.DataAtendimento.ReadOnly = true;
            // 
            // DataAgendamento
            // 
            this.DataAgendamento.DataPropertyName = "DataAgendamento";
            this.DataAgendamento.HeaderText = "Data Agendamento";
            this.DataAgendamento.Name = "DataAgendamento";
            this.DataAgendamento.ReadOnly = true;
            this.DataAgendamento.Width = 150;
            // 
            // QtdeProdutos
            // 
            this.QtdeProdutos.DataPropertyName = "QtdeProdutos";
            this.QtdeProdutos.HeaderText = "Qtde. de Produtos";
            this.QtdeProdutos.Name = "QtdeProdutos";
            this.QtdeProdutos.ReadOnly = true;
            this.QtdeProdutos.Width = 150;
            // 
            // ValorTotal
            // 
            this.ValorTotal.DataPropertyName = "ValorTotal";
            this.ValorTotal.HeaderText = "Valor do Serviço";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            this.ValorTotal.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdAtendidos);
            this.groupBox1.Controls.Add(this.rdPendentes);
            this.groupBox1.Controls.Add(this.rdNaoAutorizados);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(109, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 100);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Pesquisa";
            // 
            // rdAtendidos
            // 
            this.rdAtendidos.AutoSize = true;
            this.rdAtendidos.Location = new System.Drawing.Point(6, 73);
            this.rdAtendidos.Name = "rdAtendidos";
            this.rdAtendidos.Size = new System.Drawing.Size(88, 19);
            this.rdAtendidos.TabIndex = 2;
            this.rdAtendidos.TabStop = true;
            this.rdAtendidos.Text = "Atendidos";
            this.rdAtendidos.UseVisualStyleBackColor = true;
            // 
            // rdPendentes
            // 
            this.rdPendentes.AutoSize = true;
            this.rdPendentes.Location = new System.Drawing.Point(6, 24);
            this.rdPendentes.Name = "rdPendentes";
            this.rdPendentes.Size = new System.Drawing.Size(197, 19);
            this.rdPendentes.TabIndex = 1;
            this.rdPendentes.TabStop = true;
            this.rdPendentes.Text = "Pendentes de Atendimento";
            this.rdPendentes.UseVisualStyleBackColor = true;
            // 
            // rdNaoAutorizados
            // 
            this.rdNaoAutorizados.AutoSize = true;
            this.rdNaoAutorizados.Location = new System.Drawing.Point(6, 49);
            this.rdNaoAutorizados.Name = "rdNaoAutorizados";
            this.rdNaoAutorizados.Size = new System.Drawing.Size(130, 19);
            this.rdNaoAutorizados.TabIndex = 0;
            this.rdNaoAutorizados.TabStop = true;
            this.rdNaoAutorizados.Text = "Não Autorizados";
            this.rdNaoAutorizados.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePickerAtendimentoAte);
            this.groupBox2.Controls.Add(this.dateTimePickerAtendimentoDe);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(322, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 100);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pedríodo Atendimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Até:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "De:";
            // 
            // dateTimePickerAtendimentoAte
            // 
            this.dateTimePickerAtendimentoAte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAtendimentoAte.Location = new System.Drawing.Point(42, 68);
            this.dateTimePickerAtendimentoAte.Name = "dateTimePickerAtendimentoAte";
            this.dateTimePickerAtendimentoAte.Size = new System.Drawing.Size(214, 20);
            this.dateTimePickerAtendimentoAte.TabIndex = 1;
            // 
            // dateTimePickerAtendimentoDe
            // 
            this.dateTimePickerAtendimentoDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAtendimentoDe.Location = new System.Drawing.Point(42, 23);
            this.dateTimePickerAtendimentoDe.Name = "dateTimePickerAtendimentoDe";
            this.dateTimePickerAtendimentoDe.Size = new System.Drawing.Size(214, 20);
            this.dateTimePickerAtendimentoDe.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 95);
            this.button1.TabIndex = 105;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dateTimePickerAgendamentoAte);
            this.groupBox3.Controls.Add(this.dateTimePickerAgendamentoDe);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(597, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 100);
            this.groupBox3.TabIndex = 106;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pedríodo Agendamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Até:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "De:";
            // 
            // dateTimePickerAgendamentoAte
            // 
            this.dateTimePickerAgendamentoAte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAgendamentoAte.Location = new System.Drawing.Point(42, 68);
            this.dateTimePickerAgendamentoAte.Name = "dateTimePickerAgendamentoAte";
            this.dateTimePickerAgendamentoAte.Size = new System.Drawing.Size(214, 20);
            this.dateTimePickerAgendamentoAte.TabIndex = 1;
            // 
            // dateTimePickerAgendamentoDe
            // 
            this.dateTimePickerAgendamentoDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAgendamentoDe.Location = new System.Drawing.Point(42, 23);
            this.dateTimePickerAgendamentoDe.Name = "dateTimePickerAgendamentoDe";
            this.dateTimePickerAgendamentoDe.Size = new System.Drawing.Size(214, 20);
            this.dateTimePickerAgendamentoDe.TabIndex = 0;
            // 
            // frmConsultaSituacaoChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 364);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridChamados);
            this.Name = "frmConsultaSituacaoChamado";
            this.Text = "ConsultaSituacaoChamado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChamados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridChamados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdAtendidos;
        private System.Windows.Forms.RadioButton rdPendentes;
        private System.Windows.Forms.RadioButton rdNaoAutorizados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerAtendimentoAte;
        private System.Windows.Forms.DateTimePicker dateTimePickerAtendimentoDe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idChamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAtendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAgendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdeProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerAgendamentoAte;
        private System.Windows.Forms.DateTimePicker dateTimePickerAgendamentoDe;
    }
}