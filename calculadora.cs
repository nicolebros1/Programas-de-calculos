using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Calculadora Simples");
            Console.WriteLine("1. Adição");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Sair");

            Console.Write("Escolha uma operação (1-5): ");
            string escolha = Console.ReadLine();

            if (escolha == "5")
            {
                break;
            }

            double numero1, numero2, resultado;

            Console.Write("Digite o primeiro número: ");
            if (!double.TryParse(Console.ReadLine(), out numero1))
            {
                Console.WriteLine("Entrada inválida para o primeiro número.");
                continue;
            }

            Console.Write("Digite o segundo número: ");
            if (!double.TryParse(Console.ReadLine(), out numero2))
            {
                Console.WriteLine("Entrada inválida para o segundo número.");
                continue;
            }

            switch (escolha)
            {
                case "1":
                    resultado = numero1 + numero2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case "2":
                    resultado = numero1 - numero2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case "3":
                    resultado = numero1 * numero2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case "4":
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine($"Resultado: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Não é possível dividir por zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida. Escolha uma operação válida.");
                    break;
            }
        }

        Console.WriteLine("Calculadora encerrada. Pressione qualquer tecla para sair.");
        Console.ReadKey();
    }
}
