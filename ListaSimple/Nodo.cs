using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasExam1.ListaSimple
{
    class Nodo
    {
        private int dato;
        private Nodo sig;
        private Nodo ant;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public Nodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }
        public Nodo Aterior
        {
            get { return ant; }
            set { ant = value; }
        }
    }
}
