using Entra21.ExerciciosWhile;

Console.WriteLine(@"      MENU      
01 - Exercício 01
02 - Exercício 02
03 - Exercício 03
04 - Exercício 04
05 - Exercício 05
06 - Exercício 06
07 - Exercício 07
08 - Exercício 08
09 - Exercício 09
10 - Exercício 10
11 - Exercício 11
12 - Exercício 12
13 - Exercício 13");    

Console.Write("Digite o Exercício Desejado: ");
int exercicioDesejado = Convert.ToInt32(Console.ReadLine());

Console.Clear();

if (exercicioDesejado == 1)
{
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
else if (exercicioDesejado == 2)
{
    Exercicio02 exercicio02 = new Exercicio02();
    exercicio02.Executar();
}
else if (exercicioDesejado == 3)
{
    Exercicio03 exercicio03 = new Exercicio03();
    exercicio03.Executar();
}
else if (exercicioDesejado == 4)
{
    Exercicio04 exercicio04 = new Exercicio04();
    exercicio04.Executar();
}
else if (exercicioDesejado == 5)
{
    Exercicio05 exercicio05 = new Exercicio05();
    exercicio05.Executar();
}
else if (exercicioDesejado == 6)
{
    Exercicio06 exercicio06 = new Exercicio06();
    exercicio06.Executar();
}
else if (exercicioDesejado == 7)
{
    Exercicio07 exercicio07 = new Exercicio07();
    exercicio07.Executar();
}
else if (exercicioDesejado == 8)
{
    Exercicio08 exercicio08 = new Exercicio08();
    exercicio08.Executar();
}
else if (exercicioDesejado == 9)
{
    Exercicio09 exercicio09 = new Exercicio09();
    exercicio09.Executar();
}
else if (exercicioDesejado == 11)
{
    Exercicio11 exercicio11 = new Exercicio11();
    exercicio11.Executar();
}
else if (exercicioDesejado == 12)
{
    Exercicio12 exercicio12 = new Exercicio12();
    exercicio12.Executar();
}
else if (exercicioDesejado == 13)
{
    Exercicio13 exercicio13 = new Exercicio13();
    exercicio13.Executar();
}
