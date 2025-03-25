using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tamagochi
{
    public class EstadoFeliz : EstadoMascota
    {
        public EstadoFeliz()
        {
            PuedeJugar = true;
        }

        public override void Comer(TAMAGOCHI tamagochi)
        {
            tamagochi.IncrementarFelicidad(1);
        }

        public override void Jugar(TAMAGOCHI tamagochi)
        {
            tamagochi.VecesJugadas ++;
            tamagochi.IncrementarFelicidad(2);
            if (tamagochi.VecesJugadas >= 5)
                tamagochi.CambiarEstado(new EstadoHambre());
        }
    }
}
