using FibonacciVerifier.Model;

while (true)
{
    int numero;
    while (true)
    {
        Console.WriteLine("\nDigite um número para verificar se pertence à sequência de Fibonacci:");
        try
        {
            numero = int.Parse(Console.ReadLine());
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Por favor, digite um número válido.\n");
        }
    }

    if (Fibonacci.Verificar(numero))
    {
        Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
    }
    else
    {
        Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
    }

    Console.WriteLine("\nDeseja continuar? (S/N)");
    string resposta = Console.ReadLine().ToUpper();

    if (resposta != "S")
    {
        Console.WriteLine("\nObrigado por utilizar o programa!");
        break;
    }
}