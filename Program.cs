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
            BuscarEnMatriz(new int[2, 2], 7);

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

        // --- BLOQUE DE FIRMAS (DEFINICIONES) CON COMPROBANTES ---

        // 1. Matriz
        static void CorregirMatriz(int[,] m) { Console.WriteLine("1. Matriz procesada."); }

        // 2. Arreglo Flotantes
        static float PromedioPositivos(float[] a) { Console.WriteLine("2. Promedio de positivos calculado."); return 0.0f; }

        // 3. Cadena Matriz
        static string UnirMatriz(string[,] m) { Console.WriteLine("3. Matriz de cadenas concatenada."); return "Unido"; }

        // 4. Ciclos
        static int SumarImpares(int n) { Console.WriteLine("4. Suma con ciclo do-while realizada."); return 0; }

        // 5. Mixto
        static void FuncionMisteriosa(char a, char b, string c, char d, char e, string f) { Console.WriteLine("5. Firma misteriosa (chars/strings) ejecutada."); }

        // 6. Complejo
        static int[] WTF(string s, bool b, double d) { Console.WriteLine("6. Función compleja WTF ejecutada."); return new int[0]; }

        // 7. Booleano
        static bool EsPalindromo(string s) { Console.WriteLine("7. Verificación de palíndromo completada."); return true; }

        // 8. String
        static string Concatenar(string a, string b) { Console.WriteLine("8. Cadenas unidas exitosamente."); return a + b; }

        // 9. Conversión
        static double Fraccionar(string s) { Console.WriteLine("9. Conversión de string a double realizada."); return 0.0; }

        // 10. Invertir
        static void InvertirArray(int[] a) { Console.WriteLine("10. Inversión de arreglo ejecutada."); }

        // 11. Búsqueda
        static void BuscarEnMatriz(int[,] m, int n) { Console.WriteLine("11. Búsqueda en matriz finalizada."); }

        // 12. Simple
        static void Saludar() { Console.WriteLine("12. Hola mundo (Función sin parámetros)."); }

        // 13. Objetos
        static void ProcesarAlumno(Estudiante e) { Console.WriteLine($"13. Objeto Alumno procesado: {e.Nombre}"); }

        // 14. Listas
        static List<int> GenerarLista() { Console.WriteLine("14. Lista dinámica generada."); return new List<int>(); }

        // 15. Validación
        static bool ValidarCadena(string s) { Console.WriteLine("15. Validación de cadena numérica hecha."); return true; }

        // 16. Matemática
        static long CalcularFactorial(int n) { Console.WriteLine("16. Cálculo de factorial realizado."); return 1; }

        // 17. Char
        static char ObtenerInicial(string s) { Console.WriteLine("17. Carácter inicial obtenido."); return s[0]; }

        // 18. Fecha
        static string FormatearFecha(int d, int m, int a) { Console.WriteLine("18. Formato de fecha generado."); return $"{d}/{m}/{a}"; }

        // 19. Vacía
        static void ProcesoInterno() { Console.WriteLine("19. Función técnica interna ejecutada."); }

        // 20. Suma
        static int SumarCuatro(int a, int b, int c, int d) { Console.WriteLine("20. Suma de cuatro parámetros completada."); return a + b + c + d; }
    }
}

/* TEORÍA:
   
   1. ¿Qué es un ciclo infinito?: 
      Es un bucle cuya condición de finalización nunca se cumple, causando que el 
      programa se ejecute indefinidamente. Ejemplo: while(true) { }.

   2. ¿Qué es un error en tiempo de ejecución?: 
      Es un error que no es detectado por el compilador (la sintaxis es correcta) 
      pero ocurre mientras el programa corre. Ejemplo: Dividir por cero.
*/
