using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Reporte
    {
        public Type TipoFormId { get; set; }
        public int Total { get; set; }
        public decimal Area { get; set; }
        public decimal Perimetro { get; set; }
        
    }
}
