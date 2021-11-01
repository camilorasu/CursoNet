using System;
using System.Collections.Generic;
using CoreEscuela.App;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.inicializar();
            Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");
            Printer.beep(10000, cantidad: 5);
            imprimirCursosEscuela(engine.Escuela);
            Printer.DibujarLinea(20);
            Printer.DibujarLinea(20);
            Printer.DibujarLinea(20);
            Printer.WriteTitle("Pruebas de polimorfismo");
            var alumnoTest= new Alumno{
                Nombre="Claire Underwood"
            };
            ObjetoEscuelaBase objetoEscuelaBase=alumnoTest;
         Printer.WriteTitle("alumno");
         WriteLine($"Alumno: {alumnoTest.Nombre} uniqueId: {alumnoTest.UniqueId}");  
         Printer.WriteTitle("objeto");
         WriteLine($"Alumno: {objetoEscuelaBase.Nombre} uniqueId: {objetoEscuelaBase.UniqueId}");   
         var listasObjetos=engine.GetObjetosEscuela();

        }


        private static void imprimirCursosEscuela(Escuela escuela)
        {

            Printer.WriteTitle("Cursos de la Escuela");

            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
                }
            }
        }
    }
}