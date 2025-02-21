
using ControleDeEstoqueProauto.Data;
using ControleDeEstoqueProauto.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeEstoqueProauto
{
    public partial class Frm_Configuracoes : Form
    {
        public Frm_Configuracoes()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            string currentProvider = ConfigurationManagerHelper.GetSetting("DatabaseProvider");
            cbProvider.SelectedItem = currentProvider ?? "SQLite";

            string connectionString = ConfigurationManagerHelper.GetConnectionString(cbProvider.SelectedItem.ToString());
            TxtConnectionString.Text = connectionString;
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            string selectedProvider = cbProvider.SelectedItem.ToString();
            string newConnectionString = TxtConnectionString.Text;

            ConfigurationManagerHelper.SetConnectionString(selectedProvider, newConnectionString);
            ConfigurationManagerHelper.SetDatabaseProvider(selectedProvider);

            MessageBox.Show("Configurações salvas com sucesso!");
        }

        private void cbProvider_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedProvider = cbProvider.SelectedItem.ToString();
            string connectionString = ConfigurationManagerHelper.GetConnectionString(selectedProvider);
            TxtConnectionString.Text = connectionString;
            lblTipoBase.Text = cbProvider.SelectedItem.ToString() == "SQLite" ? "BASE PRODUÇÃO" : "BASE DE TESTE";
            lblTipoBase.ForeColor = cbProvider.SelectedItem.ToString() == "SQLite" ? Color.Green : Color.Red;
        }

        private void colarToolStripButton_Click(object sender, EventArgs e)
        {
            AppDbContext appDbContext = new AppDbContext();
            appDbContext.Database.EnsureCreatedAsync();
            appDbContext.Database.MigrateAsync();

            MessageBox.Show("Banco de Dados Criado com sucesso!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog()
                {
                    Title = "Selecione o banco de dados",
                    Multiselect = false,
                    Filter = "SQLite (*.db)|*.db"
                };
                string filepath = string.Empty;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filepath = ofd.FileName;
                }

                TxtConnectionString.Text = $@"Data Source={filepath};Cache=Shared";
            }catch(Exception ex)
            {
                throw;
            }
        }
    }
}
