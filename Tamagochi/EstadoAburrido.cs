using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    public class EstadoAburrido : EstadoMascota
    {
        private DateTime TiempoInicioAburrimiento;
        private ushort UmbralComida = 80;

        public EstadoAburrido(DateTime TiempoInicio)
        {
            PuedeJugar = true;
            TiempoInicioAburrimiento = TiempoInicio;
        }



        public override void Comer(TAMAGOCHI tamagochi)
        {
            
            if ((DateTime.Now - TiempoInicioAburrimiento).TotalMinutes > UmbralComida)
            {
                tamagochi.CambiarEstado(new EstadoFeliz());
            }
        }

        public override void Jugar(TAMAGOCHI tamagochi)
        {
            PuedeJugar = true;
            tamagochi.CambiarEstado(new EstadoFeliz());
        }
    }
}
