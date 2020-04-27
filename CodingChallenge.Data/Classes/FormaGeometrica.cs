/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using CodingChallenge.Data.Forms;
using CodingChallenge.Data.Languages;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        public static readonly Idiomas _idiomas = new Idiomas();
               
        private readonly decimal _lado;
        public static Type tipoFormId;
        public static decimal area;
        public static decimal perimetro;

        public int Tipo { get; set; }

        public FormaGeometrica(int tipo, decimal ancho)
        {
            Tipo = tipo;
            _lado = ancho;            
        }

        public static string Imprimir(IFormas[] formas, Tuple<int, string, string> idioma)
        {          
            var sb = new StringBuilder();

            #region Idioma del Reporte
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(idioma.Item2);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(idioma.Item2);            
            #endregion

            #region Reporte cabecesar

            if (!formas.Any())
            {
                sb.Append($"<h1>{ Resource.FormaVacia }</h1>");
                return sb.ToString();
            }
            
            sb.Append($"<h1>{ Resource.Titulo }</h1>");

            #endregion

            #region Reporte Cuerpo
            var returnReporte = new List<Reporte>();

            foreach (var tipoForm in formas.GroupBy(x => x.GetType()).Select(z => z.Key))
            {
                EmptyVariables();
                Reporte report = new Reporte();
                report.TipoFormId = tipoForm;
                report.Total = formas.Where(x => x.GetType().Equals(tipoForm)).Count();
                report.Area = formas.Where(x => x.GetType().Equals(tipoForm)).Sum(z => z.CalcularArea());
                report.Perimetro = formas.Where(x => x.GetType().Equals(tipoForm)).Sum(z => z.CalcularPerimetro());
                returnReporte.Add(report);                
            }
            foreach (var item in returnReporte)
            { sb.Append(ObtenerLinea(item)); }

            #endregion
           
            #region Reporte Pie

            sb.Append(Resource.Total.ToUpper() +":<br/>");            
            sb.Append(returnReporte.Sum(x => x.Total) + " " + Resource.Formas + " ");
            sb.Append((Resource.Perimetro + " ") + (returnReporte.Sum(x => x.Perimetro)).ToString("#.##") + " ");
            sb.Append(Resource.Area + " " + (returnReporte.Sum(x => x.Area)).ToString("#.##"));

            #endregion

            return sb.ToString();
        }
        
        private static string ObtenerLinea(Reporte item)
        {
            //var nombreForma = item.Total == 1 ? item.TipoFormId.Name : pluralize(item.Total, item.TipoFormId.Name);
            return $"{(item.Total + " " + TraducirForma(item.TipoFormId.Name, item.Total))} | " + Resource.Area + $" { item.Area:#.##} | " + Resource.Perimetro + $" { item.Perimetro:#.##} <br/>";
        }

        private static string TraducirForma(string nombreForma, int cantidad)
        {
            switch (nombreForma)
            {
                case "Cuadrado":
                    return cantidad == 1 ? Resource.Cuadrado : Resource.Cuadrados;
                case "Circulo":
                    return cantidad == 1 ? Resource.Circulo : Resource.Circulos;
                case "Trapecio":
                    return cantidad == 1 ? Resource.TrapecioRectangulo : Resource.TrapeciosRectangulo;
                case "TrianguloEquilatero":
                    return cantidad == 1 ? Resource.TrianguloEquilatero : Resource.TriangulosEquilatero;
            }

            return string.Empty;
        }
        private static void EmptyVariables()
        {
            tipoFormId = null;
            area = 0;
            perimetro = 0;
        }

        //static public String pluralize(int val, String sng)
        //{
        //    return pluralize(val, sng, (sng + "s"));
        //}

        //static public String pluralize(int val, String sng, String plu)
        //{
        //    //return (val + " " + (val == 1 ? sng : plu));
        //    return (val == 1 ? sng : plu);
        //}
    }
}
