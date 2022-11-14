using System.ComponentModel.DataAnnotations;

namespace ejercicio
{
public class Program
    {
        public static void Main()
        {
            double factura;
            double descuento;
            double precio;
            double preciobruto;
            double Iva= 0.12;
            double Ivacompra;
            int cantidadproductos;

            Console.WriteLine(" ingrese el valor del producto"); 
            precio= double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el valor de los productos que va a llevar");
            cantidadproductos= int.Parse(Console.ReadLine());

            Ivacompra = (precio * cantidadproductos) * 0.12;
            Console.WriteLine("el iva da un valor de: " + Ivacompra);

            preciobruto = (precio * cantidadproductos) + Ivacompra;

            if (preciobruto < 50000)
            {
                descuento = preciobruto * 0.5;
                factura = preciobruto - descuento;

            }
            else
            {
                factura = preciobruto;

            }
            Console.WriteLine($"el precio de la facuta es de: " + factura); 
        }
    }
}