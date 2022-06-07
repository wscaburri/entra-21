using ExerciciosListas;

Console.WriteLine(@"-----MENU-----
1 - Exercício 01
2 - Exercício 02
3 - Exercício 03");

Console.Write("Escolha o Exercício Desejado: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

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
    
