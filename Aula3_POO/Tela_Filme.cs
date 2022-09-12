using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula3_POO
{
    public partial class Tela_Filme : Form
    {
        public Tela_Filme()
        {
            InitializeComponent();
        }

        Filme f = new Filme(); //Instanciando objeto
        Filme[] vet = new Filme[5]; //Declaração do vetor de objetos
        int i = 0;

        private void btn_gravar_Click(object sender, EventArgs e) // algortimo referente ao botão GRAVAR colocado no forms
        {
            if (i == 6)
            {
                MessageBox.Show("Não foi possivel gravar!");
            }
            else
            {
                f.Titulo = txt_nomefilme.Text;  // referente ao preenchimento da barra de TITULO no forms
                f.Sinopse = txt_sinopse.Text; // referente ao preenchimento da barra de SINOPSE no forms
                f.Genero = txt_genero.Text; // referente ao preenchimento da barra de GENERO no forms
                f.Classificacao = txt_classificacao.Text; // referente ao preenchimento da barra de CLASSIFICAÇÃO no forms
                vet[i] = f;
                i++;
            }
            Limpar();
        }
        private void Limpar()
        {
            txt_nomefilme.Text = null;
            txt_sinopse.Text = null;
            txt_genero.Text = null;
            txt_classificacao.Text = null;
        }

        private void btn_pesquisar_Click(object sender, EventArgs e) // algortimo referente ao botão pesquisar colocado no forms
        {
            for (int x = 0; x < 5; x++)
            {
                if (txt_nomefilme.Text.Equals(vet[x].Titulo))
                {
                    txt_sinopse.Text = vet[x].Sinopse;
                    txt_genero.Text = vet[x].Genero;
                    txt_classificacao.Text = vet[x].Classificacao;
                    x = 5;
                }
                else
                {
                    if (x == 4)
                    {
                        MessageBox.Show("Título não existe!");
                    }
                }
            }
        }
    }
}
