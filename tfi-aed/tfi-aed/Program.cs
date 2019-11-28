using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfi_aed
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            while(opcao != 4)
            {
                Console.WriteLine("Selecione uma das opções abaixo:\n 1- X \n 2- \n 3 - \n 4 - Sair\nDigite a opção selecionada:");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Clear();

                    Console.WriteLine("Digite algo para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opcao == 2)
                {
                    Console.Clear();

                    Arquivo dados = new Arquivo();
                    PlacaArvore placaArvore = dados.LeitorPlacas();
                    placaArvore = dados.LeitorEstacionada(placaArvore);

                    Console.WriteLine("Qual placa do carro deseja pesquisar?");
                    string placa = Console.ReadLine();



                    placaArvore.PrintarEstaciondas(placa);

                    Console.WriteLine("Digite algo para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opcao == 3)
                {
                    Console.Clear();

                    Console.WriteLine("Digite algo para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                } 
                else {

                }
            }
        }
    }
}
    