using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfi_aed
{
    class PlacaNode
    {
        private Placa placa;
        private PlacaNode direita;
        private PlacaNode esquerda;
        private int posicao;

        public PlacaNode()
        { }

        public PlacaNode(Placa placa)
        {
            this.placa = placa;
            this.esquerda = this.direita = null;
        }

        public Placa Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public PlacaNode Direita
        {
            get { return direita; }
            set { direita = value; }
        }

        public PlacaNode Esquerda
        {
            get { return esquerda; }
            set { esquerda = value; }
        }

        public int Posicao
        {
            get { return posicao; }
            set { posicao = value; }
        }
    }
}
