using System;

namespace EtecDsEstruturasDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Começou o Programa");

            // Para          => for      => Looping (Estrutura de Repetição) com fim definido.
            // Enquanto      => while    => Fim indefinido.
            // Para Cada     => foreach  => Usado para trabalhar com Vetores (Arrays)
            // Faça Enquanto => do while => "Atira antes, pergunta depois" -> executa a repetição, testa se era vdd depois.

            //                                             i = 0 + 1  -> 1ª Execução
            //                                             i = 1 + 1  -> 2ª Execução
            //                                             i = 2 + 1  -> 3ª Execução
            //                                             i = 3 + 1  -> 4ª Execução

            //   Controle    Parada   Incremento => i++ => i = i + 1;
            for (int i=0;      i<10; i++)
            {
                Console.WriteLine("Repetiu. Valor de i é {0} ", i);
            }

            Console.WriteLine("Saiu do looping for");

            Console.Clear();


            /**
             * Estrutura WHILE
             */

            // variável de controle
            string fruta_preferida = "pera"; // trocar para vazio

            int tentativas = 0;

                  // Critério de Parada
            while(fruta_preferida != "pera")
            {
                Console.Clear();

                Console.WriteLine("Digite a fruta preferida do Prof. Charles: ");
                fruta_preferida = Console.ReadLine();

                tentativas++;

                if (fruta_preferida != "pera")
                {
                    Console.WriteLine("Você errou, quer continuar? S = sim");

                    if (Console.ReadLine().ToUpper() != "S")
                        break;
                }
                else {

                    Console.WriteLine("Parabéns! Você acertou! Depois de {0} tentativas ", tentativas);
                }
            }

            Console.WriteLine("Vc saiu do lopping while");




            /**
             *  DO ... WHILE
             */
            Console.Clear();

            int y = 5; // Variável de controle.

            do
            {
              

                Console.WriteLine("O valor de y é {0}", y);

                y++;

            } while (y < 5);
                    // Critério de Parada.

            Console.WriteLine("Vou saiu do looping do ... while ");



            string resp;

            do
            {
                Console.WriteLine("Em qual dia de setembro comemora-se a independencia do Brasil?");
                resp = Console.ReadLine();

            } while (resp != "7");

            Console.WriteLine("Vc saiu do looping do ... while de novo ");





            Console.ReadKey();
        }
    }
}
