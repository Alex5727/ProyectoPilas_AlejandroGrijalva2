using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPila
{
    internal class nodo
    {
        private int valor;
        private nodo sig;
        public nodo(int valor)
        {
            this.valor = valor;
            sig = null;
        }

        public int Valor { get => valor; set => valor = value; }
        internal nodo Sig { get => sig; set => sig = value; }

    }
}
