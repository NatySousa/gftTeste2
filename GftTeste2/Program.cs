using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GftTeste2
{
    class Program
    {
        static void Main(string[] args)
        {
            DadosEntrada de = new DadosEntrada();

            Menu m = new Menu();

            int retorno = 0;

            while (retorno != 3)
            {
                m.Opcoes();

                retorno = Convert.ToInt32(Console.ReadLine());
                switch (retorno)
                {
                    case 1:
                        Console.Write("Informe o seu ano de nascimento: ");
                        de.AnoNascimento = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informe o ano atual: ");
                        de.AnoAtual = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Sua idade é " + (de.AnoAtual - de.AnoNascimento) + " anos");
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Write("Informe o seu peso: ");
                        de.Peso = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Informe a sua altura: ");
                        de.Altura = Convert.ToDouble(Console.ReadLine());
                        de.CalcularIMC();
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("Encerrando o programa...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida, por favor escolher uma das opções válidas.");
                        break;
                }

            }

            Console.ReadKey();
        }
    }
}

           