﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Forms
{
    public class TrianguloEquilatero : Formas
    {
        private decimal _lado { get; set; }
        public TrianguloEquilatero(decimal lado)
        {
            _lado = lado;
        }
        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }
        public override decimal CalcularPerimetro()
        {
            return _lado * 3;
        }
    }
}
