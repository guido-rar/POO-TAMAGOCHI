using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    public class TAMAGOCHI
    {
        public EstadoMascota estado;
        public int VecesJugadas;

        public TAMAGOCHI()
        {
            estado = new EstadoAburrido(DateTime.Now);
        }

        public void CambiarEstado(EstadoMascota nuevoEstado)
        {
            estado = nuevoEstado;
        }

        public void IncrementarFelicidad(int cantidad)
        {
            // Lógica para aumentar la felicidad
        }
    }
}
