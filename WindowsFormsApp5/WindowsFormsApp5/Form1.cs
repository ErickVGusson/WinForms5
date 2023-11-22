using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String caminhoDoArquivo = "C:/Users/erick.vgusson/source/repos/WinForms5/WindowsFormsApp5/WindowsFormsApp5/Arquivos/dados.txt";
        private void Form1_Load(object sender, EventArgs e)
        {

            string texto = LerArquivo(caminhoDoArquivo);

            Array lista = texto.Split('\n');

            foreach (string pessoa in lista)
            {

                string[] dados = pessoa.Split('|');

                //MessageBox.Show(dados[0]);

                cbxNome.Items.Add(dados[0].ToUpper());

            }

        }

        string LerArquivo(string endereco)
        {
            string conteudo = "";
            if (File.Exists(endereco))
            {

                using (StreamReader sr = new StreamReader(endereco))
                {

                    conteudo = sr.ReadToEnd();

                }

            }

            return conteudo;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            string nome = txbNome.Text;
            string telefone = txbTelefone.Text;
            string email = txbEmail.Text;
            string separador = "|";

            if (rbTelefone.Checked)
            {

                email = "-";

            }

            if (rbEmail.Checked)
            {

                telefone = "-";


            }


            string contato = nome + separador + telefone + separador + email;

            string textoAntigo = LerArquivo(caminhoDoArquivo);

            //StreamWriter(Caminho do arquivo);
            //StreamReader(caminho do arquivo);

            using (StreamWriter sw = new StreamWriter(caminhoDoArquivo))
            {

                sw.WriteLine(textoAntigo + contato);

            }

            MessageBox.Show("Arquivo criado com sucesso");

        }

        private void btnLer_Click(object sender, EventArgs e)
        {

            string texto = LerArquivo(caminhoDoArquivo);

            Array lista = texto.Split('\n');

            foreach (string pessoa in lista)
            {

                string[] dados = pessoa.Split('|');

                cbxNome.Items.Add(dados[0].ToUpper());

                lblNome.Text = dados[0];
                lblTelefone.Text = dados[1];
                lblEmail.Text = dados[2];

            }

        }

    }
}
