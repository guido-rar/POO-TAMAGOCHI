using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    public class EstadoHambre : EstadoMascota
    {
        public EstadoHambre()
        {
            PuedeJugar = false;
        }

        public override void Comer(TAMAGOCHI tamagochi)
        {
            tamagochi.CambiarEstado(new EstadoFeliz());
        }

        public override void Jugar(TAMAGOCHI tamagochi)
        {
            // No hace nada, ya que la mascota tiene hambre y no puede jugar
        }
    }
}
