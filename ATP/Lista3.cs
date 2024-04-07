using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ATP
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex1();
            //ex2();
            //ex3();
            //ex4();
            //ex5();
            //ex6();
            //ex7();
            //ex8();
            //ex9();
            //ex10();
            //ex11();
            //ex12();
            //ex13();
            //ex14();
            ex15();
        }

        static void ex1()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Feliz ano novo!");
            Console.ReadKey();
        }

        static void ex2()
        {
            // Variaveis
            int num, i = 1;

            // Leitura de dados
            Console.WriteLine("Digite um número para saber sua tabuada");
            num = int.Parse(Console.ReadLine());

            // Processamento e saída de dados
            Console.WriteLine($"Tabuada do número {num}");
            while (i <= 10)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
                i++;
            }
            Console.ReadKey();
        }

        static void ex3()
        {
            // Variaveis
            int n, soma = 0, i = 0;

            // Leitura de dados
            Console.WriteLine("Digite a quantidade de numeros que serão somados:");
            n = int.Parse(Console.ReadLine());

            // Processamento de dados
            Console.WriteLine("Agora digite os números: ");
            do
            {
                soma += int.Parse(Console.ReadLine());
                i++;
            } while (i < n);

            // Saída de dados
            Console.WriteLine($"A soma dos números digitados é: {soma}");
            Console.ReadKey();
        }

        static void ex4()
        {
            // Variaveis
            int num, fatorial = 1;

            // Leitura de dados
            Console.WriteLine("Digite um número para saber seu fatorial: ");
            num = int.Parse(Console.ReadLine());

            // Processamento de dados
            for (int i = num; i > 0; i--)
            {
                fatorial *= i;
            }

            // Saída de dados
            Console.WriteLine($"{num}! = {fatorial}");
            Console.ReadKey();
        }

        static void ex5()
        {
            // Variaveis
            bool isPrimo;

            // Processamento e saida de dados
            for (int i = 2; i <= 100; i++)
            {
                int j = i - 1;
                isPrimo = true;

                // Verifica se o número é primo
                while (j > 1 && isPrimo)
                {
                    if (i % j == 0)
                    {
                        isPrimo = false;
                    }
                    j--;
                }

                if (isPrimo)
                {
                    Console.WriteLine($"{i} é primo");
                }
            }
            Console.ReadKey();
        }
        static void ex6()
        {
            // Variaveis
            int count = 0;
            float nota, soma = 0, media;

            // Processamento de dados
            do
            {
                Console.WriteLine("Digite a nota (negativo para parar):");
                nota = int.Parse(Console.ReadLine());

                if (nota > 0)
                {
                    soma += nota;
                    count++;
                }
            } while (nota > 0);
            media = soma / count;

            // Saída de dados
            Console.WriteLine($"A média das notas digitadas é {media}");
            Console.ReadKey();
        }

        static void ex7()
        {
            // Variaveis
            float fahrenheit;

            // Processamento e saída de dados
            for (int celcius = 0; celcius < 100; celcius++)
            {
                fahrenheit = 1.8f * celcius + 32;
                Console.WriteLine($"{celcius} C = {fahrenheit} F");
            }
            Console.ReadKey();
        }

        static void ex8()
        {
            // Variaveis
            int num, expoente, i = 1, resultado;

            // Leitura de dados
            Console.WriteLine("Digite a base:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente:");
            expoente = int.Parse(Console.ReadLine());

            // Processamento de dados
            resultado = num;
            while (i < expoente)
            {
                resultado *= num;
                i++;
            }

            // Saída de dados
            Console.WriteLine($"O resultado é: {resultado}");
            Console.ReadKey();
        }

        static void ex9()
        {
            // Variaveis
            int num, i = 1;

            // Leitura de dados
            Console.WriteLine("Digite o número:");
            num = int.Parse(Console.ReadLine());

            // Processamento de dados
            Console.WriteLine($"Os divisores de {num} são:");
            do
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i <= num);
            Console.ReadKey();
        }

        static void ex10()
        {
            // Variaveis
            int sorteio, tentativa, i = 1, limite = 7;
            Random aleatorio = new Random();

            // Interação com o usuario
            Console.WriteLine("~~~~~~~~~~ BEM VINDO ~~~~~~~~~~");
            Console.WriteLine($"Nesse jogo o computador pensa em um numero de 1 a 100 e você tem {limite} chances de acertar");

            // Processamento e saida de dados
            sorteio = aleatorio.Next(1, 101);
            do
            {
                Console.WriteLine($"Digite sua {i}º tentativa:");
                tentativa = int.Parse(Console.ReadLine());

                if (sorteio > tentativa)
                {
                    Console.WriteLine($"O número que o computador pensou é MAIOR que {tentativa}");
                } else if(sorteio < tentativa)
                {
                    Console.WriteLine($"O número que o computador pensou é MENOR que {tentativa}");
                } else
                {
                    Console.WriteLine("Parabéns! Você acertou o número que o computador pensou");
                }
                i++;
            } while (i <= limite && tentativa != sorteio);
            
            if(i == limite + 1)
            {
                Console.WriteLine($"Você perdeu. O número pensado pelo computador era {sorteio}");
            }

            Console.ReadKey();
        }

        static void ex11()
        {
            // Variaveis
            int termoN, razao;

            // Leitura de dados
            Console.WriteLine("Digite o primeiro termo da sequência:");
            termoN = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a razão da PA:");
            razao = int.Parse(Console.ReadLine());

            // Processamento e saida de dados
            for(int i = 0; i < 10; i++)
            {
                Console.Write($"{termoN}, ");
                termoN = termoN + razao;
            }
            Console.ReadKey();
        }

        static void ex12()
        {
            // Variaveis
            int num, resto, soma = 0;

            // Leitura de dados
            Console.WriteLine("Digite o número:");
            num = int.Parse(Console.ReadLine());

            // Processamento de dados
            while(num > 0)
            {
                resto = num % 10;
                num /= 10;
                soma += resto;
            }

            // Saída de dados
            Console.WriteLine($"A soma dos algarismos desse número é {soma}");
            Console.ReadKey();
        }
        static void ex13()
        {
            // Variaveis
            int x, y;

            // Leitura de dados
            Console.WriteLine("Digite X: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite Y: ");
            y = int.Parse(Console.ReadLine());

            // Processamento e saída de dados
            if(x < y)
            {
                // Se o x é menor vai de x a y
                do
                {
                    if(x % 2 != 0)
                    {
                        Console.Write($"{x},");
                    }
                    x++;
                } while (x < y);
            } else
            {
                // Se o y é menor vai de y a x
                do
                {
                    if (y % 2 != 0)
                    {
                        Console.Write($"{y},");
                    }
                    y++;
                } while (y < x);
            }
            Console.ReadKey();
        }
        static void ex14()
        {
            // Variaveis
            int impares = 1, numero, count = 0;

            // Leitura de dados
            Console.WriteLine("Digite o número:");
            numero = int.Parse(Console.ReadLine());

            // Processamento de dados
            while(numero > 0)
            {
                numero -= impares;
                impares += 2;
                count++;
            }

            // Saída de dados
            Console.WriteLine($"A raiz quadrada é {count}");
            Console.ReadKey();
        }
        static void ex15()
        {
            // Variaveis
            int qntTermos = 30, termoAtual = 480, resultado  = 0;

            // Processamento de dados
            for(int i = 1; i <= qntTermos; i++)
            {
                if(i % 2 == 0)
                {
                    resultado -= termoAtual;
                } else
                {
                    resultado += termoAtual;
                }
                termoAtual -= 5;
            }

            // Saída de dados
            Console.WriteLine($"{qntTermos} termos da sequencia resulta em: {resultado}");
            Console.ReadKey();
        }
    }
}