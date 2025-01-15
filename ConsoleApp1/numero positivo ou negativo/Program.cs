// Objetivo: Aprender a trabalhar com condições múltiplas. 
// Descrição: Desenvolva um programa que solicita ao usuário um número.
// O programa deve determinar se o número é positivo, negativo ou zero, utilizando if, else if, e else para as três possibilidades.
// Exiba a mensagem correspondente. 
//Exemplo de Saída: "O número é positivo.", "O número é negativo." ou "O número é zero." 

Console.WriteLine("digite um numero");
int numero = int.Parse(Console.ReadLine());
if (numero > 0)
{
    Console.WriteLine("o numero é positivo");
}
else if (numero == 0)
{
    Console.WriteLine("o numero é zero");
}
else
{
    Console.WriteLine("o numero é negativo");
}

