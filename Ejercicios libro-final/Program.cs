namespace ejerArea
{
    public class area
    {
        public static void Main()
        {
            decimal A;
            decimal B;
            decimal C;
            decimal AT;
            decimal AR;
            decimal ATO;
            Console.WriteLine("por favor ingrese el valor de A");
            A = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese el valor de B");
            B = decimal.Parse(Console.ReadLine());
            Console.WriteLine("por favor ingrese el valor de c");
            C = decimal.Parse(Console.ReadLine());
            AR = B + C;
            AT = ((A - C) + B) / 2;
            ATO = AR + AT;
            Console.WriteLine($"EL AREA DEL LOTE ES {ATO}");
        }

    }
}
