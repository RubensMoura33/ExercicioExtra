

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite os dados do jogador:");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Data de Nascimento (formato: dd/mm/aaaa): ");
        DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
        Console.Write("Nacionalidade: ");
        string nacionalidade = Console.ReadLine();
        Console.Write("Altura: ");
        float altura = float.Parse(Console.ReadLine());
        Console.Write("Peso: ");
        float peso = float.Parse(Console.ReadLine());

        Console.WriteLine("Escolha a posição do jogador:");
        Console.WriteLine("1. Defesa");
        Console.WriteLine("2. Ataque");
        Console.WriteLine("3. Meio-Campo");
        Console.Write("Opção: ");
        int opcao = int.Parse(Console.ReadLine());

        Jogador.JogadorFutebol jogador;

        switch (opcao)
        {
            case 1:
                jogador = new Jogador.JogadorDefesa();
                break;
            case 2:
                jogador = new Jogador.JogadorAtaque();
                break;
            case 3:
                jogador = new Jogador.JogadorMeioCampo();
                break;
            default:
                Console.WriteLine("Opção inválida. O jogador será considerado na posição de defesa.");
                jogador = new Jogador.JogadorDefesa();
                break;
        }

        jogador.Nome = nome;
        jogador.DataNascimento = dataNascimento;
        jogador.Nacionalidade = nacionalidade;
        jogador.Altura = altura;
        jogador.Peso = peso;

        Console.WriteLine("\nDados do jogador:");
        jogador.ImprimirDados();
        Console.WriteLine("Idade: " + jogador.CalcularIdade());
        Console.WriteLine("Tempo até se aposentar: " + jogador.TempoAteAposentar() + " anos");

        Console.ReadLine();
    }
}

