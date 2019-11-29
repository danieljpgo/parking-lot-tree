using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfi_aed
{
    class DataNodo
    {
        // Atributos
        private Data data;
        private DataNodo direita;
        private DataNodo esquerda;
        private DataNodo pai;
        private int balanceamento;
        private List<Estacionada> estacionadas;

        // Construtor
        public DataNodo()
        { }

        public DataNodo(Data data, List<Estacionada> estacionadas)
        {
            this.data = data;
            this.esquerda = this.direita = null;
            this.estacionadas = estacionadas;
        }

        public Data Data
        {
            get { return data; }
            set { data = value; }
        }

        public DataNodo Direita
        {
            get { return direita; }
            set { direita = value; }
        }

        public DataNodo Esquerda
        {
            get { return esquerda; }
            set { esquerda = value; }
        }
        public DataNodo Pai
        {
            get { return pai; }
            set { pai = value; }
        }

        public int Balanceamento
        {
            get { return balanceamento; }
            set { balanceamento = value; }
        }

        public List<Estacionada> Estacionadas
        {
            get { return estacionadas; }
            set { estacionadas = value; }
        }
    }
}
