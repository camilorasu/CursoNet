using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Academy", 2021, TipoEscuela.Primaria, Ciudad: "Bogota", pais: "Colombia");
            escuela.Cursos = new Curso[]{
                new Curso()
                {
                    Nombre = "101"
                },
                new Curso()
                {
                    Nombre = "201"
                },
                new Curso()
                {
                    Nombre = "301"
                },
            };



            imprimirCursosEscuela(escuela);

            bool rta = 10 ==10;
            int cantidad=10;
            if(rta == false)
            {
                WriteLine("Se cumplio la condición 1");
            }
            else if(cantidad > 15)
            {
               WriteLine (" se cumplio la condición 2");
            }
            else
            {
                WriteLine("no se cumplio la condicion ");
            }

            if(cantidad> 5 && rta == false)
            {
                WriteLine(" se cumplio la condición #3");
            }
            if(cantidad > 5 && rta)
            {
                WriteLine("Se cumplio la condición #4");
            }
            if(
                (cantidad > 15 || !rta) && (cantidad % 5 == 0)
                )
            {
                WriteLine("Se cumplio la condición #5");
            }

        }

        private static void imprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("============================");
            WriteLine("Cursos de la Escuela");
            WriteLine("============================");
            if (escuela?.Cursos != null)
                {
                    foreach (var curso in escuela.Cursos)
                    {
                        WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
                    }
                }
        }

        private static void imprimirCursoswhile(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                WriteLine($"Nombre {arregloCursos[contador].Nombre}, Id {arregloCursos[contador].UniqueId}");
                contador++;
            }
        }
        private static void imprimirCursosDowhile(Curso[] arregloCursos)
        {
            int contador = 0;
            do
            {
                WriteLine($"Nombre {arregloCursos[contador].Nombre}, Id {arregloCursos[contador].UniqueId}");
                contador++;
            }
            while (contador < arregloCursos.Length);
        }
        private static void imprimirCursosFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                WriteLine($"Nombre {arregloCursos[i].Nombre}, Id {arregloCursos[i].UniqueId}");
            }
        }
        private static void imprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");

            }
        }
    }
}
