using System;

namespace Tik_Tok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cantidad de usuarios a valorar:");
            int num_usuarios = int.Parse(Console.ReadLine());
            int contBonos =0;
            string fechaNacString;
            DateTime FechaNacimiento;
            DateTime fechaActual;
            int mes=0;
            int[] meses = new int[13];
            double promAños = 0;
            string[] nomMeses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            for (int x = 0; x <= num_usuarios - 1; x++)
            {
                Console.WriteLine("Fecha de nacimiento (mm/dd/yyyy) ");
                fechaNacString = Console.ReadLine();
                FechaNacimiento = DateTime.ParseExact(fechaNacString, "MM/dd/yyyy", null);
                fechaActual = DateTime.Now;
                TimeSpan diferencia = fechaActual - FechaNacimiento;
                double dias = diferencia.TotalDays;
                double años = Math.Floor(dias / 365);
                
                if (años >= 18 &&  años <= 50 )
                {
                    mes = FechaNacimiento.Month;
                    meses[mes] = meses[mes] + 1;
                    contBonos++; 
                }

                promAños += años; 
            }
            
            for( int y = 1; y <13; y++ )
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("|" + nomMeses[y-1] + " |" + " " + meses[y] + "  empleados" + " |" + "Dinero en Bonos $" + (meses[y] * 50000) + " |"); 
            }
            Console.WriteLine("\n\nNumero de bonos: "+contBonos);
            Console.WriteLine("\n\nPromedio Edades: " + (promAños / num_usuarios));
        }
    }
}
