using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Curso : ObjetoEscuelaBase
    {
        public TipoJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public Curso() =>  Alumnos =  new List<Alumno>(); 

    }
}