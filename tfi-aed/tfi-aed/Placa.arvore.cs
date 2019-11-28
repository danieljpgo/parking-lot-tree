using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfi_aed
{
    class PlacaArvore
    {
        PlacaNode raiz;

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

        // Método para retornar a altura da Arvore
        private int Altura(PlacaNode nodo)
        {
            if (nodo == null)
            {
                return -1;
            }

            if (nodo.Esquerda == null && nodo.Direita == null)
            {
                return 0;

            }
            else if (nodo.Esquerda == null)
            {
                return 1 + Altura(nodo.Direita);

            }
            else if (nodo.Direita == null)
            {
                return 1 + Altura(nodo.Esquerda);

            }
            else
            {
                return 1 + Math.Max(Altura(nodo.Esquerda), Altura(nodo.Direita));
            }
        }

        // Método para iniciar a geração da Arvore
        public void Inserir(PlacaNode novo)
        {
            Inserir(this.raiz, novo);
        }

        // Método para gerar a Arvore
        public void Inserir(PlacaNode onde, PlacaNode novo)
        {
            if (onde == null)
            {
                this.raiz = novo;
            }
            else
            {
                if (novo.Placa.Nome.CompareTo(onde.Placa.Nome) < 0)
                {
                    if (onde.Esquerda == null)
                    {
                        onde.Esquerda = novo;
                        novo.Pai = onde;

                        // Metodo para Balancear
                        //Console.WriteLine("Esq");
                        Balancear(onde);

                    }
                    else
                    {
                        // Inserir a esquerda
                        //Console.WriteLine("Esq Inserir");
                        Inserir(onde.Esquerda, novo);
                    }

                }
                else if (novo.Placa.Nome.CompareTo(onde.Placa.Nome) > 0)
                {

                    if (onde.Direita == null)
                    {
                        onde.Direita = novo;
                        novo.Pai = onde;

                        // Metodo para Balancear
                        //Console.WriteLine("Dir");
                        Balancear(onde);

                    }
                    else
                    {
                        // Inserir a Direita
                        //Console.WriteLine("Dir Inserir");
                        Inserir(onde.Direita, novo);
                    }

                }
                else
                {
                    // Não deve entrar aqui
                    Console.Write("Error");
                }
            }
        }

        // Método básico de balanceamento
        public void Balancear(PlacaNode atual)
        {
            atual.Balanceamento = (Altura(atual.Direita) - Altura(atual.Esquerda));
            int balanceamento = atual.Balanceamento;

            if (balanceamento == -2)
            {

                if (Altura(atual.Esquerda.Esquerda) >= Altura(atual.Esquerda.Direita))
                {
                    atual = RotacionarDireita(atual);
                }
                else
                {
                    atual = DuplaRotacaoEsquerdaDireita(atual);
                }

            }
            else if (balanceamento == 2)
            {

                if (Altura(atual.Direita.Direita) >= Altura(atual.Direita.Esquerda))
                {
                    atual = RotacionarEsquerda(atual);

                }
                else
                {
                    atual = DuplaRotacaoDireitaEsquerda(atual);
                }
            }

            if (atual.Pai != null)
            {
                Balancear(atual.Pai);
            }
            else
            {
                this.raiz = atual;
            }
        }

        // Método para Rotacionar a Esquerda
        public PlacaNode RotacionarEsquerda(PlacaNode inicial)
        {

            PlacaNode direita = inicial.Direita;
            direita.Pai = inicial.Pai;

            inicial.Direita = direita.Esquerda;

            if (inicial.Direita != null)
            {
                inicial.Direita.Pai = inicial;
            }

            direita.Esquerda = inicial;
            inicial.Pai = direita;

            if (direita.Pai != null)
            {

                if (direita.Pai.Direita == inicial)
                {
                    direita.Pai.Direita = direita;

                }
                else if (direita.Pai.Esquerda == inicial)
                {
                    direita.Pai.Esquerda = direita;
                }
            }

            inicial.Balanceamento = (Altura(inicial.Direita) - Altura(inicial.Esquerda));
            direita.Balanceamento = (Altura(direita.Direita) - Altura(direita.Esquerda));

            return direita;
        }

        // Método para Rotacionar a Direita
        public PlacaNode RotacionarDireita(PlacaNode inicial)
        {

            PlacaNode esquerda = inicial.Esquerda;
            esquerda.Pai = inicial.Pai;

            inicial.Esquerda = esquerda.Direita;

            if (inicial.Esquerda != null)
            {
                inicial.Esquerda.Pai = inicial;
            }

            esquerda.Direita = inicial;
            inicial.Pai = esquerda;

            if (esquerda.Pai != null)
            {
                if (esquerda.Pai.Direita == inicial)
                {
                    esquerda.Pai.Direita = esquerda;

                }
                else if (esquerda.Pai.Esquerda == inicial)
                {
                    esquerda.Pai.Esquerda = esquerda;
                }
            }

            inicial.Balanceamento = (Altura(inicial.Direita) - Altura(inicial.Esquerda));
            esquerda.Balanceamento = (Altura(esquerda.Direita) - Altura(esquerda.Esquerda));

            return esquerda;
        }

        // Método para rotacionamento duplo
        public PlacaNode DuplaRotacaoEsquerdaDireita(PlacaNode inicial)
        {
            inicial.Esquerda = (RotacionarEsquerda(inicial.Esquerda));
            return RotacionarDireita(inicial);
        }

        // Método para rotacionamento duplo
        public PlacaNode DuplaRotacaoDireitaEsquerda(PlacaNode inicial)
        {
            inicial.Direita = (RotacionarDireita(inicial.Direita));
            return RotacionarEsquerda(inicial);
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
                    achou = 1;
                }
            }
        }

        // Método para Printar as informações relacionadas as Estacionadas de uma Placa
        public void PrintarEstaciondas(string placaVeiculo)
        {
            // Buscar as informações relacionadas ao Veiculo
            PlacaNode placaNode = LocalizarVeiculo(placaVeiculo);

            Console.WriteLine("Informações sobre o Veiculo de Placa: {0}", placaVeiculo);

            double totalPagar = 0;

            // Loop para printar as informações
            placaNode.Estacionadas.ForEach((value) =>
            {
                // Calcular valor a pagar
                // Tempo de saida menos o tempo de entrada
                TimeSpan valor = value.Saida.Subtract(value.Entrada);
                double horas = valor.TotalHours;
                double pagar = 0;

                if (placaNode.Placa.Tipo == 2)
                {
                    pagar = (horas * 0.6);
                }
                else
                {
                    pagar = (horas * 1);
                }

                totalPagar += pagar;
                Console.WriteLine("Entrada: {0}\tSaida: {1}\tTipo: {2}\tTotal Horas: {3}\tValor: {4}", value.Entrada, value.Saida, placaNode.Placa.Tipo, horas, pagar);
                Console.WriteLine("-----------------");
            });
            Console.WriteLine("Valor total a pagar: {0}", totalPagar);
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



        // Método para gerar árvore
        //public void GerarArvore(PlacaNode nodo)
        //{
        //    PlacaNode aux;
        //    if (raiz == null && ArvoreVazia())
        //    {
        //        raiz = nodo;
        //    }
        //    else
        //    {
        //        int achou = 0;
        //        aux = raiz;
        //        while (achou == 0)
        //        {
        //            if (nodo.Placa.Nome.CompareTo(aux.Placa.Nome) < 0)
        //            {
        //                if (aux.Esquerda == null)
        //                {
        //                    aux.Esquerda = nodo;
        //                    achou = 1;
        //                }
        //                else
        //                    aux = aux.Esquerda;
        //            }
        //            else if (nodo.Placa.Nome.CompareTo(aux.Placa.Nome) > 0)
        //            {
        //                if (aux.Direita == null)
        //                {
        //                    aux.Direita = nodo;
        //                    achou = 1;
        //                }
        //                else
        //                    aux = aux.Direita;
        //            }
        //            else if (nodo.Placa.Nome == aux.Placa.Nome)
        //            {
        //                achou = 1;
        //                Console.WriteLine("Test");
        //            }
        //        }
        //    }
        //}
    }
}
