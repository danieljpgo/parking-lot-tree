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
        private List<Estacionada> estacionadas;

        public PlacaNode()
        { }

        public PlacaNode(Placa placa, List<Estacionada> estacionadas)
        {
            this.placa = placa;
            this.esquerda = this.direita = null;
            this.estacionadas = estacionadas;
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

        public List<Estacionada> Estacionadas
        {
            get { return estacionadas; }
            set { estacionadas = value; }
        }

    }
}
