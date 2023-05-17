using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//1.Crie uma classe abstrata para representar um jogador de futebol, com os atributos nome, data de nascimento, nacionalidade, altura e peso. Crie um método para imprimir todos os dados do jogador. Crie um método para calcular a idade do jogador e outro método para mostrar quanto tempo falta para o jogador se aposentar. Para isso, crie outras 3 subclasses, JOGADORDEFESA, JOGADORATAQUE e JOGADORMEIO-CAMPO considere que os jogadores da posição de defesa se aposentam em média aos 40 anos, os jogadores de meio-campo aos 38 e os atacantes aos 35.//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogador
{
    public abstract class JogadorFutebol
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Nacionalidade { get; set; }
    public float Altura { get; set; }
    public float Peso { get; set; }

    public abstract void ImprimirDados();

    public int CalcularIdade()
    {
        DateTime hoje = DateTime.Today;
        int idade = hoje.Year - DataNascimento.Year;
        if (hoje < DataNascimento.AddYears(idade))
        {
            idade--;
        }
        return idade;
    }

    public abstract int TempoAteAposentar();
}
}