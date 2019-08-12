namespace Instalador
{
    partial class Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen));
            this.BoasVindasLabel = new MaterialSkin.Controls.MaterialLabel();
            this.TitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.PanelCenter = new System.Windows.Forms.Panel();
            this.BtnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnVoltar = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnProximaTela = new MaterialSkin.Controls.MaterialFlatButton();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.PanelCenter.SuspendLayout();
            this.PanelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoasVindasLabel
            // 
            this.BoasVindasLabel.Depth = 0;
            this.BoasVindasLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.BoasVindasLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BoasVindasLabel.Location = new System.Drawing.Point(117, 31);
            this.BoasVindasLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BoasVindasLabel.Name = "BoasVindasLabel";
            this.BoasVindasLabel.Size = new System.Drawing.Size(299, 114);
            this.BoasVindasLabel.TabIndex = 0;
            this.BoasVindasLabel.Text = "Entende-se por Processo de \r\nConsentimento Livre e \r\nEsclarecido todas como se\r\nE" +
    "ntende-se por Processo de \r\nConsentimento Livre e \r\nEsclarecido todas como se";
            this.BoasVindasLabel.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.SystemColors.Window;
            this.TitleLabel.Depth = 0;
            this.TitleLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TitleLabel.Location = new System.Drawing.Point(188, 13);
            this.TitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(157, 19);
            this.TitleLabel.TabIndex = 16;
            this.TitleLabel.Text = "Um pouco mais sobre";
            this.TitleLabel.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.Window;
            this.panelTop.Controls.Add(this.TitleLabel);
            this.panelTop.Location = new System.Drawing.Point(0, 62);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(561, 52);
            this.panelTop.TabIndex = 20;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PanelCenter
            // 
            this.PanelCenter.BackColor = System.Drawing.SystemColors.Window;
            this.PanelCenter.Controls.Add(this.BoasVindasLabel);
            this.PanelCenter.Location = new System.Drawing.Point(0, 113);
            this.PanelCenter.Name = "PanelCenter";
            this.PanelCenter.Size = new System.Drawing.Size(560, 195);
            this.PanelCenter.TabIndex = 21;
            this.PanelCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.AutoSize = true;
            this.BtnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCancelar.Depth = 0;
            this.BtnCancelar.Location = new System.Drawing.Point(13, 6);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Primary = false;
            this.BtnCancelar.Size = new System.Drawing.Size(82, 36);
            this.BtnCancelar.TabIndex = 19;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.AutoSize = true;
            this.BtnVoltar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnVoltar.Depth = 0;
            this.BtnVoltar.Location = new System.Drawing.Point(399, 9);
            this.BtnVoltar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Primary = false;
            this.BtnVoltar.Size = new System.Drawing.Size(64, 36);
            this.BtnVoltar.TabIndex = 13;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // BtnProximaTela
            // 
            this.BtnProximaTela.AutoSize = true;
            this.BtnProximaTela.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnProximaTela.BackColor = System.Drawing.SystemColors.Control;
            this.BtnProximaTela.Depth = 0;
            this.BtnProximaTela.Location = new System.Drawing.Point(471, 9);
            this.BtnProximaTela.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnProximaTela.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnProximaTela.Name = "BtnProximaTela";
            this.BtnProximaTela.Primary = false;
            this.BtnProximaTela.Size = new System.Drawing.Size(73, 36);
            this.BtnProximaTela.TabIndex = 13;
            this.BtnProximaTela.Text = "Proximo";
            this.BtnProximaTela.UseVisualStyleBackColor = true;
            this.BtnProximaTela.Click += new System.EventHandler(this.materialFlatButton5_Click);
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.SystemColors.Window;
            this.PanelBottom.Controls.Add(this.BtnProximaTela);
            this.PanelBottom.Controls.Add(this.BtnVoltar);
            this.PanelBottom.Controls.Add(this.BtnCancelar);
            this.PanelBottom.Location = new System.Drawing.Point(0, 300);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(575, 65);
            this.PanelBottom.TabIndex = 17;
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 360);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.PanelCenter);
            this.Controls.Add(this.panelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instalador";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.PanelCenter.ResumeLayout(false);
            this.PanelBottom.ResumeLayout(false);
            this.PanelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel BoasVindasLabel;
        private MaterialSkin.Controls.MaterialLabel TitleLabel;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel PanelCenter;
        private MaterialSkin.Controls.MaterialFlatButton BtnCancelar;
        private MaterialSkin.Controls.MaterialFlatButton BtnVoltar;
        private MaterialSkin.Controls.MaterialFlatButton BtnProximaTela;
        private System.Windows.Forms.Panel PanelBottom;
    }
}

