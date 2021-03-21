using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerenciaPascal
{
    class Program
    {
        static void Main(string[] args)
        {   

            int longitudArray = 10;
            Electrodomestico[] listaElectrodomesticos = new Electrodomestico[longitudArray];
            
            listaElectrodomesticos[0] = new Electrodomestico();
            listaElectrodomesticos[1] = new Electrodomestico(2, 15);
            listaElectrodomesticos[2] = new Electrodomestico(2, "blanco", "F", 15);
            listaElectrodomesticos[3] = new Lavadora();
            listaElectrodomesticos[4] = new Lavadora(400, 9);
            listaElectrodomesticos[5] = new Lavadora( 35,300,40,"F","negro");
            listaElectrodomesticos[6] = new Television();
            listaElectrodomesticos[7] = new Television(18, true, 400, 15, "f", "negro");
            listaElectrodomesticos[8] = new Television(350, 11);
            listaElectrodomesticos[9] = new Television(128, true, 600, 15, "d", "negro");

            double precioTelevision = 0;
            double precioLavadora = 0;
            double precioElectrodomestico = 0;
            double precioTotal;

            for (int i = 0; i < 10; i++)
            {
              
                listaElectrodomesticos[i].precioFinal();
                precioTotal = listaElectrodomesticos[i].PrecioBase;

                if (typeof(Television).IsInstanceOfType(listaElectrodomesticos[i]))
                {
                    precioTelevision += precioTotal;
                }
                if (typeof(Lavadora).IsInstanceOfType(listaElectrodomesticos[i]))
                {
                    precioLavadora += precioTotal;
                }
                if (typeof(Electrodomestico).IsInstanceOfType(listaElectrodomesticos[i]))
                {
                    precioElectrodomestico += precioTotal;
                }
            }
            
            Console.WriteLine(precioLavadora); 
            Console.WriteLine(precioTelevision); 
            Console.WriteLine(precioElectrodomestico);
           
            Console.ReadLine();
        }
    } 
}
