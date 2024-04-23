using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Lista04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1();
            //ex2();
            //ex3();
            ex4();
            //ex5();
            //ex6();
            //ex7();
            //ex8();
            //ex9();
            //ex10();
            //ex11();
            //ex12();
        }

        static void ex1()
        {
            // Variaveis
            int[] vet = new int[20];
            int busca, i, index = -1;

            // Leitura de dados
            for(i = 0; i < vet.Length; i++)
            {
                Console.WriteLine($"Digite o {i+1}º número:");
                vet[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite o número para saber o seu index:");
            busca = int.Parse(Console.ReadLine());
            i = 0;

            // Processamento de dados
            while(index == -1 && i < vet.Length)
            {
                if (busca == vet[i])
                {
                    index = i;
                }
                i++;
            }

            // Saída de dados
            Console.WriteLine((index != -1) ? $"O número está na posição {index}" : "O número não está no vetor");
            Console.ReadKey();
        }

        static void ex2()
        {
            // Variaveis
            float[] vet = new float[60];
            float media = 0, soma = 0, notaAtual;
            int i = 0, j;

            // Leitura e processamento de dados
            do
            {
                Console.WriteLine($"Digite a {i+1}º nota:");
                notaAtual = float.Parse(Console.ReadLine());

                if(notaAtual > 0)
                {
                    soma += notaAtual;
                    vet[i] = notaAtual;
                    i++;
                }
            } while (i < vet.Length && notaAtual > 0) ;
            media = soma / i;

            // Saída de dados
            Console.WriteLine($"A média da turma foi {media}");
            Console.WriteLine("Notas de todos os alunos:");
            for (j = 0; j < i; j++)
            {
                Console.WriteLine($"Aluno {j}, nota: {vet[j]}");
            }
            Console.WriteLine("Notas acima da média:");
            for (j = 0; j < i; j++)
            {
                if (vet[j] >= media)
                {
                    Console.WriteLine($"Aluno {j}, nota: {vet[j]}");
                }
            }
            Console.ReadKey();
        }
        
        static void ex3()
            {
                // Variaveis
                int tamanhoNum, num, i, j = 0;
                bool isPalindromo = true;

                // Leitura de dados
                Console.WriteLine("Digite o tamanho do número palindromo:");
                tamanhoNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Agora digite o número:");
                num = int.Parse(Console.ReadLine());
                int[] vet = new int[tamanhoNum];
                int[] aux = new int[tamanhoNum];
                j = vet.Length - 1;

                // Processamento de dados
                for (i = 0; i < vet.Length; i++)
                {
                    vet[i] = num % 10;
                    num /= 10;

                    // Constroi um vetor invertido
                    aux[j] = vet[i];
                    j--;
                }
                for(i = 0; i < vet.Length; i++)
                {
                    if (vet[i] != aux[i])
                    {
                        isPalindromo = false;
                    }
                }

                // Saída de dados
                if(isPalindromo)
                {
                    Console.WriteLine("O número é palindromo");
                } else
                {
                    Console.WriteLine("O número não é palindromo");
                }
                Console.ReadKey();
        }
        
        static void ex4()
        {
            // Variaveis
            Random rand = new Random();
            int[] vet = new int[200];
            int opcao;

            for(int i = 0; i < vet.Length; i++)
            {
                vet[i] = rand.Next(0, 101);
            }
            do
            {
                Console.WriteLine("1. Mostrar menor nota\n2. Mostrar maior nota\n3. Pesquisar nota\n4. Mostrar média das notas e quantidade de notas acima da média\n5. Sair");
                opcao = int.Parse(Console.ReadLine());
                
                switch(opcao)
                {
                    case 1:
                        int menor = 101;
                        for(int i = 0; i < vet.Length; i++)
                        {
                            if (vet[i] < menor)
                            {
                                menor = vet[i];
                            }
                        }
                        Console.WriteLine("O menor número é " + menor);
                        break;
                    case 2:
                        int maior = -1;
                        for (int i = 0; i < vet.Length; i++)
                        {
                            if (vet[i] > maior)
                            {
                                maior = vet[i];
                            }
                        }
                        Console.WriteLine("O menor número é " + maior);
                        break;
                    case 3:
                        int nota;

                        Console.WriteLine("Digite a nota para saber suas posições: ");
                        nota = int.Parse(Console.ReadLine());
                        for(int i = 0; i < vet.Length; i++)
                        {
                            if (vet[i] == nota)
                            {
                                Console.WriteLine($"O número está na posição {i}");
                            }
                        }                        
                        break;
                    case 4:
                        float media;
                        int soma = 0;

                        for (int i = 0; i < vet.Length; i++)
                        {
                            soma += vet[i];
                        }

                        media = soma / vet.Length;
                        Console.WriteLine("A média de notas é " + media + " e os alunos acima da média são:");
                        for (int i = 0; i < vet.Length; i++)
                        {
                            if (vet[i] > media)
                            {
                                Console.WriteLine($"Aluno {i} nota {vet[i]}");
                            }
                        }
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Valor invalido! Digite um número entre 1 e 5");
                        break;
                }
            } while (opcao != 5);
        }
        
        static void ex5()
        {
            // Variaveis
            int[] votos = {0,0,0,0,0,0};
            int pos, indexMaior = 0, indexMenor = 0, maisVotado = 0, menosVotado = 100;

            // Leitura de dados (computa os votos)
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("0. Perna Longa\n1. Pluto\n2. Mickey\n3. Bob Esponja\n4. Cebolinha");
                pos = int.Parse(Console.ReadLine());
                
                // Conta votos nulos
                if(pos < 0 || pos > 4)
                {
                    pos = 5;
                }
                votos[pos]++;
            }

            for(int i = 0; i < 5; i++)
            {
                if (votos[i] > maisVotado)
                {
                    maisVotado = votos[i];
                    indexMaior = i;
                }
                if (votos[i] < menosVotado)
                {
                    menosVotado = votos[i];
                    indexMenor = i;
                }
            }

            // Saída de dados
            Console.WriteLine($"Candidato mais votado: {indexMaior} com {maisVotado} votos");
            Console.WriteLine($"Candidato menos votado: {indexMenor} com {menosVotado} votos");
            Console.WriteLine($"{votos[5]} votos nulos");
            Console.ReadKey();
        }
        
        static void ex6()
        {
            // Variaveis
            int[] vet1 = new int[5], vet2 = new int[5], soma = new int[5], produto = new int[5], diferenca = new int[5], uniao = new int[10];
            int[] intersecao = { 0, 0, 0, 0, 0 };
            int i = 0;

            // Leitura e processamento de dados
            for(i = 0; i < vet1.Length; i++)
            {
                Console.WriteLine($"Digite vet1[{i}]");
                vet1[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Digite vet2[{i}]");
                vet2[i] = int.Parse(Console.ReadLine());

                soma[i] = vet1[i] + vet2[i];
                produto[i] = vet1[i] * vet2[i];
                diferenca[i] = vet1[i] - vet2[i];
                uniao[i] = vet1[i];
                uniao[i+5] = vet2[i];
            }
            // Calcula interseção
            for(i = 0; i < vet1.Length; i++)
            {
                for (int j = 0; j < vet2.Length; j++)
                {
                    if (vet1[i] == vet2[j])
                    {
                        intersecao[i] = vet1[i];
                    }
                }
            }

            // Saída de dados
            Console.WriteLine("Soma: ");
            for (i = 0; i < soma.Length; i++)
            {
                Console.Write($"[{i}] = {soma[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("produto: ");
            for (i = 0; i < produto.Length; i++)
            {
                Console.Write($"[{i}] = {produto[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("Diferença: ");
            for (i = 0; i < diferenca.Length; i++)
            {
                Console.Write($"[{i}] = {diferenca[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("Interseção: ");
            for (i = 0; i < soma.Length; i++)
            {
                if (intersecao[i] != 0)
                {
                    Console.Write($"[{i}] = {intersecao[i]} ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("União: ");
            for (i = 0; i < uniao.Length; i++)
            {
                Console.Write($"[{i}] = {uniao[i]} ");
            }
            Console.ReadKey();
        }

        static void ex7()
        {
            // Variaveis
            int[] vet = new int[10], ordenado = new int[10];            
            Random rand = new Random();
            int maior, indiceMaior = 0;

            // Preenchimento do vetor
            Console.WriteLine("Vetor desordenado: ");
            for(int i = 0;i < vet.Length;i++) {
                vet[i] = rand.Next(0, 100);
                Console.Write($"[{i}] = {vet[i]} ");
            }

            // Processamento de dados
            for(int i = 0; i < vet.Length; i++)
            {
                maior = int.MinValue;
                for (int j = 0; j < vet.Length; j++)
                {
                    if (vet[j] > maior)
                    {
                        maior = vet[j];
                        indiceMaior = j;
                    }
                }
                ordenado[i] = maior;
                vet[indiceMaior] = int.MinValue;
            }

            // Saída de dados
            Console.WriteLine("\nVetor ordenado:");
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write($"[{i}] = {ordenado[i]} ");
            }
            Console.ReadKey();
        }

        static void ex8()
        {
            // Variaveis
            int[] vetA = new int[8], vetB = new int[12], vetC = new int[20];

            // Leitura de dados
            for(int i = 0; i < vetA.Length + vetB.Length; i++)
            {
                if(i < 8)
                {
                    Console.WriteLine($"Preencha o vetA[{i}]");
                    vetA[i] = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"Preencha o vetB[{i - 8}]");
                    vetB[i - 8] = int.Parse(Console.ReadLine());
                }
            }

            // Processamento de dados
            for (int i = 0; i < vetA.Length + vetB.Length; i++)
            {
                if (i < 8)
                {
                    vetC[i] = vetA[i];
                }
                else
                {
                    vetC[i] = vetB[i - 8];
                }
            }

            // Saída de dados
            Console.WriteLine("VetC:");
            for (int i = 0; i < vetC.Length; i++)
            {
                Console.Write($"[{i}] = {vetC[i]} ");
            }
            Console.ReadKey();
        }

        static void ex9()
        {
            // Variaveis
            int[] vetA = new int[10], vetB = new int[10];

            // Leitura de dados
            for(int i = 0; i < vetA.Length; i++)
            {
                Console.WriteLine($"Preencha vetA[{i}]: ");
                vetA[i] = int.Parse(Console.ReadLine());
            }

            // Processamento de dados
            for(int i = 0; i < vetA.Length; i++)
            {
                if (vetA[i] % 2 == 0)
                {
                    vetB[i] = vetA[i] / 2;
                } else
                {
                    vetB[i] = vetA[i] * 3;
                }
            }

            // Saída de dados
            Console.WriteLine("VetB:");
            for(int i = 0; i < vetB.Length; i++)
            {
                Console.Write($"Vetb[{i}] = {vetB[i]} ");
            }
            Console.ReadKey();
        }

        static void ex10()
        {
            // Variaveis
            int[] vetA = new int[25], vetB = new int[25], vetC = new int[50];
            int aux;

            // Leitura de dados
            for (int i = 0; i < vetA.Length + vetB.Length; i++)
            {
                if (i < 25)
                {
                    Console.WriteLine($"Preencha o vetA[{i}]");
                    vetA[i] = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"Preencha o vetB[{i - 25}]");
                    vetB[i - 25] = int.Parse(Console.ReadLine());
                }
            }

            // Processamento de dados
            for(int i = 0; i < vetC.Length; i++)
            {
                aux = i < 25 ? i : i - 25;
                if(i % 2 == 0)
                {
                    vetC[i] = vetB[aux];
                } else
                {
                    vetC[i] = vetA[aux];
                }
            }

            // Saída de dados
            Console.WriteLine("VetC:");
            for (int i = 0; i < vetC.Length; i++)
            {
                Console.Write($"vetC[{i}] = {vetC[i]} ");
            }
            Console.ReadKey();
        }

        static void ex11()
        {
            // Variaveis
            int[] vet = new int[16];
            int aux;
            Random rand = new Random();

            // Preenche e mostra o vetor original
            Console.WriteLine("Vetor original:");
            for(int i = 0; i < vet.Length; i++)
            {
                vet[i] = rand.Next(0, 101);
                Console.Write($"Vet[{i}] = {vet[i]} ");
            }

            // Processamento de dados
            for(int i = 0; i < vet.Length / 2; i++)
            {
                aux = vet[i];
                vet[i] = vet[i+8];
                vet[i + 8] = aux;
            }

            // Saída de dados
            Console.WriteLine("\nValores trocados:");
            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write($"Vet[{i}] = {vet[i]} ");
            }
            Console.ReadKey();
        }

        static void ex12()
        {
            // Variaveis
            float[] vetA = new float[10], vetB = new float[10], vetD = new float[10];
            char[] vetC = new char[10];

            // Leitura de dados
            for (int i = 0; i < vetA.Length; i++)
            {
                Console.WriteLine($"Digite vetA[{i}]: ");
                vetA[i] = float.Parse(Console.ReadLine());
                Console.WriteLine($"Digite vetB[{i}]: ");
                vetB[i] = float.Parse(Console.ReadLine());
                Console.WriteLine($"Digite vetC[{i}] (+, -, *, /): ");
                vetC[i] = char.Parse(Console.ReadLine());
            }

            // Processamento de dados
            for (int i = 0; i < vetA.Length; i++)
            {
                switch (vetC[i])
                {
                    case '+':
                        vetD[i] = vetA[i] + vetB[i];
                        break;
                    case '-':
                        vetD[i] = vetA[i] - vetB[i];
                        break;
                    case '*':
                        vetD[i] = vetA[i] * vetB[i];
                        break;
                    case '/':
                        vetD[i] = vetA[i] / vetB[i];
                        break;
                    default:
                        Console.WriteLine($"Operação [{i}] invalida");
                        vetD[i] = 0;
                        break;
                }
            }

            // Saída de dados
            for(int i = 0; i < vetA.Length; i++)
            {
                Console.WriteLine($"{vetA[i]} {vetC[i]} {vetB[i]} = {vetD[i]}");
            }
            Console.ReadKey();
        }
    }
}