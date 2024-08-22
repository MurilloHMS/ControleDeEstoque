namespace ControleDeEstoqueProauto
{
    partial class Form1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBoxProdutos = new ListBox();
            groupBox1 = new GroupBox();
            dtpDataUltimaAlteracao = new DateTimePicker();
            txtEstoqueMin = new TextBox();
            txtEstoqueAtual = new TextBox();
            txtDescricao = new TextBox();
            txtID = new TextBox();
            label = new Label();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox4 = new GroupBox();
            pictureBox1 = new PictureBox();
            ckbVerificarEstoqueMin = new CheckBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            btnInserir = new Button();
            rbRemover = new RadioButton();
            rbAcrescentar = new RadioButton();
            label7 = new Label();
            numQuantidade = new NumericUpDown();
            dtpData = new DateTimePicker();
            label8 = new Label();
            tabPage2 = new TabPage();
            groupBox3 = new GroupBox();
            ckbBuscarPorPeriodo = new CheckBox();
            dgvMovimentacoes = new DataGridView();
            dtpPara = new DateTimePicker();
            label3 = new Label();
            dtpDe = new DateTimePicker();
            label1 = new Label();
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
            listBoxProdutos.Dock = DockStyle.Bottom;
            listBoxProdutos.FormattingEnabled = true;
            listBoxProdutos.ItemHeight = 15;
            listBoxProdutos.Location = new Point(3, 97);
            listBoxProdutos.Name = "listBoxProdutos";
            listBoxProdutos.Size = new Size(298, 664);
            listBoxProdutos.TabIndex = 0;
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
            // txtEstoqueMin
            // 
            txtEstoqueMin.Location = new Point(702, 68);
            txtEstoqueMin.Name = "txtEstoqueMin";
            txtEstoqueMin.ReadOnly = true;
            txtEstoqueMin.Size = new Size(100, 23);
            txtEstoqueMin.TabIndex = 7;
            txtEstoqueMin.KeyDown += txtEstoqueMin_KeyDown;
            txtEstoqueMin.KeyPress += txtEstoqueMin_KeyPress;
            txtEstoqueMin.MouseDoubleClick += txtEstoqueMin_MouseDoubleClick;
            // 
            // txtEstoqueAtual
            // 
            txtEstoqueAtual.BackColor = SystemColors.InactiveCaption;
            txtEstoqueAtual.Location = new Point(403, 68);
            txtEstoqueAtual.Name = "txtEstoqueAtual";
            txtEstoqueAtual.ReadOnly = true;
            txtEstoqueAtual.Size = new Size(100, 23);
            txtEstoqueAtual.TabIndex = 5;
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = SystemColors.InactiveCaption;
            txtDescricao.Location = new Point(119, 68);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.ReadOnly = true;
            txtDescricao.Size = new Size(267, 23);
            txtDescricao.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.InactiveCaption;
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
            // groupBox4
            // 
            groupBox4.Controls.Add(pictureBox1);
            groupBox4.Controls.Add(ckbVerificarEstoqueMin);
            groupBox4.Controls.Add(listBoxProdutos);
            groupBox4.Dock = DockStyle.Left;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(304, 764);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Selecione o produto para alterar";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // ckbVerificarEstoqueMin
            // 
            ckbVerificarEstoqueMin.AutoSize = true;
            ckbVerificarEstoqueMin.Location = new Point(96, 73);
            ckbVerificarEstoqueMin.Name = "ckbVerificarEstoqueMin";
            ckbVerificarEstoqueMin.Size = new Size(209, 19);
            ckbVerificarEstoqueMin.TabIndex = 1;
            ckbVerificarEstoqueMin.Text = "Verificar Produtos Estoque Mínimo";
            ckbVerificarEstoqueMin.UseVisualStyleBackColor = true;
            ckbVerificarEstoqueMin.CheckedChanged += ckbVerificarEstoqueMin_CheckedChanged;
            ckbVerificarEstoqueMin.MouseClick += ckbVerificarEstoqueMin_MouseClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(304, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(880, 764);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(872, 736);
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
            // btnInserir
            // 
            btnInserir.Location = new Point(577, 74);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(116, 23);
            btnInserir.TabIndex = 13;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // rbRemover
            // 
            rbRemover.AutoSize = true;
            rbRemover.Location = new Point(456, 80);
            rbRemover.Name = "rbRemover";
            rbRemover.Size = new Size(78, 19);
            rbRemover.TabIndex = 12;
            rbRemover.TabStop = true;
            rbRemover.Text = "REMOVER";
            rbRemover.UseVisualStyleBackColor = true;
            // 
            // rbAcrescentar
            // 
            rbAcrescentar.AutoSize = true;
            rbAcrescentar.Location = new Point(351, 80);
            rbAcrescentar.Name = "rbAcrescentar";
            rbAcrescentar.Size = new Size(103, 19);
            rbAcrescentar.TabIndex = 11;
            rbAcrescentar.TabStop = true;
            rbAcrescentar.Text = "ACRESCENTAR";
            rbAcrescentar.UseVisualStyleBackColor = true;
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
            // numQuantidade
            // 
            numQuantidade.Location = new Point(207, 76);
            numQuantidade.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(120, 23);
            numQuantidade.TabIndex = 8;
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(44, 76);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(105, 23);
            dtpData.TabIndex = 10;
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
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(872, 736);
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
            dgvMovimentacoes.Dock = DockStyle.Bottom;
            dgvMovimentacoes.Location = new Point(3, 121);
            dgvMovimentacoes.Name = "dgvMovimentacoes";
            dgvMovimentacoes.ReadOnly = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 764);
            Controls.Add(tabControl1);
            Controls.Add(groupBox4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
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
        }

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
        private GroupBox groupBox4;
        private CheckBox ckbVerificarEstoqueMin;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox2;
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
    }
}
