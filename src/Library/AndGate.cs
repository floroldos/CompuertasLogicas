using System;
using System.Collections.Generic;

namespace Compuertas
{
    public class AndGate : ILogicGate
    {
        public Dictionary<string, ICalculable> Entradas {get; set;}
        public string Nombre{get; set;}
        public AndGate(string nombre)
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
            bool salida = true;
            foreach (ICalculable valores in this.Entradas.Values)
            {
                if (valores.Calculate() == false)
                {
                    salida = false;
                    return salida;
                }
            }
            return salida;
        }
    }
}
