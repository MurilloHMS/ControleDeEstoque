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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            listBoxProdutos = new System.Windows.Forms.ListBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            dtpDataUltimaAlteracao = new System.Windows.Forms.DateTimePicker();
            txtEstoqueMin = new System.Windows.Forms.TextBox();
            txtEstoqueAtual = new System.Windows.Forms.TextBox();
            txtDescricao = new System.Windows.Forms.TextBox();
            txtID = new System.Windows.Forms.TextBox();
            label = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            groupBox4 = new System.Windows.Forms.GroupBox();
            btnDownload = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ckbVerificarEstoqueMin = new System.Windows.Forms.CheckBox();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btnInserir = new System.Windows.Forms.Button();
            rbRemover = new System.Windows.Forms.RadioButton();
            rbAcrescentar = new System.Windows.Forms.RadioButton();
            label7 = new System.Windows.Forms.Label();
            numQuantidade = new System.Windows.Forms.NumericUpDown();
            dtpData = new System.Windows.Forms.DateTimePicker();
            label8 = new System.Windows.Forms.Label();
            tabPage2 = new System.Windows.Forms.TabPage();
            groupBox3 = new System.Windows.Forms.GroupBox();
            ckbBuscarPorPeriodo = new System.Windows.Forms.CheckBox();
            dgvMovimentacoes = new System.Windows.Forms.DataGridView();
            dtpPara = new System.Windows.Forms.DateTimePicker();
            label3 = new System.Windows.Forms.Label();
            dtpDe = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimentacoes).BeginInit();
            SuspendLayout();
            // 
            // listBoxProdutos
            // 
            listBoxProdutos.Dock = System.Windows.Forms.DockStyle.Bottom;
            listBoxProdutos.FormattingEnabled = true;
            listBoxProdutos.ItemHeight = 15;
            listBoxProdutos.Location = new System.Drawing.Point(3, 112);
            listBoxProdutos.Name = "listBoxProdutos";
            listBoxProdutos.Size = new System.Drawing.Size(298, 649);
            listBoxProdutos.TabIndex = 0;
            listBoxProdutos.DrawItem += listBoxProdutos_DrawItem;
            listBoxProdutos.SelectedIndexChanged += listBoxProdutos_SelectedIndexChanged;
            listBoxProdutos.KeyDown += listBoxProdutos_KeyDown;
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
            groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox1.Location = new System.Drawing.Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(866, 126);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Produto";
            // 
            // dtpDataUltimaAlteracao
            // 
            dtpDataUltimaAlteracao.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            dtpDataUltimaAlteracao.Enabled = false;
            dtpDataUltimaAlteracao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDataUltimaAlteracao.Location = new System.Drawing.Point(520, 68);
            dtpDataUltimaAlteracao.Name = "dtpDataUltimaAlteracao";
            dtpDataUltimaAlteracao.Size = new System.Drawing.Size(147, 23);
            dtpDataUltimaAlteracao.TabIndex = 9;
            // 
            // txtEstoqueMin
            // 
            txtEstoqueMin.Location = new System.Drawing.Point(702, 68);
            txtEstoqueMin.Name = "txtEstoqueMin";
            txtEstoqueMin.ReadOnly = true;
            txtEstoqueMin.Size = new System.Drawing.Size(100, 23);
            txtEstoqueMin.TabIndex = 7;
            txtEstoqueMin.KeyDown += txtEstoqueMin_KeyDown;
            txtEstoqueMin.KeyPress += txtEstoqueMin_KeyPress;
            txtEstoqueMin.MouseDoubleClick += txtEstoqueMin_MouseDoubleClick;
            // 
            // txtEstoqueAtual
            // 
            txtEstoqueAtual.BackColor = System.Drawing.Color.FromArgb(((int)((byte)216)), ((int)((byte)224)), ((int)((byte)228)));
            txtEstoqueAtual.Location = new System.Drawing.Point(403, 68);
            txtEstoqueAtual.Name = "txtEstoqueAtual";
            txtEstoqueAtual.ReadOnly = true;
            txtEstoqueAtual.Size = new System.Drawing.Size(100, 23);
            txtEstoqueAtual.TabIndex = 5;
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)((byte)216)), ((int)((byte)224)), ((int)((byte)228)));
            txtDescricao.Location = new System.Drawing.Point(119, 68);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.ReadOnly = true;
            txtDescricao.Size = new System.Drawing.Size(267, 23);
            txtDescricao.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.BackColor = System.Drawing.Color.FromArgb(((int)((byte)216)), ((int)((byte)224)), ((int)((byte)228)));
            txtID.Location = new System.Drawing.Point(44, 68);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new System.Drawing.Size(51, 23);
            txtID.TabIndex = 3;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(119, 50);
            label.Name = "label";
            label.Size = new System.Drawing.Size(70, 15);
            label.TabIndex = 2;
            label.Text = "DESCRIÇÃO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(44, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(18, 15);
            label2.TabIndex = 2;
            label2.Text = "ID";
            label2.MouseDoubleClick += label2_MouseDoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(403, 50);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(94, 15);
            label4.TabIndex = 2;
            label4.Text = "ESTOQUE ATUAL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(702, 50);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(105, 15);
            label6.TabIndex = 2;
            label6.Text = "ESTOQUE MINIMO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(520, 50);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(147, 15);
            label5.TabIndex = 2;
            label5.Text = "DATA ULTIMA ALTERAÇÃO";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnDownload);
            groupBox4.Controls.Add(textBox1);
            groupBox4.Controls.Add(pictureBox1);
            groupBox4.Controls.Add(ckbVerificarEstoqueMin);
            groupBox4.Controls.Add(listBoxProdutos);
            groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            groupBox4.Location = new System.Drawing.Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(304, 764);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            // 
            // btnDownload
            // 
            btnDownload.Location = new System.Drawing.Point(6, 69);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new System.Drawing.Size(84, 20);
            btnDownload.TabIndex = 14;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(3, 89);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite um produto para filtrar";
            textBox1.Size = new System.Drawing.Size(298, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
            pictureBox1.Location = new System.Drawing.Point(3, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(298, 48);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // ckbVerificarEstoqueMin
            // 
            ckbVerificarEstoqueMin.AutoSize = true;
            ckbVerificarEstoqueMin.Location = new System.Drawing.Point(96, 69);
            ckbVerificarEstoqueMin.Name = "ckbVerificarEstoqueMin";
            ckbVerificarEstoqueMin.Size = new System.Drawing.Size(209, 19);
            ckbVerificarEstoqueMin.TabIndex = 1;
            ckbVerificarEstoqueMin.Text = "Verificar Produtos Estoque Mínimo";
            ckbVerificarEstoqueMin.UseVisualStyleBackColor = true;
            ckbVerificarEstoqueMin.CheckedChanged += ckbVerificarEstoqueMin_CheckedChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(304, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(880, 764);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(872, 736);
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
            groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox2.Location = new System.Drawing.Point(3, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(866, 138);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Inserir Movimentação";
            // 
            // btnInserir
            // 
            btnInserir.Location = new System.Drawing.Point(577, 74);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new System.Drawing.Size(116, 23);
            btnInserir.TabIndex = 13;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // rbRemover
            // 
            rbRemover.AutoSize = true;
            rbRemover.FlatStyle = System.Windows.Forms.FlatStyle.System;
            rbRemover.Location = new System.Drawing.Point(456, 80);
            rbRemover.Name = "rbRemover";
            rbRemover.Size = new System.Drawing.Size(84, 20);
            rbRemover.TabIndex = 12;
            rbRemover.TabStop = true;
            rbRemover.Text = "REMOVER";
            rbRemover.UseVisualStyleBackColor = true;
            // 
            // rbAcrescentar
            // 
            rbAcrescentar.AutoSize = true;
            rbAcrescentar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            rbAcrescentar.Location = new System.Drawing.Point(351, 80);
            rbAcrescentar.Name = "rbAcrescentar";
            rbAcrescentar.Size = new System.Drawing.Size(109, 20);
            rbAcrescentar.TabIndex = 11;
            rbAcrescentar.TabStop = true;
            rbAcrescentar.Text = "ACRESCENTAR";
            rbAcrescentar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(44, 58);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(35, 15);
            label7.TabIndex = 2;
            label7.Text = "DATA";
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new System.Drawing.Point(207, 76);
            numQuantidade.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new System.Drawing.Size(120, 23);
            numQuantidade.TabIndex = 8;
            // 
            // dtpData
            // 
            dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpData.Location = new System.Drawing.Point(44, 76);
            dtpData.Name = "dtpData";
            dtpData.Size = new System.Drawing.Size(105, 23);
            dtpData.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(207, 58);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(80, 15);
            label8.TabIndex = 2;
            label8.Text = "QUANTIDADE";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(872, 736);
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
            groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox3.Location = new System.Drawing.Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(866, 621);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ultimas Movimentações";
            // 
            // ckbBuscarPorPeriodo
            // 
            ckbBuscarPorPeriodo.AutoSize = true;
            ckbBuscarPorPeriodo.Location = new System.Drawing.Point(462, 49);
            ckbBuscarPorPeriodo.Name = "ckbBuscarPorPeriodo";
            ckbBuscarPorPeriodo.Size = new System.Drawing.Size(126, 19);
            ckbBuscarPorPeriodo.TabIndex = 14;
            ckbBuscarPorPeriodo.Text = "Buscar Por Periodo";
            ckbBuscarPorPeriodo.UseVisualStyleBackColor = true;
            // 
            // dgvMovimentacoes
            // 
            dgvMovimentacoes.AllowUserToAddRows = false;
            dgvMovimentacoes.AllowUserToDeleteRows = false;
            dgvMovimentacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovimentacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)99)), ((int)((byte)194)), ((int)((byte)157)));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvMovimentacoes.DefaultCellStyle = dataGridViewCellStyle1;
            dgvMovimentacoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            dgvMovimentacoes.Location = new System.Drawing.Point(3, 121);
            dgvMovimentacoes.Name = "dgvMovimentacoes";
            dgvMovimentacoes.ReadOnly = true;
            dgvMovimentacoes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvMovimentacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMovimentacoes.Size = new System.Drawing.Size(860, 497);
            dgvMovimentacoes.TabIndex = 12;
            dgvMovimentacoes.KeyDown += dgvMovimentacoes_KeyDown;
            // 
            // dtpPara
            // 
            dtpPara.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpPara.Location = new System.Drawing.Point(349, 46);
            dtpPara.Name = "dtpPara";
            dtpPara.Size = new System.Drawing.Size(105, 23);
            dtpPara.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(307, 52);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "PARA";
            // 
            // dtpDe
            // 
            dtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDe.Location = new System.Drawing.Point(186, 46);
            dtpDe.Name = "dtpDe";
            dtpDe.Size = new System.Drawing.Size(105, 23);
            dtpDe.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(159, 52);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(21, 15);
            label1.TabIndex = 2;
            label1.Text = "DE";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(18, 22);
            linkLabel1.Location = new System.Drawing.Point(1046, 1);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(131, 20);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Desenvolvido Por: MHMS";
            linkLabel1.UseCompatibleTextRendering = true;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1184, 764);
            Controls.Add(linkLabel1);
            Controls.Add(tabControl1);
            Controls.Add(groupBox4);
            Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Controle de Estoque";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimentacoes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnDownload;

        #endregion

        private ListBox listBoxProdutos;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private CheckBox ckbVerificarEstoqueMin;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Button btnInserir;
        private RadioButton rbRemover;
        private RadioButton rbAcrescentar;
        private Label label7;
        private NumericUpDown numQuantidade;
        private DateTimePicker dtpData;
        private Label label8;
        private GroupBox groupBox3;
        private DataGridView dgvMovimentacoes;
        private DateTimePicker dtpPara;
        private Label label3;
        private DateTimePicker dtpDe;
        private Label label1;
        private PictureBox pictureBox1;
        private CheckBox ckbBuscarPorPeriodo;
        private TextBox textBox1;
        private LinkLabel linkLabel1;
    }
}
