using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela.App
{
    public sealed class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
        }

        public void inicializar()
        {
            Escuela = new Escuela("Academy", 2021, TipoEscuela.Primaria, Ciudad: "Bogota", pais: "Colombia");

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            var listaEvaluacion = new List<Evaluacion>();
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var alumno in curso.Alumnos)
                {
                    foreach (var asignatura in curso.Asignaturas)
                    {

                        Random random = new Random();
                        for (int i = 0; i < 5; i++)
                        {
                            var evaluacion = new Evaluacion
                            {
                                Nombre = $"Examen N°{i + 1} de {asignatura.Nombre} alumno: {alumno.Nombre}",
                                Alumno = alumno,
                                Asignatura = asignatura,
                                Nota = (float)random.NextDouble() * 5
                            };

                            alumno.Evaluaciones.Add(evaluacion);
                        }
                    }
                }
            }
        }
         public List<ObjetoEscuelaBase> GetObjetosEscuela()
         {
            var listaObj = new List<ObjetoEscuelaBase>();
                listaObj.Add(Escuela);
                listaObj.AddRange(Escuela.Cursos);
                foreach (var curso in Escuela.Cursos)
                {
                    listaObj.AddRange(curso.Asignaturas);
                    listaObj.AddRange(curso.Alumnos);

                    foreach ( var alumno in curso.Alumnos)
                    {
                        listaObj.AddRange(alumno.Evaluaciones);
                    }
                }
            return listaObj;
         }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                var listaAsignaturas = new List<Asignatura>(){
                    new Asignatura{Nombre= "Matemáticas"},
                    new Asignatura{Nombre= "Educación Fisica"},
                    new Asignatura{Nombre= "Castellano"},
                    new Asignatura{Nombre= "Ciencia Naturales"},
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnos(int cantidad)
        {
            string[] nombre1 = { "Alba", "felipe", "camilo", "Andres", "Alvaro", "Javier" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Ramirez", "Suaza", "Trump" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes" };

            var ListaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno
                               {
                                   Nombre = $"{n1} {n2} {a1}"
                               };
            return ListaAlumnos.OrderBy((alum) => alum.UniqueId).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
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
                new Curso()
                {
                    Nombre = "401", Jornada = TipoJornada.Tarde
                },
                new Curso()
                {
                    Nombre = "501", Jornada = TipoJornada.Tarde
                },
            };
            Random random = new Random();
            foreach (var c in Escuela.Cursos)
            {
                int cantRandom = random.Next(5, 20);
                c.Alumnos = GenerarAlumnos(cantRandom);
            }
        }
    }
}