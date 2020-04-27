using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Languages
{
    public class Idiomas
    {   
        public static Tuple<int, string, string>[] Lenguajes = new Tuple<int, string, string>[] {
            Tuple.Create(0, "es-AR", "Español - Argentina"),
            Tuple.Create(1, "en-US", "English - United States"),
            Tuple.Create(2, "it-IT", "Italiano - Italia"),
            Tuple.Create(3, "fr-FR", "Francés - Francia"),
        };
    }
}
