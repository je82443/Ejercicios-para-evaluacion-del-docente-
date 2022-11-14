namespace ejercicio32
{
    public class program
    {
        public static void Main()
        {
            Console.WriteLine("ingrese un numero");
            int numero = int.Parse(Console.ReadLine());
            if (numero == 0)
            {

                Console.WriteLine("el numero" + numero + "es un numero neutro");


            }
            else if (numero > 0)
            {
                Console.WriteLine("el numero" + numero + "es un numero positivo");
            }
            else
            {
                Console.WriteLine("el numero" + numero + "es un numero negativo");
            }
            Console.ReadKey();
        }
    }
    
}
                   
