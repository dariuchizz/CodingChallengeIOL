using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Forms;
using CodingChallenge.Data.Languages;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenge.ConsoleTest
{
    class Program
    {
        /// <summary>
        /// Idiomas.Lenguajes
        /// 0, "es-AR", "Español - Argentina"
        /// 1, "en-US", "English - United States"
        /// 2, "it-IT", "Italiano - Italia"
        /// 3, "fr-FR", "Francés - Francia"
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            TestResumenListaVacia();
            TestResumenListaVaciaEnFrances();
            TestResumenListaConUnCuadrado();
            TestResumenListaConMasCuadrados();
            TestResumenListaConMasCuadradosEnItaliano();
            TestResumenListaConMasTipos();
            TestResumenListaConMasTiposEnCastellano();
            TestResumenListaConMasTiposEnEnglish();
            Console.ReadLine();
        }
               
        private static void TestResumenListaVacia()
        {
            var idioma = Idiomas.Lenguajes;
            var formas = new IFormas[] { };
            //es-AR
            var detalleFormas = FormaGeometrica.Imprimir(formas, idioma[0]);
            Console.WriteLine(idioma[0].Item3 + " " + detalleFormas);
        }

        private static void TestResumenListaVaciaEnFrances()
        {
            var idioma = Idiomas.Lenguajes;
            var formas = new IFormas[] { };
            //es-AR
            var detalleFormas = FormaGeometrica.Imprimir(formas, idioma[3]);
            Console.WriteLine(idioma[3].Item3 + " " + detalleFormas);
        }

        private static void TestResumenListaConUnCuadrado()
        {
            var idioma = Idiomas.Lenguajes;
            var forms = new IFormas[]
            {
                new Cuadrado(5)                
            };
            //it-IT
            var detalleFormas = FormaGeometrica.Imprimir(forms, idioma[0]);
            Console.WriteLine(idioma[0].Item3 + " " + detalleFormas);
        }

        private static void TestResumenListaConMasCuadrados()
        {
            var idioma = Idiomas.Lenguajes;
            var forms = new IFormas[]
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };
            //en-US
            var detalleFormas = FormaGeometrica.Imprimir(forms, idioma[1]);
            Console.WriteLine(idioma[1].Item3 + " " + detalleFormas);
        }

        private static void TestResumenListaConMasCuadradosEnItaliano()
        {
            var idioma = Idiomas.Lenguajes;
            var forms = new IFormas[]
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };
            //en-US
            var detalleFormas = FormaGeometrica.Imprimir(forms, idioma[2]);
            Console.WriteLine(idioma[2].Item3 + " " + detalleFormas);
        }

        private static void TestResumenListaConMasTipos()
        {
            var idioma = Idiomas.Lenguajes;
            var formas = new IFormas[]
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };
            //en-US
            var detalleFormas = FormaGeometrica.Imprimir(formas, idioma[0]);
            Console.WriteLine(idioma[0].Item3 + " " + detalleFormas);
        }
        private static void TestResumenListaConMasTiposEnCastellano()
        {
            var idioma = Idiomas.Lenguajes;
            var formas = new IFormas[]
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };
            //es-AR
            var detalleFormas = FormaGeometrica.Imprimir(formas, idioma[0]);
            Console.WriteLine(idioma[0].Item3 + " " + detalleFormas);
        }

        public static void TestResumenListaConMasTiposEnEnglish()
        {
            var idioma = Idiomas.Lenguajes;
            var formas = new IFormas[]
            {
                new Cuadrado(5),
                new Circulo(3),
                new Trapecio(6,3,7,2),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new TrianguloEquilatero(4.2m)
            };
            //en-US
            var detalleFormas = FormaGeometrica.Imprimir(formas, idioma[1]);
            Console.WriteLine(idioma[1].Item3 + " " + detalleFormas);

        }
    }
}
