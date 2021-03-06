using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TipoJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }
        
        public List<Evaluacion> evaluaciones { get; set; }
        public Curso() => (UniqueId, Alumnos,evaluaciones) = (System.Guid.NewGuid().ToString(), new List<Alumno>(), new List<Evaluacion>()); 

    }
}