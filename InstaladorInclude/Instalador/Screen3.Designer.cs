namespace Instalador
{
    partial class Screen3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen3));
            this.labelDiretorio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.labelProximo = new MaterialSkin.Controls.MaterialFlatButton();
            this.labelProcurar = new MaterialSkin.Controls.MaterialFlatButton();
            this.labelCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.labelVoltar = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.labelErroEspaço = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelEspaçoDisco = new MaterialSkin.Controls.MaterialLabel();
            this.labelNecessarioEspaço = new MaterialSkin.Controls.MaterialLabel();
            this.labelEspaçoNecessario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDiretorio
            // 
            this.labelDiretorio.Depth = 0;
            this.labelDiretorio.Hint = "";
            this.labelDiretorio.Location = new System.Drawing.Point(72, 194);
            this.labelDiretorio.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDiretorio.Name = "labelDiretorio";
            this.labelDiretorio.PasswordChar = '\0';
            this.labelDiretorio.SelectedText = "";
            this.labelDiretorio.SelectionLength = 0;
            this.labelDiretorio.SelectionStart = 0;
            this.labelDiretorio.Size = new System.Drawing.Size(394, 23);
            this.labelDiretorio.TabIndex = 0;
            this.labelDiretorio.UseSystemPasswordChar = false;
            this.labelDiretorio.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(68, 159);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(121, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Pasta de destino";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // labelProximo
            // 
            this.labelProximo.AutoSize = true;
            this.labelProximo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.labelProximo.BackColor = System.Drawing.SystemColors.Control;
            this.labelProximo.Depth = 0;
            this.labelProximo.Location = new System.Drawing.Point(471, 9);
            this.labelProximo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.labelProximo.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelProximo.Name = "labelProximo";
            this.labelProximo.Primary = false;
            this.labelProximo.Size = new System.Drawing.Size(73, 36);
            this.labelProximo.TabIndex = 5;
            this.labelProximo.Text = "Proximo";
            this.labelProximo.UseVisualStyleBackColor = false;
            this.labelProximo.Click += new System.EventHandler(this.labelProximo_Click);
            // 
            // labelProcurar
            // 
            this.labelProcurar.AutoSize = true;
            this.labelProcurar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.labelProcurar.Depth = 0;
            this.labelProcurar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.labelProcurar.Location = new System.Drawing.Point(474, 194);
            this.labelProcurar.Margin = new System.Windows.Forms.Padding(4);
            this.labelProcurar.MaximumSize = new System.Drawing.Size(23, 23);
            this.labelProcurar.MinimumSize = new System.Drawing.Size(23, 23);
            this.labelProcurar.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelProcurar.Name = "labelProcurar";
            this.labelProcurar.Primary = false;
            this.labelProcurar.Size = new System.Drawing.Size(23, 23);
            this.labelProcurar.TabIndex = 6;
            this.labelProcurar.Text = "...";
            this.labelProcurar.UseVisualStyleBackColor = true;
            this.labelProcurar.Click += new System.EventHandler(this.labelProcurar_Click);
            // 
            // labelCancelar
            // 
            this.labelCancelar.AutoSize = true;
            this.labelCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.labelCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.labelCancelar.Depth = 0;
            this.labelCancelar.Location = new System.Drawing.Point(13, 6);
            this.labelCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.labelCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCancelar.Name = "labelCancelar";
            this.labelCancelar.Primary = false;
            this.labelCancelar.Size = new System.Drawing.Size(82, 36);
            this.labelCancelar.TabIndex = 7;
            this.labelCancelar.Text = "CANCELAR";
            this.labelCancelar.UseVisualStyleBackColor = false;
            this.labelCancelar.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // labelVoltar
            // 
            this.labelVoltar.AutoSize = true;
            this.labelVoltar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.labelVoltar.BackColor = System.Drawing.SystemColors.Control;
            this.labelVoltar.Depth = 0;
            this.labelVoltar.Location = new System.Drawing.Point(399, 9);
            this.labelVoltar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.labelVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelVoltar.Name = "labelVoltar";
            this.labelVoltar.Primary = false;
            this.labelVoltar.Size = new System.Drawing.Size(64, 36);
            this.labelVoltar.TabIndex = 8;
            this.labelVoltar.Text = "Voltar";
            this.labelVoltar.UseVisualStyleBackColor = false;
            this.labelVoltar.Click += new System.EventHandler(this.labelVoltar_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(98, 108);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(337, 38);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Agora nós devemos escolher um local adequado\r\npara a instalação do software em qu" +
    "estão";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // labelErroEspaço
            // 
            this.labelErroEspaço.BackColor = System.Drawing.SystemColors.Window;
            this.labelErroEspaço.Depth = 0;
            this.labelErroEspaço.Enabled = false;
            this.labelErroEspaço.Hint = "";
            this.labelErroEspaço.Location = new System.Drawing.Point(300, 264);
            this.labelErroEspaço.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelErroEspaço.Name = "labelErroEspaço";
            this.labelErroEspaço.PasswordChar = '\0';
            this.labelErroEspaço.SelectedText = "";
            this.labelErroEspaço.SelectionLength = 0;
            this.labelErroEspaço.SelectionStart = 0;
            this.labelErroEspaço.Size = new System.Drawing.Size(197, 23);
            this.labelErroEspaço.TabIndex = 10;
            this.labelErroEspaço.UseSystemPasswordChar = false;
            this.labelErroEspaço.Click += new System.EventHandler(this.labelErroEspaço_Click);
            // 
            // labelEspaçoDisco
            // 
            this.labelEspaçoDisco.AutoSize = true;
            this.labelEspaçoDisco.BackColor = System.Drawing.SystemColors.Window;
            this.labelEspaçoDisco.Depth = 0;
            this.labelEspaçoDisco.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelEspaçoDisco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEspaçoDisco.Location = new System.Drawing.Point(296, 231);
            this.labelEspaçoDisco.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEspaçoDisco.Name = "labelEspaçoDisco";
            this.labelEspaçoDisco.Size = new System.Drawing.Size(201, 19);
            this.labelEspaçoDisco.TabIndex = 11;
            this.labelEspaçoDisco.Text = "Espaço Disponível em Disco";
            // 
            // labelNecessarioEspaço
            // 
            this.labelNecessarioEspaço.AutoSize = true;
            this.labelNecessarioEspaço.BackColor = System.Drawing.SystemColors.Window;
            this.labelNecessarioEspaço.Depth = 0;
            this.labelNecessarioEspaço.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelNecessarioEspaço.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelNecessarioEspaço.Location = new System.Drawing.Point(68, 231);
            this.labelNecessarioEspaço.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelNecessarioEspaço.Name = "labelNecessarioEspaço";
            this.labelNecessarioEspaço.Size = new System.Drawing.Size(208, 19);
            this.labelNecessarioEspaço.TabIndex = 12;
            this.labelNecessarioEspaço.Text = "Espaço Necessário em Disco";
            // 
            // labelEspaçoNecessario
            // 
            this.labelEspaçoNecessario.BackColor = System.Drawing.SystemColors.Window;
            this.labelEspaçoNecessario.Depth = 0;
            this.labelEspaçoNecessario.Enabled = false;
            this.labelEspaçoNecessario.Hint = "";
            this.labelEspaçoNecessario.Location = new System.Drawing.Point(72, 264);
            this.labelEspaçoNecessario.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEspaçoNecessario.Name = "labelEspaçoNecessario";
            this.labelEspaçoNecessario.PasswordChar = '\0';
            this.labelEspaçoNecessario.SelectedText = "";
            this.labelEspaçoNecessario.SelectionLength = 0;
            this.labelEspaçoNecessario.SelectionStart = 0;
            this.labelEspaçoNecessario.Size = new System.Drawing.Size(204, 23);
            this.labelEspaçoNecessario.TabIndex = 13;
            this.labelEspaçoNecessario.UseSystemPasswordChar = false;
            this.labelEspaçoNecessario.Click += new System.EventHandler(this.labelEspaçoNecessario_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.labelVoltar);
            this.panel1.Controls.Add(this.labelCancelar);
            this.panel1.Controls.Add(this.labelProximo);
            this.panel1.Location = new System.Drawing.Point(0, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 66);
            this.panel1.TabIndex = 14;
            // 
            // Screen3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 360);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelEspaçoNecessario);
            this.Controls.Add(this.labelNecessarioEspaço);
            this.Controls.Add(this.labelEspaçoDisco);
            this.Controls.Add(this.labelErroEspaço);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.labelProcurar);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.labelDiretorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Screen3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instalador";
            this.Load += new System.EventHandler(this.Screen3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField labelDiretorio;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton labelProximo;
        private MaterialSkin.Controls.MaterialFlatButton labelProcurar;
        private MaterialSkin.Controls.MaterialFlatButton labelCancelar;
        private MaterialSkin.Controls.MaterialFlatButton labelVoltar;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField labelErroEspaço;
        private MaterialSkin.Controls.MaterialLabel labelEspaçoDisco;
        private MaterialSkin.Controls.MaterialLabel labelNecessarioEspaço;
        private MaterialSkin.Controls.MaterialSingleLineTextField labelEspaçoNecessario;
        private System.Windows.Forms.Panel panel1;
    }
}