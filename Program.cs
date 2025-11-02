using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha o smartphone:");
        Console.WriteLine("1 - Nokia");
        Console.WriteLine("2 - iPhone");
        Console.Write("Opção: ");
        string opcao = Console.ReadLine();

        Console.Write("Digite o nome do aplicativo para instalar: ");
        string nomeApp = Console.ReadLine();

        Smartphone smartphone;

        if (opcao == "1")
        {
            smartphone = new Nokia("11999999999", "Nokia 3310", "IMEINOKIA1234", 64);
        }
        else if (opcao == "2")
        {
            smartphone = new Iphone("11988888888", "iPhone 13", "IMEIIPHONE1234", 128);
        }
        else
        {
            Console.WriteLine("Opção inválida!");
            return;
        }

        Console.Write("Deseja realizar uma ligação? (s/n): ");
        string ligar = Console.ReadLine();

        if (ligar.ToLower() == "s")
        {
            smartphone.Ligar();
        }

        Console.Write("Deseja receber uma ligação? (s/n): ");
        string receber = Console.ReadLine();

        if (receber.ToLower() == "s")
        {
            smartphone.ReceberLigacao();
        }

        smartphone.InstalarAplicativo(nomeApp);
    }
}
