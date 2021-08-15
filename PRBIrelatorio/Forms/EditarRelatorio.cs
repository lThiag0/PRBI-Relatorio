using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static PRBIrelatorio.ReadConfig;

namespace PRBIrelatorio.Forms
{
    public partial class EditarRelatorio : Form
    {
        public EditarRelatorio()
        {
            InitializeComponent();
        }

        static string DataHojeEditF(string data)
        {
            string[] dataHojeEditSplit = data.Split('/');
            string ano = dataHojeEditSplit[2];
            string mes = dataHojeEditSplit[1];
            string dia = dataHojeEditSplit[0];
            return ano + "/" + mes + "/" + dia;
        }

        static string DataHojeEditFMes(string data)
        {
            string[] dataHojeEditSplit = data.Split('/');
            string ano = dataHojeEditSplit[2];
            string mes = dataHojeEditSplit[1];
            return ano + "/" + mes;
        }

        private void BuscarRelatorio_Click(object sender, EventArgs e)
        {
            if (DataRelatorioBuscar.MaskCompleted && cpfBuscar.MaskCompleted)
            {
                if (File.Exists(CaminhoDiretorio() + DataHojeEditF(DataRelatorioBuscar.Text) + "/" + cpfBuscar.Text + ".xml"))
                {
                    // O arquivo existe!

                    XDocument doc = XDocument.Load(CaminhoDiretorio() + DataHojeEditF(DataRelatorioBuscar.Text) + "/" + cpfBuscar.Text + ".xml");
                    var prods = from p in doc.Descendants("pessoa")
                                select new
                                {
                                    edit_nome = p.Element("nome").Value,
                                    edit_cpf = p.Element("cpf").Value,
                                    edit_compareu = p.Element("compareu").Value,
                                    edit_senhasatg = p.Element("senhasatg").Value,
                                    edit_horarioagen = p.Element("horarioagen").Value,
                                    edit_perito = p.Element("perito").Value,
                                    edit_periciafeita = p.Element("periciafeita").Value,
                                    edit_motivo = p.Element("motivo").Value,
                                    edit_por = p.Element("por").Value,
                                };

                    foreach (var p in prods)
                    {
                        nomeEditSegurado.Text = p.edit_nome;
                        cpfEditSegurado.Text = p.edit_cpf;
                        compareuEdit.Text = p.edit_compareu;
                        SenhaEditSAT.Text = p.edit_senhasatg;
                        horarioEditAgendamento.Text = p.edit_horarioagen;
                        AtendidoEditPeloMedico.Text = p.edit_perito;
                        PEditConcluida.Text = p.edit_periciafeita;
                        TextEditMotivo.Text = p.edit_motivo;
                        DadosEditPor.Text = p.edit_por;
                    }

                    groupBox2.Enabled = false;
                    groupBox1.Enabled = true;
                    groupBox4.Enabled = true;
                    groupBox3.Enabled = true;
                    SalvaEditRelatorio.Enabled = true;
                    ExcluirRelatorio.Enabled = true;

                }
                else { MessageBox.Show("Relatório para essa data com esse CPF não foi encontrado."); }
            }
            else { MessageBox.Show("Preencha os campos Data do Relatório e CPF do segurado para busca o relatório."); }
        }

