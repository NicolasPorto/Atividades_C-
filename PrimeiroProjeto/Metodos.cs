using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class retangulo
    {

        public double Altura;
        public double Largura;

        public double Area()
        {
            double area = Largura * Altura;

            return area;

        }

        public double Perimetro()
        {

            return 2 * (Largura + Altura);

        }

        public double Diagonal()
        {

            return Math.Sqrt(Largura * Largura + Altura * Altura);

        }
    }

    class funcionario
    {

        public String nome;
        public double salarioBruto;
        public double imposto;

        public double salarioLiquido()
        {

            return salarioBruto - imposto;
        }

        public void AumentarSalario(double porcentagem)
        {

            salarioBruto = (salarioBruto * (porcentagem/100)) + salarioBruto;
        }
    }

    class aluno
    {
        public String nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public double nota_Final()
        {

            return nota1 + nota2 + nota3;

        }

        public String decisao()
        {
            if(nota_Final() >= 60)
            {
                return "APROVADO";

            }
            else
            {

                return "REPROVADO";

            }
        }

        public double pontos_Faltantes()
        {
 
            return (60 - nota_Final());

        }
    }
}
