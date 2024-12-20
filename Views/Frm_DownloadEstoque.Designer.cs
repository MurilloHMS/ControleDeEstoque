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
            groupBox1 = new GroupBox();
            label1 = new Label();
            dtpDataSelecionada = new DateTimePicker();
            btnBaixar = new Button();
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
            // label1
            // 
            label1.Location = new Point(27, 32);
            label1.Name = "label1";
            label1.Size = new Size(200, 45);
            label1.TabIndex = 0;
            label1.Text = "Selecione uma data abaixo para puxar as informações do estoque";
            // 
            // dtpDataSelecionada
            // 
            dtpDataSelecionada.Location = new Point(27, 80);
            dtpDataSelecionada.Name = "dtpDataSelecionada";
            dtpDataSelecionada.Size = new Size(200, 23);
            dtpDataSelecionada.TabIndex = 1;
            // 
            // btnBaixar
            // 
            btnBaixar.Location = new Point(45, 119);
            btnBaixar.Name = "btnBaixar";
            btnBaixar.Size = new Size(152, 23);
            btnBaixar.TabIndex = 2;
            btnBaixar.Text = "Download";
            btnBaixar.UseVisualStyleBackColor = true;
            btnBaixar.Click += this.btnBaixar_Click;
            // 
            // Frm_DownloadEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 162);
            Controls.Add(groupBox1);
            Name = "Frm_DownloadEstoque";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Download Dados";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpDataSelecionada;
        private Label label1;
        private Button btnBaixar;
    }
}