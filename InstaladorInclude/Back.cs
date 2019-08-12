using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.IO;


namespace InstaladorBACK
{
    //Classe responsável pela ligação com a forma que está no front-end 
    public partial class Screen1 : Form

    //Classe main
    class Aplicação
    {
        //Ligação com o front-end (Associação com os componentes do front-end)
        public Screen1()
        {
            InitializeComponent();
        }

        // Método responsável pra caso o botão SIM seja clicado
        private void simClick(object sender, EventArgs e)
        {
            Pergunta.Text = "Instalando... Por favor, aguarde...";
            Nao.Enabled = false;
            Instalar();
        }
        // Método responsável pra caso o botão NÃO seja clicado
        private void naoClick(object sender, EventArgs e)
        {
            this.Close();
        }


        //Criação de Thread
        Thread InstalarThread;

        //Método do instalador (Responsável pela escolha de diretório do usuário e instalação das threads)
        void Instalar()
        {
            url = "link do site";
            String extensao = Path.GetExtension(url);
            InstalarThread = new Thread(InstallAsync);
            nomeArquivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Nome desejado";
            InstalarThread.Start();
        }

        //String endereço e nome do arquivo
        String url;
        String nomeArquivo;


        //Método de Abortar instalação
        void finalizarPrograma()
        {
            return;
            try //Finalizando Threads e o programa
            {
                InstalarThread.Abort();
                InstalarThread.Interrupt();
                InstalarThread.Suspend();
                InstalarThread = null;

            }
            catch //Tratamento de exceção
            {

            }
        }


        //Método de Instalação Assíncrona
        void InstallAsync()
        {
            try //Procedimento de instalação
            {
                WebClient cliente = new WebClient();
                cliente.DownloadFile(url, nomeArquivo);
                Console.WriteLine("Instalação concluída com sucesso em: " + nomeArquivo);
                Application.Exit();
                finalizarPrograma(); //Caso o programa não seja encerrado com o método anterior 
            }
            catch (Exception error) //Tratamento de excessão
            {
                String mensagemErro = String.Empty;
                while (error != null) // Quando houver erro
                {
                    mensagemErro += error.Message + '\n'; //Mostrará o erro separado linha por linha
                    error = error.InnerException;
                }
                Console.WriteLine("Ocorreu um erro." + mensagemErro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                finalizarPrograma();

            }
        }

    }
}
