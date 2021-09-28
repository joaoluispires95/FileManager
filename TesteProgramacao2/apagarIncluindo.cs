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
    public partial class apagarIncluindo : Form
    {
        public apagarIncluindo()
        {
            InitializeComponent();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            procuraPasta.ShowDialog();

            txt_procura.Text = procuraPasta.SelectedPath;
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            if(Directory.Exists(txt_procura.Text))
            {
                if(string.IsNullOrEmpty(txt_caracteres.Text))
                {
                    MessageBox.Show("Os caracteres indicados não são válidos", "Erro!");
                }
                else
                {
                    string[] pastas = Directory.GetFiles(txt_procura.Text);

                    foreach (string ficheiro in pastas)
                    {
                        var info = new FileInfo(ficheiro);

                        if (Path.GetFileNameWithoutExtension(ficheiro).Contains(txt_caracteres.Text))
                        {
                            File.Delete(ficheiro);
                        }
                    }

                    MessageBox.Show("Foram apagados todos os ficheiros que continham\nos caracteres indicados no seu nome", "Sucesso!");
                }
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
