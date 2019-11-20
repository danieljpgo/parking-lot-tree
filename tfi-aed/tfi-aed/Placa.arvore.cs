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
        public void GerarArvore()
        {

        }


        // Método para Inserir na estrutura árvore objetos recebidos 
        //public void InserirNaArvore(PlacaNode nodo, Fila estacionada, ref Fila[] inicio, ref Fila[] fim)
        //{
        //    PlacaNode aux;
        //    if (raiz == null && ArvoreVazia())
        //    {
        //        nodo.Posicao = indiceVetor;
        //        raiz = nodo;
        //        estacionada.Enfileirar(estacionada, ref inicio[indiceVetor], ref fim[indiceVetor]);
        //        indiceVetor++;
        //    }

        //    // 1 - localizar nó
        //    // 2 - localizar posição do vetor
        //    // 3 - localizar posição na fila e inserir 
        //    else
        //    {
        //        int achou = 0;
        //        aux = raiz;
        //        while (achou == 0)
        //        {
        //            if (nodo.Placa.CompareTo(aux.Placa) < 0)
        //            {
        //                if (aux.Esquerda == null)
        //                {
        //                    nodo.Posicao = indiceVetor;
        //                    aux.Esquerda = nodo;
        //                    estacionada.Enfileirar(estacionada, ref inicio[indiceVetor], ref fim[indiceVetor]);
        //                    indiceVetor++;
        //                    achou = 1;
        //                }
        //                else
        //                    aux = aux.Esquerda;
        //            }
        //            else if (nodo.Placa.CompareTo(aux.Placa) > 0)
        //            {
        //                if (aux.Direita == null)
        //                {
        //                    nodo.Posicao = indiceVetor;
        //                    aux.Direita = nodo;
        //                    estacionada.Enfileirar(estacionada, ref inicio[indiceVetor], ref fim[indiceVetor]);
        //                    indiceVetor++;
        //                    achou = 1;
        //                }
        //                else
        //                    aux = aux.Direita;
        //            }
        //            else if (nodo.Placa.CompareTo(aux.Placa) == 0)
        //            {
        //                estacionada.Enfileirar(estacionada, ref inicio[aux.Posicao], ref fim[aux.Posicao]);
        //                achou = 1;
        //            }
        //        }
        //    }
        //}

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
