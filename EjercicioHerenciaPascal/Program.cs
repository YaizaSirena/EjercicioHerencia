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
            listaElectrodomesticos[1] = new Electrodomestico(2,15);
            listaElectrodomesticos[2] = new Electrodomestico(2, "blanco","F", 15);
            listaElectrodomesticos[3] = new Lavadora();
            listaElectrodomesticos[4] = new Lavadora(400,9);
            listaElectrodomesticos[5] = new Lavadora(300, 7);
            listaElectrodomesticos[6] = new Television();
            listaElectrodomesticos[7] = new Television(18,true, 400, 15,"f", "negro");
            listaElectrodomesticos[8] = new Television(350,11);
            listaElectrodomesticos[9] = new Television(128,true,600,15,"d","negro");
            //(double resolucionPa, bool TDTPa,  int precioPa, int pesoPa, string consumoPa, string colorPa)

            double precioFinal;
            for (int i = 0; i <10; i++)
            {
                
                precioFinal = listaElectrodomesticos[i].precioFinal();
            }
        }
    }

   
    //Asigna a cada posición un objeto de las clases anteriores con los valores que desees.
    //•
    //Ahora, recorre este array y ejecuta el métodoprecioFinal().
    //•
    //Deberás mostrar el precio de cada clase,
    //        es decir, el precio de todas las televisiones por un lado, el de las lavadoras 
    //        por otro y la suma de los Electrodomesticos(puedes crear objetos Electrodomestico,
    //    pero recuerda que Television y Lavadora también son electrodomésticos). 
    //        Recuerda el uso operador instanceof.
    //Por ejemplo, si tenemos un Electrodomestico con un precio final de 300, una lavadora de 200 
    //        y una televisión de 500, el resultado final sera de 1000 (300+200+500) para electrodomésticos,
    //        200 para lavadora y 500 paratelevisión.
}
