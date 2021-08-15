using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRBIrelatorio.Forms
{
    public partial class ConfigRelatorio : Form
    {
        public ConfigRelatorio()
        {
            InitializeComponent();
            diretorioConfig.Text = ConfigurationManager.AppSettings["Diretorio"];
        }

        private void VoltarConfigMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    diretorioConfig.Text = fbd.SelectedPath;
                    //MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
        }

        private void SalvaConfig_Click(object sender, EventArgs e)
        {
            if (diretorioConfig.Text != "") {
                //ConfigurationManager.AppSettings["Diretorio"] = diretorioConfig.Text + "/";
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config.AppSettings.Settings["Diretorio"].Value = diretorioConfig.Text + "/";
                config.Save(ConfigurationSaveMode.Minimal);
                ConfigurationManager.RefreshSection("appSettings");
                MessageBox.Show("Novo diretorio principal configurado com sucesso: " + ConfigurationManager.AppSettings["Diretorio"]);
                Close();
            } else { MessageBox.Show("Preencha o caminho do diretorio principal."); }
        }
    }
}
