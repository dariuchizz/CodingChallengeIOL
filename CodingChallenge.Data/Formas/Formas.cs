using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Forms
{
    public abstract class Formas : IFormas
    {
        public string key => GetType().Name;

        public abstract decimal CalcularArea();

        public abstract decimal CalcularPerimetro();
    }
}
