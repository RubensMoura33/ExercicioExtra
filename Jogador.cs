using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//1.Crie uma classe abstrata para representar um jogador de futebol, com os atributos nome, data de nascimento, nacionalidade, altura e peso. Crie um método para imprimir todos os dados do jogador. Crie um método para calcular a idade do jogador e outro método para mostrar quanto tempo falta para o jogador se aposentar. Para isso, crie outras 3 subclasses, JOGADORDEFESA, JOGADORATAQUE e JOGADORMEIO-CAMPO considere que os jogadores da posição de defesa se aposentam em média aos 40 anos, os jogadores de meio-campo aos 38 e os atacantes aos 35.//

namespace ExercicioExtra
{


    public abstract class Jogador
    {
        public string Nome; 
        public int Dia;
        public int Mes;
        public int Ano;
        public string Nacionalidade;
        public string Altura;
        public float Peso;
        public string DadosJogador(string nome, int dia, int mes, int ano, string nacionalidade, string altura, float peso)
        {
            Nome = nome;
            Dia = dia;
            Mes = mes;
            Ano = ano;
            Nacionalidade = nacionalidade;
            Altura = altura;
            Peso = peso;

           
            return @$"
            Dados do Jogador:
            Nome:{Nome}
            Data de nascimento:{dia}/{mes}/{ano}
            Nacionalidade:{Nacionalidade}
            Altura:{Altura}
            Peso:{Peso}";
        }

        
    }
    }
