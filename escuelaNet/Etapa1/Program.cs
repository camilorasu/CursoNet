using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Academy", 2021, TipoEscuela.Primaria, Ciudad: "Bogota", pais: "Colombia");
            Console.WriteLine(escuela);
        }
    }
}
