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
    public partial class listaPastas : Form
    {
        public listaPastas()
        {
            InitializeComponent();
        }

        private void btn_subPastas_Click(object sender, EventArgs e)
        {
            procuraPasta.ShowDialog();

            txt_procura.Text = procuraPasta.SelectedPath;
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            txt_caixaPrincipal.ResetText();

            if(Directory.Exists(txt_procura.Text))
            {
                string[] pastas = Directory.GetDirectories(txt_procura.Text);

                foreach (string pasta in pastas)
                {
                    txt_caixaPrincipal.Text += pasta + "\r" + "\n";
                }

                MessageBox.Show("Todas as pastas estão listadas", "Sucesso!");
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
