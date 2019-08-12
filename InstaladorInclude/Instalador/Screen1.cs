using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MaterialSkin.Controls;

namespace Instalador
{
    public partial class Screen : MaterialForm
    {   
        //Método principal 
        public Screen()
        {
            string texto = "";

            InitializeComponent();
            //Impedir do Cliente maximizar caixa
            this.MaximizeBox = false;
            


            //Diretório onde o arquivo.txt está
            string path = Environment.CurrentDirectory + '/' + "BoasVindas.txt";

            //Construtor responsável por ler o arquivo
            using (StreamReader leitor = new StreamReader(path, Encoding.GetEncoding("ISO-8859-1")))
            { 

                string linha = leitor.ReadLine();
                //Ler o arquivo até o final incluindo as quebras de linha
                while (linha != null)
                {
                    texto += linha + "\n";
                    linha = leitor.ReadLine();
                }
                //Screen sendo alimentada com o que tem no arquivo.txt
                BoasVindasLabel.Text = texto;
            }
            
        }

        //Texto de apresentação
        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        //Botão Cancelar
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            //Fechamento da Aplicação
            this.Close();
            Application.Exit();
        }

        //Botão Próximo
        private void materialFlatButton5_Click(object sender, EventArgs e)
        {

            
            Screen2 segundaTela = new Screen2(); // Declara o Screen2
            segundaTela.Show(); // Exibe Screen2
            Hide();
            
        }

        //Texto sobre
        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}
