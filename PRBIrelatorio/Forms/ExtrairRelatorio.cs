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
using System.Drawing.Printing;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.text.pdf.draw;
using System.Diagnostics;

namespace PRBIrelatorio.Forms
{
    public partial class ExtrairRelatorio : Form
    {
        public ExtrairRelatorio()
        {
            InitializeComponent();
        }

        static string DataHojeExtrairF(string data)
        {
            string[] dataHojeExtrairSplit = data.Split('/');
            string ano = dataHojeExtrairSplit[2];
            string mes = dataHojeExtrairSplit[1];
            string dia = dataHojeExtrairSplit[0];
            return ano + "/" + mes + "/" + dia;
        }

        static string DataHojeExtrairPontoF(string data)
        {
            string[] dataHojeExtrairSplit = data.Split('/');
            string ano = dataHojeExtrairSplit[2];
            string mes = dataHojeExtrairSplit[1];
            string dia = dataHojeExtrairSplit[0];
            return dia + "." + mes + "." + ano;
        }
        static string DataHojeExtrairMesF(string data)
        {
            string[] dataHojeExtrairSplit = data.Split('/');
            string ano = dataHojeExtrairSplit[2];
            string mes = dataHojeExtrairSplit[1];
            return ano + "/" + mes;
        }
        private void extrairDiario_Click(object sender, EventArgs e)
        {
            if (DataRelatorioExtrair.MaskCompleted)
            {
                if (Directory.Exists(CaminhoDiretorio() + DataHojeExtrairF(DataRelatorioExtrair.Text)))
                {
                    groupBox1.Enabled = false;
                    XDocument root = XDocument.Load(CaminhoDiretorio() + DataHojeExtrairMesF(DataRelatorioExtrair.Text) + "/relatorioMensal.xml");
                    var query = from element in root.Descendants("pessoa").
                                Where(x => x.Attribute("dataAgen").Value == DataRelatorioExtrair.Text)
                                select element;

                    foreach (var es in query)
                    {
                        ListViewItem item = new ListViewItem(es.Element("senhasatg").Value);
                        item.SubItems.Add(es.Element("nome").Value);
                        item.SubItems.Add(es.Element("cpf").Value);
                        item.SubItems.Add(es.Element("compareu").Value);
                        item.SubItems.Add(es.Element("horarioagen").Value);
                        item.SubItems.Add(es.Element("perito").Value);
                        item.SubItems.Add(es.Element("periciafeita").Value);
                        item.SubItems.Add(es.Element("motivo").Value);
                        TextExtraido.Items.Add(item);
                    }

                    //TextExtraido.SizeColumnsToFitDataAndHeaders();
                    for (int i = 0; i < 3; i++) TextExtraido.Columns[i].Width = 110;

                    extrairImprimir.Enabled = true;
                }
                else { MessageBox.Show("Relatório para essa data não foi encontrado."); }
            }
            else { MessageBox.Show("Preencha o campo Data do Relatório para extrair o relatório."); }
        }

        private void extrairImprimir_Click(object sender, EventArgs e)
        {
            if (DataRelatorioExtrair.MaskCompleted)
            {
                if (Directory.Exists(CaminhoDiretorio() + DataHojeExtrairF(DataRelatorioExtrair.Text)))
                {
                    if (!Directory.Exists(CaminhoDiretorio() + DataHojeExtrairF(DataRelatorioExtrair.Text)))
                    {
                        MessageBox.Show("Relatório para essa data não foi encontrado.");
                    }
                    extrairImprimir.Enabled = false;
                    using (FileStream stream = new FileStream(CaminhoDiretorio() + DataHojeExtrairF(DataRelatorioExtrair.Text) + "/" + DataHojeExtrairPontoF(DataRelatorioExtrair.Text) + "-Relatorio.pdf", FileMode.Create))
                    {
                        Paragraph paragrafo = new Paragraph("RELATÓRIO PRBI DO DIA " + DataRelatorioExtrair.Text, iTextSharp.text.FontFactory.GetFont("Calibri", 22));
                        paragrafo.Alignment = Element.ALIGN_CENTER;

                        Document pdfDoc = new Document(PageSize.A4);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(paragrafo);
                        //pdfDoc.Add(new Chunk("\n"));

                        foreach (ListViewItem itemRow in TextExtraido.Items)
                        {
                            int i = 0;
                            List<string> relatorioGeralList = new List<string>();
                            for (i = 0; i < itemRow.SubItems.Count; i++)
                            {
                                relatorioGeralList.Add(itemRow.SubItems[i].Text);
                            }
                            pdfDoc.Add(new Chunk("\n"));
                            LineSeparator lsTest = new LineSeparator();
                            pdfDoc.Add(lsTest);

                            //string respostaConcluida = String.Join(" ", relatorioGeralList.ToArray());
                            Paragraph paragrafoList = new Paragraph(
                                "NOME: " + relatorioGeralList[1] + "\n" +
                                "CPF: " + relatorioGeralList[2] + "                 SENHA: " + relatorioGeralList[0] + "                 HORARIO AGENDADO: " + relatorioGeralList[4] + "\n" +
                                "COMPARECEU A PERÍCIA: " + relatorioGeralList[3] + "                                   PERÍCIA CONCLUÍDA: " + relatorioGeralList[6] + "\n" +
                                "MOTIVO: " + relatorioGeralList[7]
                                , iTextSharp.text.FontFactory.GetFont("Arial", 12));
                            paragrafoList.Alignment = Element.ALIGN_JUSTIFIED;
                            paragrafoList.PaddingTop = 20f;
                            paragrafoList.SpacingBefore = 0f;
                            paragrafoList.SpacingAfter = 1f;
                            paragrafoList.ExtraParagraphSpace = 0f;
                            pdfDoc.Add(paragrafoList);
                        }

                        pdfDoc.Close();
                        stream.Close();
                        MessageBox.Show("PDF criado com o relatório com sucesso. \n" + "Diretorio do relatório: " + CaminhoDiretorio() + DataHojeExtrairF(DataRelatorioExtrair.Text) + "/" + DataHojeExtrairPontoF(DataRelatorioExtrair.Text) + "-Relatorio.pdf");
                        extrairImprimir.Enabled = true;
                        Process.Start(CaminhoDiretorio() + DataHojeExtrairF(DataRelatorioExtrair.Text) + "/" + DataHojeExtrairPontoF(DataRelatorioExtrair.Text) + "-Relatorio.pdf");
                        //Process.Start("Explorer", CaminhoDiretorio() + DataHojeExtrairF(DataRelatorioExtrair.Text));
                        //Close();
                    }
                }
                else { MessageBox.Show("Relatório para essa data não foi encontrado."); }
            }
            else { MessageBox.Show("Preencha o campo Data do Relatório para extrair o relatório."); }
        }

        private void VoltarExtrairMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void extrairLimpa_Click(object sender, EventArgs e)
        {
            TextExtraido.Items.Clear();
            DataRelatorioExtrair.Text = "";
            extrairImprimir.Enabled = false;
            groupBox1.Enabled = true;
        }
    }
}
