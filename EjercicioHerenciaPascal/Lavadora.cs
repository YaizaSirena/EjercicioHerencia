using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerenciaPascal
{
    class Lavadora : Electrodomestico
    {
        
        
        public int Carga { get; set; }

        public Lavadora() : base()
        {
            Carga = 5;
        }
        public Lavadora(int precioPa , int pesoPa) : base(precioPa, pesoPa)
        {
            Carga = 5;
        }
        public Lavadora(int cargaPa, int precioPa, int pesoPa, string consumoPa, string colorPa )
            : base(precioPa, colorPa, consumoPa, pesoPa)
        {
            Carga = cargaPa;
        }

        public override void precioFinal()
        {
            if(Carga > 30)
            {
                PrecioBase += 50;
            }
        }
        
    }
}
