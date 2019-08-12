using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.IO;

namespace Instalador
{
    public partial class Screen2 : MaterialForm
    {  
        //Método principal
        public Screen2()
        {
            string texto = "";

            InitializeComponent();
            //Botão Próximo desativado
            labelProximo.Enabled = false;
            //Desativar botão de maximizar tela
            this.MaximizeBox = false;

            //Diretório onde o arquivo.txt está
            string path = Environment.CurrentDirectory + '/' + "TermosLincenca.txt";

            //Construtor responsável por ler o arquivo
            /*using (StreamReader leitor = new StreamReader(path, Encoding.GetEncoding("ISO-8859-1")))
            {

                string linha = leitor.ReadLine();
                //Ler o arquivo até o final incluindo as quebras de linha
                while (linha != null)
                {
                    texto += linha + "\n";
                    linha = leitor.ReadLine();
                }
                //Screen sendo alimentada com o que tem no arquivo.txt
                labelLincenca.Text = texto;
            }
            */

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }
        //Botão Cancelar
        private void labelCancelar_Click(object sender, EventArgs e)
        {   //Fechar aplicação
            this.Close();
            Application.Exit();
        }

        //Botão Discordo
        private void labelDiscordo_CheckedChanged(object sender, EventArgs e)
        {
            //Desativar botão Próximo
            labelProximo.Enabled = false;
           
        }

        //Botão Próximo
        private void labelProximo_Click(object sender, EventArgs e)
        {
            
            Screen3 terceiraTela = new Screen3(); // Declara o Screen3
            terceiraTela.Show(); // Exibe Screen3
            Hide();

        }

        //Botão Voltar
        private void labelVoltar_Click(object sender, EventArgs e)
        {
            
            Screen primeiraTela = new Screen(); // Declara o Screen1
            primeiraTela.Show(); // Exibe Screen1
            Hide();
        }

        //Botão Concordo
        private void labelConcordo_CheckedChanged(object sender, EventArgs e)
        {
            //Torna os botões Próximo e Voltar clicáveis
            labelProximo.Enabled = true;
            labelVoltar.Enabled = true;
        }

        //Texto de apresentação da tela
        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }


        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
