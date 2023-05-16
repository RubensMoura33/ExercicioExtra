
//1.Crie uma classe abstrata para representar um jogador de futebol, com os atributos nome, data de nascimento, nacionalidade, altura e peso. Crie um método para imprimir todos os dados do jogador. Crie um método para calcular a idade do jogador e outro método para mostrar quanto tempo falta para o jogador se aposentar. Para isso, crie outras 3 subclasses, JOGADORDEFESA, JOGADORATAQUE e JOGADORMEIO-CAMPO considere que os jogadores da posição de defesa se aposentam em média aos 40 anos, os jogadores de meio-campo aos 38 e os atacantes aos 35.//

using ExercicioExtra;

Console.WriteLine($"Digite o nome do jogador");
string nome = Console.ReadLine();

Console.WriteLine($"Digite o dia de nascimento");
int dia = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o mes de nascimento");
int mes = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o ano de nascimento");
int ano = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite a nacionalidade do jogador");
string nacionalidade = Console.ReadLine();

Console.WriteLine($"Digite a altura do jogador");
string altura = Console.ReadLine();

Console.WriteLine($"Digite o peso do jogador");
float peso = float.Parse(Console.ReadLine());


static char menu()
{
    Console.WriteLine($"---------------------------------------------");
    Console.WriteLine($"¦           Menu do Jogador                 ¦");
    Console.WriteLine($"---------------------------------------------");

    Console.WriteLine(@$"
    Escolha uma opcao?
    1 - Dados do jogador
    2 - Idade do Jogador
    3 - Tempo para aposentar
    4 - Cancelar operação

    0 - Sair
 ");
    return char.Parse(Console.ReadLine());
}

do
{
    switch (menu())
    {
        case '1':
        JogadorAtaque Ataque = new JogadorAtaque();
        Jogador.DadosJogador(nome, dia, mes, ano, nacionalidade, altura, peso);
    
            
            break;

        case '2':
            break;

        case '3':
            //desconto de 12%
            //exibir código de barras
            break;
        
        case '4':
            ;
            break;
    }
} while (menu() != '0');
