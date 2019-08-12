using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;
using System.Windows.Forms;
using System.IO;

namespace Instalador
{
    public partial class Screen3 : MaterialForm
    {
        //Texto apresentação
        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }
        
        //Texto pasta destino
        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        //Método principal
        public Screen3()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            //Torna o desktop diretório padrão para instalação
            var diretorioPadrao = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles);
            //Mostra ao usuário o diretório atual
            labelDiretorio.Text = diretorioPadrao;


        }

        //Barra de diretório
        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {
            
        }

        //Botão Cancelar
        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            //Fechar aplicação
            this.Close();
            Application.Exit();
        }


        //Botão Voltar
        private void labelVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false; //Torna invisível ao usuário a tela anterior
            Screen2 segundaTela = new Screen2(); // Declara o Screen2
            segundaTela.Show(); // Exibe Screen2
        }

        //Métodos das bibliotecas responsáveis pela busca de diretório 
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog1;

        //Métodos das bibliotecas responsáveis por criar o arquivo no diretório escolhido
        private MenuItem fileMenuItem, openMenuItem;
        private string openFileName, folderName;
 
        //Buscar diretório
        private void Screen3_Load(object sender, EventArgs e)
        {

        }


        //Enquanto estiver com a tela de busca acionada
        private bool fileOpened = false;


        //Botão de Procurar
        private void labelProcurar_Click(object sender, EventArgs e)
        {
            //Telas visíveis para o usuário interagir
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();

            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();

            this.openMenuItem = new System.Windows.Forms.MenuItem();

            //Verificar se é possível criar neste local
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Pegar o lugar selecionado
                folderName = folderBrowserDialog1.SelectedPath;
                if (!fileOpened)
                {
                    //Tornar como diretório de download o lugar selecionado
                    openFileDialog1.InitialDirectory = folderName;
                    openFileDialog1.FileName = null;
                    //Ações após o click
                    openMenuItem.PerformClick();

                    //Verificar espaço disponível
                    DriveInfo diDisc = new DriveInfo(folderName);
                    Int64 ByteLivre = diDisc.TotalFreeSpace;

                    double KB = ByteLivre / 1024;
                    double MB = KB / 1024;
                    double GB = MB / 1024;

                    var memoriaAnterior = GC.GetTotalMemory(true);
                    var listaEnorme = Enumerable.Range(0, 150000).ToList();
                    var memoriaAtual = GC.GetTotalMemory(true);

                    var espacoNecessarioBytes = memoriaAtual - memoriaAnterior;
                    int espacoNecessario = Convert.ToInt32(memoriaAtual - memoriaAnterior);

                    int Gb = Convert.ToInt32(GB);
                    labelErroEspaço.Text = Convert.ToString(Gb + "GB");

                    KB = espacoNecessario / 1024;
                    MB = KB / 1024;

                    int Mb = Convert.ToInt32(MB);
                    labelEspaçoNecessario.Text = Convert.ToString(Mb + "MB");
                    


                    if (ByteLivre > espacoNecessarioBytes) 
                    {
                        MessageBox.Show("Libere espaço na memoria e tente novamente.", "Memória Cheia",
                                 MessageBoxButtons.OK,  
                                 MessageBoxIcon.Exclamation);
                       
                    }
                    //Mostrar ao usuário caminho selecionado
                    labelDiretorio.Text = folderName;
                }
                
            }
        }

        private void labelProximo_Click(object sender, EventArgs e)
        {
            
            //Screen4 quartaTela = new Screen4(); // Declara o Screen3
            //quartaTela.Show(); // Exibe Screen4
            Hide();
        }

        private void labelErroEspaço_Click(object sender, EventArgs e)
        {
           
        }

        private void labelEspaçoNecessario_Click(object sender, EventArgs e)
        {

        }

       
    }
}
