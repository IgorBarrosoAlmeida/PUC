namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio1();
            //exercicio2();
            //exercicio3();
            //exercicio4();
            //exercicio5();
        }

        static void exercicio1()
        {
            float lado, perimetro, area, diagonal;

            Console.WriteLine("Qual é o valor do lado do quadrado: ");
            lado = float.Parse(Console.ReadLine());

            perimetro = 4 * lado;
            area = (float)Math.Pow(lado, 2);
            diagonal = lado * (float)Math.Sqrt(2);

            Console.WriteLine($"O perimetro vale: {perimetro}\nA area vale {area}\nA diagonal vale: {diagonal}");
            Console.ReadKey();
        }

        static void exercicio2()
        {
            float h, b, perimetro, area, diagonal;

            Console.WriteLine("Digite o valor da altura do retangulo");
            h = float.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite o valor da base do retangulo");
            b = float.Parse(Console.ReadLine());

            perimetro = 2 * (h + b);
            area = b * h;
            diagonal = (float)Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));

            Console.WriteLine($"O perimetro vale: {perimetro}\nA area vale {area}\nA diagonal vale: {diagonal}");
            Console.ReadKey();
        }

        static void exercicio3()
        {
            int Fahrenheit, Celcius;

            Console.WriteLine("Digite a temperatura em Fahrenheit: ");
            Fahrenheit = int.Parse(Console.ReadLine());

            Celcius = (5 * (Fahrenheit - 32)) / 9;

            Console.WriteLine($"O valor em Celcius é {Celcius}");
            Console.ReadKey();
        }

        static void exercicio4()
        {
            int eleitores, voto_branco, voto_nulo, voto_valido;
            Console.WriteLine("Digite a quantidade total de eleitores:");
            eleitores = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de votos em branco:");
            voto_branco = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de votos nulo: ");
            voto_nulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de votos validos");
            voto_valido = int.Parse(Console.ReadLine());

            int porcentagem_branco = (voto_branco * 100) / eleitores;
            int porcentagem_nulo = (voto_nulo * 100) / eleitores;
            int porcentagem_valido = (voto_valido * 100) / eleitores;

            Console.WriteLine($"Porcentagem de voto em branco {porcentagem_branco}\nPorcentagem de voto nulo: {porcentagem_nulo}\nPorcentagem de votos validos: {porcentagem_valido}");
            Console.ReadKey();
        }

        static void exercicio5()
        {
            int varA, varB, aux;

            Console.WriteLine("Digite o valor de VarA:");
            varA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de VarB:");
            varB = int.Parse(Console.ReadLine());

            aux = varA;
            varA = varB;
            varB = aux;

            Console.WriteLine($"varA: {varA}\nvarB: {varB}");
            Console.ReadKey();
        }

        static void exercicio6() {
            float numerador, denominador;
            resultado = numerador / denominador;
            
            Console.WriteLine($"O resultado é {Math.Round(resultado, 2)}");
            Console.ReadKey();
        }

        static void exercicio7() {
            float despesa, gorjeta;

            Console.WriteLine("Digite o valor gasto: ");
            despesa = float.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite a porcentagem referente a gorjeta: ");
            gorjeta = float.Parse(Console.ReadLine());
            
            gorjeta = despesa * (gorjeta / 100);
            total = despesa + gorjeta;

            Console.WriteLine($"A gorjeta é: {gorjeta}\nE o total é: {total}");
            Console.ReadKey();
        }

        static void exercicio8() {
            int CDU, UDC, centena, dezena, unidade;

            Console.WriteLine("Digite um numero no formato CDU: ");
            CDU = int.Parse(Console.ReadLine());   
            
            centena = CDU / 100;
            CDU = CDU % 100;
            dezena = CDU / 10;
            CDU = CDU % 10;
            unidade = CDU;

            UDC = (centena * 100) + (dezena * 10) + (unidade);
            Console.WriteLine($"O numero em formato UDC é: {UDC}");
            Console.ReadKey();
        }

        static void exercicio9() {
            float kilowatt, salario_minimo, preco_kilowatt, valor_a_pagar;

            Console.WriteLine("Qual é o valor do salaro minimo: ");
            salario_minimo = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos kilowatt são gastos na residencia: ");
            kilowatt = float.Parse(Console.ReadLine());

            preco_kilowatt = salario_minimo / 1000;
            valor_a_pagar = preco_kilowatt * kilowatt;

            Console.WriteLine($"O preço por cada kilowatt é {preco_kilowatt}\nE o valor total a se pagar na residencia é: {valor_a_pagar}");
            Console.ReadKey();    
        }
    }
}

