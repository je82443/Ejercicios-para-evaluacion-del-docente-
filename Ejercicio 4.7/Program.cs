namespace Ejericico
{
    public class program
    {
        public static void Main()
        {
            int numeroUno;
            int numeroDos;

            Console.WriteLine("Escriba el numero mayor");
            numeroUno = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el numero menor:");
            numeroDos = int.Parse(Console.ReadLine());
            if (numeroUno % numeroDos == 0)
            {
                Console.WriteLine(numeroDos + " es divisor de " + numeroUno);
            }
            else
            {

            }

            Console.WriteLine(numeroDos + "no es divisor de " + numeroDos);

        }


    }
}
