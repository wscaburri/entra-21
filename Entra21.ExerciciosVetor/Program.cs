using Entra21.ExerciciosVetor;

Console.WriteLine(@"----------MENU----------
1 - Exercício 01
2 - Exercício 02
3 - Exercício 03
8 - Exemplo Professor");

Console.Write("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    Exercicios01 exercicios01 = new Exercicios01();
    exercicios01.Executar();
}
else if (opcaoDesejada == 2)
{
    Exercicios02 exercicios02 = new Exercicios02();
    exercicios02.Executar();
}
else if (opcaoDesejada == 3)
{
    Exercicios03 exercicios03 = new Exercicios03();
    exercicios03.Executar();
}
else if (opcaoDesejada == 4)
{
    Exercicios04 exercicios04 = new Exercicios04();
    exercicios04.Executar();
}
else if (opcaoDesejada == 8)
{
    ExemplosProfessor exemplosProfessor = new ExemplosProfessor();
    exemplosProfessor.Executar();
}