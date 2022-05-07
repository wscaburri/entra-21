using Entra21.ExerciciosWhile;

Console.WriteLine(@"      MENU      
1 - Exercício 01
2 - Exercício 02
3 - Exercício 03
4 - Exercício 04
5 - Exercício 05
6 - Exercício 06
7 - Exercício 07
8 - Exercício 08");

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