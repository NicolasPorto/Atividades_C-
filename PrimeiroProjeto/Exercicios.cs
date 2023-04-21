using System;
using System.Globalization;

namespace Couse{

    /*class exerc2{
         static void Main(String[] args){

             int A, B, C, D, dif;

             Console.WriteLine("Digite 4 valores:");
             A = int.Parse(Console.ReadLine());
             B = int.Parse(Console.ReadLine());
             C = int.Parse(Console.ReadLine());
             D = int.Parse(Console.ReadLine());

             dif = (A * B - C * D);

             Console.WriteLine("DIFERENÇA = " + dif);

         }
     }*/

    /*class exerc3{
        static void Main(String[] args){

            int num_funcionario;
            double horas, valor_hora, salario;

            Console.WriteLine("Número do funcionário:");
            num_funcionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Horas Trabalhadas:");
            horas = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor hora:");
            valor_hora = double.Parse(Console.ReadLine());

            salario = horas * valor_hora;

            Console.WriteLine("NUMBER = " + num_funcionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));
        }
    }*/

    /*class exerc4{
        static void Main(String[] args)
        {
            int cod1, cod2, qtd1, qtd2;
            double preco1, preco2, valor_total;

            Console.WriteLine("Codigo 1:");
            cod1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade 1:");
            qtd1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Preço 1:");
            preco1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Codigo 2:");
            cod2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade 2:");
            qtd2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Preço 2:");
            preco2 = double.Parse(Console.ReadLine());

            valor_total = (qtd1 * preco1) + (qtd2 * preco2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valor_total.ToString("F2"));  

        }
    }*/

    /*class exerc5{
        static void Main(String[] args){


            Console.WriteLine("Digite três valores:");
            String[] vet = Console.ReadLine().Split(' ');

            double A = double.Parse(vet[0]);
            double B = double.Parse(vet[1]);
            double C = double.Parse(vet[2]);

            double triangulo = (A * C) / 2;
            double ciruclo = (3.14159 * C * C);
            double trapezio = ((A + B) / 2) * C;
            double quadrado = B * B;
            double retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: " + ciruclo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));

        }
    }*/

    /*class exerc6{
        static void Main(String[] args){

            Console.WriteLine("Número: ");
            int num = int.Parse(Console.ReadLine());

            if(num%2 == 0){

                Console.WriteLine("PAR");

            }else{

                Console.WriteLine("IMPAR");
            }

        }
    }*/

    /*class exerc7{
        static void Main(String[] args){

            Console.WriteLine("Dois números: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1%num2 == 0 || num2%num1 == 0){

                Console.WriteLine("São Multiplos");

            }else{

                Console.WriteLine("Não São Multiplos");
            }

        }
    }*/

    /*class exerc8{
        static void Main(String[] args){

            int duracaoJogo = 0;

            Console.WriteLine("Hora inicial: ");
            int horaInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Hora final: ");
            int horaFinal = int.Parse(Console.ReadLine());

            if (horaInicial < horaFinal){

                duracaoJogo = horaFinal - horaInicial;

            }if(horaFinal <= horaInicial){

                duracaoJogo = 24 - horaInicial + horaFinal;

            }

            Console.WriteLine("O JOGO DUROU " + duracaoJogo + " HORA(S)");

        }
    }*/

    /*class exerc9{
        static void Main(String[] args){

            double total = 0;

            Console.WriteLine("Código e Quantidade:");
            String[] vet = Console.ReadLine().Split(' ');

            int cod = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);

            if (cod == 1) {

                total = quantidade * 4.00;

            }if (cod == 2) {

                total = quantidade * 4.50;


            }if (cod == 3) {

                total = quantidade * 5.00;

            }if (cod == 4){

                total = quantidade * 2.00;

            }if(cod == 5){

                total = quantidade * 1.50;

            }

            Console.WriteLine("Total: R$ " + total.ToString("F2"));
        }
    }*/

    /*class exerc10{
        static void Main(String[] args)
        {


            Console.WriteLine("Valor: ");
            double num = double.Parse(Console.ReadLine());

            if (num >= 0 && num <= 25)
            {

                Console.WriteLine("Intervalo [0,25]");

            }
            if (num > 25 && num <= 50)
            {

                Console.WriteLine("Intervalo [25,50]");

            }
            if (num > 50 && num <= 75)
            {

                Console.WriteLine("Intervalo [50,75]");

            }
            if (num > 75 && num <= 100)
            {

                Console.WriteLine("Intervalo [75,100]");

            }
            if(num < 0 || num > 100)
            {

                Console.WriteLine("Fora de intervalo");

            }
        }
    }*/

    /*class exerc11{
        static void Main(String[] args)
        {
            Console.WriteLine("Digite X e Y:");
            String[] vet = Console.ReadLine().Split(' ');

            double X = Double.Parse(vet[0], CultureInfo.InvariantCulture);
            double Y = Double.Parse(vet[1], CultureInfo.InvariantCulture);

            if(X > 0 && Y > 0)
            {
                Console.WriteLine("Q1");

            }else if(X > 0 && Y < 0)
            {
                Console.WriteLine("Q4");

            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("Q2");

            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Q3");

            }
            else if (Y == 0 && X == 0)
            {
                Console.WriteLine("ORIGEM");

            }
            else if (Y == 0)
            {
                Console.WriteLine("EIXO Y");

            }
            else if (X == 0)
            {
                Console.WriteLine("EIXO X");

            }
        }
    }*/

