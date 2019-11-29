using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfi_aed
{
    class DataArvore
    {
        DataNodo raiz;

        public DataArvore()
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
        private int Altura(DataNodo nodo)
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
        public void Inserir(DataNodo novo)
        {
            Inserir(this.raiz, novo);
        }

        // Método para gerar a Arvore
        public void Inserir(DataNodo onde, DataNodo novo)
        {
            if (onde == null)
            {
                this.raiz = novo;
            }
            else
            {
                //novo.Vaga.Nome.CompareTo(onde.Vaga.Nom
                if (DateTime.Compare(novo.Data.Entradas, onde.Data.Entradas) < 0)
                {
                    if (onde.Esquerda == null)
                    {
                        onde.Esquerda = novo;
                        novo.Pai = onde;

                        // Metodo para Balancear
                        Balancear(onde);

                    }
                    else
                    {
                        // Inserir a esquerda
                        Inserir(onde.Esquerda, novo);
                    }

                }
                else if (DateTime.Compare(novo.Data.Entradas, onde.Data.Entradas) > 0)
                {

                    if (onde.Direita == null)
                    {
                        onde.Direita = novo;
                        novo.Pai = onde;

                        // Metodo para Balancear
                        Balancear(onde);

                    }
                    else
                    {
                        // Inserir a Direita
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
        public void Balancear(DataNodo atual)
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
        public DataNodo RotacionarEsquerda(DataNodo inicial)
        {

            DataNodo direita = inicial.Direita;
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
        public DataNodo RotacionarDireita(DataNodo inicial)
        {

            DataNodo esquerda = inicial.Esquerda;
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
        public DataNodo DuplaRotacaoEsquerdaDireita(DataNodo inicial)
        {
            inicial.Esquerda = (RotacionarEsquerda(inicial.Esquerda));
            return RotacionarDireita(inicial);
        }

        // Método para rotacionamento duplo
        public DataNodo DuplaRotacaoDireitaEsquerda(DataNodo inicial)
        {
            inicial.Direita = (RotacionarDireita(inicial.Direita));
            return RotacionarEsquerda(inicial);
        }

        // Método para Inserir na estrutura árvore objetos recebidos 
        public void InserirNaArvore(Estacionada estacionada)
        {
            DataNodo aux;
            int achou = 0;
            aux = raiz;
            while (achou == 0)
            {

                //estacionada.Vaga.CompareTo(aux.Vaga.Nome
                if (DateTime.Compare(estacionada.Entrada, aux.Data.Entradas) < 0)
                {
                    aux = aux.Esquerda;
                }
                else if (DateTime.Compare(estacionada.Entrada, aux.Data.Entradas) > 0)
                {
                    aux = aux.Direita;
                }
                else if (DateTime.Compare(estacionada.Entrada, aux.Data.Entradas) == 0)
                {
                    aux.Estacionadas.Add(estacionada);
                    achou = 1;
                }
            }
        }

        // Método para Printar as informações relacionadas as Estacionadas de uma Placa
        public void PrintarDatas(string vaga, string valorInit, string valorFim)
        {
            // Buscar as informações relacionadas ao Veiculo
            DataNodo vagaNodo = LocalizarData(vaga);

            DateTime inicio = DateTime.ParseExact(valorInit, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTime fim = DateTime.ParseExact(valorFim, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            Console.WriteLine("Informações sobre a Vaga: {0}", vaga);

            // Ordernação utilizando metodos de sort da lista generica do Generic
            // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.sort?view=netframework-4.8#System_Collections_Generic_List_1_Sort_System_Comparison__0__
            vagaNodo.Estacionadas.Sort((a, b) => a.Entrada.CompareTo(b.Entrada));

            // Loop para printar as informações
            vagaNodo.Estacionadas.ForEach((value) =>
            {
                if ((DateTime.Compare(value.Entrada, inicio) >= 0) && (DateTime.Compare(value.Saida, fim) <= 0))
                {
                    Console.WriteLine("Entrada: {0}\tSaida: {1}\tPlaca: {2}", value.Entrada, value.Saida, value.Placa);
                    Console.WriteLine("-----------------");

                }
            });
        }

        // Método usado para localizar o veículo nas estruturas criadas de árvore e filas
        public DataNodo LocalizarData(string data)
        {
            DataNodo aux = raiz;
            int achou = 0;

            DateTime dataFormatada = DateTime.ParseExact(data, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            if (raiz == null)
            {
                Console.WriteLine(" Árvore vazia");
                return null;
            }
            else
            {
                while (aux != null && achou == 0)
                {
                    if (DateTime.Compare(aux.Data.Entradas, dataFormatada) == 0)
                    {
                        // Ao achar a data é retornado o Nodo
                        return aux;
                    }
                    else if (DateTime.Compare(aux.Data.Entradas, dataFormatada) > 0)
                        aux = aux.Esquerda;
                    else if (DateTime.Compare(aux.Data.Entradas, dataFormatada) < 0)
                        aux = aux.Direita;
                }

                Console.WriteLine("Data não encontrada");
                return null;
            }
        }
    }
}