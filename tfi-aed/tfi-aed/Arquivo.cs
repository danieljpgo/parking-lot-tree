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
            List<Estacionada> estacionadas;

            string linha;
            string[] linhaSepara;


            Console.WriteLine("Leitor de Placas iniciado.");
            while (!reader.EndOfStream)
            {
                linha = reader.ReadLine();
                linhaSepara = linha.Split(';');

                // Gerar Placa
                placa = new Placa(linhaSepara[0], int.Parse(linhaSepara[1]));

                // Gerar Nodo 
                estacionadas = new List<Estacionada>();
                placaNode = new PlacaNode(placa, estacionadas);

                // Inserir Nodo na Arvore
                placaArvore.Inserir(placaNode);
            }
            Console.WriteLine("Leitor de Placas finalizado.");
            return placaArvore;
        }

        public VagaArvore LeitorVagas()
        {
            StreamReader reader = new StreamReader("AEDVagasEstacionamento.txt");

            Vaga vaga;
            VagaNodo vagaNodo;
            VagaArvore vagaArvore = new VagaArvore();
            List<Estacionada> estacionadas;

            string linha;
            string[] linhaSepara;


            Console.WriteLine("Leitor de Vagas iniciado.");
            while (!reader.EndOfStream)
            {
                linha = reader.ReadLine();
                linhaSepara = linha.Split(';');

                // Gerar Placa
                vaga = new Vaga(linhaSepara[0], int.Parse(linhaSepara[1]));

                // Gerar Nodo 
                estacionadas = new List<Estacionada>();
                vagaNodo = new VagaNodo(vaga, estacionadas);

                // Inserir Nodo na Arvore
                vagaArvore.Inserir(vagaNodo);
            }
            Console.WriteLine("Leitor de Vagas finalizado.");
            return vagaArvore;
        }

        public dynamic LeitorEstacionada(PlacaArvore placaArvore, VagaArvore vagaArvore)
        {
            StreamReader reader = new StreamReader("AEDEstacionadas.txt");
            Estacionada estacionada;

            string linha;
            string[] linhaSepara;

            Console.WriteLine("Leitor de Estacionadas iniciado.");
            while (!reader.EndOfStream)
            {
                linha = reader.ReadLine();
                linhaSepara = linha.Split(';');

                if (placaArvore != null)
                {
                    // Gerar Estacionada
                    estacionada = new Estacionada(
                        linhaSepara[0],
                        linhaSepara[1],
                        DateTime.ParseExact(linhaSepara[2], "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture),
                        DateTime.ParseExact(linhaSepara[3], "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture));

                    // Inserir estacionada em seu respectivo Nodo na Arvore
                    placaArvore.InserirNaArvore(estacionada);
                }

                else
                {
                    // Gerar Estacionada
                    estacionada = new Estacionada(
                        linhaSepara[0],
                        linhaSepara[1],
                        DateTime.ParseExact(linhaSepara[2], "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture),
                        DateTime.ParseExact(linhaSepara[3], "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture));

                    // Inserir estacionada em seu respectivo Nodo na Arvore
                    vagaArvore.InserirNaArvore(estacionada);
                }
            }

            Console.WriteLine("Leitor de Estacionadas finalizado.");

            if (placaArvore != null)
            {
                return placaArvore;
            }

            else
            {
                return vagaArvore;
            }
        }
    }
}
