namespace ejercicios
{
    public class program
    {
        public static void Main()
        {
            Console.WriteLine("ingrese por favor un numero");
            double Numero6;
            Numero6 = double.Parse(Console.ReadLine());
            if (10 <= Numero6 && Numero6 <= 100)
            {
                Console.WriteLine("el numero es se encuentra entre 10 y 100");
            }
            else
            {
                Console.WriteLine("el numero no se encuentra entre 10 y 100");
            }
        }

    }

}