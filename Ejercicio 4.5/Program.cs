
namespace trabajo4
{

    class clase
    {

        static public void Main()
        {


            // 4.5

            int anyo = 0;
            int dia = 0;
            int mes = 0;

            double divisible = anyo % 4;


            Console.WriteLine("Ingrese el año.");
            anyo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el mes.");
            mes = Convert.ToInt32(Console.ReadLine());

            if (mes > 0 && anyo > 1800 && mes < 13)
            {

                if (mes == 2)
                {
                    Console.WriteLine("Ingrese el día.");
                    dia = int.Parse(Console.ReadLine());


                    if (dia > 29 && divisible == 0 && dia > 0)
                    {
                        Console.WriteLine("Este mes solo tiene 29 días.");
                    }
                    else
                    {
                        if (dia > 28)
                        {
                            Console.WriteLine("Este mes solo tiene 28 días.");
                        }
                    }
                }

                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    Console.WriteLine("Ingrese el día.");

                    dia = int.Parse(Console.ReadLine());
                    if (dia > 31 && dia > 0)
                    {
                        Console.WriteLine("Este mes solo tiene 31 días.");
                    }
                }
                else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    Console.WriteLine("Ingrese el día.");
                    dia = int.Parse(Console.ReadLine());
                    if (dia > 30 && dia > 0)
                    {
                        Console.WriteLine("este mes solo tiene 30 días.");
                    }
                }
                else
                {
                    Console.WriteLine("hay 12 meses.");
                }

                DateTime mifecha = new DateTime(anyo, mes, dia);
                mifecha = mifecha.AddDays(1);

                Console.WriteLine("La fecha del siguiente dia sera");
                Console.WriteLine(mifecha);

            }
            else
            {

                Console.WriteLine("La fecha es incorrecta");
            }
        }
    }
}
