using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        public static int Divisao(int n, int n2) { 
            return  n / n2;
        }
        public static int Pergunta() {
            int numero = 0;
            Console.WriteLine();
            Console.Write("Informe o número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }
        public static string Primo(int n) {
            int cont = 0;
            for (int i = 1; i <= n; i++) {
                if (n % i ==0) {
                    cont++;
                }
            }

            if (cont == 2) {
                return "É um número primo";
            }

            return "Não é um número primo";
        }
        public static int Fatorial(int n) {
            if (n <= 1 ) {
                return 1;
            }

            return n * Fatorial(n-1);
        }
        static void Main(string[] args)
        {
            Boolean veri = false;
            int n1 = 0;
            int n2 = 0;

            do
            {
                Console.Clear();
                int opcao = 0;
                Console.WriteLine("Sistema matemático");
                Console.WriteLine("Calcular o fatorial (1)");
                Console.WriteLine("Verificar se um número é primo (2)");
                Console.WriteLine("Efetuar a divisão de um número Inteiro (3)");
                Console.WriteLine("Sair(4)");
                Console.Write("Opção:");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"Fatorial: {Fatorial(Pergunta())}");
                        break;
                    case 2:
                        Console.WriteLine($"{Primo(Pergunta())}");
                        break;
                    case 3:
                        Console.Write("Informe o dividendo: ");
                        n1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Informe o divisor: ");
                        n2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"A divisão: {Divisao(n1, n2)}");

                        break;
                    case 4:
                        veri = true;
                        break;
                    default:
                        Console.WriteLine("Digitou errado");
                    break;
                }
                Console.ReadKey();
            }while (!veri);
        }
    }
}
