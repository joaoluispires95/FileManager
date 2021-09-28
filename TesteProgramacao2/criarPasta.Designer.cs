namespace TesteProgramacao2
{
    partial class criarPasta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(criarPasta));
            this.txt_nomePasta = new System.Windows.Forms.TextBox();
            this.btn_criarPasta = new System.Windows.Forms.Button();
            this.procuraPasta = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_executar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_procura = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nomePasta
            // 
            this.txt_nomePasta.Location = new System.Drawing.Point(12, 35);
            this.txt_nomePasta.Name = "txt_nomePasta";
            this.txt_nomePasta.Size = new System.Drawing.Size(203, 23);
            this.txt_nomePasta.TabIndex = 6;
            // 
            // btn_criarPasta
            // 
            this.btn_criarPasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_criarPasta.BackgroundImage")));
            this.btn_criarPasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_criarPasta.Location = new System.Drawing.Point(221, 86);
            this.btn_criarPasta.Name = "btn_criarPasta";
            this.btn_criarPasta.Size = new System.Drawing.Size(27, 23);
            this.btn_criarPasta.TabIndex = 5;
            this.btn_criarPasta.UseVisualStyleBackColor = true;
            this.btn_criarPasta.Click += new System.EventHandler(this.btn_criarPasta_Click);
            // 
            // btn_executar
            // 
            this.btn_executar.BackColor = System.Drawing.Color.Black;
            this.btn_executar.FlatAppearance.BorderSize = 0;
            this.btn_executar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_executar.ForeColor = System.Drawing.Color.White;
            this.btn_executar.Location = new System.Drawing.Point(12, 116);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(203, 23);
            this.btn_executar.TabIndex = 4;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = false;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Criar pasta com o nome:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Na pasta:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_procura
            // 
            this.txt_procura.Location = new System.Drawing.Point(12, 87);
            this.txt_procura.Name = "txt_procura";
            this.txt_procura.Size = new System.Drawing.Size(203, 23);
            this.txt_procura.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(12, 345);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 9;
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
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // criarPasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(260, 387);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_procura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_executar);
            this.Controls.Add(this.btn_criarPasta);
            this.Controls.Add(this.txt_nomePasta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "criarPasta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar pasta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nomePasta;
        private System.Windows.Forms.Button btn_criarPasta;
        private System.Windows.Forms.FolderBrowserDialog procuraPasta;
        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_procura;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}