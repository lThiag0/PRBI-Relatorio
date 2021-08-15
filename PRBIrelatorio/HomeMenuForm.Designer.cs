
namespace PRBIrelatorio
{
    partial class PRBI_MenuForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRBI_MenuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.extrair_relatorio = new System.Windows.Forms.Button();
            this.config_relatorio = new System.Windows.Forms.Button();
            this.editar_relatorio = new System.Windows.Forms.Button();
            this.criar_relatorio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(649, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa de Revisão dos Benefícios por Incapacidade - Relatório";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.extrair_relatorio);
            this.groupBox1.Controls.Add(this.config_relatorio);
            this.groupBox1.Controls.Add(this.editar_relatorio);
            this.groupBox1.Controls.Add(this.criar_relatorio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // extrair_relatorio
            // 
            this.extrair_relatorio.BackColor = System.Drawing.Color.LightSlateGray;
            this.extrair_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extrair_relatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extrair_relatorio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.extrair_relatorio.Location = new System.Drawing.Point(487, 22);
            this.extrair_relatorio.Name = "extrair_relatorio";
            this.extrair_relatorio.Size = new System.Drawing.Size(139, 38);
            this.extrair_relatorio.TabIndex = 3;
            this.extrair_relatorio.Text = "Extrair";
            this.extrair_relatorio.UseVisualStyleBackColor = false;
            this.extrair_relatorio.Click += new System.EventHandler(this.extrair_relatorio_Click);
            // 
            // config_relatorio
            // 
            this.config_relatorio.BackColor = System.Drawing.Color.Cornsilk;
            this.config_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.config_relatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.config_relatorio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.config_relatorio.Location = new System.Drawing.Point(331, 22);
            this.config_relatorio.Name = "config_relatorio";
            this.config_relatorio.Size = new System.Drawing.Size(139, 38);
            this.config_relatorio.TabIndex = 2;
            this.config_relatorio.Text = "Configurações";
            this.config_relatorio.UseVisualStyleBackColor = false;
            this.config_relatorio.Click += new System.EventHandler(this.config_relatorio_Click);
            // 
            // editar_relatorio
            // 
            this.editar_relatorio.BackColor = System.Drawing.Color.LightSeaGreen;
            this.editar_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar_relatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar_relatorio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editar_relatorio.Location = new System.Drawing.Point(173, 22);
            this.editar_relatorio.Name = "editar_relatorio";
            this.editar_relatorio.Size = new System.Drawing.Size(139, 38);
            this.editar_relatorio.TabIndex = 1;
            this.editar_relatorio.Text = "Editar Relatório";
            this.editar_relatorio.UseVisualStyleBackColor = false;
            this.editar_relatorio.Click += new System.EventHandler(this.editar_relatorio_Click);
            // 
            // criar_relatorio
            // 
            this.criar_relatorio.BackColor = System.Drawing.Color.LightBlue;
            this.criar_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.criar_relatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criar_relatorio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.criar_relatorio.Location = new System.Drawing.Point(15, 22);
            this.criar_relatorio.Name = "criar_relatorio";
            this.criar_relatorio.Size = new System.Drawing.Size(139, 38);
            this.criar_relatorio.TabIndex = 0;
            this.criar_relatorio.Text = "Criar Relatório";
            this.criar_relatorio.UseVisualStyleBackColor = false;
            this.criar_relatorio.Click += new System.EventHandler(this.criar_relatorio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desenvolvido por Thiago Araujo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Versão: 1.0.1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PRBI_MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(674, 162);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PRBI_MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRBI Relatório";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button criar_relatorio;
        private System.Windows.Forms.Button editar_relatorio;
        private System.Windows.Forms.Button extrair_relatorio;
        private System.Windows.Forms.Button config_relatorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

