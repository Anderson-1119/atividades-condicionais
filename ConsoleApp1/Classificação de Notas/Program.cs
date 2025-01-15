// Classificação de Notas

Console.WriteLine("digite sua nota");
int numero = int.Parse(Console.ReadLine());
if (numero >=9)
{
    Console.WriteLine("excelente");
}
else if (numero >=7)
{
    Console.WriteLine("boa");
}
else if (numero <5)
{
    Console.WriteLine("baixa");
}
else
{
    Console.WriteLine("regular");
}

