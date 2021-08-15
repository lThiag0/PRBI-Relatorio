
namespace PRBIrelatorio.Forms
{
    partial class ConfigRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigRelatorio));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.diretorioConfig = new System.Windows.Forms.TextBox();
            this.SalvaConfig = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.VoltarConfigMenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(691, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "PRBI Configurar Relatório";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.diretorioConfig);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 105);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(674, 39);
            this.label3.TabIndex = 14;
            this.label3.Text = "Para que o programa funcione em múltiplos computadores é preciso que o computador" +
    " com o diretorio principal esteja ligado.";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Caminho do diretorio principal";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Procura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // diretorioConfig
            // 
            this.diretorioConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diretorioConfig.Location = new System.Drawing.Point(6, 77);
            this.diretorioConfig.Name = "diretorioConfig";
            this.diretorioConfig.Size = new System.Drawing.Size(555, 22);
            this.diretorioConfig.TabIndex = 11;
            // 
            // SalvaConfig
            // 
            this.SalvaConfig.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.SalvaConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SalvaConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.SalvaConfig.ForeColor = System.Drawing.Color.White;
            this.SalvaConfig.Location = new System.Drawing.Point(597, 152);
            this.SalvaConfig.Name = "SalvaConfig";
            this.SalvaConfig.Size = new System.Drawing.Size(106, 31);
            this.SalvaConfig.TabIndex = 12;
            this.SalvaConfig.Text = "Salvar";
            this.SalvaConfig.UseVisualStyleBackColor = false;
            this.SalvaConfig.Click += new System.EventHandler(this.SalvaConfig_Click);
            // 
            // VoltarConfigMenu
            // 
            this.VoltarConfigMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.VoltarConfigMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VoltarConfigMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.VoltarConfigMenu.ForeColor = System.Drawing.Color.White;
            this.VoltarConfigMenu.Location = new System.Drawing.Point(485, 152);
            this.VoltarConfigMenu.Name = "VoltarConfigMenu";
            this.VoltarConfigMenu.Size = new System.Drawing.Size(106, 31);
            this.VoltarConfigMenu.TabIndex = 13;
            this.VoltarConfigMenu.Text = "Voltar";
            this.VoltarConfigMenu.UseVisualStyleBackColor = false;
            this.VoltarConfigMenu.Click += new System.EventHandler(this.VoltarConfigMenu_Click);
            // 
            // ConfigRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 193);
            this.Controls.Add(this.VoltarConfigMenu);
            this.Controls.Add(this.SalvaConfig);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRBI Configurar Relatório";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox diretorioConfig;
        private System.Windows.Forms.Button SalvaConfig;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button VoltarConfigMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}