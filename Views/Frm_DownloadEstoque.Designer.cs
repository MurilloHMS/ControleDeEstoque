namespace ControleDeEstoqueProauto
{
    partial class Frm_DownloadEstoque
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DownloadEstoque));
            groupBox1 = new GroupBox();
            btnBaixar = new Button();
            dtpDataSelecionada = new DateTimePicker();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBaixar);
            groupBox1.Controls.Add(dtpDataSelecionada);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 162);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Para Download";
            // 
            // btnBaixar
            // 
            btnBaixar.Location = new Point(45, 119);
            btnBaixar.Name = "btnBaixar";
            btnBaixar.Size = new Size(152, 23);
            btnBaixar.TabIndex = 2;
            btnBaixar.Text = "Download";
            btnBaixar.UseVisualStyleBackColor = true;
            btnBaixar.Click += btnBaixar_Click;
            // 
            // dtpDataSelecionada
            // 
            dtpDataSelecionada.Format = DateTimePickerFormat.Short;
            dtpDataSelecionada.ImeMode = ImeMode.NoControl;
            dtpDataSelecionada.Location = new Point(27, 80);
            dtpDataSelecionada.Name = "dtpDataSelecionada";
            dtpDataSelecionada.Size = new Size(200, 23);
            dtpDataSelecionada.TabIndex = 1;
            toolTip1.SetToolTip(dtpDataSelecionada, "Os dados baixados serão referentes a data selecionada, e caso não tenha dados\r\nna data inserida, será coletado da última data anterior");
            // 
            // label1
            // 
            label1.Location = new Point(27, 32);
            label1.Name = "label1";
            label1.Size = new Size(200, 45);
            label1.TabIndex = 0;
            label1.Text = "Selecione uma data abaixo para puxar as informações do estoque";
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 100;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Ajuda";
            // 
            // Frm_DownloadEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 162);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_DownloadEstoque";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Download Dados";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDataSelecionada;
        private Label label1;
        private Button btnBaixar;
        private ToolTip toolTip1;
    }
}