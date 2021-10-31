using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Academy", 2021, TipoEscuela.Primaria, Ciudad: "Bogota", pais: "Colombia");
            escuela.Cursos = new List<Curso>(){
                 new Curso()
                {
                    Nombre = "101", Jornada = TipoJornada.Mañana
                },
                new Curso()
                {
                    Nombre = "201", Jornada = TipoJornada.Mañana
                },
                new Curso()
                {
                    Nombre = "301", Jornada = TipoJornada.Mañana
                },
            };

            escuela.Cursos.Add(new Curso { Nombre = "102", Jornada = TipoJornada.Tarde });
            escuela.Cursos.Add(new Curso { Nombre = "202", Jornada = TipoJornada.Tarde });

            var otrColeccion = new List<Curso>(){
                 new Curso()
                {
                    Nombre = "401", Jornada = TipoJornada.Mañana
                },
                new Curso()
                {
                    Nombre = "501", Jornada = TipoJornada.Mañana
                },
                new Curso()
                {
                    Nombre = "501", Jornada = TipoJornada.Tarde
                },
            };


            //escuela.Cursos.AddRange(otrColeccion);
            imprimirCursosEscuela(escuela);
            WriteLine("================================");
           /* escuela.Cursos.RemoveAll(delegate (Curso cur)
            {
                return cur.Nombre == "301";
            });
            escuela.Cursos.RemoveAll((cur)=> cur.Nombre == "501" && cur.Jornada == TipoJornada.Mañana);
            */
            imprimirCursosEscuela(escuela);


        }

        // apuntador o funcion 
        // private static bool Predicado(Curso curobj)
        // {
        //     return curobj.Nombre == "301";
        // }
        /// comentarios de este metodo 
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
