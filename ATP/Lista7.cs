using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeClasses
{
    /* Classe Exercicio 1 */
    class Cliente
    {
        // Atributos
        private string Nome;
        private string Endereco;
        private string Telefone;

        // Getters e Setters
        public string _Nome
        { get { return Nome; } set { Nome = value; } }
        public string _Endereco
        { get { return Endereco; } set { Endereco = value; } }
        public string _Telefone
        { get { return Telefone; } set { Telefone = value; } }

        // Construtores
        public Cliente()
        {
            Nome = "";
            Endereco = "";
            Telefone = "";
        }

        public Cliente(string nome, string endereco, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }

        public void ToString()
        {
            Console.WriteLine($"Nome: {Nome}; Endereço: {Endereco}; Telefone: {Telefone}");
        }
    }

    /* Classe do exercicio 2 */
    class Data
    {
        // Atributos
        private int Dia;
        private int Mes;
        private int Ano;

        // Getters e Setters
        public int _Dia
        { get { return Dia; } set { Dia = value; } }
        public int _Mes
        { get { return Mes; } set { Mes = value; } }
        public int _Ano
        { get { return Ano; } set { Ano = value; } }

        // Construtor
        public Data(int dia, int mes, int ano)
        {
            Dia = dia;
            Mes = mes;
            Ano = ano;
        }

        public void ToString()
        {
            string dd = Dia < 10 ? $"0{Dia}" : $"{Dia}";
            string mm = Mes < 10 ? $"0{Mes}" : $"{Mes}";
            string aa = Ano < 10 ? $"0{Ano}" : $"{Ano}";

            Console.WriteLine($"{dd}/{mm}/{aa}");
            Console.ReadKey();
        }
    }

    /* Classe exercicio 3 */
    class Circulo
    {
        // Atributos
        private float Raio;

        // Getters e Setters
        public float _Raio
        { get { return Raio; } set { Raio = value; } }

        // Construtor
        public Circulo(float raio)
        {
            Raio = raio;
        }

        // Métodos
        public double CalcularArea()
        {
            return Math.Pow(Raio, 2) * Math.PI;
        }

        public float CalcularDiametro()
        {
            return Raio * 2;
        }

        public double CalcularPerimetro()
        {
            return Raio * 2 * Math.PI;
        }

        public void ToString()
        {
            Console.WriteLine($"Raio: {Raio}; Area: {this.CalcularArea()}; Diametro: {this.CalcularDiametro()}; Perimetro: {this.CalcularPerimetro()}");
            Console.ReadKey();
        }
    }

    /* Classe exercicio 4 */
    class Aluno
    {
        // Atributos
        private string Nome;
        private string Matricula;
        private double[] Notas;

        // Getters e Setters
        public string _Nome
        { get { return Nome; } set { Nome = value; } }
        public string _Matricula
        { get { return Matricula; } set { Matricula = value; } }
        public double[] _Notas
        { get { return Notas; } set { Notas = value; } }

        // Construtor
        public Aluno(string nome, string matricula, int qntNotas)
        {
            Nome = nome;
            Matricula = matricula;
            Notas = new double[qntNotas];
            PreencheNotas();
        }

        // metodos
        public void PreencheNotas()
        {
            for (int i = 0; i < Notas.Length; i++)
            {
                Console.WriteLine($"Digite a nota {i + 1} de {Nome}:");
                Notas[i] = double.Parse(Console.ReadLine());
            }
        }

        public double CalcularMediaNotas()
        {
            double soma = 0;
            for (int i = 0; i < Notas.Length; i++)
            {
                soma += Notas[i];
            }

            return soma / Notas.Length;
        }

        public void ToString()
        {
            Console.WriteLine($"Aluno: {Nome}");
            Console.WriteLine($"Matricula: {Matricula}");
            Console.WriteLine($"Notas:");

            for (int i = 0; i < Notas.Length; i++)
            {
                Console.WriteLine($"Prova {i + 1}: {Notas[i]}");
            }
            Console.WriteLine($"Média das notas: {CalcularMediaNotas()}");
        }
    }

    /* Classe do exercicio 6 */
    class Cargo
    {
        // Atributos
        private string codCargo;
        private double valorHoraTrabalhada;

        // Getters e setters
        public string _codCarg
        { get { return codCargo; } set { codCargo = value; } }
        public double _valorHoraTrabalhada
        { get { return valorHoraTrabalhada; } set { valorHoraTrabalhada = value; } }

        // Construtor
        public Cargo(string cod, double valorHora)
        {
            codCargo = cod;
            valorHoraTrabalhada = valorHora;
        }

    }

    class Funcionario
    {
        // Atributos
        private Cargo cargo;
        private char sexo;
        private double horasTrabalhadas;

        // Getters e setters
        public Cargo _cargo
        { get { return cargo; } set { cargo = value; } }
        public char _sexo
        { get { return sexo; } set { sexo = value; } }
        public double _horasTrabalhadas
        { get { return horasTrabalhadas; } set { horasTrabalhadas = value; } }

        // Construtor
        public Funcionario(string codCargo, double valorHora, char s, double h)
        {
            cargo = new Cargo(codCargo, valorHora);
            sexo = s;
            horasTrabalhadas = h;
        }

        // Métodos
        public double CalculaSalario()
        {
            return horasTrabalhadas * cargo._valorHoraTrabalhada;
        }

        public void ToString()
        {
            Console.WriteLine($"Cargo: {cargo._codCarg}");
            Console.WriteLine($"Sexo: {sexo}");
            Console.WriteLine($"Horas trabalhadas: {horasTrabalhadas}");
            Console.WriteLine($"Salario: {CalculaSalario()}");
        }
    }

    /* Classes do exercicio 7 */
    class Etiqueta
    {
        // Atributos
        private string marca;
        private string tamanho;

        // Getters e setters
        public string _marca
        { get { return marca; } set { marca = value; } }
        public string _tamanho
        { get { return tamanho; } set { tamanho = value; } }

        // Construtor
        public Etiqueta(string marca, string tamanho)
        {
            this.marca = marca;
            this.tamanho = tamanho;
        }
    }

    class Produto
    {
        // Atributos
        private string nome;
        private double preco;
        private Etiqueta etiqueta;

        // Getters e setters
        public string _nome
        { get { return nome; } set { nome = value; } }
        public double _preco
        { get { return preco; } set { preco = value; } }
        public Etiqueta _etiqueta
        { get { return etiqueta; } set { etiqueta = value; } }

        // Construtores
        public Produto(string nome, double preco, Etiqueta etiqueta)
        {
            this.nome = nome;
            this.preco = preco;
            this.etiqueta = etiqueta;
        }

        public Produto(string nome, double preco, string marca, string tamanho)
        {
            this.nome = nome;
            this.preco = preco;
            etiqueta = new Etiqueta(marca, tamanho);
        }

        // Metodos
        public void ToString()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Marca: {etiqueta._marca}");
            Console.WriteLine($"Tamanho: {etiqueta._tamanho}");
            Console.WriteLine($"Preço: {preco}");
        }
    }

    /* Classes do exercicio 8 */
    class ClienteBanco
    {
        // Atributos
        private string nome;
        private string cpf;
        private ContaCorrente conta;

        // Getters e setters
        public string _nome
        { get { return nome; } set { nome = value; } }
        public string _cpf
        { get { return cpf; } set { cpf = value; } }
        public ContaCorrente _conta
        { get { return conta; } set { conta = value; } }

        // Construtor
        public ClienteBanco(string nome, string cpf, ContaCorrente conta)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.conta = conta;
        }

        // Metodos
        public bool Sacar(double valor)
        {
            return conta.Sacar(valor);
        }

        public void Depositar(double valor)
        {
            conta.Depositar(valor);
        }

        public void ToString()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"CPF: {cpf}");
            conta.ToString();
            conta._agencia.ToString();
        }
    }

    class ContaCorrente
    {
        // Atributos
        private int numero;
        private int digito;
        private double saldo;
        private Agencia agencia;

        // Getters e setters
        public int _numero
        { get { return numero; } set { numero = value; } }
        public int _digito
        { get { return digito; } set { digito = value; } }
        public double _saldo
        { get { return saldo; } }
        public Agencia _agencia
        { get { return agencia; } set { agencia = value; } }

        // Construtor
        public ContaCorrente(int numero, int digito, double saldoInicial, Agencia agencia)
        {
            this.numero = numero;
            this.digito = digito;
            this.saldo = saldoInicial;
            this.agencia = agencia;
        }

        // Metodos
        public void Depositar(double valor)
        {
            saldo += valor;
        }

        // Retorna true caso o saque seja bem sucedido e false caso contrario
        public bool Sacar(double valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente para saque.");
                Console.WriteLine($"Valor do saque: {valor}");
                Console.WriteLine($"Saldo: {saldo}");
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public string ConstultarSaldo()
        {
            return $"Numero da conta: {numero}, Digito: {digito}, Numero da agência: {agencia._numero}, Digito: {agencia._digito}\nSaldo: {saldo}";
        }

        public void ToString()
        {
            Console.WriteLine($"Conta corrente: {numero}, Digito:  {digito}");
            Console.WriteLine($"Saldo: {saldo}");

        }
    }

    class Agencia
    {
        // Atributos
        private string nome;
        private int numero;
        private int digito;

        // Getters e setters
        public string _nome
        { get { return nome; } set { nome = value; } }
        public int _numero
        { get { return numero; } set { numero = value; } }
        public int _digito
        { get { return digito; } set { digito = value; } }

        // Construtor
        public Agencia(string nome, int numero, int digito)
        {
            this.nome = nome;
            this.numero = numero;
            this.digito = digito;
        }

        public void ToString()
        {
            Console.WriteLine($"Agência: {nome}, {numero}, Digito: {digito}");
        }
    }

    class Estacionamento
    {
        private String nome; //nome do estacionamento.
        private int numTotalVagas;//número total de vagas do estacionamento.
        private int numVagasLivres; //número de vagas livres no estacionamento.
        private String[] vagas; // vetor que armazena cada uma das vagas do estacionamento

        public Estacionamento(String nome, int numTotalVagas)
        {
            this.nome = nome;
            this.numTotalVagas = numTotalVagas;
            this.numVagasLivres = numTotalVagas;
            this.vagas = new string[numTotalVagas];
        }

        public int Estacionar(String placa)
        {
            for (int i = 0; i < vagas.Length; i++)
            {
                if (vagas[i] == null)
                {
                    vagas[i] = placa;
                    return i;
                }
            }

            // Caso não tenha vagas disponiveis
            return -1;
        }
        public int ObterVagaOcupada(String placa)
        {
            for (int i = 0; i < vagas.Length; i++)
            {
                if (vagas[i] == placa)
                {
                    return i;
                }
            }

            // Caso a placa não seja encontrada
            return -1;
        }

        public void RetirarVeiculo(String placa)
        {
            for (int i = 0; i < vagas.Length; i++)
            {
                if (vagas[i] == placa)
                {
                    vagas[i] = null;
                }
            }
        }

        public int ObterNumVagasLivres()
        {
            int count = 0;

            for (int i = 0; i < vagas.Length; i++)
            {
                if (vagas[i] == null)
                {
                    count++;
                }
            }

            return count;
        }
        public void ExibirOcupacao()
        {
            string vaga;
            for (int i = 0; i < vagas.Length; i++)
            {
                vaga = vagas[i] == null ? "Vazio" : $"{vagas[i]}";
                Console.Write($"{vaga} ");
            }
            Console.WriteLine();
        }
    }

    internal class Program
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
            ex9();
        }

        static void ex1()
        {
            string nome, endereco, telefone;

            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o endereço: ");
            endereco = Console.ReadLine();
            Console.WriteLine("Digite o telefone: ");
            telefone = Console.ReadLine();
            Cliente c1 = new Cliente(nome, endereco, telefone);


            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o endereço: ");
            endereco = Console.ReadLine();
            Console.WriteLine("Digite o telefone: ");
            telefone = Console.ReadLine();
            Cliente c2 = new Cliente(nome, endereco, telefone);


            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o endereço: ");
            endereco = Console.ReadLine();
            Console.WriteLine("Digite o telefone: ");
            telefone = Console.ReadLine();
            Cliente c3 = new Cliente(nome, endereco, telefone);

            Console.WriteLine("Cliente 1:");
            c1.ToString();
            Console.WriteLine("Cliente 2:");
            c2.ToString();
            Console.WriteLine("Cliente 3:");
            c3.ToString();
            Console.ReadKey();
        }

        static void ex2()
        {
            // Teste com uma data com dia, mes e ano maiores que 10
            Data data1 = new Data(24, 12, 2024);
            // teste com uma data com dia, mês e ano menores que 10
            Data data2 = new Data(5, 5, 5);

            data1.ToString();
            data2.ToString();
        }

        static void ex3()
        {
            Circulo c1 = new Circulo(1);
            Circulo c2 = new Circulo(2);
            Circulo c3 = new Circulo(3);
            Circulo c4 = new Circulo(4);

            c1.ToString();
            c2.ToString();
            c3.ToString();
            c4.ToString();
        }

        static void ex4()
        {
            Aluno al1 = new Aluno("Igor", "856314", 3);
            Aluno al2 = new Aluno("Tadeu", "772231", 3);

            al1.ToString();
            al2.ToString();
            Console.ReadKey();
        }

        static void ex5()
        {
            Cliente[] clientes = new Cliente[3];
            string nome, endereco, telefone;

            // Inicializa os clientes
            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine($"Digite o nome do {i + 1} cliente: ");
                nome = Console.ReadLine();
                Console.WriteLine($"Digite o endereco do {i + 1} cliente: ");
                endereco = Console.ReadLine();
                Console.WriteLine($"Digite o telefone do {i + 1} cliente: ");
                telefone = Console.ReadLine();

                clientes[i] = new Cliente(nome, endereco, telefone);
            }

            // Modifica através da propriedade
            clientes[0]._Nome = "Igor Barroso Almeida";

            Console.WriteLine("Clientes: ");
            for (int i = 0; i < clientes.Length; i++)
            {
                clientes[i].ToString();
            }
            Console.ReadKey();
        }

        static void ex6()
        {
            Funcionario f1 = new Funcionario("1234", 50, 'f', 200);
            Funcionario f2 = new Funcionario("2222", 20, 'm', 150);
            Funcionario f3 = new Funcionario("3333", 100, 'f', 180);

            f1.ToString();
            Console.WriteLine("----------------");
            f2.ToString();
            Console.WriteLine("----------------");
            f3.ToString();
            Console.ReadKey();
        }

        static void ex7()
        {
            // Primeiro produto
            Console.WriteLine("Dados do primeiro produto: ");
            Console.WriteLine("Marca: ");
            string marca = Console.ReadLine();
            Console.WriteLine("tamanho: ");
            string tamanho = Console.ReadLine();
            Console.WriteLine("nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Etiqueta e1 = new Etiqueta(marca, tamanho);
            Produto p1 = new Produto(nome, preco, e1);

            // Segundo produto
            Console.WriteLine("Dados do segundo produto: ");
            Console.WriteLine("Marca: ");
            marca = Console.ReadLine();
            Console.WriteLine("tamanho: ");
            tamanho = Console.ReadLine();
            Console.WriteLine("nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            preco = double.Parse(Console.ReadLine());

            Produto p2 = new Produto(nome, preco, marca, tamanho);


            // Printa as informações
            p1.ToString();
            Console.WriteLine("------------");
            p2.ToString();
            Console.ReadKey();
        }

        static void ex8()
        {
            Agencia agencia = new Agencia("Pampulha", 7890, 5);
            ContaCorrente conta = new ContaCorrente(1234, 4, 150, agencia);
            ClienteBanco cliente = new ClienteBanco("Ademar da Silva", "123231518-12", conta);

            Console.WriteLine("Conta antes das operações");
            cliente.ToString();

            cliente.Sacar(140);
            Console.WriteLine("----------------------");
            Console.WriteLine("Consultando saldo: " + cliente._conta.ConstultarSaldo());
            Console.WriteLine("----------------------");
            cliente.Sacar(200);
            Console.WriteLine("----------------------");
            Console.WriteLine("Consultando saldo: " + cliente._conta.ConstultarSaldo());
            Console.WriteLine("----------------------");
            cliente.Depositar(25.45);
            Console.WriteLine("----------------------");
            Console.WriteLine("Consultando saldo: " + cliente._conta.ConstultarSaldo());
            Console.WriteLine("----------------------");

            Console.WriteLine("Conta depois das operações");
            cliente.ToString();
            Console.ReadKey();
        }

        static void ex9()
        {
            int vagaOcupada;
            Estacionamento e = new Estacionamento("Estacionamento", 10);

            vagaOcupada = e.Estacionar("HKT0098");
            vagaOcupada = e.Estacionar("OLP4290");
            vagaOcupada = e.Estacionar("HJB0495");
            vagaOcupada = e.Estacionar("OWB3904");
            
            Console.WriteLine("Ocupação após a chegada de quatro clientes:");
            e.ExibirOcupacao();
            
            //HKT0098 OLP4290 HJB0495 OWB3904 vazia vazia vazia vazia vazia vazia
            vagaOcupada = e.ObterVagaOcupada("HKT0098");
            Console.WriteLine($"Veículo HKT0098 está na vaga {vagaOcupada}");
            
            // Veículo HKT0098 está na vaga 0
            e.RetirarVeiculo("HKT0098");
            Console.WriteLine("Após a retirada do veículo de placa HKT0098:");
            e.ExibirOcupacao();
            
            //vazia OLP4290 HJB0495 OWB3904 vazia vazia vazia vazia vazia vazia
            vagaOcupada = e.Estacionar("HTP5619");
            vagaOcupada = e.Estacionar("BOL4861");
            vagaOcupada = e.Estacionar("HGT9436");
            Console.WriteLine("Ocupação após a chegada de mais 3 clientes:");
            e.ExibirOcupacao();
            
            //HTP5619 OLP4290 HJB0495 OWB3904 BOL4861 HGT9436 vazia vazia vazia vazia
            Console.WriteLine($"Vagas livres: {e.ObterNumVagasLivres()}");
            
            Console.ReadKey();
        }
    }
}
