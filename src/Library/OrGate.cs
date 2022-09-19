using System;
using System.Collections.Generic;

namespace Compuertas
{
    public class OrGate : ILogicGate
    {
        public Dictionary<string, ICalculable> Entradas {get; set;}
        public string Nombre{get; set;}
        public OrGate(string nombre)
        {
            this.Nombre =  nombre;
            this.Entradas = new Dictionary<string, ICalculable>{};
        }
        public void Connect(string nombre, ICalculable valor)
        {
            this.Entradas[nombre] = valor;
        }
        public bool Calculate()
        {
            bool salida = false;
            foreach (ICalculable valores in this.Entradas.Values)
            {
               if (valores.Calculate() == true)
               {
                    salida = true;
                    return salida;
               }
            }
            return salida;
        }

    }
}