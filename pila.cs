using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Xml;

namespace ProyectoPila
{
    internal class pila
    {
        private int MAX;
        private int tope = 0;
        private nodo inicio;

        public pila(int max)
        {
            MAX = max;
            inicio = null;
        }

        public bool Emty()
        {
            if (inicio == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public bool Full()
        {
            if(tope==MAX)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintStack()
        {
            nodo act = inicio;
            string a = "";

            if (act == null)
            {
                Console.WriteLine("La pila esta vacia");
            }
            else
            {
               while(act != null)
                {
                    if (act.Sig != null)
                    {
                        a = a + "〚 " + act.Valor.ToString() + "〛, ";
                        act = act.Sig;
                    }
                    else
                    {
                        a = a + "〚 "  + act.Valor.ToString() + "〛";
                        act = act.Sig;
                    }

                }
               Console.WriteLine(a);
            }

        }

        public bool Push(int num)
        {
            nodo nuevo = new nodo(num);
            nodo act = inicio;

            if (Full())
            {
                return false;
            }
            else if(act == null)
            {
                inicio = nuevo;
                tope = 1;
                return true;
            }
            else
            {
                while (act.Sig != null)
                {
                    act = act.Sig;
                }
                act.Sig = nuevo;
                tope = tope + 1;
                return true;
            }

        }

        public int Pop()
        {
            nodo act = inicio;
            int num = -1;
            int num2;
            int n = 0;

            if (Emty())
            {
                return num;
            }
            else if(tope == 1)
            {
                num2 = inicio.Valor;
                inicio= inicio.Sig;
                tope = 0;
                return num2;
            }
            else
            {
                act = inicio;
                while (n < tope-2)
                {
                    n = n + 1;
                    act = act.Sig;
                }
                num2 = act.Sig.Valor;
                act.Sig.Sig = null;
                act.Sig = act.Sig.Sig;
                tope = tope - 1;
                return num2;
            }
        }
    }
}
