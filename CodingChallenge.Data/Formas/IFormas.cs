using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Forms
{
    public interface IFormas
    {
        string key { get; }
        decimal CalcularArea();
        decimal CalcularPerimetro();
    }
}
