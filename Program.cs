Console.WriteLine("Bem vindo à Calculadora!");
Console.WriteLine();

Console.Write("Informe o primeiro número: ");
var n1 = Convert.Int32(Console.ReadLine());

Console.Write("Informe o segundo número.:" );
var n2 = Convert.Int32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Soma.....: {n1 + n2}");
Console.WriteLine($"Subtração: {n1 - n2}");
Console.WriteLine($"Divisão..: {n1 / n2}");
