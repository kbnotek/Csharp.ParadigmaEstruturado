using ApostilaDeCharp.OrientacaoObjetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApostilaDeCsharp.InterfaceGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVoa_Click(object sender, EventArgs e)
        {
            Personagem p = new Personagem();
            p.Nome = txtNome.Text;
            p.QtdePontos = int.Parse(txtPontos.Text);
            Movimentacao m = new Movimentacao();
            MessageBox.Show(m.Voar(p));
        }

        private void btnAndar_Click(object sender, EventArgs e)
        {
            Personagem p = new Personagem();
            p.Nome = txtNome.Text;
            p.QtdePontos = int.Parse(txtPontos.Text);
            Movimentacao m = new Movimentacao();
            MessageBox.Show(m.Andar(p));
        }
    }
}
