using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {  
           WriteLine("".PadLeft(tam, '='));
        }
        public static void WriteTitle(string titulo)
        {
         var tamaño= titulo.Length+4;
         DibujarLinea(tamaño);
         WriteLine($"| {titulo} |");
         DibujarLinea(tamaño);
        }
        public static void beep(int hz =2000, int tiempo=500, int cantidad=1)
        {
            while (cantidad-- > 0)
            {
            Beep(hz,tiempo);
            }
        }
    }
}