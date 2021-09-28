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
    public partial class criarPasta : Form
    {
        public criarPasta()
        {
            InitializeComponent();
        }

        private void btn_criarPasta_Click(object sender, EventArgs e)
        {
            procuraPasta.ShowDialog();

            txt_procura.Text = procuraPasta.SelectedPath;      
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_nomePasta.Text))
            {
                MessageBox.Show("O nome da pasta é inválido", "Erro!");
            }
            else
            {
                if(Directory.Exists(txt_procura.Text))
                {
                    Directory.CreateDirectory($"{txt_procura.Text}" + "\\" + $"{txt_nomePasta.Text}");

                    MessageBox.Show("A pasta foi criada", "Sucesso!");
                }
                else
                {
                    MessageBox.Show("A localização indicada é inválida", "Erro!");
                }
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
