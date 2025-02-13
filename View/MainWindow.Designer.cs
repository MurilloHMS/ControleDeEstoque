namespace ControleDeEstoqueProauto
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem1 = new ToolStripMenuItem();
            incluirNovosRegistrosToolStripMenuItem1 = new ToolStripMenuItem();
            atualizarListaDeItensToolStripMenuItem = new ToolStripMenuItem();
            baixarMovimentaçõesPorDataToolStripMenuItem1 = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            toolTip1 = new ToolTip(components);
            pictureBox1 = new PictureBox();
            txtEstoqueMin = new TextBox();
            btnInserir = new Button();
            rbRemover = new RadioButton();
            rbAcrescentar = new RadioButton();
            numQuantidade = new NumericUpDown();
            dtpData = new DateTimePicker();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelTimer = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            groupBox4 = new GroupBox();
            listBoxProdutos = new ListBox();
            txtFiltro = new TextBox();
            ckbVerificarEstoqueMin = new CheckBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            panel3 = new Panel();
            dgvMovimentacoes = new DataGridView();
            panel2 = new Panel();
            ckbBuscarPorPeriodo = new CheckBox();
            dtpPara = new DateTimePicker();
            label3 = new Label();
            dtpDe = new DateTimePicker();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            dtpDataUltimaAlteracao = new DateTimePicker();
            txtEstoqueAtual = new TextBox();
            txtDescricao = new TextBox();
            txtID = new TextBox();
            label = new Label();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            statusStrip1.SuspendLayout();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimentacoes).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem1, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem1
            // 
            cadastrosToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { incluirNovosRegistrosToolStripMenuItem1, atualizarListaDeItensToolStripMenuItem, baixarMovimentaçõesPorDataToolStripMenuItem1 });
            cadastrosToolStripMenuItem1.Name = "cadastrosToolStripMenuItem1";
            cadastrosToolStripMenuItem1.Size = new Size(71, 20);
            cadastrosToolStripMenuItem1.Text = "Cadastros";
            // 
            // incluirNovosRegistrosToolStripMenuItem1
            // 
            incluirNovosRegistrosToolStripMenuItem1.Image = Properties.Resources.Plus;
            incluirNovosRegistrosToolStripMenuItem1.Name = "incluirNovosRegistrosToolStripMenuItem1";
            incluirNovosRegistrosToolStripMenuItem1.Size = new Size(241, 22);
            incluirNovosRegistrosToolStripMenuItem1.Text = "Incluir Novos Registros";
            incluirNovosRegistrosToolStripMenuItem1.Click += incluirNovosRegistrosToolStripMenuItem1_Click;
            // 
            // atualizarListaDeItensToolStripMenuItem
            // 
            atualizarListaDeItensToolStripMenuItem.Image = Properties.Resources.Update_Left_Rotation;
            atualizarListaDeItensToolStripMenuItem.Name = "atualizarListaDeItensToolStripMenuItem";
            atualizarListaDeItensToolStripMenuItem.Size = new Size(241, 22);
            atualizarListaDeItensToolStripMenuItem.Text = "Atualizar Lista de Itens";
            atualizarListaDeItensToolStripMenuItem.Click += atualizarListaDeItensToolStripMenuItem_Click;
            // 
            // baixarMovimentaçõesPorDataToolStripMenuItem1
            // 
            baixarMovimentaçõesPorDataToolStripMenuItem1.Image = Properties.Resources.Downloading_Updates;
            baixarMovimentaçõesPorDataToolStripMenuItem1.Name = "baixarMovimentaçõesPorDataToolStripMenuItem1";
            baixarMovimentaçõesPorDataToolStripMenuItem1.Size = new Size(241, 22);
            baixarMovimentaçõesPorDataToolStripMenuItem1.Text = "Baixar Movimentações por data";
            baixarMovimentaçõesPorDataToolStripMenuItem1.Click += baixarMovimentaçõesPorDataToolStripMenuItem1_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 100;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Ajuda";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            toolTip1.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // txtEstoqueMin
            // 
            txtEstoqueMin.Location = new Point(702, 68);
            txtEstoqueMin.Name = "txtEstoqueMin";
            txtEstoqueMin.ReadOnly = true;
            txtEstoqueMin.Size = new Size(100, 23);
            txtEstoqueMin.TabIndex = 7;
            toolTip1.SetToolTip(txtEstoqueMin, "Clique Duas Vezes com o botão do mouse para habilitar a edição e\r\npressione ENTER para salvar");
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(596, 38);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(116, 23);
            btnInserir.TabIndex = 13;
            btnInserir.Text = "Inserir";
            toolTip1.SetToolTip(btnInserir, "Registra a movimentação do produto");
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // rbRemover
            // 
            rbRemover.AutoSize = true;
            rbRemover.FlatStyle = FlatStyle.System;
            rbRemover.Location = new Point(475, 44);
            rbRemover.Name = "rbRemover";
            rbRemover.Size = new Size(84, 20);
            rbRemover.TabIndex = 12;
            rbRemover.TabStop = true;
            rbRemover.Text = "REMOVER";
            toolTip1.SetToolTip(rbRemover, "Inclui estoque negativo nas movimentações");
            rbRemover.UseVisualStyleBackColor = true;
            // 
            // rbAcrescentar
            // 
            rbAcrescentar.AutoSize = true;
            rbAcrescentar.FlatStyle = FlatStyle.System;
            rbAcrescentar.Location = new Point(370, 44);
            rbAcrescentar.Name = "rbAcrescentar";
            rbAcrescentar.Size = new Size(109, 20);
            rbAcrescentar.TabIndex = 11;
            rbAcrescentar.TabStop = true;
            rbAcrescentar.Text = "ACRESCENTAR";
            toolTip1.SetToolTip(rbAcrescentar, "Inclui estoque positivo nas movimentações\r\n");
            rbAcrescentar.UseVisualStyleBackColor = true;
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(226, 40);
            numQuantidade.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(120, 23);
            numQuantidade.TabIndex = 8;
            toolTip1.SetToolTip(numQuantidade, "Define a quantidade de produto a ser adicionada ou removida do estoque");
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(63, 40);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(105, 23);
            dtpData.TabIndex = 10;
            toolTip1.SetToolTip(dtpData, "Data do registro da movimentação \r\n\r\nEx: \r\n\r\nProduto movimentado hoje, mantenha a data atual\r\n\r\nProduto com movimentação dia 22/12/2024, altere a data para 22/12/2024");
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelTimer, toolStripStatusLabel2, toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 679);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RightToLeft = RightToLeft.Yes;
            statusStrip1.Size = new Size(1184, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTimer
            // 
            toolStripStatusLabelTimer.Margin = new Padding(0, 3, 15, 2);
            toolStripStatusLabelTimer.Name = "toolStripStatusLabelTimer";
            toolStripStatusLabelTimer.Size = new Size(118, 17);
            toolStripStatusLabelTimer.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Margin = new Padding(0, 3, 15, 2);
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(37, 17);
            toolStripStatusLabel2.Text = "v1.0.9";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.IsLink = true;
            toolStripStatusLabel1.Margin = new Padding(0, 3, 10, 2);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(142, 17);
            toolStripStatusLabel1.Text = "Desenvolvido Por: MHMS";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(listBoxProdutos);
            groupBox4.Controls.Add(txtFiltro);
            groupBox4.Controls.Add(ckbVerificarEstoqueMin);
            groupBox4.Controls.Add(pictureBox1);
            groupBox4.Dock = DockStyle.Left;
            groupBox4.Location = new Point(0, 24);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(304, 655);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            // 
            // listBoxProdutos
            // 
            listBoxProdutos.Dock = DockStyle.Fill;
            listBoxProdutos.FormattingEnabled = true;
            listBoxProdutos.ItemHeight = 15;
            listBoxProdutos.Location = new Point(3, 109);
            listBoxProdutos.Name = "listBoxProdutos";
            listBoxProdutos.Size = new Size(298, 543);
            listBoxProdutos.TabIndex = 6;
            listBoxProdutos.SelectedIndexChanged += listBoxProdutos_SelectedIndexChanged;
            listBoxProdutos.KeyDown += listBoxProdutos_KeyDown;
            // 
            // txtFiltro
            // 
            txtFiltro.Dock = DockStyle.Top;
            txtFiltro.Location = new Point(3, 86);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.PlaceholderText = "Digite um produto para filtrar";
            txtFiltro.Size = new Size(298, 23);
            txtFiltro.TabIndex = 5;
            txtFiltro.TextChanged += textBox1_TextChanged;
            // 
            // ckbVerificarEstoqueMin
            // 
            ckbVerificarEstoqueMin.AutoSize = true;
            ckbVerificarEstoqueMin.Dock = DockStyle.Top;
            ckbVerificarEstoqueMin.Location = new Point(3, 67);
            ckbVerificarEstoqueMin.Name = "ckbVerificarEstoqueMin";
            ckbVerificarEstoqueMin.Size = new Size(298, 19);
            ckbVerificarEstoqueMin.TabIndex = 4;
            ckbVerificarEstoqueMin.Text = "Verificar Produtos Estoque Mínimo";
            ckbVerificarEstoqueMin.UseVisualStyleBackColor = true;
            ckbVerificarEstoqueMin.CheckedChanged += ckbVerificarEstoqueMin_CheckedChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(304, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 655);
            panel1.TabIndex = 13;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel3);
            groupBox3.Controls.Add(panel2);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 211);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(880, 444);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ultimas Movimentações";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvMovimentacoes);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(874, 347);
            panel3.TabIndex = 16;
            // 
            // dgvMovimentacoes
            // 
            dgvMovimentacoes.AllowUserToAddRows = false;
            dgvMovimentacoes.AllowUserToDeleteRows = false;
            dgvMovimentacoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovimentacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(99, 194, 157);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvMovimentacoes.DefaultCellStyle = dataGridViewCellStyle1;
            dgvMovimentacoes.Dock = DockStyle.Fill;
            dgvMovimentacoes.Location = new Point(0, 0);
            dgvMovimentacoes.Name = "dgvMovimentacoes";
            dgvMovimentacoes.ReadOnly = true;
            dgvMovimentacoes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvMovimentacoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovimentacoes.Size = new Size(874, 347);
            dgvMovimentacoes.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.Controls.Add(ckbBuscarPorPeriodo);
            panel2.Controls.Add(dtpPara);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dtpDe);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(874, 75);
            panel2.TabIndex = 15;
            // 
            // ckbBuscarPorPeriodo
            // 
            ckbBuscarPorPeriodo.AutoSize = true;
            ckbBuscarPorPeriodo.Location = new Point(526, 42);
            ckbBuscarPorPeriodo.Name = "ckbBuscarPorPeriodo";
            ckbBuscarPorPeriodo.Size = new Size(126, 19);
            ckbBuscarPorPeriodo.TabIndex = 24;
            ckbBuscarPorPeriodo.Text = "Buscar Por Periodo";
            ckbBuscarPorPeriodo.UseVisualStyleBackColor = true;
            // 
            // dtpPara
            // 
            dtpPara.Format = DateTimePickerFormat.Short;
            dtpPara.Location = new Point(413, 39);
            dtpPara.Name = "dtpPara";
            dtpPara.Size = new Size(105, 23);
            dtpPara.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(371, 45);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 20;
            label3.Text = "PARA";
            // 
            // dtpDe
            // 
            dtpDe.Format = DateTimePickerFormat.Short;
            dtpDe.Location = new Point(250, 39);
            dtpDe.Name = "dtpDe";
            dtpDe.Size = new Size(105, 23);
            dtpDe.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 45);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 21;
            label1.Text = "DE";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnInserir);
            groupBox2.Controls.Add(rbRemover);
            groupBox2.Controls.Add(rbAcrescentar);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(numQuantidade);
            groupBox2.Controls.Add(dtpData);
            groupBox2.Controls.Add(label8);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 126);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(880, 85);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Inserir Movimentação";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(63, 22);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 2;
            label7.Text = "DATA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(226, 22);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 2;
            label8.Text = "QUANTIDADE";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpDataUltimaAlteracao);
            groupBox1.Controls.Add(txtEstoqueMin);
            groupBox1.Controls.Add(txtEstoqueAtual);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(880, 126);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Produto";
            // 
            // dtpDataUltimaAlteracao
            // 
            dtpDataUltimaAlteracao.CalendarMonthBackground = SystemColors.InactiveCaption;
            dtpDataUltimaAlteracao.Enabled = false;
            dtpDataUltimaAlteracao.Format = DateTimePickerFormat.Short;
            dtpDataUltimaAlteracao.Location = new Point(520, 68);
            dtpDataUltimaAlteracao.Name = "dtpDataUltimaAlteracao";
            dtpDataUltimaAlteracao.Size = new Size(147, 23);
            dtpDataUltimaAlteracao.TabIndex = 9;
            // 
            // txtEstoqueAtual
            // 
            txtEstoqueAtual.BackColor = Color.FromArgb(216, 224, 228);
            txtEstoqueAtual.Location = new Point(403, 68);
            txtEstoqueAtual.Name = "txtEstoqueAtual";
            txtEstoqueAtual.ReadOnly = true;
            txtEstoqueAtual.Size = new Size(100, 23);
            txtEstoqueAtual.TabIndex = 5;
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = Color.FromArgb(216, 224, 228);
            txtDescricao.Location = new Point(119, 68);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.ReadOnly = true;
            txtDescricao.Size = new Size(267, 23);
            txtDescricao.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(216, 224, 228);
            txtID.Location = new Point(44, 68);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(51, 23);
            txtID.TabIndex = 3;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(119, 50);
            label.Name = "label";
            label.Size = new Size(70, 15);
            label.TabIndex = 2;
            label.Text = "DESCRIÇÃO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 50);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(403, 50);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 2;
            label4.Text = "ESTOQUE ATUAL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(702, 50);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 2;
            label6.Text = "ESTOQUE MINIMO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(520, 50);
            label5.Name = "label5";
            label5.Size = new Size(147, 15);
            label5.TabIndex = 2;
            label5.Text = "DATA ULTIMA ALTERAÇÃO";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 701);
            Controls.Add(panel1);
            Controls.Add(groupBox4);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Estoque";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMovimentacoes).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem1;
        private ToolStripMenuItem incluirNovosRegistrosToolStripMenuItem1;
        private ToolStripMenuItem atualizarListaDeItensToolStripMenuItem;
        private ToolStripMenuItem baixarMovimentaçõesPorDataToolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolTip toolTip1;
        private StatusStrip statusStrip1;
        private GroupBox groupBox4;
        private PictureBox pictureBox1;
        private ToolStripStatusLabel toolStripStatusLabelTimer;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtFiltro;
        private CheckBox ckbVerificarEstoqueMin;
        private ListBox listBoxProdutos;
        private Panel panel1;
        private GroupBox groupBox1;
        private DateTimePicker dtpDataUltimaAlteracao;
        private TextBox txtEstoqueMin;
        private TextBox txtEstoqueAtual;
        private TextBox txtDescricao;
        private TextBox txtID;
        private Label label;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label5;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button btnInserir;
        private RadioButton rbRemover;
        private RadioButton rbAcrescentar;
        private Label label7;
        private NumericUpDown numQuantidade;
        private DateTimePicker dtpData;
        private Label label8;
        private Panel panel2;
        private CheckBox ckbBuscarPorPeriodo;
        private DateTimePicker dtpPara;
        private Label label3;
        private DateTimePicker dtpDe;
        private Label label1;
        private Panel panel3;
        private DataGridView dgvMovimentacoes;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
    }
}
