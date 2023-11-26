// See https://aka.ms/new-console-template for more information
Console.WriteLine("---Média de notas---");
Console.WriteLine("Seja bem vindo aluno(a) da Etec! Digite a seguir suas notas.");

double nt1, nt2, nt3, nt4, media;
string resultado;

Console.Write("1° nota...:");
nt1 = Convert.ToDouble(Console.ReadLine());

Console.Write("2° nota...:");
nt2 = Convert.ToDouble(Console.ReadLine());

Console.Write("3° nota...:");
nt3 = Convert.ToDouble(Console.ReadLine());

Console.Write("4° nota...:");
nt4 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

if (nt1 < 0  || nt1 > 10 
|| nt2 < 0  || nt2 > 10
|| nt3 < 0  || nt3 > 10
|| nt4 < 0  || nt4 > 10)
{
    Console.WriteLine("Digete notas somente entre 0 e 10!"); 
}


    else
{
    media = (nt1 + nt2 + nt3 + nt4) / 4;

if (media < 5)
    {
        resultado = "Reprovado";
    }
    else if (media > 6)
    {
        resultado = "Aprovado";
    }
    else
    {
        resultado = "Em recuperação";
    }
Console.WriteLine($"Você ficou com média {media}");
Console.WriteLine($"{resultado:resultado}");
}






