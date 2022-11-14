namespace Ejercicicios
{
    public class program
    {
        public static void Main()
        {
            double Pulg = 0;
            double Mt = 0.0254;
            double Cpulg = 0;
            double Metrosdados= 0;
            Console.WriteLine(" por ingrese de metros necesitados para la tela:"); 
            Metrosdados= double.Parse(Console.ReadLine()); 
            Cpulg= Metrosdados/Mt;
            Console.WriteLine($" la cantidad de tela que necesita pedir ;{Cpulg}"); 
        }

    }
}