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
                }
                else if (estacionada.Placa.CompareTo(aux.Placa.Nome) > 0)
                {
                    aux = aux.Direita;
                }
                else if (estacionada.Placa.CompareTo(aux.Placa.Nome) == 0)
                {
                    aux.Estacionadas.Add(estacionada);
                    Console.WriteLine(aux.Placa.Nome);
                    Console.WriteLine(estacionada.Placa);
                    Console.WriteLine(aux.Estacionadas.Count);
                    achou = 1;
                }
            }
        }

        // Método usado para localizar o veículo nas estruturas criadas de árvore e filas
        //public void LocalizarVeiculo(string placaVeiculo)
        //{
        //    PlacaNode aux = raiz;
        //    Fila auxFila = new Fila();
        //    int achou = 0;
        //    if (raiz == null)
        //        Console.WriteLine(" Árvore vazia");

        //    // Primeiro achar a placa e em seguida a posicao na lista de filas 
        //    else
        //    {
        //        while (aux != null && achou == 0)
        //        {
        //            if (aux.Placa.CompareTo(placaVeiculo) == 0)
        //            {
        //                // 0 apenas para preencher a solicitação no método que vai receber
        //                auxFila.Desenfileirar(auxFila, 2, aux.Posicao);
        //                achou = 1;
        //            }
        //            else if (aux.Placa.CompareTo(placaVeiculo) > 0)
        //                aux = aux.Esquerda;
        //            else if (aux.Placa.CompareTo(placaVeiculo) < 0)
        //                aux = aux.Direita;
        //        }
        //        if (achou == 0)
        //            Console.WriteLine(" Placa não encontrada");
        //    }
        //}
    }
}
