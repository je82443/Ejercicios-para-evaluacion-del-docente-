namespace Ejercicios
{
    public class program
    {
        public static void Main()
        {
            double Candidadporaño = 0, cantidadI, ahorrodelmes;
                for (int i = 1; i < 13; i++)
            {
                Console.WriteLine("procesos" + i);
                Console.WriteLine("ingrese el valor a depositar"); 
                cantidadI = double.Parse(Console.ReadLine());   
                Candidadporaño=Candidadporaño+cantidadI;
                ahorrodelmes = Candidadporaño;
                Console.WriteLine("el valor del ahorro por mes es de " + ahorrodelmes);
            }
            Console.WriteLine("el valor del ahorro del mes es de " + Candidadporaño); 

        }
    }
}