        private void PEditConcluida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PEditConcluida.SelectedIndex == 0)
            {
                // Não foi Conluida com sucesso
                TextEditMotivo.Enabled = true;
                ImportanteMotivo.Enabled = true;
                TextEditMotivo.Text = "";
            }
            else
            {
                // Foi concluida com sucesso
                TextEditMotivo.Enabled = false;
                ImportanteMotivo.Enabled = false;
                TextEditMotivo.Text = "Perícia médica concluída.";
            }
        }

        private Boolean CamposPreenchidosEdit()
        {
            if (nomeEditSegurado.Text != "" &&
                cpfEditSegurado.Text != "" &&
                compareuEdit.SelectedIndex >= 0 &&
                PEditConcluida.SelectedIndex >= 0 &&
                DadosEditPor.Text != "")
            {
                return true;
            }
            else { return false; }
        }

        private void SalvaEditRelatorio_Click(object sender, EventArgs e)
        {
            if (CamposPreenchidosEdit())
            {

                XDocument xDoc = XDocument.Load(CaminhoDiretorio() + DataHojeEditFMes(DataRelatorioBuscar.Text) + "/relatorioMensal.xml");
                var _idcpf = xDoc.Root.Descendants("pessoa").FirstOrDefault(_ => _.Attribute("idcpf").Value.Equals(cpfBuscar.Text));
                if (_idcpf is XElement)
                {

                    //Element
                    _idcpf.Element("nome").Value = nomeEditSegurado.Text;
                    _idcpf.Element("cpf").Value = cpfEditSegurado.Text;
                    _idcpf.Element("compareu").Value = compareuEdit.Text;
                    _idcpf.Element("senhasatg").Value = SenhaEditSAT.Text;
                    _idcpf.Element("horarioagen").Value = horarioEditAgendamento.Text;
                    _idcpf.Element("perito").Value = AtendidoEditPeloMedico.Text;
                    _idcpf.Element("periciafeita").Value = PEditConcluida.Text;
                    _idcpf.Element("motivo").Value = TextEditMotivo.Text;
                    _idcpf.Element("por").Value = DadosEditPor.Text;

                    xDoc.Save(CaminhoDiretorio() + DataHojeEditFMes(DataRelatorioBuscar.Text) + "/relatorioMensal.xml");
                }
                else
                {
                    MessageBox.Show("Relatório com o CPF não encontrado.");
                }

                //Novo documento
                XDocument doc = new XDocument();
                doc.Add(new XComment("Início"));
                doc.Add(new XElement("root",
                    new XElement("pessoa",
                        new XAttribute("idcpf", cpfEditSegurado.Text),
                        new XAttribute("dataAgen", DataRelatorioBuscar.Text),
                        new XElement("nome", nomeEditSegurado.Text),
                        new XElement("cpf", cpfEditSegurado.Text),
                        new XElement("compareu", compareuEdit.Text),
                        new XElement("senhasatg", SenhaEditSAT.Text),
                        new XElement("horarioagen", horarioEditAgendamento.Text),
                        new XElement("perito", AtendidoEditPeloMedico.Text),
                        new XElement("periciafeita", PEditConcluida.Text),
                        new XElement("motivo", TextEditMotivo.Text),
                        new XElement("por", DadosEditPor.Text)
                        )));
                doc.Add(new XComment("Fim"));
                doc.Save(CaminhoDiretorio() + DataHojeEditF(DataRelatorioBuscar.Text) + "/" + cpfBuscar.Text + ".xml");

                MessageBox.Show("Relatório editado com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os dados necessarios para salva essa edição do relatório.");
            }
        }

        private void ExcluirRelatorio_Click(object sender, EventArgs e)
        {
            File.Delete(CaminhoDiretorio() + DataHojeEditF(DataRelatorioBuscar.Text) + "/" + cpfBuscar.Text + ".xml");

            XDocument xDoc = XDocument.Load(CaminhoDiretorio() + DataHojeEditFMes(DataRelatorioBuscar.Text) + "/relatorioMensal.xml");
            var _idcpf = xDoc.Root.Descendants("pessoa").FirstOrDefault(_ => _.Attribute("idcpf").Value.Equals(cpfBuscar.Text));
            if (_idcpf is XElement)
            {
                _idcpf.Remove();
                xDoc.Save(CaminhoDiretorio() + DataHojeEditFMes(DataRelatorioBuscar.Text) + "/relatorioMensal.xml");
            }
            else
            {
                MessageBox.Show("Relatório com o CPF não encontrado.");
            }

            MessageBox.Show("Relatório deletado com sucesso.");
            Close();
        }

        private void compareuEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (compareuEdit.SelectedIndex == 0)
            {
                // Compareceu
                groupBox4.Enabled = true;
                SenhaEditSAT.Enabled = true;
                horarioEditAgendamento.Enabled = true;
                AtendidoEditPeloMedico.Enabled = true;
                SenhaEditSAT.Text = "";
                horarioEditAgendamento.Text = "";
                AtendidoEditPeloMedico.Text = "";
                TextEditMotivo.Text = "";
            }
            else
            {
                // Não Compareceu
                groupBox4.Enabled = false;
                SenhaEditSAT.Enabled = false;
                horarioEditAgendamento.Enabled = false;
                AtendidoEditPeloMedico.Enabled = false;
                SenhaEditSAT.Text = "H0000";
                horarioEditAgendamento.Text = "00:00";
                AtendidoEditPeloMedico.Text = "";
                PEditConcluida.SelectedIndex = 0;
                TextEditMotivo.Text = "Segurado(a) não compareceu na perícia médica.";
            }
        }

        private void VoltarEditMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimparBusca_Click(object sender, EventArgs e)
        {
            DataRelatorioBuscar.Text = "";
            cpfBuscar.Text = "";
        }
    }
}
