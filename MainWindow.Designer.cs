﻿namespace ControleDeEstoqueProauto
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            linkLabel1 = new LinkLabel();
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem1 = new ToolStripMenuItem();
            incluirNovosRegistrosToolStripMenuItem1 = new ToolStripMenuItem();
            atualizarListaDeItensToolStripMenuItem = new ToolStripMenuItem();
            baixarMovimentaçõesPorDataToolStripMenuItem1 = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            toolTip1 = new ToolTip(components);
            pictureBox1 = new PictureBox();
            btnInserir = new Button();
            rbRemover = new RadioButton();
            rbAcrescentar = new RadioButton();
            numQuantidade = new NumericUpDown();
            dtpData = new DateTimePicker();
            txtEstoqueMin = new TextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelTimer = new ToolStripStatusLabel();
            groupBox4 = new GroupBox();
            listBoxProdutos = new ListBox();
            textBox1 = new TextBox();
            ckbVerificarEstoqueMin = new CheckBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
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
            tabPage2 = new TabPage();
            groupBox3 = new GroupBox();
            ckbBuscarPorPeriodo = new CheckBox();
            dgvMovimentacoes = new DataGridView();
            dtpPara = new DateTimePicker();
            label3 = new Label();
            dtpDe = new DateTimePicker();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            statusStrip1.SuspendLayout();
            groupBox4.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimentacoes).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkArea = new LinkArea(18, 22);
            linkLabel1.Location = new Point(1053, 24);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(131, 20);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Desenvolvido Por: MHMS";
            linkLabel1.UseCompatibleTextRendering = true;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
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
            // btnInserir
            // 
            btnInserir.Location = new Point(577, 74);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(116, 23);
            btnInserir.TabIndex = 13;
            btnInserir.Text = "Inserir";
            toolTip1.SetToolTip(btnInserir, "Registra a movimentação do produto");
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // rbRemover
            // 
            rbRemover.AutoSize = true;
            rbRemover.FlatStyle = FlatStyle.System;
            rbRemover.Location = new Point(456, 80);
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
            rbAcrescentar.Location = new Point(351, 80);
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
            numQuantidade.Location = new Point(207, 76);
            numQuantidade.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(120, 23);
            numQuantidade.TabIndex = 8;
            toolTip1.SetToolTip(numQuantidade, "Define a quantidade de produto a ser adicionada ou removida do estoque");
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(44, 76);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(105, 23);
            dtpData.TabIndex = 10;
            toolTip1.SetToolTip(dtpData, "Data do registro da movimentação \r\n\r\nEx: \r\n\r\nProduto movimentado hoje, mantenha a data atual\r\n\r\nProduto com movimentação dia 22/12/2024, altere a data para 22/12/2024");
            // 
            // txtEstoqueMin
            // 
            txtEstoqueMin.Location = new Point(702, 68);
            txtEstoqueMin.Name = "txtEstoqueMin";
            txtEstoqueMin.ReadOnly = true;
            txtEstoqueMin.Size = new Size(100, 23);
            txtEstoqueMin.TabIndex = 7;
            toolTip1.SetToolTip(txtEstoqueMin, "Clique Duas Vezes com o botão do mouse para habilitar a edição e\r\npressione ENTER para salvar");
            txtEstoqueMin.KeyDown += txtEstoqueMin_KeyDown;
            txtEstoqueMin.KeyPress += txtEstoqueMin_KeyPress;
            txtEstoqueMin.MouseDoubleClick += txtEstoqueMin_MouseDoubleClick;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelTimer });
            statusStrip1.Location = new Point(0, 679);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RightToLeft = RightToLeft.Yes;
            statusStrip1.Size = new Size(1184, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTimer
            // 
            toolStripStatusLabelTimer.Name = "toolStripStatusLabelTimer";
            toolStripStatusLabelTimer.Size = new Size(118, 17);
            toolStripStatusLabelTimer.Text = "toolStripStatusLabel1";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(listBoxProdutos);
            groupBox4.Controls.Add(textBox1);
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
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(3, 86);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite um produto para filtrar";
            textBox1.Size = new Size(298, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(304, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(880, 655);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(872, 627);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Movimentação Produto";
            tabPage1.UseVisualStyleBackColor = true;
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
            groupBox2.Location = new Point(3, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(866, 138);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Inserir Movimentação";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 58);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 2;
            label7.Text = "DATA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(207, 58);
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
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(866, 126);
            groupBox1.TabIndex = 14;
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
            label2.MouseDoubleClick += label2_MouseDoubleClick;
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
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(872, 627);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Filtro Movimentações";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ckbBuscarPorPeriodo);
            groupBox3.Controls.Add(dgvMovimentacoes);
            groupBox3.Controls.Add(dtpPara);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(dtpDe);
            groupBox3.Controls.Add(label1);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(866, 621);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ultimas Movimentações";
            // 
            // ckbBuscarPorPeriodo
            // 
            ckbBuscarPorPeriodo.AutoSize = true;
            ckbBuscarPorPeriodo.Location = new Point(462, 49);
            ckbBuscarPorPeriodo.Name = "ckbBuscarPorPeriodo";
            ckbBuscarPorPeriodo.Size = new Size(126, 19);
            ckbBuscarPorPeriodo.TabIndex = 14;
            ckbBuscarPorPeriodo.Text = "Buscar Por Periodo";
            ckbBuscarPorPeriodo.UseVisualStyleBackColor = true;
            // 
            // dgvMovimentacoes
            // 
            dgvMovimentacoes.AllowUserToAddRows = false;
            dgvMovimentacoes.AllowUserToDeleteRows = false;
            dgvMovimentacoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovimentacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(99, 194, 157);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMovimentacoes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMovimentacoes.Dock = DockStyle.Bottom;
            dgvMovimentacoes.Location = new Point(3, 121);
            dgvMovimentacoes.Name = "dgvMovimentacoes";
            dgvMovimentacoes.ReadOnly = true;
            dgvMovimentacoes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvMovimentacoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovimentacoes.Size = new Size(860, 497);
            dgvMovimentacoes.TabIndex = 12;
            dgvMovimentacoes.KeyDown += dgvMovimentacoes_KeyDown;
            // 
            // dtpPara
            // 
            dtpPara.Format = DateTimePickerFormat.Short;
            dtpPara.Location = new Point(349, 46);
            dtpPara.Name = "dtpPara";
            dtpPara.Size = new Size(105, 23);
            dtpPara.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 52);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "PARA";
            // 
            // dtpDe
            // 
            dtpDe.Format = DateTimePickerFormat.Short;
            dtpDe.Location = new Point(186, 46);
            dtpDe.Name = "dtpDe";
            dtpDe.Size = new Size(105, 23);
            dtpDe.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 52);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 2;
            label1.Text = "DE";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 701);
            Controls.Add(tabControl1);
            Controls.Add(groupBox4);
            Controls.Add(statusStrip1);
            Controls.Add(linkLabel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimentacoes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox2;
        private Button btnInserir;
        private RadioButton rbRemover;
        private RadioButton rbAcrescentar;
        private Label label7;
        private NumericUpDown numQuantidade;
        private DateTimePicker dtpData;
        private Label label8;
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
        private TabPage tabPage2;
        private GroupBox groupBox3;
        private CheckBox ckbBuscarPorPeriodo;
        private DataGridView dgvMovimentacoes;
        private DateTimePicker dtpPara;
        private Label label3;
        private DateTimePicker dtpDe;
        private Label label1;
        private ToolStripStatusLabel toolStripStatusLabelTimer;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private CheckBox ckbVerificarEstoqueMin;
        private ListBox listBoxProdutos;
    }
}
