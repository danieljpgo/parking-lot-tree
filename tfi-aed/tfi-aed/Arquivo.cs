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
        public PlacaArvore LeitorPlacas()
        {
            StreamReader reader = new StreamReader("AEDfrota.txt");

            Placa placa;
            PlacaNode placaNode;
            PlacaArvore placaArvore = new PlacaArvore();
            List<Estacionada> estacionadas = new List<Estacionada>();

            string linha;
            string[] linhaSepara;

            while (!reader.EndOfStream)
            {
                linha = reader.ReadLine();
                linhaSepara = linha.Split(';');
                placa = new Placa(linhaSepara[0], int.Parse(linhaSepara[1]));
                placaNode = new PlacaNode(placa, estacionadas);
                placaArvore.GerarArvore(placaNode);
            }

            return placaArvore;
        }

        public PlacaArvore LeitorEstacionada(PlacaArvore arvore)
        {
            StreamReader reader = new StreamReader("AEDEstacionadas.txt");
            Estacionada estacionada;

            string linha;
            string[] linhaSepara;

            while (!reader.EndOfStream)
            {
                linha = reader.ReadLine();
                linhaSepara = linha.Split(';');
                estacionada = new Estacionada(
                    linhaSepara[0],
                    linhaSepara[1],
                    DateTime.ParseExact(linhaSepara[2], "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture),
                    DateTime.ParseExact(linhaSepara[3], "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture));
                arvore.InserirNaArvore(estacionada);
                Console.WriteLine(estacionada);
            }

            return arvore;
        }
    }
}
