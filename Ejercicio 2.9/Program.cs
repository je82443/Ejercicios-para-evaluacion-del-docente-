namespace Ejericicios
{
    public class program
    {
        public static void Main()
        {
            int SS, CH, VH;
            Console.WriteLine("Por favor ingrese las horas trabadas"); 
            CH=int.Parse(Console.ReadLine());
            Console.WriteLine(" por ingrese el valor de la hora"); 
            VH=int.Parse(Console.ReadLine());
            SS = CH * VH;
            Console.WriteLine($"El suelo semanal es {SS}");

        }
    }

}