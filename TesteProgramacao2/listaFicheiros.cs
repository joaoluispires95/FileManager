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
    public partial class listaFicheiros : Form
    {
        public listaFicheiros()
        {
            InitializeComponent();
        }

        private void btn_todosFicheiros_Click(object sender, EventArgs e)
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
                    txt_caixaPrincipal.Text += Path.GetFileNameWithoutExtension(pasta) + "\r" + "\n";
                }

                MessageBox.Show("Todos os ficheiros estão listados", "Sucesso!");
            }
            else
            {
                MessageBox.Show("A localização indicada não é válida", "Erro!");
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
