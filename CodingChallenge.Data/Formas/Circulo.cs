
using System;

namespace CodingChallenge.Data.Forms
{
    public class Circulo : Formas
    {
        private decimal _radio { get; set; }

        public Circulo(decimal lado)
        {
            _radio = lado;
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (_radio / 2) * (_radio / 2);
        }
        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _radio;
        }

    }
}
