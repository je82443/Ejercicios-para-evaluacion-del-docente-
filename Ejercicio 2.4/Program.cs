namespace ejercicios
{
    public class program
    {
        public static void Main()
        {
            int numero1;

            int numero2;
            int numero3;
            int numero4;

            int suma;
            int media;
            int producto;

            Console.WriteLine("ingrese por favor el primer numero"); 
            numero1= int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese por favor el segundo numero");
            numero2= int.Parse(Console.ReadLine()); 

            Console.WriteLine("ingrese por favor el segundo numero");
            numero3= int.Parse(Console.ReadLine()); 

            Console.WriteLine("ingrese por favor el cuarto numero");
            numero4 = int.Parse(Console.ReadLine());    

            producto = numero1 * numero2 * numero3* numero4;
            suma = numero1 + numero2 + numero3 + numero4;
            media = suma / 4; 
            Console.WriteLine($"El resultado de la suma es:{suma}, el resultado del producto es :{producto}, el resutatado de la media es:{media}");
        }
    }
}
