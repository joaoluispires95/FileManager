using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TesteProgramacao2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_callSubPastas_Click(object sender, EventArgs e)
        {
            listaPastas mostrar = new listaPastas();

            this.Hide();
            mostrar.Show();
        }

        private void btn_callFicheiros_Click(object sender, EventArgs e)
        {
            listaFicheiros mostrar = new listaFicheiros();

            this.Hide();
            mostrar.Show();
        }

        private void btn_callFicheirosDetalhe_Click(object sender, EventArgs e)
        {
            listaFicheirosDetalhe mostrar = new listaFicheirosDetalhe();

            this.Hide();
            mostrar.Show();
        }

        private void btn_callExtensao_Click(object sender, EventArgs e)
        {
            procuraExtensao mostrar = new procuraExtensao();

            this.Hide();
            mostrar.Show();
        }

        private void btn_callCriarPasta_Click(object sender, EventArgs e)
        {
            criarPasta mostrar = new criarPasta();

            this.Hide();
            mostrar.Show();
        }

        private void btn_callMoverCopiar_Click(object sender, EventArgs e)
        {
            moverCopiar mostrar = new moverCopiar();

            this.Hide();
            mostrar.Show();
        }

        private void btn_apagarExtensao_Click(object sender, EventArgs e)
        {
            apagarExtensao mostrar = new apagarExtensao();

            this.Hide();
            mostrar.Show();
        }

        private void btn_apagarIncluindo_Click(object sender, EventArgs e)
        {
            apagarIncluindo mostrar = new apagarIncluindo();

            this.Hide();
            mostrar.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Criado por João Pires\n\nv1.0.0\n\n25/01/2021", "Créditos");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
