using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioExtra
{
    public class JogadorAtaque : Jogador
    {

        public void Aposentar()
        {
        if (Posicao == Atacante)
        {
          idadeAposentar = idade - 35; 
        }
        }
    }
}