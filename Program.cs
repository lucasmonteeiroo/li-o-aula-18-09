
double num1, num2, num3, media;


Console.WriteLine("--- Média Aritmética de 3 números ---");
Console.WriteLine();


Console.Write("Digite o primeiro número: ");
num1 = Convert.ToDouble(Console.ReadLine());


Console.Write("Digite o segundo número: ");
num2 = Convert.ToDouble(Console.ReadLine());


Console.Write("Digite o terceiro número: ");
num3 = Convert.ToDouble(Console.ReadLine());


media = num1 + num2 + num3 / 3;


Console.WriteLine($"\nMédia: {media:N1}");