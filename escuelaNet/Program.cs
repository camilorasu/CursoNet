using System;

namespace escuelaNet
{
    class Escuela
    {
        public string nombre;
        public string direccion;
        public int añoFundacion;
        public string ceo;

        public void Timbrar()
        {
            //Todo
            Console.Beep(2000,3000);  
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var miEscuela = new Escuela();
            miEscuela.nombre = "Academia"; 
            miEscuela.direccion = "Usme";
            miEscuela.añoFundacion = 2021; 
            Console.WriteLine("Timbrando");
            miEscuela.Timbrar();
            //Console.WriteLine("Hello World!");
        }
    }
}
