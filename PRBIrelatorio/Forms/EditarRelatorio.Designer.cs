
namespace PRBIrelatorio.Forms
{
    partial class EditarRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarRelatorio));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ImportanteMotivo = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PEditConcluida = new System.Windows.Forms.ComboBox();
            this.TextEditMotivo = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.VoltarEditMenu = new System.Windows.Forms.Button();
            this.SalvaEditRelatorio = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.DadosEditPor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.LimparBusca = new System.Windows.Forms.Button();
            this.BuscarRelatorio = new System.Windows.Forms.Button();
            this.cpfBuscar = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.DataRelatorioBuscar = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AtendidoEditPeloMedico = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.horarioEditAgendamento = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SenhaEditSAT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.compareuEdit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cpfEditSegurado = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeEditSegurado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExcluirRelatorio = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ImportanteMotivo);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.PEditConcluida);
            this.groupBox4.Controls.Add(this.TextEditMotivo);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Enabled = false;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox4.Location = new System.Drawing.Point(13, 247);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(690, 96);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // ImportanteMotivo
            // 
            this.ImportanteMotivo.AutoSize = true;
            this.ImportanteMotivo.BackColor = System.Drawing.Color.Transparent;
            this.ImportanteMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportanteMotivo.ForeColor = System.Drawing.Color.Red;
            this.ImportanteMotivo.Location = new System.Drawing.Point(203, 18);
            this.ImportanteMotivo.Name = "ImportanteMotivo";
            this.ImportanteMotivo.Size = new System.Drawing.Size(13, 16);
            this.ImportanteMotivo.TabIndex = 20;
            this.ImportanteMotivo.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(91, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 16);
            this.label18.TabIndex = 18;
            this.label18.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(156, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Motivo:";
            // 
            // PEditConcluida
            // 
            this.PEditConcluida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PEditConcluida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PEditConcluida.FormattingEnabled = true;
            this.PEditConcluida.Items.AddRange(new object[] {
            "NÃO",
            "SIM"});
            this.PEditConcluida.Location = new System.Drawing.Point(9, 61);
            this.PEditConcluida.Name = "PEditConcluida";
            this.PEditConcluida.Size = new System.Drawing.Size(132, 23);
            this.PEditConcluida.TabIndex = 12;
            this.PEditConcluida.SelectedIndexChanged += new System.EventHandler(this.PEditConcluida_SelectedIndexChanged);
            // 
            // TextEditMotivo
            // 
            this.TextEditMotivo.BackColor = System.Drawing.SystemColors.Window;
            this.TextEditMotivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextEditMotivo.Location = new System.Drawing.Point(159, 37);
            this.TextEditMotivo.Name = "TextEditMotivo";
            this.TextEditMotivo.Size = new System.Drawing.Size(512, 47);
            this.TextEditMotivo.TabIndex = 19;
            this.TextEditMotivo.Text = "";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 40);
            this.label10.TabIndex = 16;
            this.label10.Text = "Perícia Concluída com sucesso:";
            // 
            // VoltarEditMenu
            // 
            this.VoltarEditMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.VoltarEditMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VoltarEditMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.VoltarEditMenu.ForeColor = System.Drawing.Color.White;
            this.VoltarEditMenu.Location = new System.Drawing.Point(373, 434);
            this.VoltarEditMenu.Name = "VoltarEditMenu";
            this.VoltarEditMenu.Size = new System.Drawing.Size(106, 31);
            this.VoltarEditMenu.TabIndex = 12;
            this.VoltarEditMenu.Text = "Voltar";
            this.VoltarEditMenu.UseVisualStyleBackColor = false;
            this.VoltarEditMenu.Click += new System.EventHandler(this.VoltarEditMenu_Click);
            // 
            // SalvaEditRelatorio
            // 
            this.SalvaEditRelatorio.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.SalvaEditRelatorio.Enabled = false;
            this.SalvaEditRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SalvaEditRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.SalvaEditRelatorio.ForeColor = System.Drawing.Color.White;
            this.SalvaEditRelatorio.Location = new System.Drawing.Point(597, 434);
            this.SalvaEditRelatorio.Name = "SalvaEditRelatorio";
            this.SalvaEditRelatorio.Size = new System.Drawing.Size(106, 31);
            this.SalvaEditRelatorio.TabIndex = 11;
            this.SalvaEditRelatorio.Text = "Salvar";
            this.SalvaEditRelatorio.UseVisualStyleBackColor = false;
            this.SalvaEditRelatorio.Click += new System.EventHandler(this.SalvaEditRelatorio_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.DadosEditPor);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Enabled = false;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox3.Location = new System.Drawing.Point(13, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(690, 79);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(156, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 16);
            this.label20.TabIndex = 21;
            this.label20.Text = "*";
            // 
            // DadosEditPor
            // 
            this.DadosEditPor.Location = new System.Drawing.Point(9, 36);
            this.DadosEditPor.Name = "DadosEditPor";
            this.DadosEditPor.Size = new System.Drawing.Size(662, 22);
            this.DadosEditPor.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Dados preenchidos por:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.LimparBusca);
            this.groupBox2.Controls.Add(this.BuscarRelatorio);
            this.groupBox2.Controls.Add(this.cpfBuscar);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.DataRelatorioBuscar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(13, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 67);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(269, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 16);
            this.label22.TabIndex = 18;
            this.label22.Text = "*";
            // 
            // LimparBusca
            // 
            this.LimparBusca.BackColor = System.Drawing.Color.BurlyWood;
            this.LimparBusca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LimparBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LimparBusca.ForeColor = System.Drawing.Color.White;
            this.LimparBusca.Location = new System.Drawing.Point(360, 13);
            this.LimparBusca.Name = "LimparBusca";
            this.LimparBusca.Size = new System.Drawing.Size(60, 22);
            this.LimparBusca.TabIndex = 23;
            this.LimparBusca.Text = "Limpar";
            this.LimparBusca.UseVisualStyleBackColor = false;
            this.LimparBusca.Click += new System.EventHandler(this.LimparBusca_Click);
            // 
            // BuscarRelatorio
            // 
            this.BuscarRelatorio.BackColor = System.Drawing.Color.LightGray;
            this.BuscarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuscarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.BuscarRelatorio.ForeColor = System.Drawing.Color.White;
            this.BuscarRelatorio.Location = new System.Drawing.Point(360, 39);
            this.BuscarRelatorio.Name = "BuscarRelatorio";
            this.BuscarRelatorio.Size = new System.Drawing.Size(60, 22);
            this.BuscarRelatorio.TabIndex = 14;
            this.BuscarRelatorio.Text = "Buscar";
            this.BuscarRelatorio.UseVisualStyleBackColor = false;
            this.BuscarRelatorio.Click += new System.EventHandler(this.BuscarRelatorio_Click);
            // 
            // cpfBuscar
            // 
            this.cpfBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfBuscar.Location = new System.Drawing.Point(159, 35);
            this.cpfBuscar.Mask = "000.000.000-00";
            this.cpfBuscar.Name = "cpfBuscar";
            this.cpfBuscar.Size = new System.Drawing.Size(168, 22);
            this.cpfBuscar.TabIndex = 18;
            this.cpfBuscar.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(156, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 16);
            this.label19.TabIndex = 18;
            this.label19.Text = "CPF do segurado:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(108, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 16);
            this.label21.TabIndex = 22;
            this.label21.Text = "*";
            // 
            // DataRelatorioBuscar
            // 
            this.DataRelatorioBuscar.Location = new System.Drawing.Point(9, 35);
            this.DataRelatorioBuscar.Mask = "00/00/0000";
            this.DataRelatorioBuscar.Name = "DataRelatorioBuscar";
            this.DataRelatorioBuscar.Size = new System.Drawing.Size(104, 22);
            this.DataRelatorioBuscar.TabIndex = 14;
            this.DataRelatorioBuscar.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Relatório do dia:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(691, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "PRBI Editar Relatório";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.AtendidoEditPeloMedico);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.horarioEditAgendamento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SenhaEditSAT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.compareuEdit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cpfEditSegurado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nomeEditSegurado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(13, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 126);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(622, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 16);
            this.label17.TabIndex = 17;
            this.label17.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(476, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 16);
            this.label16.TabIndex = 16;
            this.label16.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(296, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(137, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(613, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(128, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "*";
            // 
            // AtendidoEditPeloMedico
            // 
            this.AtendidoEditPeloMedico.Location = new System.Drawing.Point(503, 89);
            this.AtendidoEditPeloMedico.Name = "AtendidoEditPeloMedico";
            this.AtendidoEditPeloMedico.Size = new System.Drawing.Size(168, 22);
            this.AtendidoEditPeloMedico.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(500, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Perito(a) Médico(a):";
            // 
            // horarioEditAgendamento
            // 
            this.horarioEditAgendamento.Location = new System.Drawing.Point(322, 89);
            this.horarioEditAgendamento.Mask = "00:00";
            this.horarioEditAgendamento.Name = "horarioEditAgendamento";
            this.horarioEditAgendamento.Size = new System.Drawing.Size(162, 22);
            this.horarioEditAgendamento.TabIndex = 9;
            this.horarioEditAgendamento.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Horario de Agendamento:";
            // 
            // SenhaEditSAT
            // 
            this.SenhaEditSAT.Location = new System.Drawing.Point(159, 89);
            this.SenhaEditSAT.Name = "SenhaEditSAT";
            this.SenhaEditSAT.Size = new System.Drawing.Size(142, 22);
            this.SenhaEditSAT.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Senha gerada no SAT:";
            // 
            // compareuEdit
            // 
            this.compareuEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compareuEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compareuEdit.FormattingEnabled = true;
            this.compareuEdit.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.compareuEdit.Location = new System.Drawing.Point(9, 89);
            this.compareuEdit.Name = "compareuEdit";
            this.compareuEdit.Size = new System.Drawing.Size(132, 23);
            this.compareuEdit.TabIndex = 5;
            this.compareuEdit.SelectedIndexChanged += new System.EventHandler(this.compareuEdit_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Segurado compareu:";
            // 
            // cpfEditSegurado
            // 
            this.cpfEditSegurado.Enabled = false;
            this.cpfEditSegurado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfEditSegurado.Location = new System.Drawing.Point(503, 35);
            this.cpfEditSegurado.Mask = "000.000.000-00";
            this.cpfEditSegurado.Name = "cpfEditSegurado";
            this.cpfEditSegurado.Size = new System.Drawing.Size(168, 22);
            this.cpfEditSegurado.TabIndex = 3;
            this.cpfEditSegurado.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF do segurado:";
            // 
            // nomeEditSegurado
            // 
            this.nomeEditSegurado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeEditSegurado.Location = new System.Drawing.Point(9, 35);
            this.nomeEditSegurado.Name = "nomeEditSegurado";
            this.nomeEditSegurado.Size = new System.Drawing.Size(475, 22);
            this.nomeEditSegurado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do segurado:";
            // 
            // ExcluirRelatorio
            // 
            this.ExcluirRelatorio.BackColor = System.Drawing.Color.Red;
            this.ExcluirRelatorio.Enabled = false;
            this.ExcluirRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExcluirRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ExcluirRelatorio.ForeColor = System.Drawing.Color.White;
            this.ExcluirRelatorio.Location = new System.Drawing.Point(485, 434);
            this.ExcluirRelatorio.Name = "ExcluirRelatorio";
            this.ExcluirRelatorio.Size = new System.Drawing.Size(106, 31);
            this.ExcluirRelatorio.TabIndex = 14;
            this.ExcluirRelatorio.Text = "Excluir";
            this.ExcluirRelatorio.UseVisualStyleBackColor = false;
            this.ExcluirRelatorio.Click += new System.EventHandler(this.ExcluirRelatorio_Click);
            // 
            // EditarRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 478);
            this.Controls.Add(this.ExcluirRelatorio);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.VoltarEditMenu);
            this.Controls.Add(this.SalvaEditRelatorio);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRBI Editar Relatório";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label ImportanteMotivo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox PEditConcluida;
        private System.Windows.Forms.RichTextBox TextEditMotivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button VoltarEditMenu;
        private System.Windows.Forms.Button SalvaEditRelatorio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox DadosEditPor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.MaskedTextBox DataRelatorioBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox AtendidoEditPeloMedico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox horarioEditAgendamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SenhaEditSAT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox compareuEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox cpfEditSegurado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomeEditSegurado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LimparBusca;
        private System.Windows.Forms.Button BuscarRelatorio;
        private System.Windows.Forms.MaskedTextBox cpfBuscar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button ExcluirRelatorio;
    }
}