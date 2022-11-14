
namespace Ejercicios

{
    public class program
    {
       public static void Main()
        {
            double X = 0;
            int Potencia;
            double resultado;
            Console.WriteLine(" ingrese el valor de x"); 
            X= double.Parse(Console.ReadLine());

            if (X != 0)
            {
                Console.WriteLine("ingrese el valor de la potencia");
                Potencia=int.Parse(Console.ReadLine()); 
                resultado= Math.Pow(X,Potencia);
                Console.WriteLine("El resultado de la potencia es " + resultado);

                
            }
            else
            {
                Console.WriteLine(" resultado de x no puede ser 0");  
            }
        }
    }
}