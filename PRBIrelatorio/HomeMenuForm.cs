using PRBIrelatorio.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static PRBIrelatorio.ReadConfig;

namespace PRBIrelatorio
{
    public partial class PRBI_MenuForm : Form
    {
        public PRBI_MenuForm()
        {
            InitializeComponent();
        }

        private void criar_relatorio_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Caminho do diretorio: " + CaminhoDiretorio());
            //MessageBox.Show("Caminho do diretorio Settings: " + ConfigurationManager.AppSettings["Diretorio"]);
            CriarRelatorio relatorio = new CriarRelatorio();
            relatorio.Show();
        }

        private void editar_relatorio_Click(object sender, EventArgs e)
        {
            EditarRelatorio editR = new EditarRelatorio();
            editR.Show();
        }

        private void config_relatorio_Click(object sender, EventArgs e)
        {
            ConfigRelatorio configR = new ConfigRelatorio();
            configR.Show();
        }

        private void extrair_relatorio_Click(object sender, EventArgs e)
        {
            ExtrairRelatorio extrairR = new ExtrairRelatorio();
            extrairR.Show();
        }
    }
}
