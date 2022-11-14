using System.Diagnostics.CodeAnalysis;

namespace Ejercicios
{
    public class program
    {
        public static void Main()
        {
            int i;
            int n, sum;
            int suma;
            i = 1;
            suma = 0;
            while (i <= 10)
            {
                Console.WriteLine("Ingresa un numero: ");
                n = Convert.ToInt32(Console.ReadLine());
                suma = suma + n;
                i++;
            }
            Console.WriteLine($"La suma de los 10 numeros es{suma}");
            return ;
        }
    }
}       