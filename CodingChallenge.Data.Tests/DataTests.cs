using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Forms;
using CodingChallenge.Data.Languages;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        /// <summary>
        /// Idiomas.Lenguajes
        /// 0, "es-AR", "Español - Argentina"        
        /// </summary>
        /// <param name="args"></param>
        [TestCase]
        public void TestResumenListaVacia()
        {
            var idioma = Idiomas.Lenguajes;
            var formas = new IFormas[] { };
            //es-AR
            var detalleFormas = FormaGeometrica.Imprimir(formas, idioma[0]);
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", detalleFormas); 
        }

        /// <summary>
        /// Idiomas.Lenguajes
        /// 3, "fr-FR", "Francés - Francia"        
        /// </summary>
        /// <param name="args"></param>
        public void TestResumenListaVaciaEnFrances()
        {
            var idioma = Idiomas.Lenguajes;
            var formas = new IFormas[] { };
            //fr-FR
            var detalleFormas = FormaGeometrica.Imprimir(formas, idioma[3]);
            Assert.AreEqual("<h1>Liste vide de formes!</h1>", detalleFormas);
        }

        /// <summary>
        /// Idiomas.Lenguajes
        /// 1, "en-US", "English - United States"
        /// </summary>
        /// <param name="args"></param>
        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            var idioma = Idiomas.Lenguajes;
            var formas = new IFormas[] { };
            //en-US
            var detalleFormas = FormaGeometrica.Imprimir(formas, idioma[1]);
            Assert.AreEqual("<h1>Empty list of shapes!</h1>", detalleFormas);
        }
        
        /// <summary>
        /// Idiomas.Lenguajes
        /// 0, "es-AR", "Español - Argentina"        
        /// </summary>
        /// <param name="args"></param>
        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var idioma = Idiomas.Lenguajes;
            var formas = new IFormas[]
            {
                new Cuadrado(5)
            };
            //es-AR
            var detalleFormas = FormaGeometrica.Imprimir(formas, idioma[0]); 
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", detalleFormas);
        }

        /// <summary>
        /// Idiomas.Lenguajes
        /// 1, "en-US", "English - United States"
        /// </summary>
        /// <param name="args"></param>
        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var idioma = Idiomas.Lenguajes;
            var formas = new IFormas[]
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };
            //en-US
            var detalleFormas = FormaGeometrica.Imprimir(formas, idioma[1]);
            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", detalleFormas);
        }

        /// <summary>
        /// Idiomas.Lenguajes
        /// 2, "it-IT", "Italiano - Italia"
        /// </summary>
        /// <param name="args"></param>
        [TestCase]
        public void TestResumenListaConMasCuadradosEnItaliano()
        {
            var idioma = Idiomas.Lenguajes;
            var formas = new IFormas[]
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };
            //it-IT
            var detalleFormas = FormaGeometrica.Imprimir(formas, idioma[2]);
            Assert.AreEqual("<h1>Rapporto sulle forme</h1>3 Forme | Zona 35 | Piazze 36 <br/>TOTAL:<br/>3 i titolo Piazze 36 Zona 35", detalleFormas);
        }

        /// <summary>
        /// Idiomas.Lenguajes
        /// 1, "en-US", "English - United States"
        /// </summary>
        /// <param name="args"></param>
        [TestCase]
        public void TestResumenListaConMasTipos()
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
            var detalleFormas = FormaGeometrica.Imprimir(formas, idioma[1]);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 shapes Perimeter 97.66 Area 91.65",
                detalleFormas);
        }

        /// <summary>
        /// Idiomas.Lenguajes
        /// 0, "es-AR", "Español - Argentina"
        /// </summary>
        /// <param name="args"></param>
        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
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

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                detalleFormas);
        }

        /// <summary>
        /// Idiomas.Lenguajes
        /// 1, "en-US", "English - United States"
        /// </summary>
        /// <param name="args"></param>
        [TestCase]
        public void TestResumenListaConMasTiposEnEnglish()
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

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>1 Circle | Area 7.07 | Perimeter 9.42 <br/>1 Trapeze | Area 31.5 | Perimeter 18 <br/>2 Triangles | Area 42.71 | Perimeter 39.6 <br/>TOTAL:<br/>6 shapes Perimeter 95.02 Area 110.28",
                detalleFormas);

        }
    }
}
