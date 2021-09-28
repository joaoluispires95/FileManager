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
    public partial class moverCopiar : Form
    {
        public moverCopiar()
        {
            InitializeComponent();
        }

        private void ck_mover_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_mover.Checked == true)
            {
                ck_copiar.Checked = false;
            }
            else
            {
                ck_copiar.Checked = true;
            }
        }

        private void ck_copiar_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_copiar.Checked == true)
            {
                ck_mover.Checked = false;
            }
            else
            {
                ck_mover.Checked = true;
            }
        }

        private void btn_ficheiro_Click(object sender, EventArgs e)
        {
            procuraPasta.ShowDialog();

            txt_ficheiro.Text = procuraPasta.SelectedPath;
        }

        private void btn_destino_Click(object sender, EventArgs e)
        {
            procuraPasta.ShowDialog();

            txt_destino.Text = procuraPasta.SelectedPath;
        }

        private void btn_executar_Click_1(object sender, EventArgs e)
        {
            if(Directory.Exists(txt_ficheiro.Text))
            {
                if(Directory.Exists(txt_destino.Text))
                {
                    string[] ficheiros = Directory.GetFiles(txt_ficheiro.Text);

                    if (ck_copiar.Checked == true)
                    {
                        foreach(string ficheiro in ficheiros)
                        {
                            File.Copy(ficheiro, txt_destino.Text + $"\\" + $"{Path.GetFileName(ficheiro)}");
                        }

                        MessageBox.Show("Ficheiros copiados com sucesso", "Sucesso!");
                    }
                    else if (ck_mover.Checked == true)
                    {
                        foreach(string ficheiro in ficheiros)
                        {
                            File.Move(ficheiro, txt_destino.Text + $"\\" + $"{Path.GetFileName(ficheiro)}");
                        }

                        MessageBox.Show("Ficheiros movidos com sucesso", "Sucesso!");

                    }
                }
                else
                {
                    MessageBox.Show("A localização de destino é inválida", "Erro!");
                }
            }
            else
            {
                MessageBox.Show("A localização de origem é inválida", "Erro!");
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
