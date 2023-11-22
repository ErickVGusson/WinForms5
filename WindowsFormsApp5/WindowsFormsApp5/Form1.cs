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

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            string texto = txbInput.Text;
            String caminhoDoArquivo = "C:/Users/erick.vgusson/source/repos/WinForms5/WindowsFormsApp5/WindowsFormsApp5/Arquivos/dados.txt";

            //StreamWriter(Caminho do arquivo);
            //StreamReader(caminho do arquivo);

            using (StreamWriter sw = new StreamWriter(caminhoDoArquivo))
            {

                sw.WriteLine(texto);

            }

            MessageBox.Show("Arquivo criado com sucesso");

        }
    }
}
