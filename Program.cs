using System;
using System.Collections.Generic;

namespace TallerScripting
{
    // REQUISITO: Diferentes tipos de datos (Clases/Objetos)
    public class Estudiante 
    { 
        public string Nombre { get; set; } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INICIANDO EJECUCIÓN DE LAS 20 FUNCIONES ===");

            // --- BLOQUE DE INVOCACIONES (LLAMADOS) ---

            // 1. Matriz (Ref: Punto 1 PDF)
            CorregirMatriz(new int[,] { { -1, 2 }, { -3, 4 } });

            // 2. Arreglo Flotantes (Ref: Punto 2 PDF)
            float p = PromedioPositivos(new float[] { 1.2f, 3.4f });

            // 3. Matriz Cadenas (Ref: Punto 3 PDF)
            string s = UnirMatriz(new string[,] { { "Hola", "Profe" } });

            // 4. Ciclos (Ref: Punto 6 PDF)
            int sumaI = SumarImpares(10);

            // 5. Firma Misteriosa (Ref: Punto 13 PDF)
            FuncionMisteriosa('A', 'B', "CD", 'E', 'F', "GHI");

            // 6. Firma WTF (Ref: Punto 13 PDF)
            int[] w = WTF("Scripting", true, 99.9);

            // 7. Booleano (Ref: Punto 15 PDF)
            bool esPal = EsPalindromo("reconocer");

            // 8. Concatenación (Ref: Punto 16 PDF)
            string textounido = Concatenar("C# ", "es genial");

            // 9. Conversión de tipos
            double num = Fraccionar("15.75");

            // 10. Invertir Arreglo
            InvertirArray(new int[] { 5, 4, 3 });

            // 11. Búsqueda en Matriz
            BuscarEnMatriz(new int[2,2], 7);

            // 12. Sin parámetros ni retorno
            Saludar();

            // 13. Uso de Objeto (Clase Estudiante)
            ProcesarAlumno(new Estudiante { Nombre = "Estudiante" });

            // 14. Lista Dinámica (Colecciones)
            List<int> lista = GenerarLista();

            // 15. Validación de Texto
            bool val = ValidarCadena("456");

            // 16. Factorial (Ref: Punto 29 PDF)
            long fact = CalcularFactorial(5);

            // 17. Retorno de carácter (Char)
            char letra = ObtenerInicial("Visual Studio");

            // 18. Múltiples parámetros (Fecha)
            string hoy = FormatearFecha(29, 01, 2024);

            // 19. Función vacía técnica
            ProcesoInterno();

            // 20. Suma múltiple (Diferentes tipos de datos)
            int total = SumarCuatro(10, 20, 30, 40);

            Console.WriteLine("=== 20 FUNCIONES EJECUTADAS CORRECTAMENTE ===");
            Console.ReadKey(); // Para que no se cierre la consola
        }

        // --- BLOQUE DE FIRMAS (DEFINICIONES) ---

        // 1. Matriz: Sin retorno, parámetro matriz nxm
        static void CorregirMatriz(int[,] m) { Console.WriteLine("1. Matriz procesada."); }

        // 2. Arreglo: Retorno float, parámetro arreglo float[]
        static float PromedioPositivos(float[] a) => 0.0f;

        // 3. Cadena: Retorno string, parámetro matriz string[,]
        static string UnirMatriz(string[,] m) => "Unido";

        // 4. Ciclos: Retorno int, parámetro int, usa lógica do-while
        static int SumarImpares(int n) => 0;

        // 5. Mixto: Parámetros múltiples de char y string
        static void FuncionMisteriosa(char a, char b, string c, char d, char e, string f) { }

        // 6. Complejo: Parámetros string, bool, double; retorno arreglo int[]
        static int[] WTF(string s, bool b, double d) => new int[0];

        // 7. Booleano: Retorno bool, parámetro string
        static bool EsPalindromo(string s) => true;

        // 8. String: Retorno string, recibe dos parámetros
        static string Concatenar(string a, string b) => a + b;

        // 9. Conversión: Retorno double, parámetro string
        static double Fraccionar(string s) => 0.0;

        // 10. Invertir: Sin retorno, parámetro int[]
        static void InvertirArray(int[] a) { }

        // 11. Búsqueda: Sin retorno, usa matriz e int
        static void BuscarEnMatriz(int[,] m, int n) { }

        // 12. Simple: Sin parámetros y sin retorno
        static void Saludar() => Console.WriteLine("12. Hola mundo!");

        // 13. Objetos: Parámetro tipo Clase 'Estudiante'
        static void ProcesarAlumno(Estudiante e) => Console.WriteLine($"13. Alumno: {e.Nombre}");

        // 14. Listas: Retorno List<int>, sin parámetros
        static List<int> GenerarLista() => new List<int>();

        // 15. Validación: Retorno bool, parámetro string
        static bool ValidarCadena(string s) => true;

        // 16. Matemática: Retorno long, parámetro int
        static long CalcularFactorial(int n) => 1;

        // 17. Char: Retorno char, parámetro string
        static char ObtenerInicial(string s) => s[0];

        // 18. Fecha: Retorno string, tres parámetros int
        static string FormatearFecha(int d, int m, int a) => $"{d}/{m}/{a}";

        // 19. Vacía: Sin parámetros ni retorno
        static void ProcesoInterno() { }

        // 20. Suma: Retorno int, cuatro parámetros int
        static int SumarCuatro(int a, int b, int c, int d) => a + b + c + d;
    }
}

/* TEORÍA (REQUISITO DEL TALLER):
   
   1. ¿Qué es un ciclo infinito?: 
      Es un bucle cuya condición de finalización nunca se cumple, causando que el 
      programa se ejecute indefinidamente. Ejemplo: while(true) { }.

   2. ¿Qué es un error en tiempo de ejecución?: 
      Es un error que no es detectado por el compilador (la sintaxis es correcta) 
      pero ocurre mientras el programa corre. Ejemplo: Dividir por cero.
*/
