using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfi_aed
{
    class Data
    {
        // Atributos
        public DateTime entradas;

        // Construtor
        public Data()
        { }

        public Data(DateTime entrada)
        {
            this.entradas = entrada;
        }

        public DateTime Entradas
        { get { return entradas; } }
    }
}
