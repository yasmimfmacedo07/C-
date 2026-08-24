Console.WriteLine("11)\tFaça um programa em C# que leia duas notas e a matrícula de 50 alunos, calcule e imprima:\r\na)\tA média aritmética das notas de cada aluno e uma mensagem indicando se o aluno está aprovado ou reprovado, conforme quadro abaixo:\r\n");
Console.WriteLine(" \n ");
Console.WriteLine("Média aritimética | Mensagem\nMenor ou igual 5.0|Aluno com a matricula XXXXXX foi reprovado\nMaior ou igual 6.0|Aluno com a matricula XXXXXX foi aprovado");
Console.WriteLine(" \n ");
Console.WriteLine("b) O total de alunos aprovados\n \nc) O total de alunos reprovados\n \nd) A média da turma");
Console.WriteLine(" \n ");
Console.WriteLine("------------------------------------------------------------------------");
int matricula, nota1, nota2, mediaaluno, mediaturma, alunosaprovaodos = 0, alunosreprovados = 0;
for (int i = 0; i < 50; i++)
{
    Console.Write("Digite a matrícula do aluno: ");
    matricula = int.Parse(Console.ReadLine());
    Console.Write("Digite a primeira nota do aluno: ");
    nota1 = int.Parse(Console.ReadLine());
    Console.Write("Digite a segunda nota do aluno: ");
    nota2 = int.Parse(Console.ReadLine());
    mediaaluno = (nota1 + nota2) / 2;
    if (mediaaluno >= 6)
    {
               Console.WriteLine($"Aluno {matricula} aprovado com média {mediaaluno}");
        alunosaprovaodos++;
    }
    else
    {
        Console.WriteLine($"Aluno {matricula} reprovado com média {mediaaluno}");
        alunosreprovados++;
    }
}
mediaturma = (alunosaprovaodos + alunosreprovados) / 5;
Console.WriteLine($"Média da turma: {mediaturma}");
Console.WriteLine($"Alunos aprovados: {alunosaprovaodos}");
Console.WriteLine($"Alunos reprovados: {alunosreprovados}");