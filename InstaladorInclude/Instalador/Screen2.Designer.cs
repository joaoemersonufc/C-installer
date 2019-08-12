namespace Instalador
{
    partial class Screen2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen2));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.labelVoltar = new MaterialSkin.Controls.MaterialFlatButton();
            this.labelCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.labelProximo = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelConcordo = new MaterialSkin.Controls.MaterialRadioButton();
            this.labelDiscordo = new MaterialSkin.Controls.MaterialRadioButton();
            this.labelLincenca = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(191, 10);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(150, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Termo de conciência";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // labelVoltar
            // 
            this.labelVoltar.AutoSize = true;
            this.labelVoltar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.labelVoltar.Depth = 0;
            this.labelVoltar.Location = new System.Drawing.Point(399, 9);
            this.labelVoltar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.labelVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelVoltar.Name = "labelVoltar";
            this.labelVoltar.Primary = false;
            this.labelVoltar.Size = new System.Drawing.Size(64, 36);
            this.labelVoltar.TabIndex = 12;
            this.labelVoltar.Text = "Voltar";
            this.labelVoltar.UseVisualStyleBackColor = true;
            this.labelVoltar.Click += new System.EventHandler(this.labelVoltar_Click);
            // 
            // labelCancelar
            // 
            this.labelCancelar.AutoSize = true;
            this.labelCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.labelCancelar.Depth = 0;
            this.labelCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.labelCancelar.Location = new System.Drawing.Point(13, 9);
            this.labelCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.labelCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCancelar.Name = "labelCancelar";
            this.labelCancelar.Primary = false;
            this.labelCancelar.Size = new System.Drawing.Size(82, 36);
            this.labelCancelar.TabIndex = 11;
            this.labelCancelar.Text = "CANCELAR";
            this.labelCancelar.UseVisualStyleBackColor = true;
            this.labelCancelar.Click += new System.EventHandler(this.labelCancelar_Click);
            // 
            // labelProximo
            // 
            this.labelProximo.AutoSize = true;
            this.labelProximo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.labelProximo.Depth = 0;
            this.labelProximo.Location = new System.Drawing.Point(471, 9);
            this.labelProximo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.labelProximo.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelProximo.Name = "labelProximo";
            this.labelProximo.Primary = false;
            this.labelProximo.Size = new System.Drawing.Size(73, 36);
            this.labelProximo.TabIndex = 10;
            this.labelProximo.Text = "Proximo";
            this.labelProximo.UseVisualStyleBackColor = true;
            this.labelProximo.Click += new System.EventHandler(this.labelProximo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 47);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelCancelar);
            this.panel4.Controls.Add(this.labelProximo);
            this.panel4.Controls.Add(this.labelVoltar);
            this.panel4.Location = new System.Drawing.Point(0, 300);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(560, 65);
            this.panel4.TabIndex = 17;
            // 
            // labelConcordo
            // 
            this.labelConcordo.AutoSize = true;
            this.labelConcordo.Depth = 0;
            this.labelConcordo.Font = new System.Drawing.Font("Roboto", 10F);
            this.labelConcordo.Location = new System.Drawing.Point(14, 142);
            this.labelConcordo.Margin = new System.Windows.Forms.Padding(0);
            this.labelConcordo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.labelConcordo.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelConcordo.Name = "labelConcordo";
            this.labelConcordo.Ripple = true;
            this.labelConcordo.Size = new System.Drawing.Size(106, 30);
            this.labelConcordo.TabIndex = 13;
            this.labelConcordo.TabStop = true;
            this.labelConcordo.Text = "Eu condordo";
            this.labelConcordo.UseVisualStyleBackColor = true;
            this.labelConcordo.CheckedChanged += new System.EventHandler(this.labelConcordo_CheckedChanged);
            // 
            // labelDiscordo
            // 
            this.labelDiscordo.AutoSize = true;
            this.labelDiscordo.Depth = 0;
            this.labelDiscordo.Font = new System.Drawing.Font("Roboto", 10F);
            this.labelDiscordo.Location = new System.Drawing.Point(134, 142);
            this.labelDiscordo.Margin = new System.Windows.Forms.Padding(0);
            this.labelDiscordo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.labelDiscordo.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDiscordo.Name = "labelDiscordo";
            this.labelDiscordo.Ripple = true;
            this.labelDiscordo.Size = new System.Drawing.Size(133, 30);
            this.labelDiscordo.TabIndex = 14;
            this.labelDiscordo.TabStop = true;
            this.labelDiscordo.Text = "Não, eu discordo";
            this.labelDiscordo.UseVisualStyleBackColor = true;
            this.labelDiscordo.CheckedChanged += new System.EventHandler(this.labelDiscordo_CheckedChanged);
            // 
            // labelLincenca
            // 
            this.labelLincenca.Depth = 0;
            this.labelLincenca.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelLincenca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelLincenca.Location = new System.Drawing.Point(22, 6);
            this.labelLincenca.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelLincenca.Name = "labelLincenca";
            this.labelLincenca.Size = new System.Drawing.Size(489, 114);
            this.labelLincenca.TabIndex = 2;
            this.labelLincenca.Text = resources.GetString("labelLincenca.Text");
            this.labelLincenca.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(14, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(560, 68);
            this.panel3.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.labelLincenca);
            this.panel2.Controls.Add(this.labelDiscordo);
            this.panel2.Controls.Add(this.labelConcordo);
            this.panel2.Location = new System.Drawing.Point(0, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 192);
            this.panel2.TabIndex = 16;
            // 
            // Screen2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.labelCancelar;
            this.ClientSize = new System.Drawing.Size(560, 360);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Screen2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instalador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton labelVoltar;
        private MaterialSkin.Controls.MaterialFlatButton labelCancelar;
        private MaterialSkin.Controls.MaterialFlatButton labelProximo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialRadioButton labelConcordo;
        private MaterialSkin.Controls.MaterialRadioButton labelDiscordo;
        private MaterialSkin.Controls.MaterialLabel labelLincenca;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}