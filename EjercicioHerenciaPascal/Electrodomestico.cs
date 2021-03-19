using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerenciaPascal
{
    class Electrodomestico
    {

        //Atributos :
        double precioBase;
        public enum enumColor { BLANCO, NEGRO, ROJO, AZUL, GRIS, blanco, negro, rojo, azul, gris };
        public enumColor color;
        public enum enumConsumo { A, B, C, D, E, F }
        public enumConsumo consumo;
        public double peso;

        //Geter seter
        public double PrecioBase { get; set; }
        public enumColor Color { get; set; }
        public enumConsumo Consumo { get; set; }
        public double Peso { get; set; }

        //Constructores:
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

        public Electrodomestico(double precioBasePa, string colorPa, string consumoPa, double pesoBasePa)
        {
            PrecioBase = precioBasePa;
            comprobarColor(colorPa);
            comprobarConsumoEnergético(consumoPa);
            Peso = pesoBasePa;
        }

        private void comprobarConsumoEnergético (string consumoPa)
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

        public void precioFinal()
        {
            switch(consumo)
            {
                case enumConsumo.A:
                    precioBase += 100;
                    break;
                case enumConsumo.B:
                    precioBase += 80;
                    break;
                case enumConsumo.C:
                    precioBase += 60;
                    break;
                case enumConsumo.D:
                    precioBase += 50;
                    break;
                case enumConsumo.E:
                    precioBase += 30;
                    break;
                case enumConsumo.F:
                    precioBase += 10;
                    break;
            }
            if (Peso > 0 || Peso <= 19)
            {
                precioBase += 10;
            }
            else if (Peso >=20  || Peso <= 49)
            {
                precioBase += 50;
            }
            else if (Peso >= 50 || Peso <= 79)
            {
                precioBase += 80;
            }
            else if (Peso >80)
            {
                precioBase += 100;
            }
        }

    }
}
