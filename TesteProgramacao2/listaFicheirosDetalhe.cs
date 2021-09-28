using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TesteProgramacao2
{
    public partial class listaFicheirosDetalhe : Form
    {
        public listaFicheirosDetalhe()
        {
            InitializeComponent();
        }

        private void btn_todosFicheirosDetalhe_Click(object sender, EventArgs e)
        {
            procuraPasta.ShowDialog();

            txt_procura.Text = procuraPasta.SelectedPath;
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            txt_caixaPrincipal.ResetText();

            if(Directory.Exists(txt_procura.Text))
            {
                string[] pastas = Directory.GetFiles(txt_procura.Text);

                foreach (string pasta in pastas)
                {
                    var info = new FileInfo(pasta);

                    txt_caixaPrincipal.Text += $"{Path.GetFileName(pasta)}" + " - Tamanho: " + $"{info.Length}" + " bytes" + "\r" + "\n";
                }

                MessageBox.Show("Todos os ficheiros foram listados", "Sucesso!");
            }
            else
            {
                MessageBox.Show("A localização indicada é inválida", "Erro!");
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 voltar = new Form1();

            this.Hide();
            voltar.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
