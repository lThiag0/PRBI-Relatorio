using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static PRBIrelatorio.ReadConfig;

namespace PRBIrelatorio.Forms
{
    public partial class CriarRelatorio : Form
    {
        string dataHoje = DateTime.Now.ToString(new CultureInfo("pt-BR", true).DateTimeFormat.ShortDatePattern);
        public CriarRelatorio()
        {
            InitializeComponent();
            DataRelatorio.Text = dataHoje;
            PConcluida.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PConcluida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PConcluida.SelectedIndex == 0) {
                // Não foi Concluida com sucesso
                TextMotivo.Enabled = true;
                ImportanteMotivo.Enabled = true;
                TextMotivo.Text = "";
            } else
            {
                // Foi concluida com sucesso
                TextMotivo.Enabled = false;
                ImportanteMotivo.Enabled = false;
                TextMotivo.Text = "Perícia médica concluída.";
            }
        }

        private Boolean CamposPreenchidos() {
            if (DataRelatorio.Text != "" &&
                nomeSegurado.Text != "" &&
                cpfSegurado.Text != "" &&
                comboBox1.SelectedIndex >= 0 &&
                PConcluida.SelectedIndex >= 0 &&
                DadosPor.Text != "")
            {
                return true;
            } else { return false; }
        }

        private void CriarDiretorio(string NomePath) {
            try
            {
                if (Directory.Exists(CaminhoDiretorio() + NomePath))
                {
                    //MessageBox.Show("Esse diretorio já existe.");
                }
                else
                {
                    DirectoryInfo di = Directory.CreateDirectory(CaminhoDiretorio() + NomePath);
                    //MessageBox.Show("O diretório foi criado com sucesso em: " + Directory.GetCreationTime(CaminhoDiretorio() + NomePath));
                }

                //di.Delete();
                //MessageBox.Show("O diretório foi excluído com sucesso.");
            }
            catch (Exception e)
            {
                MessageBox.Show("O processo falhou: {0} ", e.ToString());
            }
        }

        static string Reverse(string text)
        {
            char[] charArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reverse += charArray[i];
            }
            return reverse;
        }

        private void SalvaRelatorio_Click(object sender, EventArgs e)
        {
            //DateTime aDate = DateTime.Now;
            string[] dataHojeSplit = DataRelatorio.Text.Split('/');
            string ano = dataHojeSplit[2];
            string mes = dataHojeSplit[1];
            string dia = dataHojeSplit[0];
            //CriarDiretorio(dia+"."+ mes+"."+ ano);
            if (CamposPreenchidos())
            {
                CriarDiretorio(ano+"/"+mes+"/"+dia);

                XDocument docLoad = XDocument.Load(CaminhoDiretorio() + ano + "/" + mes + "/relatorioMensal.xml");
                XElement root = new XElement("pessoa");
                root.Add(new XAttribute("idcpf", cpfSegurado.Text));
                root.Add(new XAttribute("dataAgen", DataRelatorio.Text));
                root.Add(new XElement("nome", nomeSegurado.Text));
                root.Add(new XElement("cpf", cpfSegurado.Text));
                root.Add(new XElement("compareu", comboBox1.Text));
                root.Add(new XElement("senhasatg", SenhaSAT.Text));
                root.Add(new XElement("horarioagen", horarioAgendamento.Text));
                root.Add(new XElement("perito", AtendidoPeloMedico.Text));
                root.Add(new XElement("periciafeita", nomeSegurado.Text));
                root.Add(new XElement("motivo", TextMotivo.Text));
                root.Add(new XElement("por", DadosPor.Text));
                docLoad.Element("root").Add(root);
                docLoad.Save(CaminhoDiretorio() + ano + "/" + mes + "/relatorioMensal.xml");

                //Novo documento
                XDocument doc = new XDocument();
                doc.Add(new XComment("Início"));
                doc.Add(new XElement("root",
                    new XElement("pessoa",
                        new XAttribute("idcpf", cpfSegurado.Text),
                        new XAttribute("dataAgen", DataRelatorio.Text),
                        new XElement("nome", nomeSegurado.Text),
                        new XElement("cpf", cpfSegurado.Text),
                        new XElement("compareu", comboBox1.Text),
                        new XElement("senhasatg", SenhaSAT.Text),
                        new XElement("horarioagen", horarioAgendamento.Text),
                        new XElement("perito", AtendidoPeloMedico.Text),
                        new XElement("periciafeita", PConcluida.Text),
                        new XElement("motivo", TextMotivo.Text),
                        new XElement("por", DadosPor.Text)
                        )));
                doc.Add(new XComment("Fim"));
                doc.Save(CaminhoDiretorio() + ano + "/" + mes + "/" + dia + "/" + cpfSegurado.Text + ".xml");

                MessageBox.Show("Relatório criado com sucesso!");
                Close();
            }
            else {
                MessageBox.Show("Preencha todos os dados necessarios para salva esse relatório.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                // Compareceu
                groupBox4.Enabled = true;
                SenhaSAT.Enabled = true;
                horarioAgendamento.Enabled = true;
                AtendidoPeloMedico.Enabled = true;
                SenhaSAT.Text = "";
                horarioAgendamento.Text = "";
                AtendidoPeloMedico.Text = "";
                TextMotivo.Text = "";
            }
            else
            {
                // Não Compareceu
                groupBox4.Enabled = false;
                SenhaSAT.Enabled = false;
                horarioAgendamento.Enabled = false;
                AtendidoPeloMedico.Enabled = false;
                SenhaSAT.Text = "H0000";
                horarioAgendamento.Text = "00:00";
                AtendidoPeloMedico.Text = "";
                PConcluida.SelectedIndex = 0;
                TextMotivo.Text = "Segurado(a) não compareceu na perícia médica.";
            }
        }

        private void VoltarMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
