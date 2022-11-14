namespace Ejercicios
{
    public class program
    {
        public static void Main()
        {
            int edad = 1, suma = 0, total = 0;
            int x=1;
            float promedio;
            Console.WriteLine("ingrese el total de alumnos"); 
            total= int.Parse(Console.ReadLine());   
            while (x <= total)
            {
                Console.WriteLine("ingrese su edad por favor"); 
                edad= int.Parse(Console.ReadLine());
                suma = suma + edad; 
                x= x + 1;
                promedio= suma/total;
                Console.WriteLine($" el promedio del grupo es de {promedio}"); 
            }
        }
    }
}



         