using Entra21.ExemplosWhile;

Console.WriteLine(@"----------MENU----------
1 - Exemplo 01
2 - Exemplo 02
3 - Exemplo 03");

Console.Write("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    //NomeDaClasse nomeVariavel = new NomeDaClasse();
    Exemplo01 exemplo01 = new Exemplo01();
    exemplo01.Executar();
}
else if (opcaoDesejada == 2)
{
    Exemplo02 exemplo02 = new Exemplo02();
    exemplo02.Executar();
}
else if (opcaoDesejada == 3)
{
    Exemplo03 exemplo03 = new Exemplo03();
    exemplo03.Executar();
}