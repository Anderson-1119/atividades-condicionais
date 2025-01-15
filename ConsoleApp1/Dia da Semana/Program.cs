// Dia da Semana

Console.WriteLine("digite um numero de 1 a 7");
int numero = int.Parse(Console.ReadLine());
if (numero == 1)
{
    Console.WriteLine("domingo");
}
else if (numero == 2)
{
    Console.WriteLine("segunda");
}
else if (numero == 3)
{
    Console.WriteLine("terça");
}
else if (numero == 4)
{
    Console.WriteLine("quarta");
}
else if (numero == 5)
{
    Console.WriteLine("quinta");
}
else if (numero == 6)
{
    Console.WriteLine("sexta");
}
else if (numero == 7)
{
    Console.WriteLine("sabado");
}
else
{
    Console.WriteLine("numero invalido, digite um numero de 1 a 7");
}
