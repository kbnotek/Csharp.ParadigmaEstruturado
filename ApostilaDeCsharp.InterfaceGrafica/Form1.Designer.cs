namespace ApostilaDeCsharp.InterfaceGrafica
{
    partial class Form1
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
            this.btnNadar = new System.Windows.Forms.Button();
            this.btnPular = new System.Windows.Forms.Button();
            this.btnCorrer = new System.Windows.Forms.Button();
            this.btnVirarEsquerda = new System.Windows.Forms.Button();
            this.btnVirarDireita = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnAndar = new System.Windows.Forms.Button();
            this.txtPontos = new System.Windows.Forms.TextBox();
            this.lblPontos = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnVoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNadar
            // 
            this.btnNadar.Location = new System.Drawing.Point(644, 167);
            this.btnNadar.Name = "btnNadar";
            this.btnNadar.Size = new System.Drawing.Size(75, 25);
            this.btnNadar.TabIndex = 1;
            this.btnNadar.Text = "Nadar";
            this.btnNadar.UseVisualStyleBackColor = true;
            this.btnNadar.Click += new System.EventHandler(this.btnNadar_Click);
            // 
            // btnPular
            // 
            this.btnPular.Location = new System.Drawing.Point(643, 136);
            this.btnPular.Name = "btnPular";
            this.btnPular.Size = new System.Drawing.Size(75, 25);
            this.btnPular.TabIndex = 2;
            this.btnPular.Text = "Pular";
            this.btnPular.UseVisualStyleBackColor = true;
            this.btnPular.Click += new System.EventHandler(this.btnPular_Click);
            // 
            // btnCorrer
            // 
            this.btnCorrer.Location = new System.Drawing.Point(724, 136);
            this.btnCorrer.Name = "btnCorrer";
            this.btnCorrer.Size = new System.Drawing.Size(74, 25);
            this.btnCorrer.TabIndex = 3;
            this.btnCorrer.Text = "Correr";
            this.btnCorrer.UseVisualStyleBackColor = true;
            this.btnCorrer.Click += new System.EventHandler(this.btnCorrer_Click);
            // 
            // btnVirarEsquerda
            // 
            this.btnVirarEsquerda.Location = new System.Drawing.Point(564, 67);
            this.btnVirarEsquerda.Name = "btnVirarEsquerda";
            this.btnVirarEsquerda.Size = new System.Drawing.Size(89, 22);
            this.btnVirarEsquerda.TabIndex = 4;
            this.btnVirarEsquerda.Text = "Virar Esquerda";
            this.btnVirarEsquerda.UseVisualStyleBackColor = true;
            this.btnVirarEsquerda.Click += new System.EventHandler(this.btnVirarEsquerda_Click);
            // 
            // btnVirarDireita
            // 
            this.btnVirarDireita.Location = new System.Drawing.Point(709, 67);
            this.btnVirarDireita.Name = "btnVirarDireita";
            this.btnVirarDireita.Size = new System.Drawing.Size(89, 23);
            this.btnVirarDireita.TabIndex = 5;
            this.btnVirarDireita.Text = "Virar Direita";
            this.btnVirarDireita.UseVisualStyleBackColor = true;
            this.btnVirarDireita.Click += new System.EventHandler(this.btnVirarDireita_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(644, 95);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(89, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(686, 198);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 7;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnAndar
            // 
            this.btnAndar.Location = new System.Drawing.Point(644, 38);
            this.btnAndar.Name = "btnAndar";
            this.btnAndar.Size = new System.Drawing.Size(74, 23);
            this.btnAndar.TabIndex = 8;
            this.btnAndar.Text = "Andar";
            this.btnAndar.UseVisualStyleBackColor = true;
            this.btnAndar.Click += new System.EventHandler(this.btnAndar_Click);
            // 
            // txtPontos
            // 
            this.txtPontos.Location = new System.Drawing.Point(115, 45);
            this.txtPontos.Name = "txtPontos";
            this.txtPontos.Size = new System.Drawing.Size(117, 20);
            this.txtPontos.TabIndex = 9;
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos.Location = new System.Drawing.Point(12, 48);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(97, 13);
            this.lblPontos.TabIndex = 10;
            this.lblPontos.Text = "Total de Pontos";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(132, 13);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome Do Personagem";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(150, 16);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(110, 20);
            this.txtNome.TabIndex = 12;
            // 
            // btnVoa
            // 
            this.btnVoa.Location = new System.Drawing.Point(725, 168);
            this.btnVoa.Name = "btnVoa";
            this.btnVoa.Size = new System.Drawing.Size(73, 23);
            this.btnVoa.TabIndex = 13;
            this.btnVoa.Text = "Voar";
            this.btnVoa.UseVisualStyleBackColor = true;
            this.btnVoa.Click += new System.EventHandler(this.btnVoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoa);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblPontos);
            this.Controls.Add(this.txtPontos);
            this.Controls.Add(this.btnAndar);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnVirarDireita);
            this.Controls.Add(this.btnVirarEsquerda);
            this.Controls.Add(this.btnCorrer);
            this.Controls.Add(this.btnPular);
            this.Controls.Add(this.btnNadar);
            this.Name = "Form1";
            this.Text = "Drive I";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoar;
        private System.Windows.Forms.Button btnNadar;
        private System.Windows.Forms.Button btnPular;
        private System.Windows.Forms.Button btnCorrer;
        private System.Windows.Forms.Button btnVirarEsquerda;
        private System.Windows.Forms.Button btnVirarDireita;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnAndar;
        private System.Windows.Forms.TextBox txtPontos;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnVoa;
    }
}

