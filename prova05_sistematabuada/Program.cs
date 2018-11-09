using System;

namespace prova05_sistematabuada
{
    class Program
    {
        static void Main(string[] args)
        {

            int text = 0;
            do
            {
                Console.WriteLine("Informe uma opcao\n1 - Soma\n2 - Subtracao\n3 - Multiplicacao\n4 - Divisao");
                int operacao = Convert.ToInt32(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        for (int i = 1; i <= 10; i++)
                        {
                            for (int a = 1; a <= 10; a++)
                            {
                                Console.WriteLine("{0}+{1} = {2}", i, a, (i + a));
                            }
                            Console.WriteLine("\n");
                        }
                        text = 1;
                        break;

                    case 2:
                        for (int i = 1; i <= 10; i++)
                        {
                            for (int a = 1; a <= 10; a++)
                            {
                                Console.WriteLine("{0}-{1} = {2}", i, a, (i - a));
                            }
                            Console.WriteLine("\n");
                        }
                        text = 1;
                        break;
                    case 3:
                        for (int i = 1; i <= 10; i++)
                        {
                            for (int a = 1; a <= 10; a++)
                            {
                                Console.WriteLine("{0}*{1} = {2}", i, a, (i * a));
                            }
                            Console.WriteLine("\n");
                        }
                        text = 1;
                        break;
                    case 4:
                        for (int i = 1; i <= 10; i++)
                        {
                            for (int a = 1; a <= 10; a++)
                            {
                                Console.WriteLine("{0}/{1} = {2}", i, a, (i / a));
                            }
                            Console.WriteLine("\n");
                        }
                        text = 1;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcao invalida.");
                        break;
                }
            } while (text == 0);


        }
    }
}
