namespace ControleDeEstoqueProauto
{
    partial class Frm_Configuracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Configuracoes));
            toolStrip1 = new ToolStrip();
            salvarToolStripButton = new ToolStripButton();
            colarToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
            groupBox1 = new GroupBox();
            lblTipoBase = new Label();
            cbProvider = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            TxtConnectionString = new TextBox();
            button1 = new Button();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { salvarToolStripButton, colarToolStripButton, toolStripSeparator, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(882, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // salvarToolStripButton
            // 
            salvarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            salvarToolStripButton.Image = (Image)resources.GetObject("salvarToolStripButton.Image");
            salvarToolStripButton.ImageTransparentColor = Color.Magenta;
            salvarToolStripButton.Name = "salvarToolStripButton";
            salvarToolStripButton.Size = new Size(23, 22);
            salvarToolStripButton.Text = "&Salvar";
            salvarToolStripButton.Click += salvarToolStripButton_Click;
            // 
            // colarToolStripButton
            // 
            colarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            colarToolStripButton.Image = (Image)resources.GetObject("colarToolStripButton.Image");
            colarToolStripButton.ImageTransparentColor = Color.Magenta;
            colarToolStripButton.Name = "colarToolStripButton";
            colarToolStripButton.Size = new Size(23, 22);
            colarToolStripButton.Text = "&Colar";
            colarToolStripButton.ToolTipText = "Criar Banco De Dados";
            colarToolStripButton.Click += colarToolStripButton_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
            // 
            // ajudaToolStripButton
            // 
            ajudaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ajudaToolStripButton.Image = (Image)resources.GetObject("ajudaToolStripButton.Image");
            ajudaToolStripButton.ImageTransparentColor = Color.Magenta;
            ajudaToolStripButton.Name = "ajudaToolStripButton";
            ajudaToolStripButton.Size = new Size(23, 22);
            ajudaToolStripButton.Text = "Aju&da";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(lblTipoBase);
            groupBox1.Controls.Add(cbProvider);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtConnectionString);
            groupBox1.Location = new Point(9, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(857, 160);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configurações";
            // 
            // lblTipoBase
            // 
            lblTipoBase.AutoSize = true;
            lblTipoBase.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoBase.ForeColor = Color.Black;
            lblTipoBase.Location = new Point(35, 30);
            lblTipoBase.Name = "lblTipoBase";
            lblTipoBase.Size = new Size(65, 25);
            lblTipoBase.TabIndex = 3;
            lblTipoBase.Text = "label3";
            // 
            // cbProvider
            // 
            cbProvider.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProvider.FormattingEnabled = true;
            cbProvider.Items.AddRange(new object[] { "SQLite", "PostgreSQL" });
            cbProvider.Location = new Point(35, 83);
            cbProvider.Name = "cbProvider";
            cbProvider.Size = new Size(121, 23);
            cbProvider.TabIndex = 2;
            cbProvider.SelectedIndexChanged += cbProvider_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 65);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Provedor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 65);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 1;
            label1.Text = "String De Conexão";
            // 
            // TxtConnectionString
            // 
            TxtConnectionString.Location = new Point(181, 83);
            TxtConnectionString.Name = "TxtConnectionString";
            TxtConnectionString.Size = new Size(631, 23);
            TxtConnectionString.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(813, 82);
            button1.Name = "button1";
            button1.Size = new Size(38, 23);
            button1.TabIndex = 4;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Frm_Configuracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 212);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            Name = "Frm_Configuracoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configurações do Banco de dados";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton salvarToolStripButton;
        private ToolStripButton colarToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton ajudaToolStripButton;
        private GroupBox groupBox1;
        private Label lblTipoBase;
        private ComboBox cbProvider;
        private Label label2;
        private Label label1;
        private TextBox TxtConnectionString;
        private Button button1;
    }
}