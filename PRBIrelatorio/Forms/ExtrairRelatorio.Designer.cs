
namespace PRBIrelatorio.Forms
{
    partial class ExtrairRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtrairRelatorio));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DataRelatorioExtrair = new System.Windows.Forms.MaskedTextBox();
            this.extrairAnual = new System.Windows.Forms.Button();
            this.extrairSemanal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.extrairDiario = new System.Windows.Forms.Button();
            this.extrairImprimir = new System.Windows.Forms.Button();
            this.VoltarExtrairMenu = new System.Windows.Forms.Button();
            this.TextExtraido = new System.Windows.Forms.ListView();
            this.columnSenhaSAT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNomeS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCpfS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCompareceuS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHorarioAg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPerito = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPericiaC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMotivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.extrairMensal = new System.Windows.Forms.Button();
            this.extrairLimpa = new System.Windows.Forms.Button();
            this.extrairAbrirPasta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(691, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "PRBI Extrair Relatório";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.extrairMensal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.DataRelatorioExtrair);
            this.groupBox1.Controls.Add(this.extrairAnual);
            this.groupBox1.Controls.Add(this.extrairSemanal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.extrairDiario);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 79);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(573, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Relatório do dia:";
            // 
            // DataRelatorioExtrair
            // 
            this.DataRelatorioExtrair.Location = new System.Drawing.Point(576, 47);
            this.DataRelatorioExtrair.Mask = "00/00/0000";
            this.DataRelatorioExtrair.Name = "DataRelatorioExtrair";
            this.DataRelatorioExtrair.Size = new System.Drawing.Size(104, 22);
            this.DataRelatorioExtrair.TabIndex = 15;
            this.DataRelatorioExtrair.ValidatingType = typeof(System.DateTime);
            // 
            // extrairAnual
            // 
            this.extrairAnual.Enabled = false;
            this.extrairAnual.Location = new System.Drawing.Point(334, 38);
            this.extrairAnual.Name = "extrairAnual";
            this.extrairAnual.Size = new System.Drawing.Size(103, 29);
            this.extrairAnual.TabIndex = 16;
            this.extrairAnual.Text = "Anual";
            this.extrairAnual.UseVisualStyleBackColor = true;
            // 
            // extrairSemanal
            // 
            this.extrairSemanal.Enabled = false;
            this.extrairSemanal.Location = new System.Drawing.Point(225, 38);
            this.extrairSemanal.Name = "extrairSemanal";
            this.extrairSemanal.Size = new System.Drawing.Size(103, 29);
            this.extrairSemanal.TabIndex = 15;
            this.extrairSemanal.Text = "Semanal";
            this.extrairSemanal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Extrair relatório:";
            // 
            // extrairDiario
            // 
            this.extrairDiario.Location = new System.Drawing.Point(7, 38);
            this.extrairDiario.Name = "extrairDiario";
            this.extrairDiario.Size = new System.Drawing.Size(103, 29);
            this.extrairDiario.TabIndex = 0;
            this.extrairDiario.Text = "Diário";
            this.extrairDiario.UseVisualStyleBackColor = true;
            this.extrairDiario.Click += new System.EventHandler(this.extrairDiario_Click);
            // 
            // extrairImprimir
            // 
            this.extrairImprimir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.extrairImprimir.Enabled = false;
            this.extrairImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.extrairImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.extrairImprimir.ForeColor = System.Drawing.Color.White;
            this.extrairImprimir.Location = new System.Drawing.Point(597, 429);
            this.extrairImprimir.Name = "extrairImprimir";
            this.extrairImprimir.Size = new System.Drawing.Size(106, 31);
            this.extrairImprimir.TabIndex = 13;
            this.extrairImprimir.Text = "Extrair";
            this.extrairImprimir.UseVisualStyleBackColor = false;
            this.extrairImprimir.Click += new System.EventHandler(this.extrairImprimir_Click);
            // 
            // VoltarExtrairMenu
            // 
            this.VoltarExtrairMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.VoltarExtrairMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VoltarExtrairMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.VoltarExtrairMenu.ForeColor = System.Drawing.Color.White;
            this.VoltarExtrairMenu.Location = new System.Drawing.Point(373, 429);
            this.VoltarExtrairMenu.Name = "VoltarExtrairMenu";
            this.VoltarExtrairMenu.Size = new System.Drawing.Size(106, 31);
            this.VoltarExtrairMenu.TabIndex = 14;
            this.VoltarExtrairMenu.Text = "Voltar";
            this.VoltarExtrairMenu.UseVisualStyleBackColor = false;
            this.VoltarExtrairMenu.Click += new System.EventHandler(this.VoltarExtrairMenu_Click);
            // 
            // TextExtraido
            // 
            this.TextExtraido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSenhaSAT,
            this.columnNomeS,
            this.columnCpfS,
            this.columnCompareceuS,
            this.columnHorarioAg,
            this.columnPerito,
            this.columnPericiaC,
            this.columnMotivo});
            this.TextExtraido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextExtraido.FullRowSelect = true;
            this.TextExtraido.GridLines = true;
            this.TextExtraido.HideSelection = false;
            this.TextExtraido.Location = new System.Drawing.Point(17, 126);
            this.TextExtraido.MultiSelect = false;
            this.TextExtraido.Name = "TextExtraido";
            this.TextExtraido.Size = new System.Drawing.Size(686, 297);
            this.TextExtraido.TabIndex = 15;
            this.TextExtraido.UseCompatibleStateImageBehavior = false;
            this.TextExtraido.View = System.Windows.Forms.View.Details;
            // 
            // columnSenhaSAT
            // 
            this.columnSenhaSAT.Text = "Senha SAT";
            this.columnSenhaSAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSenhaSAT.Width = 90;
            // 
            // columnNomeS
            // 
            this.columnNomeS.Text = "Nome";
            this.columnNomeS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnNomeS.Width = 300;
            // 
            // columnCpfS
            // 
            this.columnCpfS.Text = "CPF";
            this.columnCpfS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCpfS.Width = 200;
            // 
            // columnCompareceuS
            // 
            this.columnCompareceuS.Text = "Compareceu";
            this.columnCompareceuS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCompareceuS.Width = 100;
            // 
            // columnHorarioAg
            // 
            this.columnHorarioAg.Text = "Horario Agendado";
            this.columnHorarioAg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHorarioAg.Width = 130;
            // 
            // columnPerito
            // 
            this.columnPerito.Text = "Períto Médico";
            this.columnPerito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPerito.Width = 100;
            // 
            // columnPericiaC
            // 
            this.columnPericiaC.Text = "Perícia Concluída";
            this.columnPericiaC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPericiaC.Width = 200;
            // 
            // columnMotivo
            // 
            this.columnMotivo.Text = "Motivo";
            this.columnMotivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnMotivo.Width = 300;
            // 
            // extrairMensal
            // 
            this.extrairMensal.Enabled = false;
            this.extrairMensal.Location = new System.Drawing.Point(116, 38);
            this.extrairMensal.Name = "extrairMensal";
            this.extrairMensal.Size = new System.Drawing.Size(103, 29);
            this.extrairMensal.TabIndex = 18;
            this.extrairMensal.Text = "Mensal";
            this.extrairMensal.UseVisualStyleBackColor = true;
            // 
            // extrairLimpa
            // 
            this.extrairLimpa.BackColor = System.Drawing.Color.LightSlateGray;
            this.extrairLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.extrairLimpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.extrairLimpa.ForeColor = System.Drawing.Color.White;
            this.extrairLimpa.Location = new System.Drawing.Point(485, 429);
            this.extrairLimpa.Name = "extrairLimpa";
            this.extrairLimpa.Size = new System.Drawing.Size(106, 31);
            this.extrairLimpa.TabIndex = 16;
            this.extrairLimpa.Text = "Limpar";
            this.extrairLimpa.UseVisualStyleBackColor = false;
            this.extrairLimpa.Click += new System.EventHandler(this.extrairLimpa_Click);
            // 
            // extrairAbrirPasta
            // 
            this.extrairAbrirPasta.BackColor = System.Drawing.Color.BurlyWood;
            this.extrairAbrirPasta.Enabled = false;
            this.extrairAbrirPasta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.extrairAbrirPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.extrairAbrirPasta.ForeColor = System.Drawing.Color.White;
            this.extrairAbrirPasta.Location = new System.Drawing.Point(17, 429);
            this.extrairAbrirPasta.Name = "extrairAbrirPasta";
            this.extrairAbrirPasta.Size = new System.Drawing.Size(174, 31);
            this.extrairAbrirPasta.TabIndex = 17;
            this.extrairAbrirPasta.Text = "Abrir pasta de relatórios";
            this.extrairAbrirPasta.UseVisualStyleBackColor = false;
            this.extrairAbrirPasta.Visible = false;
            // 
            // ExtrairRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 471);
            this.Controls.Add(this.extrairAbrirPasta);
            this.Controls.Add(this.extrairLimpa);
            this.Controls.Add(this.TextExtraido);
            this.Controls.Add(this.VoltarExtrairMenu);
            this.Controls.Add(this.extrairImprimir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExtrairRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRBI Extrair Relatório";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button extrairDiario;
        private System.Windows.Forms.Button extrairAnual;
        private System.Windows.Forms.Button extrairSemanal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button extrairImprimir;
        private System.Windows.Forms.Button VoltarExtrairMenu;
        private System.Windows.Forms.MaskedTextBox DataRelatorioExtrair;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView TextExtraido;
        private System.Windows.Forms.ColumnHeader columnNomeS;
        private System.Windows.Forms.ColumnHeader columnCpfS;
        private System.Windows.Forms.ColumnHeader columnCompareceuS;
        private System.Windows.Forms.ColumnHeader columnSenhaSAT;
        private System.Windows.Forms.ColumnHeader columnHorarioAg;
        private System.Windows.Forms.ColumnHeader columnPerito;
        private System.Windows.Forms.ColumnHeader columnPericiaC;
        private System.Windows.Forms.ColumnHeader columnMotivo;
        private System.Windows.Forms.Button extrairMensal;
        private System.Windows.Forms.Button extrairLimpa;
        private System.Windows.Forms.Button extrairAbrirPasta;
    }
}