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
                SoundPlayer voou = new SoundPlayer(@"C:\Users\Aluno\Documents\Curso\ApostilaDeCSharp\ApostilaDeCharp.OrientacaoObjetos\voando.wav");
                voou.Play();
                return $"{p.Nome} voou ";
                
               
            }
            else
            {
                return $"{p.Nome} Não voou";
            }
           
        }
        public string Nadar(Personagem p)
        {
            return $"{p.Nome} Nadou!";
        }
        public string Pular(Personagem p)
        {
            return $"{p.Nome} pulou !";
        }
        public string Correr(Personagem p)
        {
            return $"{p.Nome} correu !";
        }
        public string VirarEsquerda(Personagem p)
        {
            return $"{p.Nome} Virou a Esquerda";
        }
        public string VirarDireita(Personagem p)
        {
            return $"{p.Nome} virou a Direito";

        }
        public string Parar(Personagem p)
        {
            return $"{p.Nome} Parou ";
        }
        public string Voltar(Personagem p)
        {
            return $"{p.Nome} Voltou";
        }
        public string Andar(Personagem p)
        {
            SoundPlayer voou = new SoundPlayer(@"C:\Users\Aluno\Documents\Curso\ApostilaDeCSharp\ApostilaDeCharp.OrientacaoObjetos\andar.wav");
            voou.Play();
            return $"{p.Nome} você andou";
        }

     

    }
}
