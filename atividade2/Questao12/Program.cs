Console.WriteLine("12) Faça um programa em C# que leia a altura, o sexo(“M”, “F”) e idade de 100 pessoas. Calcular e imprimir: \na) A maior altura \nb) Quantas mulheres estão com altura maior ou igual a 1.70\nc) Média de altura das mulheres com mais de 30 anos\n");
Console.WriteLine(" \n ");
Console.WriteLine("------------------------------------------------------------------------------------------------");
Console.WriteLine(" \n ");
int totalPessoas = 3, umesetenta=0, idade, mulheresmais30=0;
double altura, maioraltura=0, altura30=0, mediamulheresmais30 = 0;
char sexo;

for (int i = 1; i <= totalPessoas; i++)
{
    Console.WriteLine("Digite a altura " + i +  " da pessoa: ");
    altura = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o sexo da " + i + " pessoa  (M/F): ");
    sexo = char.Parse(Console.ReadLine().ToUpper());
    Console.WriteLine("Digite a idade da " + i + " pessoa: ");
    idade = int.Parse(Console.ReadLine());
    if (i == 1)
    {
        maioraltura = altura;
    }
    else
    {
        if (altura > maioraltura)
        {
            maioraltura = altura;
        }
    }
    if (sexo == 'F' && altura >= 170)
    {
        umesetenta++;
    }
    if (sexo == 'F' && idade > 30)
    {
        mulheresmais30++ ;
        altura30 += altura;
    }
}
mediamulheresmais30 = altura30 / mulheresmais30;
Console.WriteLine("=========== RESULTADOS ===========");
Console.WriteLine("");
Console.WriteLine($"A maior altura registrada foi: {maioraltura}\nMulheres com mais de 30 anos: {mediamulheresmais30}\nMulheres com altura maior ou igual a 1.70: {umesetenta}");