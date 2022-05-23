using Entra21.ExerciciosVetor;

Console.WriteLine(@"----------MENU----------
1 - Exercício 01
2 - Exercício 02
3 - Exercício 03
4 - Exercício 04
8 - Exemplo Professor");

Console.Write("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

Console.Clear();

if (opcaoDesejada == 1)
{
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
else if (opcaoDesejada == 2)
{
    Exercicio02 exercicio02 = new Exercicio02();
    exercicio02.Executar();
}
else if (opcaoDesejada == 3)
{
    Exercicio03 exercicio03 = new Exercicio03();
    exercicio03.Executar();
}
else if (opcaoDesejada == 4)
{
    Exercicio04 exercicio04 = new Exercicio04();
    exercicio04.Executar();
}
else if (opcaoDesejada == 8)
{
    ExemplosProfessor exemplosProfessor = new ExemplosProfessor();
    exemplosProfessor.Executar();
}
