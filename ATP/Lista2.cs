using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2Condicionais
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
            ex13();
        }

        static void ex1()
        {
            // Variaveis
            int idade1, idade2, idade3, maior, menor;

            // Leitura de dados
            Console.WriteLine("Digite a primeira idade: ");
            idade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda idade: ");
            idade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira idade: ");
            idade3 = int.Parse(Console.ReadLine());

            // Processamento de dados
            if (idade1 > idade2 && idade1 > idade3)
            {
                maior = idade1;
                if (idade2 > idade3)
                {
                    menor = idade3;
                }
                else
                {
                    menor = idade2;
                }
            }
            else if (idade2 > idade3)
            {
                maior = idade2;
                if (idade1 > idade3)
                {
                    menor = idade3;
                }
                else
                {
                    menor = idade1;
                }
            }
            else
            {
                maior = idade3;
                if (idade1 > idade2)
                {
                    menor = idade2;
                }
                else
                {
                    menor = idade1;
                }
            }

            // Saida de dados
            Console.WriteLine($"O maior é {maior} e o menor é {menor}");
            Console.ReadKey();
        }

        static void ex2()
        {  
            // Variaveis
            int num;
            string saida;

            // Leitura de dados
            Console.WriteLine("Digite o numero: ");
            num = int.Parse(Console.ReadLine());

            // Processamento de dados
            if (num == 1)
            {
                saida = "O valor em extenso é: Um";
            } else if (num == 2)
            {
                saida = "O valor em extenso é: Dois";
            } else if (num == 3)
            {
                saida = "O valor em extenso é: Três";
            } else if (num == 4)
            {
                saida = "O valor em extenso é: Quatro";
            } else if (num == 5)
            {
                saida = "O valor em extenso é: Cinco";
            } else {
                saida = "Valor inválido";
            }

            Console.WriteLine(saida);
            Console.ReadKey();
        }

        static void ex3()
        {
            // Variaveis
            int idade, tempo_habilitado;
            char tipo_habilitacao;

            // Leitura de dados
            Console.WriteLine("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tipo de habilitação que você tem: ");
            tipo_habilitacao = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tempo(em anos) habilitado: ");
            tempo_habilitado = int.Parse(Console.ReadLine());
           
            // Processamento e saida de dados
            if(idade >= 21)
            {
                if(tipo_habilitacao == 'C' || tipo_habilitacao == 'c')
                {
                    if(tempo_habilitado >= 1)
                    {
                        Console.WriteLine("Você atende aos requisitoss para tirar habilitação do tipo D");
                    } else
                    {
                        Console.WriteLine("Não pode tirar habilitação tipo D pois tem a habilitação do tipo C a pouco tempo.");
                    }
                } else if (tipo_habilitacao == 'B' || tipo_habilitacao == 'b')
                {
                    if (tempo_habilitado >= 2)
                    {
                        Console.WriteLine("Você atende aos requisitoss para tirar habilitação do tipo D");
                    } else
                    {
                        Console.WriteLine("Não pode tirar habilitação tipo D pois tem a habilitação do tipo D a pouco tempo.");
                    }
                } else
                {
                    Console.WriteLine("Não pode tirar habilitação tipo D pois não tem habilitação nem do tipo C nem do tipo B.");
                }
            } else
            {
                Console.WriteLine("Não pode tirar habilitação tipo D pois é novo demais.");
            }
            Console.ReadKey();
        }

        static void ex4()
        {
            // Variavel
            int opcao;
            float num1, num2, resultado = 0;

            // Leitura de dados
            Console.WriteLine("1. Somar dois números.\n2.Subtrair dois números.\n3.Multiplicação de dois números.\n4.Divisão de dois números.");
            opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o num1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o num2: ");
            num2 = int.Parse(Console.ReadLine());

            // Processamento de dados
            if (opcao == 1)
            {
                resultado = num1 + num2;
            } else if(opcao == 2)
            {
                resultado = num1 - num2;
            } else if (opcao == 3)
            {
                resultado = num1 * num2;
            } else if (opcao == 4)
            {
                if(num2 != 0)
                {
                    resultado = num1 / num2;
                } else
                {
                    Console.WriteLine("------ERRO------\nO denominador não pode ser igual a 0");
                }
            } else
            {
                Console.WriteLine("Opção invalida");
            }

            // Saida de dados
            if(resultado != 0)
            {
                Console.WriteLine($"O resultado é: {resultado}");
            }
            Console.ReadKey();
        }

        static void ex5()
        {
            // Variavel
            int idade;

            // Leitura de dados
            Console.WriteLine("Digite a idade do nadador");
            idade = int.Parse(Console.ReadLine());

            // Processamento e saida de dados
            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Infantil A.");
            } else if (idade >= 8 && idade <= 10)
            {
                Console.WriteLine("Infantil B.");
            } else if (idade >= 11 && idade <= 13)
            {
                Console.WriteLine("Juvenil A.");
            } else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Juvenil B.");
            } else if(idade >= 18)
            {
                Console.WriteLine("Sênior.");
            } else {
                Console.WriteLine("Não tem idade o suficiente para ser nadador");
            }
            Console.ReadKey();
        }

        static void ex6() {
            int w, x, y, z;
            double resultado = 0;

            // Leitura de dados
            Console.WriteLine("Digite o valor de w");
            w = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de y");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de z");
            z = int.Parse(Console.ReadLine());

            // Processamento de dados
            if(w == 1) {
                // Média geometrica
                resultado = Math.Sqrt(x*y*z);
            } else if(w == 2) {
                // Média ponderada
                resultado = (x + (2*y) + (3*z)) / 6f;
            } else if(w == 3) {
                // Média harmônica
                resultado = 1 / ((1f/x) + (1f/y) + (1f/z));
            } else if(w == 4) {
                // Média aritmética
                resultado = (x + y + z) / 3f;
            } else {
                Console.WriteLine("Opção invalida");
            }

            // Saida de dados
            if(w > 0 && w < 5) {
            Console.WriteLine($"O resultado é: {resultado}");
            }
            Console.ReadKey();
        }

        static void ex7() {
            // Variaveis
            int num;
           
            // Leitua de dados
            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());


            // Processamento e saida de dados
            if(num % 3 == 0 && num % 5 == 0) {
                Console.WriteLine("O numero é divisivel por 3 e por 5.");
            } else {
                Console.WriteLine("O número não é divisivel por 3 e por 5 simultaneamente");
            }
            Console.ReadKey();
        }

        static void ex8() {
            // Variaveis
            int dia;

            // Leitura de dados
            Console.WriteLine("Digite um numero de 1 a 7:");
            dia = int.Parse(Console.ReadLine());

            // Saida de dados
            switch(dia){
                case 1:
                    Console.WriteLine("O dia corresponde ao domingo");
                    break;
                case 2:
                    Console.WriteLine("O dia corresponde a segunda-feira");
                    break;
                case 3:
                    Console.WriteLine("O dia corresponde a terça-feira");
                    break;
                case 4:
                    Console.WriteLine("O dia corresponde a quarta-feira");
                    break;
                case 5:
                    Console.WriteLine("O dia corresponde a quinta-feira");
                    break;
                case 6:
                    Console.WriteLine("O dia corresponde a sexta-feira");
                    break;
                case 7:
                    Console.WriteLine("O dia corresponde ao sabado");
                    break;
                default:
                    Console.WriteLine("Dia invalido");
                    break;
            }
            Console.ReadKey();
        }

        static void ex9() {
            // Variaveis
            int num;

            // Leitura de dados
            Console.WriteLine("Digite um numero de 0 a 4");
            num = int.Parse(Console.ReadLine());

            // Processamento e saida de dados
            switch(num) {
                case 0:
                    Console.WriteLine($"O numero em extenso é: Zero");
                    break;
                case 1:
                    Console.WriteLine($"O numero em extenso é: Um");
                    break;
                case 2:
                    Console.WriteLine($"O numero em extenso é: Dois");
                    break;
                case 3:
                    Console.WriteLine($"O numero em extenso é: Três");
                    break;
                case 4:
                    Console.WriteLine($"O numero em extenso é: Quatro");
                    break;
                default:
                    Console.WriteLine($"numero invalido");
                    break;
            }
            Console.ReadKey();
        }

        static void ex10() {
            // Variaveis
            int opcao, medida = 0;

            // Leitura de dados
            Console.WriteLine("Escolha a conversão:\n1. Converter de centímetros para metros.\n2. Converter de metros para centímetros.\n3. Converter de milímetros para metros.\n4. Converter de metros para milímetros.");
            opcao = int.Parse(Console.ReadLine());
            if(opcao >0 && opcao < 5){
                Console.WriteLine("Digite a medida: ");
                medida = int.Parse(Console.ReadLine());
            }

            // Processamento e saida de dados
            switch(opcao) {
                case 1:
                    // Converter de centímetros para metros
                    Console.WriteLine($"cm: {medida} --> metros: {medida/100f}");
                    break;
                case 2:
                    // Converter de metros para centímetros
                    Console.WriteLine($"metros: {medida} --> cm: {medida*100}");                
                    break;
                case 3:
                    // Converter de milímetros para metros
                    Console.WriteLine($"milimetro: {medida} --> metros: {medida/1000f}");                    
                    break;
                case 4:
                    // Converter de metros para milímetros
                    Console.WriteLine($"metros: {medida} --> milimetros: {medida*1000}");
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
            Console.ReadKey();
        }

        static void ex11() {
            // Variaveis
            char letra;
            bool eh_vogal;

            // Leitura de dados
            Console.WriteLine("Digite uma letra");
            letra = char.Parse(Console.ReadLine());

            // Processamento de dados
            switch(letra){
                case 'a':
                    eh_vogal = true;
                    break;
                case 'A':
                    eh_vogal = true;
                    break;
                case 'e':
                    eh_vogal = true;
                    break;
                case 'E':
                    eh_vogal = true;
                    break;
                case 'i':
                    eh_vogal = true;
                    break;
                case 'I':
                    eh_vogal = true;
                    break;
                case 'o':
                    eh_vogal = true;
                    break;
                case 'O':
                    eh_vogal = true;
                    break;
                case 'u':
                    eh_vogal = true;
                    break;
                case 'U':
                    eh_vogal = true;
                    break;
                default:
                    // A letra é consoante
                    eh_vogal = false;
                    break;
            }

            // Saida de dados
            if(eh_vogal){
                Console.WriteLine("A letra é uma vogal");
            } else {
                Console.WriteLine("A letra não é uma vogal");
            }
            Console.ReadKey();
        }

        static void ex12() {
            // Variaveis
            float altura, peso_ideal;
            char sexo;

            // Leitura de dados
            Console.WriteLine("Digite a altura");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o sexo (M ou F):");
            sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Teste " + altura);
            // Processamento de dados
            peso_ideal = sexo == 'M' ? (72.7f * altura) - 58 : (62.1f * altura) - 44.7f;

            // Saida de dados
            Console.WriteLine($"Seu peso ideal é {peso_ideal}kg");
            Console.ReadKey();
        }

        static void ex13() {
            // Variaveis
            int ano;
            bool eh_bissexto;
           
            // Leitura de dados
            Console.WriteLine("Digite um ano para saber se ele é bissexto:");
            ano = int.Parse(Console.ReadLine());

            // Processamento de dados
            eh_bissexto = (ano % 400 == 0) || (ano % 4 == 0 && ano % 100 != 0)? true : false;

            // Saida de dados
            if(eh_bissexto) {
                Console.WriteLine("O ano informado é bissexto");
            } else {
                Console.WriteLine("O ano informado não é bissexto");
            }
            Console.ReadKey();
        }
    }
}