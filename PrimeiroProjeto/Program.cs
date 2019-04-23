using System;
using System.Globalization;
using System.Collections.Generic;
namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt = -1;
            while (opt != 0)
            {
                Console.WriteLine(
                    "\n----------------------------------------------------------" +
                    "\nESCOLHA UMA OPÇÃO: " +
                    "\n1 - Parte 1" +
                    "\n2 - Parte 2" +
                    "\n3 - Dados de duas pessoas e mostrar o nome da mais velha" +
                    "\n4 - Retângulo" +
                    "\n5 - Aluno" +
                    "\n6 - Conversor de Moeda" +
                    "\n7 - Banco" +
                    "\n8 - Employees Registry" +
                    "\n0 - Sair" +
                    "\n----------------------------------------------------------");
                opt = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------------------------------");
                switch (opt)
                {
                    case 1:
                        parte1();
                        break;
                    case 2:
                        parte2();
                        break;
                    case 3:
                        Older();
                        break;
                    case 4:
                        Retangulo();
                        break;
                    case 5:
                        Aluno();
                        break;
                    case 6:
                        Conversor();
                        break;
                    case 7:
                        Banco();
                        break;
                    case 8:
                        Employees();
                        break;
                    default:
                        break;
                }
            }            
        }

        static void Employees()
        {
            Console.Write("How many employees will be registered? ");
            int qte = int.Parse(Console.ReadLine());

            List<EmployeesRegistry> employer = new List<EmployeesRegistry>();
            for (int i = 1; i <= qte; i++)
            {
                Console.WriteLine("\nEmployee #{0}:", i);
                Console.Write("Id: ");
                string id = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employer.Add(new EmployeesRegistry(id, name, salary));
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            string idToIncrease = Console.ReadLine();
            
            int index = employer.FindIndex(x=> x.Id == idToIncrease);
            if (index == 1)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employer[index].IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("\nUpdated list of employees:");
            foreach(EmployeesRegistry obj in employer)
            {
                Console.WriteLine(obj);
            }
        }

        static void Banco()
        {
            Console.Write("Entre o número da conta: ");
            string conta = Console.ReadLine();
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial(s/n)? ");
            char opt = char.Parse(Console.ReadLine());
            double deposito;
            Banco b;
            if (opt == 's')
            {
                Console.Write("Entre o valor de depósito inicial:  ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                b = new Banco(conta, titular, deposito);
            }
            else
                b = new Banco(conta, titular);
            
            Console.WriteLine("\nDados da conta:\n" + b);

            Console.Write("\nEntre um valor para depósito: ");
            deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.Deposito(deposito);
            Console.WriteLine("\nDados da conta atualizados:\n" + b);

            Console.Write("\nEntre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.Saque(saque);
            Console.WriteLine("\nDados da conta atualizados:\n" + b);
        }

        static void Conversor()
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double qte = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.ValorTotal(cotacao, qte).ToString("F2", CultureInfo.InvariantCulture));
        }

        static void Aluno()
        {
            Aluno a = new Aluno();
            Console.Write("Nome do aluno: ");
            a.nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NOTA FINAL = " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(a.StatusAluno());
            if (a.StatusAluno() == "REPROVADO")
                Console.WriteLine("FALTARAM " + a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
        }

        static void Retangulo()
        {
            Retangulo ret = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo:");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }

        static void Older()
        {
            Pessoa x, y;
            x = new Pessoa();
            y = new Pessoa();
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Idade: ");
            x.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            y.nome = Console.ReadLine();
            Console.Write("Idade: ");
            y.idade = int.Parse(Console.ReadLine());

            if (x.idade > y.idade)
                Console.WriteLine("Pessoa mais velha: " + x.nome);
            else if (y.idade > x.idade)
                Console.WriteLine("Pessoa mais velha: " + y.nome);
            else
                Console.WriteLine("Ambos tem a mesma idade!!");
        }

        static void parte1()
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: \n{0}, cujo preço é $ {1:F2}\n{2}, cujo preço é $ {3:F2}\n", produto1, preco1, produto2, preco2);
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}\nMedida com oito casas decimais: {medida:F8}\n");
            Console.WriteLine("Arredondado(três casas decimais): " + medida.ToString("F3") + "\nSeparador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }

        static void parte2()
        {
            Console.WriteLine("Entre com seu nome completo:");
            string name = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura(mesma linha):");
            string[] v = Console.ReadLine().Split(' ');
            string lastName = v[0];
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2], CultureInfo.InvariantCulture);

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine(name + "\n" + quartos + "\n" + preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName + "\n" + idade + "\n" + altura.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
