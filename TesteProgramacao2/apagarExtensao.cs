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
    public partial class apagarExtensao : Form
    {
        public apagarExtensao()
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
                if (string.IsNullOrEmpty(txt_extensao.Text))
                {
                    MessageBox.Show("A extensão indicada é inválida", "Erro!");
                }
                else
                {
                    string[] pastas = Directory.GetFiles(txt_procura.Text);

                    foreach (string ficheiro in pastas)
                    {
                        var info = new FileInfo(ficheiro);

                        if (Path.GetExtension(ficheiro) == txt_extensao.Text || Path.GetExtension(ficheiro) == ("." + txt_extensao.Text))
                        {
                            File.Delete(ficheiro);
                        }
                    }

                    MessageBox.Show("Foram apagados todos os ficheiros com a extensão indicada", "Sucesso!");
                }
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
