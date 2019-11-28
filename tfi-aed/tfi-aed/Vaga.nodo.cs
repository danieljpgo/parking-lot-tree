using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfi_aed
{
    class VagaNodo
    {
        // Atributos
        private Vaga vaga;
        private VagaNodo direita;
        private VagaNodo esquerda;
        private VagaNodo pai;
        private int balanceamento;
        private List<Estacionada> estacionadas;

        // Construtor
        public VagaNodo()
        { }

        public VagaNodo(Vaga vaga, List<Estacionada> estacionadas)
        {
            this.vaga = vaga;
            this.esquerda = this.direita = null;
            this.estacionadas = estacionadas;
        }

        public Vaga Vaga
        {
            get { return vaga; }
            set { vaga = value; }
        }

        public VagaNodo Direita
        {
            get { return direita; }
            set { direita = value; }
        }

        public VagaNodo Esquerda
        {
            get { return esquerda; }
            set { esquerda = value; }
        }
        public VagaNodo Pai
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
