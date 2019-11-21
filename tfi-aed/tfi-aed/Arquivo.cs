using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace tfi_aed
{
    class Arquivo
    {
        public void LeitorPlacas()
        {
            StreamReader reader = new StreamReader("AEDfrota.txt");

            Placa placa;
            PlacaNode placaNode;
            PlacaArvore placaArvore = new PlacaArvore();

            string linha;
            string[] linhaSepara;

            while (!reader.EndOfStream)
            {
                linha = reader.ReadLine();
                linhaSepara = linha.Split(';');
                placa = new Placa(linhaSepara[0], int.Parse(linhaSepara[1]));
                placaNode = new PlacaNode(placa);
                placaArvore.GerarArvore(placaNode);
            }
        }
    }
}
