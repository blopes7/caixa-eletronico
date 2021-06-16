using System;

namespace caixa_eletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota2 = 0;
            int nota5 = 0;
            int nota10 = 0;
            int nota20 = 0;
            int nota50 = 0;
            int nota100 = 0;
            int nota200 = 0;


            Console.WriteLine("Seja bem vindo ao nosso banco");
         Console.WriteLine("Notas disponíveis: R$2.00 | R$5.00 | R$20.00 | R$50.00 | R$100.00| R$200.00");
         Console.WriteLine("Digite o valor desejado: ");


            string valorDigitado = Console.ReadLine();
            int valorSaque = Convert.ToInt32(valorDigitado);

            while (valorSaque > 0)
            {
                if (valorSaque >=200)
                {
                     valorSaque -= 200;
                     nota200++;
                }
                else
                {
                    if (valorSaque >=100)
                    {
                        valorSaque -= 100; //saquei a nota
                        nota100++; // informei que saquei 1 nota de R$100
                    }
                    else
                    {
                        if (valorSaque >= 50)
                        {
                            valorSaque -= 50;
                            nota50++;
                        }
                        else
                        {
                            if (valorSaque >=20)
                            {
                                valorSaque -= 20;
                                nota20++;
                            }
                            else
                            {
                                if (valorSaque >=10)
                                {
                                    valorSaque -= 10;
                                    nota10++;
                                }
                                else
                                {
                                    if (valorSaque >=5)
                                    {
                                        valorSaque -= 5;
                                        nota5++;
                                    }
                                    else
                                    {
                                        if (valorSaque >=2)
                                        {
                                            valorSaque -= 2;
                                            nota2++;
                                        }
                                    }
                                }
                            }
                        }
                    }

                }

            }

            if (nota2 != 0)
            {
                Console.WriteLine("Nota 2: " + nota2);
            }
            if (nota5 != 0)
            {
                Console.WriteLine("Nota 5: " + nota5);
            }
            if (nota10 != 0)
            {
                Console.WriteLine("Nota 10: " + nota10);
            }
            if (nota20 != 0)
            {
                Console.WriteLine("Nota 20: " + nota20);
            }
            if (nota50 != 0)
            {
                Console.WriteLine("Nota 50: " + nota50);
            }
            if (nota100 != 0)
            {
                Console.WriteLine("Nota 100: " + nota100);
            }
            if (nota200 != 0)
            {
                Console.WriteLine("Nota 200: " + nota200);
            }
        }
    }
}
