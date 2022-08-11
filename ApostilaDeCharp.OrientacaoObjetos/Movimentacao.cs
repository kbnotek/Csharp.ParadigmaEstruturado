using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;


namespace ApostilaDeCharp.OrientacaoObjetos
{
    public class Movimentacao
    {

        public string Voar(Personagem p)
        {

            if (p.QtdePontos > 10)
            {
                SoundPlayer voou = new SoundPlayer(Properties.Resources.voando); voou.Play();
                return $"{p.Nome} voou ";
                
               
            }
            else
            {
                return $"{p.Nome} Não voou";
            }
           
        }
        public string Nadar(Personagem p)
        {   // com link do diretorio local 
            //SoundPlayer voou = new SoundPlayer(@"C:\Users\Aluno\Documents\Curso\ApostilaDeCSharp\ApostilaDeCharp.OrientacaoObjetos\nadar.wav");
            SoundPlayer nadou = new SoundPlayer(Properties.Resources.nadar);
            nadou.Play();
            return $"{p.Nome} Nadou!";
        }
        public string Pular(Personagem p)
        {
            SoundPlayer pulou = new SoundPlayer(Properties.Resources.pular);
            pulou.Play();           
            return $"{p.Nome} pulou !";
        }
        public string Correr(Personagem p)
        {
            SoundPlayer coreu = new SoundPlayer(Properties.Resources.correr); 
            coreu.Play();
            return $"{p.Nome} correu !";
        }
        public string VirarEsquerda(Personagem p)
        {
            SoundPlayer virouE = new SoundPlayer(Properties.Resources.click);
            virouE.Play();
            return $"{p.Nome} Virou a Esquerda";
        }
        public string VirarDireita(Personagem p)
        {
            SoundPlayer virouD = new SoundPlayer(Properties.Resources.click);
            virouD.Play();
            return $"{p.Nome} virou a Direito";

        }
        public string Parar(Personagem p)
        {
            SoundPlayer parou = new SoundPlayer(Properties.Resources.parar);
            parou.Play();
            return $"{p.Nome} Parou ";
        }
        public string Voltar(Personagem p)
        {
            SoundPlayer voltou = new SoundPlayer(Properties.Resources.voltar);
            voltou.Play();
            return $"{p.Nome} Voltou";
        }
        public string Andar(Personagem p)
        {
            SoundPlayer andou = new SoundPlayer(Properties.Resources.andar); 
            andou.Play();
            return $"{p.Nome} você andou";
        }

     

    }
}
