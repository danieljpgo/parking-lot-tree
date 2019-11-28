using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfi_aed
{
    class PlacaArvore
    {
        static PlacaNode raiz;
        static int indiceVetor;

        public PlacaArvore()
        { }

        // Método para checar se a árvore está vazia
        public bool ArvoreVazia()
        {
            if (raiz == null)
                return true;
            else
                return false;
        }

        // Método para gerar árvore
        public void GerarArvore(PlacaNode nodo)
        {
            PlacaNode aux;
            if (raiz == null && ArvoreVazia())
            {
                raiz = nodo;
            }
            else
            {
                int achou = 0;
                aux = raiz;
                while (achou == 0)
                {
                    if (nodo.Placa.Nome.CompareTo(aux.Placa.Nome) < 0)
                    {
                        if (aux.Esquerda == null)
                        {
                            //nodo.Posicao = indiceVetor;
                            aux.Esquerda = nodo;
                            achou = 1;
                        }
                        else
                            aux = aux.Esquerda;
                    }
                    else if (nodo.Placa.Nome.CompareTo(aux.Placa.Nome) > 0)
                    {
                        if (aux.Direita == null)
                        {
                            //nodo.Posicao = indiceVetor;
                            aux.Direita = nodo;
                            //indiceVetor++;
                            achou = 1;
                        }
                        else
                            aux = aux.Direita;
                    }
                    else if (nodo.Placa.Nome == aux.Placa.Nome)
                    {
                        achou = 1;
                        Console.WriteLine("Test");
                    }
                }
            }
        }


        // Método para Inserir na estrutura árvore objetos recebidos 
        public void InserirNaArvore(Estacionada estacionada)
        {
            PlacaNode aux;
            int achou = 0;
            aux = raiz;
            while (achou == 0)
            {
                if (estacionada.Placa.CompareTo(aux.Placa.Nome) < 0)
                {
                    aux = aux.Esquerda;
                    Console.WriteLine("Esquerda");
                }
                else if (estacionada.Placa.CompareTo(aux.Placa.Nome) > 0)
                {
                    aux = aux.Direita;
                    Console.WriteLine("Direita");
                }
                else if (estacionada.Placa.CompareTo(aux.Placa.Nome) == 0)
                {
                    aux.Estacionadas.Add(estacionada);
                    Console.WriteLine(aux.Estacionadas.Count);
                    Console.WriteLine(aux.Placa.Nome);
                    achou = 1;
                }
            }
        }

        public void PrintarEstaciondas(string placaVeiculo)
        {
            PlacaNode placaNode = LocalizarVeiculo(placaVeiculo);

            placaNode.Estacionadas.ForEach((value) =>
            {
                // Calcular valor a pagar
                // Tempo de saida menos o tempo de entrada
                TimeSpan valor = value.Saida.Subtract(value.Entrada);
                double horas = valor.TotalHours;
                int pagar = 0;

                if(placaNode.Placa.Tipo == 2)
                {
                    pagar = (horas * 1);
                }
                else
                {
                    pagar = (horas * 1);
                }

                Console.WriteLine(value.Entrada);
            });
        }

        // Método usado para localizar o veículo nas estruturas criadas de árvore e filas
        public PlacaNode LocalizarVeiculo(string placaVeiculo)
        {
            PlacaNode aux = raiz;
            int achou = 0;

            if (raiz == null)
            {
                Console.WriteLine(" Árvore vazia");
                return null;
            }
            else
            {
                while (aux != null && achou == 0)
                {
                    if (aux.Placa.Nome.CompareTo(placaVeiculo) == 0)
                    {
                        // Ao achar a placa é retornado o Nodo
                        return aux;
                    }
                    else if (aux.Placa.Nome.CompareTo(placaVeiculo) > 0)
                        aux = aux.Esquerda;
                    else if (aux.Placa.Nome.CompareTo(placaVeiculo) < 0)
                        aux = aux.Direita;
                }

                Console.WriteLine(" Placa não encontrada");
                return null;
            }
        }
    }
}
