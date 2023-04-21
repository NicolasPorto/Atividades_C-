using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Course;

namespace Course
{
    internal class program
    {
        static void Main(string[] args)
        {
            Banco produto;
            double deposito = 0;

            Console.WriteLine("Entre o número da conta:");
            int numero_conta = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre o titular da conta:");
            String nome = Console.ReadLine();

            Console.WriteLine("Hávera deposito inicial?");
            if(Console.ReadLine() == "s") {

                Console.WriteLine("Entre o valor de deposito:");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                produto = new Banco(numero_conta, nome, deposito);
            }
            else
            {
                produto = new Banco(numero_conta, nome);

            }

            Console.WriteLine("Dados da conta: " + produto.ToString());

            Console.WriteLine("Entre um valor para deposito:");
            produto.ValorDeposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados atualizados: " + produto.ToString());

            Console.WriteLine("Entre um valor para Saque:");
            produto.ValorSaque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados atualizados: " + produto.ToString());
        }
    }
}

/*retangulo obj = new retangulo();

Console.WriteLine("Entre com a largura e a altura:");
obj.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
obj.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("AREA = " + obj.Area().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PERIMETRO = " + obj.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL = " + obj.Diagonal().ToString("F2", CultureInfo.InvariantCulture));


funcionario obj = new funcionario();

obj.nome = Console.ReadLine();
obj.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
obj.imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Funcionário: " + obj.nome + ", $" + obj.salarioLiquido());
Console.Write("Digite a porcentagem para aumentar salário: ");
obj.AumentarSalario(double.Parse(Console.ReadLine()));

Console.WriteLine("Dados Atualizados: " + obj.nome + ", $" + obj.salarioLiquido());*/

/*aluno obj = new aluno();

Console.WriteLine("Nome do aluno:");
obj.nome = Console.ReadLine();
Console.WriteLine("Digite as três notas:");
obj.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
obj.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
obj.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("NOTA FINAL = " + obj.nota_Final().ToString("F2", CultureInfo.InvariantCulture));

Console.WriteLine(obj.decisao());

if (obj.nota_Final() < 60)
{

    Console.WriteLine("FALTARAM " + obj.pontos_Faltantes().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS.");

}*/

/*double salario_Medio;

Console.WriteLine("NOME E SALARIO DA PRIMEIRA PESSOA: ");
String[] pessoa1 = Console.ReadLine().Split(' ');
Console.WriteLine("NOME E SALARIO DA SEGUNDA PESSOA");
String[] pessoa2 = Console.ReadLine().Split(' ');

salario_Medio = (double.Parse(pessoa1[2]) + double.Parse(pessoa2[2])) / 2;

Console.WriteLine("Salário médio: " + salario_Medio.ToString("F2", CultureInfo.InvariantCulture));*/