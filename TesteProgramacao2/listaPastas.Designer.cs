namespace TesteProgramacao2
{
    partial class listaPastas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listaPastas));
            this.btn_subPastas = new System.Windows.Forms.Button();
            this.txt_caixaPrincipal = new System.Windows.Forms.TextBox();
            this.procuraPasta = new System.Windows.Forms.FolderBrowserDialog();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_procura = new System.Windows.Forms.TextBox();
            this.btn_executar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_subPastas
            // 
            this.btn_subPastas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_subPastas.BackgroundImage")));
            this.btn_subPastas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_subPastas.Location = new System.Drawing.Point(221, 32);
            this.btn_subPastas.Name = "btn_subPastas";
            this.btn_subPastas.Size = new System.Drawing.Size(27, 23);
            this.btn_subPastas.TabIndex = 1;
            this.btn_subPastas.UseVisualStyleBackColor = true;
            this.btn_subPastas.Click += new System.EventHandler(this.btn_subPastas_Click);
            // 
            // txt_caixaPrincipal
            // 
            this.txt_caixaPrincipal.Location = new System.Drawing.Point(12, 175);
            this.txt_caixaPrincipal.Multiline = true;
            this.txt_caixaPrincipal.Name = "txt_caixaPrincipal";
            this.txt_caixaPrincipal.ReadOnly = true;
            this.txt_caixaPrincipal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_caixaPrincipal.Size = new System.Drawing.Size(236, 150);
            this.txt_caixaPrincipal.TabIndex = 0;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(193, 20);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "Ver sub-pastas dentro da pasta:";
            // 
            // txt_procura
            // 
            this.txt_procura.Location = new System.Drawing.Point(12, 32);
            this.txt_procura.Name = "txt_procura";
            this.txt_procura.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_procura.Size = new System.Drawing.Size(203, 23);
            this.txt_procura.TabIndex = 3;
            // 
            // btn_executar
            // 
            this.btn_executar.BackColor = System.Drawing.Color.Black;
            this.btn_executar.FlatAppearance.BorderSize = 0;
            this.btn_executar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_executar.ForeColor = System.Drawing.Color.White;
            this.btn_executar.Location = new System.Drawing.Point(12, 61);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(203, 23);
            this.btn_executar.TabIndex = 4;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = false;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(12, 345);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(218, 345);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // listaPastas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(260, 387);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_executar);
            this.Controls.Add(this.txt_procura);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.txt_caixaPrincipal);
            this.Controls.Add(this.btn_subPastas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "listaPastas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver sub-pastas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_subPastas;
        private System.Windows.Forms.TextBox txt_caixaPrincipal;
        private System.Windows.Forms.FolderBrowserDialog procuraPasta;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox txt_procura;
        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}