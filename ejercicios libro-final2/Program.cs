namespace ejerleche
{
    public class Leche
    {
        public static void Main()

        {
            decimal LPG = 3.785M;
            decimal L, pg, g, t;
            decimal LV;
            decimal PG;
            decimal CG;
            decimal Valorventa;
            decimal l;
            Console.WriteLine(" por favor ingrese el valor de los litros"); 
            L = decimal.Parse(Console.ReadLine());
            Console.WriteLine(" por favor ingrese el precio de los galones"); 
            pg = decimal.Parse(Console.ReadLine());

            g = (L * LPG);
            t= (pg*g);
            Console.WriteLine($"el valor de la venta es de{t}");
        }
    }
}
