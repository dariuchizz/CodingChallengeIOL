using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Forms
{
    public class Trapecio : Formas
    {
        private readonly decimal _ladoA;
        private readonly decimal _ladoB;
        private readonly decimal _ladoC;
        private readonly decimal _ladoD;

        public Trapecio(decimal ladoA, decimal ladoB, decimal ladoC, decimal ladoD)
        {
            _ladoA = ladoA;
            _ladoB = ladoB;
            _ladoC = ladoC;
            _ladoD = ladoD;
        }
        public override decimal CalcularArea()
        {
            return _ladoC * ((_ladoA + _ladoB) / 2);
        }
        public override decimal CalcularPerimetro()
        {
            return _ladoA + _ladoB + _ladoC + _ladoD;
        }
    }
}