    /*class exerc12{
        static void Main(String[] args)
        {

            double salario, imposto;

            Console.WriteLine("Salário:");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(salario <= 2000.00)
            {
                Console.WriteLine("ISENTO");

            }else if(salario > 2000.00 && salario <= 3000.00)
            {

                imposto = (salario - 2000.00) * 0.08;
                Console.WriteLine("R$ " + imposto);

            }
            else if(salario > 3000.00 && salario <= 4500.00)
            {

                imposto = (1000.00 * 0.08) + ((salario - 3000.00) * 0.18);
                Console.WriteLine("R$ " + imposto);
            }
            else if(salario > 4500.00)
            {

                imposto = (1000.00 * 0.08) + (1500.00 * 0.18) + ((salario - 4500.00) * 0.28);
                Console.WriteLine("R$ " + imposto);
            }
        }
    }*/

    /*class exerc13{
        static void Main(String[] args)
        {

            Console.WriteLine("Digite a senha:");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }*/

    /*class exerc14{
        static void Main(String[] args)
        {
            double X, Y;

            Console.WriteLine("Digite X e Y");
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            while (X != 0 && Y != 0)
            {

                if (X > 0 && Y > 0)
                {
                    Console.WriteLine("PRIMEIRO");

                }
                else if (X > 0 && Y < 0)
                {
                    Console.WriteLine("QUARTO");

                }
                else if (X < 0 && Y > 0)
                {
                    Console.WriteLine("SEGUNDO");

                }
                else if (X < 0 && Y < 0)
                {
                    Console.WriteLine("TERCEIRO");

                }

                X = int.Parse(Console.ReadLine());
                Y = int.Parse(Console.ReadLine());

            }
        }
    }*/

    /*class exerc15{
        static void Main(String[] args)
        {
            int alcool = 0, gasolina = 0, diesel = 0;

            Console.WriteLine("1. Álcool | 2. Gasolina | 3. Diesel | 4. Fim");
            int opcao = int.Parse(Console.ReadLine());

            while (opcao != 4) { 

                if (opcao == 1)
                {
                    alcool = alcool + 1;

                }
                else if (opcao == 2)
                {
                    gasolina = gasolina + 1;

                }
                else if (opcao == 3)
                {
                    diesel = diesel + 1;

                }

                opcao = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);


        }
    }*/

    /*class exerc16{
        static void Main(String[] args)
        {

            Console.WriteLine("Valor:");
            int X = int.Parse(Console.ReadLine());

            for(int num = 1; num <= X; num++)
            {

                if(num%2 != 0)
                {

                    Console.WriteLine(num);

                }
            }
        }
    }*/

    /*class exerc17{
        static void Main(String[] args)
        {
            int num_in = 0;
            int num_out = 0;

            Console.WriteLine("Quantas entradas:");
            int N = int.Parse(Console.ReadLine());

            for(int X = 1; X <= N; X++)
            {

                int valor = int.Parse(Console.ReadLine());

                if(valor >= 10 && valor <= 20)
                {

                    num_in = num_in + 1;

                }
                else
                {

                    num_out = num_out + 1;

                }

            }

            Console.WriteLine(num_in + " in");
            Console.WriteLine(num_out + " out");

        }
    }*/

    /*class exerc18{
        static void Main(String[] args)
        {
            double media;

            Console.WriteLine("Quantas entradas:");
            int N = int.Parse(Console.ReadLine());

            for (int num = 1; num <= N; num++)
            {
                String[] vet = Console.ReadLine().Split(' '); 

                double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

                media = (A * 2.0 + B * 3.0 + C * 5.0)/ 10.0;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }
        }
    }*/

    /*class exerc19{
        static void Main(String[] args)
        {

            Console.WriteLine("QTD de entradas:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Numerador e Denominador:");

            for (int num = 1; num <= N; num++)
            {

                String[] vet = Console.ReadLine().Split(' ');

                double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double media = A / B;

                if(B == 0)
                {
                    Console.WriteLine("Divisão Impossivel");

                }
                else
                {

                    Console.WriteLine(media.ToString("F1"), CultureInfo.InvariantCulture);

                }
            }
        }
    }*/

    /*class exerc20{
        static void Main(String[] args)
        {
            int fatorial = 1;

            Console.WriteLine("Números:");
            int N = int.Parse(Console.ReadLine());
      
            for(int num = 1; num <= N; num++)
            {

                fatorial = fatorial * num; 

            }

            Console.WriteLine(fatorial);
            
        }
    }*/

    /*class exerc21{
        static void Main(String[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for(int num = 1; num <= N; num++)
            {

                if(N%num == 0)
                {

                    Console.WriteLine(num);

                }

            }
        }
    }*/

    /*class exerc22{
        static void Main(String[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for(int num = 1; num <= N; num++)
            {

                Console.WriteLine(num + " " + (num * num) + " " + (num * num * num));
 
            }
        }
    }*/
}