namespace TesteProgramacao2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.procuraFicheiro = new System.Windows.Forms.OpenFileDialog();
            this.btn_callSubPastas = new System.Windows.Forms.Button();
            this.btn_callFicheiros = new System.Windows.Forms.Button();
            this.btn_callFicheirosDetalhe = new System.Windows.Forms.Button();
            this.btn_callExtensao = new System.Windows.Forms.Button();
            this.btn_callCriarPasta = new System.Windows.Forms.Button();
            this.btn_callMoverCopiar = new System.Windows.Forms.Button();
            this.btn_apagarExtensao = new System.Windows.Forms.Button();
            this.btn_apagarIncluindo = new System.Windows.Forms.Button();
            this.toolSubPastas = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // procuraFicheiro
            // 
            this.procuraFicheiro.FileName = "openFileDialog1";
            // 
            // btn_callSubPastas
            // 
            this.btn_callSubPastas.BackColor = System.Drawing.Color.Black;
            this.btn_callSubPastas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_callSubPastas.FlatAppearance.BorderSize = 0;
            this.btn_callSubPastas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_callSubPastas.ForeColor = System.Drawing.Color.White;
            this.btn_callSubPastas.Location = new System.Drawing.Point(12, 12);
            this.btn_callSubPastas.Margin = new System.Windows.Forms.Padding(0);
            this.btn_callSubPastas.Name = "btn_callSubPastas";
            this.btn_callSubPastas.Size = new System.Drawing.Size(200, 30);
            this.btn_callSubPastas.TabIndex = 17;
            this.btn_callSubPastas.Text = "Ver sub-pastas";
            this.btn_callSubPastas.UseVisualStyleBackColor = false;
            this.btn_callSubPastas.Click += new System.EventHandler(this.btn_callSubPastas_Click);
            // 
            // btn_callFicheiros
            // 
            this.btn_callFicheiros.BackColor = System.Drawing.Color.Black;
            this.btn_callFicheiros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_callFicheiros.FlatAppearance.BorderSize = 0;
            this.btn_callFicheiros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_callFicheiros.ForeColor = System.Drawing.Color.White;
            this.btn_callFicheiros.Location = new System.Drawing.Point(12, 48);
            this.btn_callFicheiros.Margin = new System.Windows.Forms.Padding(0);
            this.btn_callFicheiros.Name = "btn_callFicheiros";
            this.btn_callFicheiros.Size = new System.Drawing.Size(200, 30);
            this.btn_callFicheiros.TabIndex = 18;
            this.btn_callFicheiros.Text = "Ver todos os ficheiros";
            this.btn_callFicheiros.UseVisualStyleBackColor = false;
            this.btn_callFicheiros.Click += new System.EventHandler(this.btn_callFicheiros_Click);
            // 
            // btn_callFicheirosDetalhe
            // 
            this.btn_callFicheirosDetalhe.BackColor = System.Drawing.Color.Black;
            this.btn_callFicheirosDetalhe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_callFicheirosDetalhe.FlatAppearance.BorderSize = 0;
            this.btn_callFicheirosDetalhe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_callFicheirosDetalhe.ForeColor = System.Drawing.Color.White;
            this.btn_callFicheirosDetalhe.Location = new System.Drawing.Point(12, 84);
            this.btn_callFicheirosDetalhe.Margin = new System.Windows.Forms.Padding(0);
            this.btn_callFicheirosDetalhe.Name = "btn_callFicheirosDetalhe";
            this.btn_callFicheirosDetalhe.Size = new System.Drawing.Size(200, 30);
            this.btn_callFicheirosDetalhe.TabIndex = 19;
            this.btn_callFicheirosDetalhe.Text = "Ver todos os ficheiros (detalhe)";
            this.btn_callFicheirosDetalhe.UseVisualStyleBackColor = false;
            this.btn_callFicheirosDetalhe.Click += new System.EventHandler(this.btn_callFicheirosDetalhe_Click);
            // 
            // btn_callExtensao
            // 
            this.btn_callExtensao.BackColor = System.Drawing.Color.Black;
            this.btn_callExtensao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_callExtensao.FlatAppearance.BorderSize = 0;
            this.btn_callExtensao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_callExtensao.ForeColor = System.Drawing.Color.White;
            this.btn_callExtensao.Location = new System.Drawing.Point(12, 120);
            this.btn_callExtensao.Margin = new System.Windows.Forms.Padding(0);
            this.btn_callExtensao.Name = "btn_callExtensao";
            this.btn_callExtensao.Size = new System.Drawing.Size(200, 30);
            this.btn_callExtensao.TabIndex = 20;
            this.btn_callExtensao.Text = "Procurar por extensão";
            this.btn_callExtensao.UseVisualStyleBackColor = false;
            this.btn_callExtensao.Click += new System.EventHandler(this.btn_callExtensao_Click);
            // 
            // btn_callCriarPasta
            // 
            this.btn_callCriarPasta.BackColor = System.Drawing.Color.Black;
            this.btn_callCriarPasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_callCriarPasta.FlatAppearance.BorderSize = 0;
            this.btn_callCriarPasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_callCriarPasta.ForeColor = System.Drawing.Color.White;
            this.btn_callCriarPasta.Location = new System.Drawing.Point(12, 156);
            this.btn_callCriarPasta.Margin = new System.Windows.Forms.Padding(0);
            this.btn_callCriarPasta.Name = "btn_callCriarPasta";
            this.btn_callCriarPasta.Size = new System.Drawing.Size(200, 30);
            this.btn_callCriarPasta.TabIndex = 21;
            this.btn_callCriarPasta.Text = "Criar pasta";
            this.btn_callCriarPasta.UseVisualStyleBackColor = false;
            this.btn_callCriarPasta.Click += new System.EventHandler(this.btn_callCriarPasta_Click);
            // 
            // btn_callMoverCopiar
            // 
            this.btn_callMoverCopiar.BackColor = System.Drawing.Color.Black;
            this.btn_callMoverCopiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_callMoverCopiar.FlatAppearance.BorderSize = 0;
            this.btn_callMoverCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_callMoverCopiar.ForeColor = System.Drawing.Color.White;
            this.btn_callMoverCopiar.Location = new System.Drawing.Point(12, 192);
            this.btn_callMoverCopiar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_callMoverCopiar.Name = "btn_callMoverCopiar";
            this.btn_callMoverCopiar.Size = new System.Drawing.Size(200, 30);
            this.btn_callMoverCopiar.TabIndex = 22;
            this.btn_callMoverCopiar.Text = "Mover ou Copiar ficheiros";
            this.btn_callMoverCopiar.UseVisualStyleBackColor = false;
            this.btn_callMoverCopiar.Click += new System.EventHandler(this.btn_callMoverCopiar_Click);
            // 
            // btn_apagarExtensao
            // 
            this.btn_apagarExtensao.BackColor = System.Drawing.Color.Black;
            this.btn_apagarExtensao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_apagarExtensao.FlatAppearance.BorderSize = 0;
            this.btn_apagarExtensao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apagarExtensao.ForeColor = System.Drawing.Color.White;
            this.btn_apagarExtensao.Location = new System.Drawing.Point(12, 228);
            this.btn_apagarExtensao.Margin = new System.Windows.Forms.Padding(0);
            this.btn_apagarExtensao.Name = "btn_apagarExtensao";
            this.btn_apagarExtensao.Size = new System.Drawing.Size(200, 30);
            this.btn_apagarExtensao.TabIndex = 23;
            this.btn_apagarExtensao.Text = "Apagar: Extensão...";
            this.btn_apagarExtensao.UseVisualStyleBackColor = false;
            this.btn_apagarExtensao.Click += new System.EventHandler(this.btn_apagarExtensao_Click);
            // 
            // btn_apagarIncluindo
            // 
            this.btn_apagarIncluindo.BackColor = System.Drawing.Color.Black;
            this.btn_apagarIncluindo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_apagarIncluindo.FlatAppearance.BorderSize = 0;
            this.btn_apagarIncluindo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apagarIncluindo.ForeColor = System.Drawing.Color.White;
            this.btn_apagarIncluindo.Location = new System.Drawing.Point(12, 264);
            this.btn_apagarIncluindo.Margin = new System.Windows.Forms.Padding(0);
            this.btn_apagarIncluindo.Name = "btn_apagarIncluindo";
            this.btn_apagarIncluindo.Size = new System.Drawing.Size(200, 30);
            this.btn_apagarIncluindo.TabIndex = 24;
            this.btn_apagarIncluindo.Text = "Apagar: Incluindo...";
            this.btn_apagarIncluindo.UseVisualStyleBackColor = false;
            this.btn_apagarIncluindo.Click += new System.EventHandler(this.btn_apagarIncluindo_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(218, 12);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(30, 30);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 25;
            this.pictureBox10.TabStop = false;
            this.toolSubPastas.SetToolTip(this.pictureBox10, "Lista todas as subpastas dentro de\r\numa pasta escolhida pelo utilizador");
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(218, 264);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            this.toolSubPastas.SetToolTip(this.pictureBox4, "Apaga ficheiros que contenham uma\r\nsecção no seu nome indicada pelo\r\nutilizador");
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(218, 228);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            this.toolSubPastas.SetToolTip(this.pictureBox5, "Apaga todos os ficheiros dentro de\r\numa pasta com a extensão escolhida\r\npelo util" +
        "izador");
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(218, 192);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            this.toolSubPastas.SetToolTip(this.pictureBox6, "Move ou copia todos os\r\nficheiros entre duas pastas");
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(218, 156);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 30);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            this.toolSubPastas.SetToolTip(this.pictureBox7, "Cria pastas no sítio indicado pelo utilizado\r\ncom o nome à escolha do utilizador");
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(218, 120);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 30);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 25;
            this.pictureBox8.TabStop = false;
            this.toolSubPastas.SetToolTip(this.pictureBox8, "Procura os ficheiros dentro de uma pasta\r\nescolhida pelo utilizador com uma exten" +
        "são\r\nespecífica indicada pelo utilizador");
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(218, 84);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 30);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 25;
            this.pictureBox9.TabStop = false;
            this.toolSubPastas.SetToolTip(this.pictureBox9, "Lista todos os ficheiros dentro de uma pasta\r\nescolhida pelo utilizador e os seus" +
        " detalhes\r\n(extensão e tamanho)");
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox11.BackgroundImage")));
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(218, 48);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(30, 30);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 25;
            this.pictureBox11.TabStop = false;
            this.toolSubPastas.SetToolTip(this.pictureBox11, "Lista todos os ficheiros dentro\r\nde uma pasta escolhida pelo utilizador");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(198, 325);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.toolSubPastas.SetToolTip(this.pictureBox1, "Sair");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(12, 325);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(260, 387);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_apagarIncluindo);
            this.Controls.Add(this.btn_apagarExtensao);
            this.Controls.Add(this.btn_callMoverCopiar);
            this.Controls.Add(this.btn_callCriarPasta);
            this.Controls.Add(this.btn_callExtensao);
            this.Controls.Add(this.btn_callFicheirosDetalhe);
            this.Controls.Add(this.btn_callFicheiros);
            this.Controls.Add(this.btn_callSubPastas);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Ficheiros";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog procuraFicheiro;
        private System.Windows.Forms.Button btn_callSubPastas;
        private System.Windows.Forms.Button btn_callFicheiros;
        private System.Windows.Forms.Button btn_callFicheirosDetalhe;
        private System.Windows.Forms.Button btn_callExtensao;
        private System.Windows.Forms.Button btn_callCriarPasta;
        private System.Windows.Forms.Button btn_callMoverCopiar;
        private System.Windows.Forms.Button btn_apagarExtensao;
        private System.Windows.Forms.Button btn_apagarIncluindo;
        private System.Windows.Forms.ToolTip toolSubPastas;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

