using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerenciaPascal
{
    class Television : Electrodomestico
    {
        public double Resolucion { get; set; }
        public bool TDT { get; set; }

        public Television() : base()
        {
            Resolucion = 20;
            TDT = false;
        }

        public Television(int precioPa, int pesoPa) : base(precioPa, pesoPa)
        {
            Resolucion = 20;
            TDT = false;
        }

        public Television(double resolucionPa, bool TDTPa, int precioPa, int pesoPa, string consumoPa, string colorPa)
          : base(precioPa, colorPa, consumoPa, pesoPa)
        {
            Resolucion = resolucionPa;
            TDT = TDTPa;
        }

        public override void precioFinal()          //Método sobreescrito que aumenta el precio en fubncion de resolución y TDT
        {
            if( Resolucion > 40)
            {
                PrecioBase *= 1.3;
            }
            if( TDT)
            {
                PrecioBase += 50;
            }
        }
    }
}
