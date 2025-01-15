//Comparação de Números 

Console.WriteLine("digite o primeiro numero");
int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("digite o segundo numero");
int numero2 = int.Parse(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine("o primeiro numero é maior que o segundo");
}
else if (numero1 == numero2)
{
    Console.WriteLine("os numeros sao iguais");
}
else
{
    Console.WriteLine("o segundo numero é maior que o primeiro");
}

