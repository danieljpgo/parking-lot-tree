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
            Arquivo dados = new Arquivo();

            PlacaArvore placaArvore = dados.LeitorPlacas();
            placaArvore = dados.LeitorEstacionada(placaArvore);

            PlacaNode placaNode = placaArvore.LocalizarVeiculo("PUA-7542");
            Console.WriteLine(placaNode);


            Console.ReadKey();
        }
    }
}
