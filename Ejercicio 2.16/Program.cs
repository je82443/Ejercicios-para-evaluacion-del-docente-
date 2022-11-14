namespace Ejercicios
{
    public class program
    {
        public static void Main()
        {
            int contador;
            int limite;
            int sumatoria;
            sumatoria = 0;
            contador = 1;
            limite = 10;
            for( contador = 1; contador <= limite; contador++ )
            {
                sumatoria= sumatoria + contador;
                Console.WriteLine($"el valor de la la sumatoria es de {sumatoria}");

            }
        }
    }
}

   