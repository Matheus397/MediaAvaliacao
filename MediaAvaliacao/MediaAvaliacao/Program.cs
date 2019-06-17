using System;
using System.Globalization;

namespace MediaAvaliacao

{
    class Program
    {
        static void Main(string[] args)
        {

            int[] notas;
            string[] nomes;
            int i;

            string[] s;
            nomes = new string[5];
            notas = new int[5];

            for (i = 0; i < 5; i++)
            {
                try
                {
                    Console.WriteLine("\nInforme o nome e a nota do Aluno\n");
                    s = Console.ReadLine().Split(' ');
                    nomes[i] = s[0];
                    notas[i] = int.Parse(s[1]);

                    while (notas[i] < 0 || notas[i] > 10)
                    {

                        Console.WriteLine("\nVocê informou uma nota inválida por favor insira novamente !");
                        notas[i] = int.Parse(Console.ReadLine());

                    }

                }

                catch (Exception)
                {

                    Console.WriteLine("Erro \n");
                    i--;

                }
            }

            int reprovados = 0;

            int aprovados = 0;

            int mediaSalaAprovados;

            int mediaSalaReprovados;

            double mediaTurma = 0.0;

            Console.Clear();

            for (i = 0; i < 5; i++)
            {

                if (notas[i] < 5)
                {

                    Console.WriteLine($"\n O aluno: {nomes[i]} tirou {notas[i]} Foi Reprovado");
                    reprovados++;

                }

                else if (notas[i] >= 5)
                {

                    Console.WriteLine($"\n O aluno: {nomes[i]} tirou {notas[i]} Foi Aprovado");
                    aprovados++;

                }

            }

            for (i = 0; i < 5; i++)
            {

                mediaTurma += notas[i];

            }

            mediaTurma = (double)mediaTurma / 5;

            mediaSalaReprovados = ((reprovados * 2) * 100) / 10;

            mediaSalaAprovados = ((aprovados * 2) * 100) / 10;

            Console.WriteLine($"\n A porcentagem de alunos aprovados é de: {mediaSalaAprovados} %  e de alunos reprovados é de {mediaSalaReprovados} %");

            Console.WriteLine($"\n São {aprovados} alunos aprovados e {reprovados} alunos reprovados !");

            Console.WriteLine($"\n A média da sala em nota é de {mediaTurma.ToString("F1", CultureInfo.InvariantCulture)}");

        }
    }
}









