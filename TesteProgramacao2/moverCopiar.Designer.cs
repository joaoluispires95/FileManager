namespace TesteProgramacao2
{
    partial class moverCopiar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(moverCopiar));
            this.procuraPasta = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btn_executar = new System.Windows.Forms.Button();
            this.btn_destino = new System.Windows.Forms.Button();
            this.btn_ficheiro = new System.Windows.Forms.Button();
            this.ck_copiar = new System.Windows.Forms.CheckBox();
            this.ck_mover = new System.Windows.Forms.CheckBox();
            this.txt_ficheiro = new System.Windows.Forms.TextBox();
            this.txt_destino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(586, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Destino";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(585, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Ficheiro";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(518, 319);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 19);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Copiar";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(518, 293);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 19);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Mover";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btn_executar
            // 
            this.btn_executar.BackColor = System.Drawing.Color.Black;
            this.btn_executar.FlatAppearance.BorderSize = 0;
            this.btn_executar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_executar.ForeColor = System.Drawing.Color.White;
            this.btn_executar.Location = new System.Drawing.Point(29, 141);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(203, 31);
            this.btn_executar.TabIndex = 12;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = false;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click_1);
            // 
            // btn_destino
            // 
            this.btn_destino.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_destino.BackgroundImage")));
            this.btn_destino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_destino.Location = new System.Drawing.Point(221, 87);
            this.btn_destino.Name = "btn_destino";
            this.btn_destino.Size = new System.Drawing.Size(27, 23);
            this.btn_destino.TabIndex = 11;
            this.btn_destino.UseVisualStyleBackColor = true;
            this.btn_destino.Click += new System.EventHandler(this.btn_destino_Click);
            // 
            // btn_ficheiro
            // 
            this.btn_ficheiro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ficheiro.BackgroundImage")));
            this.btn_ficheiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ficheiro.Location = new System.Drawing.Point(221, 34);
            this.btn_ficheiro.Name = "btn_ficheiro";
            this.btn_ficheiro.Size = new System.Drawing.Size(27, 23);
            this.btn_ficheiro.TabIndex = 10;
            this.btn_ficheiro.UseVisualStyleBackColor = true;
            this.btn_ficheiro.Click += new System.EventHandler(this.btn_ficheiro_Click);
            // 
            // ck_copiar
            // 
            this.ck_copiar.AutoSize = true;
            this.ck_copiar.Location = new System.Drawing.Point(133, 116);
            this.ck_copiar.Name = "ck_copiar";
            this.ck_copiar.Size = new System.Drawing.Size(61, 19);
            this.ck_copiar.TabIndex = 9;
            this.ck_copiar.Text = "Copiar";
            this.ck_copiar.UseVisualStyleBackColor = true;
            this.ck_copiar.CheckedChanged += new System.EventHandler(this.ck_copiar_CheckedChanged);
            // 
            // ck_mover
            // 
            this.ck_mover.AutoSize = true;
            this.ck_mover.Checked = true;
            this.ck_mover.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_mover.Location = new System.Drawing.Point(67, 116);
            this.ck_mover.Name = "ck_mover";
            this.ck_mover.Size = new System.Drawing.Size(60, 19);
            this.ck_mover.TabIndex = 8;
            this.ck_mover.Text = "Mover";
            this.ck_mover.UseVisualStyleBackColor = true;
            this.ck_mover.CheckedChanged += new System.EventHandler(this.ck_mover_CheckedChanged);
            // 
            // txt_ficheiro
            // 
            this.txt_ficheiro.Location = new System.Drawing.Point(12, 35);
            this.txt_ficheiro.Name = "txt_ficheiro";
            this.txt_ficheiro.Size = new System.Drawing.Size(203, 23);
            this.txt_ficheiro.TabIndex = 13;
            // 
            // txt_destino
            // 
            this.txt_destino.Location = new System.Drawing.Point(12, 87);
            this.txt_destino.Name = "txt_destino";
            this.txt_destino.Size = new System.Drawing.Size(203, 23);
            this.txt_destino.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Escolha a origem:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Escolha o destino:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(12, 345);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 16;
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
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // moverCopiar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(260, 387);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_destino);
            this.Controls.Add(this.txt_ficheiro);
            this.Controls.Add(this.ck_mover);
            this.Controls.Add(this.ck_copiar);
            this.Controls.Add(this.btn_ficheiro);
            this.Controls.Add(this.btn_destino);
            this.Controls.Add(this.btn_executar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "moverCopiar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mover ou Copiar ficheiros";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog procuraPasta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.Button btn_destino;
        private System.Windows.Forms.Button btn_ficheiro;
        private System.Windows.Forms.CheckBox ck_copiar;
        private System.Windows.Forms.CheckBox ck_mover;
        private System.Windows.Forms.TextBox txt_ficheiro;
        private System.Windows.Forms.TextBox txt_destino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}