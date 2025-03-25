using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    public abstract class EstadoMascota
    {
        public bool PuedeJugar;
        public abstract void Comer(TAMAGOCHI tamagochi);
        public abstract void Jugar(TAMAGOCHI tamagochi);
    }
}
