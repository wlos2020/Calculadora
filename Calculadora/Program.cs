// See https://aka.ms/new-console-template for more information
// Declarando as variáveis e iniciando com zero.
double num1 = 0; double num2 = 0;

// TÍTULO NO CONSOLE C#.
Console.WriteLine("Console Calculadora em C#\r");
Console.WriteLine("------------------------\n");

// Solicita uo primeiro númeor a ser calculado.
Console.WriteLine("Digite um número e depois pressione Enter");
num1 = Convert.ToDouble(Console.ReadLine());

// Solicita o segundo número a ser calculado.
Console.WriteLine("Digite outro número e depois pressione Enter");
num2 = Convert.ToDouble(Console.ReadLine());

// Solicita uma das opções.
Console.WriteLine("Escolha uma das opções da lista:");
Console.WriteLine("\ta - Adição");
Console.WriteLine("\ts - Subtração");
Console.WriteLine("\tm - Multiplicação");
Console.WriteLine("\td - Divisão");
Console.Write("Qual sua opção? ");

// Usando Switch
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Sua resposta é: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Sua resposta é: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Sua resposta é: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        // Solicita que entre com número difereten de zero
        while (num2 == 0)
        {
            Console.WriteLine("Digite um número diferente de ZERO: ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"Sua resposta é: {num1} / {num2} = " + (num1 / num2));
        break;
}

// Aguarda a resposta do usuario paa fecar o app.
Console.Write("Pressione Qualquer tecla paa fechar a calculadora...");
Console.ReadKey();