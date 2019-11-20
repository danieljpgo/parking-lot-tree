using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfi_aed
{
    class Fila
    {
        //private Fila proximo;
        //private Estacionada dados;

        //static Fila filaRotas = new Fila();
        //static Fila[] filaVeiculos;

        //public Fila()
        //{ }
        //public Fila(Estacionada dados)
        //{
        //    this.dados = dados;
        //}

        //public Estacionada Dados
        //{
        //    get { return dados; }
        //    set { dados = value; }
        //}

        //public Fila Proximo
        //{
        //    get { return proximo; }
        //    set { proximo = value; }
        //}

        //// Método que montará as filas inserindo um objeto atrás do outro
        //public void Enfileirar(Fila novo, ref Fila inicio, ref Fila fim)
        //{
        //    if (inicio.Dados == null)
        //    {
        //        inicio = novo;
        //        fim = novo;
        //    }
        //    else
        //    {
        //        fim.Proximo = novo;
        //        fim = novo;
        //    }
        //}

        //// Método necessário para já transferir fila criada para fila de rotas da classe
        //public void SalvarEmFilaRotas(Fila novoVeiculoFila)
        //{
        //    filaRotas = novoVeiculoFila;
        //}

        //// Método para desenfileirar, mostra informações dos veículos
        //public void Desenfileirar(Fila caminhante, int chave, int codigo)
        //{
        //    if (chave == 1)
        //    {
        //        Console.WriteLine("\n AMOSTRA DE ROTAS BASEADO EM DATAS: \n");
        //        while (caminhante != null)
        //        {
        //            Console.WriteLine(" Data: {0}, Rota: {1} km", caminhante.Dados.Data.ToShortDateString(), caminhante.Dados.Rota);
        //            caminhante = caminhante.Proximo;
        //        }
        //        caminhante = null;
        //    }
        //    else if (chave == 2)
        //    {
        //        caminhante = filaVeiculos[codigo];
        //        Console.WriteLine("\n Veículo do tipo: {0}", caminhante.TipoVeiculo(caminhante.Dados.Tipo));
        //        while (caminhante != null)
        //        {
        //            Console.WriteLine("   Data: {0}, Rota: {1} km", caminhante.Dados.Data.ToShortDateString(), caminhante.Dados.Rota);
        //            caminhante = caminhante.Proximo;
        //        }
        //        caminhante = null;
        //    }
        //    else
        //    {
        //        DateTime dataAux = caminhante.dados.Data;
        //        Console.WriteLine("\n ROTAS AGRUPADAS POR DATA ");
        //        Console.WriteLine("\n Data: {0}", caminhante.Dados.Data.ToShortDateString());
        //        while (caminhante != null)
        //        {
        //            if (dataAux == caminhante.dados.Data)
        //            {
        //                Console.WriteLine("   Rota: {0}, Veículo do tipo: {1}, placa: {2} ", caminhante.Dados.Rota,
        //                    caminhante.TipoVeiculo(caminhante.Dados.Tipo), caminhante.dados.Placa);
        //            }
        //            else
        //            {
        //                Console.WriteLine("\n Data: {0}", caminhante.Dados.Data.ToShortDateString());
        //                dataAux = caminhante.dados.Data;
        //                Console.WriteLine("   Rota: {0}, Veículo do tipo: {1}, placa: {2} ", caminhante.Dados.Rota,
        //                caminhante.TipoVeiculo(caminhante.Dados.Tipo), caminhante.dados.Placa);
        //            }
        //            caminhante = caminhante.Proximo;
        //        }
        //        caminhante = null;
        //    }
        //}

        //public void CalcularDistancia()
        //{
        //    int[] somaDistancia = new int[filaVeiculos.Length];
        //    int maiorDistancia = int.MinValue;
        //    int posicao = 0;

        //    for (int i = 0; i < somaDistancia.Length; i++)
        //        somaDistancia[i] = 0;

        //    Fila caminhante = new Fila();
        //    for (int i = 0; i < filaVeiculos.Length; i++)
        //    {
        //        caminhante = filaVeiculos[i];
        //        while (caminhante != null)
        //        {
        //            somaDistancia[i] += caminhante.dados.Rota;
        //            caminhante = caminhante.Proximo;
        //        }
        //    }
        //    for (int i = 0; i < somaDistancia.Length; i++)
        //    {
        //        if (maiorDistancia < somaDistancia[i])
        //        {
        //            maiorDistancia = somaDistancia[i];
        //            posicao = i;
        //        }
        //    }
        //    Console.WriteLine("\n VEÍCULO QUE PERCORREU MAIOR DISTÂNCIA E ABASTECEU MAIS");
        //    Console.WriteLine("\n A maior distância percorrida foi: {0} km pelo veículo placa: {1}, tipo: {2} ", maiorDistancia,
        //        filaVeiculos[posicao].dados.Placa, TipoVeiculo(filaVeiculos[posicao].dados.Tipo));
        //    int divisao = maiorDistancia / 300;
        //    Console.WriteLine(" Foi necessário abastecer: {0} vezes, 1 a cada 300 km. ", divisao);
        //}

        //// Método que traduz o código e retorna o texto correspondente 
        //public string TipoVeiculo(int tipo)
        //{
        //    if (tipo == 1)
        //        return "carro";
        //    else if (tipo == 2)
        //        return "van";
        //    else if (tipo == 3)
        //        return "furgão";
        //    else
        //        return "caminhão";
        //}

        //// Método chamado pela classe Program, na opção 1 do menu, busca a fila para ser enviada para percorrer 
        //public Fila BuscarFilaRotas()
        //{
        //    return filaRotas;
        //}

        //// Recebe o vetor com as filas de cada veículo
        //public void SalvaFilaVeiculos(Fila[] filaV)
        //{
        //    filaVeiculos = new Fila[filaV.Length];
        //    filaVeiculos = filaV;
        //}
    }
}
