// Cálculo do Desconto 

Console.WriteLine("digite o valor");
double numero = double.Parse(Console.ReadLine());

if (numero > 100)
{
    double desconto = numero * 0.10;
    numero -= desconto;
    Console.WriteLine($"valor com desonto: R${numero}");
}
else
{
    Console.WriteLine($"valor original: R${numero}");
}
