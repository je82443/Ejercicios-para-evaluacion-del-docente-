namespace Ejercicios
{
    public class program
    {
        public static void Main()
        {
            double pago,MetrosP ,La, Lb, Lc, PrecioI, Preciobruto;
            Console.WriteLine(" digite el ancho de la alberca"); 
            La= double.Parse(Console.ReadLine());

            Console.WriteLine(" por ingrese el largo de la alberca");
            Lb= double.Parse(Console.ReadLine());

            Console.WriteLine("por ingrese el valor de la altura de la alberca");
            Lc= double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite el precio del agua, tenga en cuenta que esta es en metros cubicos");
            PrecioI= double.Parse(Console.ReadLine());  

            MetrosP= La*Lb*Lc;
            Preciobruto = MetrosP * PrecioI;

            Console.WriteLine($"La cantidad de metros cubicos necesitados sera{MetrosP}cm3");
            Console.WriteLine($"la cantidad de metros cubicos sera{Preciobruto}cm3"); 
        }
    }
}