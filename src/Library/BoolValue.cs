using System;

namespace Compuertas
{
    public class BoolValue : ICalculable
    {
        public bool Value {get; set;}
        public BoolValue (bool value)
        {
            this.Value = value;
        }
        public bool Calculate()
        {
            return this.Value;
        }
    }
}