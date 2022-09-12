namespace Aula3_POO
{
    partial class Tela_Filme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_filme = new System.Windows.Forms.TextBox();
            this.text_sinopse = new System.Windows.Forms.TextBox();
            this.text_classificacao = new System.Windows.Forms.TextBox();
            this.text_genero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Classificação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gênero";
            // 
            // text_filme
            // 
            this.text_filme.Location = new System.Drawing.Point(157, 25);
            this.text_filme.Name = "text_filme";
            this.text_filme.Size = new System.Drawing.Size(434, 20);
            this.text_filme.TabIndex = 4;
            // 
            // text_sinopse
            // 
            this.text_sinopse.Location = new System.Drawing.Point(157, 54);
            this.text_sinopse.Name = "text_sinopse";
            this.text_sinopse.Size = new System.Drawing.Size(434, 20);
            this.text_sinopse.TabIndex = 5;
            // 
            // text_classificacao
            // 
            this.text_classificacao.Location = new System.Drawing.Point(157, 80);
            this.text_classificacao.Name = "text_classificacao";
            this.text_classificacao.Size = new System.Drawing.Size(434, 20);
            this.text_classificacao.TabIndex = 6;
            // 
            // text_genero
            // 
            this.text_genero.Location = new System.Drawing.Point(157, 106);
            this.text_genero.Name = "text_genero";
            this.text_genero.Size = new System.Drawing.Size(434, 20);
            this.text_genero.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sinopse";
            // 
            // btn_gravar
            // 
            this.btn_gravar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravar.Location = new System.Drawing.Point(87, 195);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(163, 92);
            this.btn_gravar.TabIndex = 9;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Location = new System.Drawing.Point(373, 195);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(163, 92);
            this.btn_pesquisar.TabIndex = 10;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // Tela_Filme
            // 
            this.ClientSize = new System.Drawing.Size(633, 373);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_genero);
            this.Controls.Add(this.text_classificacao);
            this.Controls.Add(this.text_sinopse);
            this.Controls.Add(this.text_filme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Tela_Filme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_gravar;
        private System.Windows.Forms.Button bt_pesquisar;
        private System.Windows.Forms.Label txt_nomefilme;
        private System.Windows.Forms.TextBox txtfilme;
        private System.Windows.Forms.TextBox txtgenero;
        private System.Windows.Forms.Label txt_genero;
        private System.Windows.Forms.TextBox txtsinopse;
        private System.Windows.Forms.Label txt_sinopse;
        private System.Windows.Forms.TextBox txtclassificacao;
        private System.Windows.Forms.Label txt_classificacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_filme;
        private System.Windows.Forms.TextBox text_sinopse;
        private System.Windows.Forms.TextBox text_classificacao;
        private System.Windows.Forms.TextBox text_genero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_pesquisar;
    }
}