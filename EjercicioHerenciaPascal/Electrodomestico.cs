using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerenciaPascal
{
    class Electrodomestico
    {
        public enum enumColor { BLANCO, NEGRO, ROJO, AZUL, GRIS, blanco, negro, rojo, azul, gris };
        public enum enumConsumo { A, B, C, D, E, F }
        
        public double PrecioBase { get; set; }
        public enumColor Color { get; set; }
        public enumConsumo Consumo { get; set; }
        public double Peso { get; set; }

        public Electrodomestico ()
        {
            PrecioBase = 100;
            Color = enumColor.BLANCO;
            Consumo = enumConsumo.F;
            Peso = 5;
        }

        public Electrodomestico(double precioBasePa, double pesoBasePa)
        {
            PrecioBase = precioBasePa;
            Color = enumColor.BLANCO;
            Consumo = enumConsumo.F;
            Peso = pesoBasePa;
        }

        public Electrodomestico(double precioBasePa, string colorPa, string consumoPa, double pesoPa)
        {
            PrecioBase = precioBasePa;
            comprobarColor(colorPa);
            comprobarConsumoEnergetico(consumoPa);
            Peso = pesoPa;
        }

        private void comprobarConsumoEnergetico (string consumoPa)
        {
            if (Enum.IsDefined(typeof(enumConsumo), consumoPa))
            {
                Consumo = (enumConsumo)Enum.Parse(typeof(enumConsumo), consumoPa);
            }
            else
            {
                Consumo = enumConsumo.F;
            }
        }

        private void comprobarColor(string colorPa)
        {
            if (Enum.IsDefined(typeof(enumColor), colorPa))
            {
                Color = (enumColor)Enum.Parse(typeof(enumColor), colorPa);
            }
            else
            {
                Color = enumColor.BLANCO;
            }
        }

        public virtual void precioFinal()       //Método que aumenta el precio según consumo y peso del electrodomestico
        {
            switch(Consumo)
            {
                case enumConsumo.A:
                    PrecioBase += 100;
                    break;
                case enumConsumo.B:
                    PrecioBase += 80;
                    break;
                case enumConsumo.C:
                    PrecioBase += 60;
                    break;
                case enumConsumo.D:
                    PrecioBase += 50;
                    break;
                case enumConsumo.E:
                    PrecioBase += 30;
                    break;
                case enumConsumo.F:
                    PrecioBase += 10;
                    break;
            } 

            if (Peso > 0 || Peso <= 19)
            {
                PrecioBase += 10;
            }
            else if (Peso >=20  || Peso <= 49)
            {
                PrecioBase += 50;
            }
            else if (Peso >= 50 || Peso <= 79)
            {
                PrecioBase += 80;
            }
            else if (Peso >80)
            {
                PrecioBase += 100;
            }
        }

    }
}
