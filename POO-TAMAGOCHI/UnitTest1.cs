using Tamagochi;

namespace POO_TAMAGOCHI
{
    public class UnitTest1
    {
        [Fact]
        public void Tamagochi_CambiaDeEstado_AEstadoFeliz_CuandoComeEnEstadoHambre()
        {
            // Arrange
            var tamagochi = new TAMAGOCHI();
            tamagochi.CambiarEstado(new EstadoHambre());

            // Act
            tamagochi.estado.Comer(tamagochi);

            // Assert
            Assert.IsType<EstadoFeliz>(tamagochi.estado);
        }

        [Fact]
        public void Tamagochi_CambiaDeEstado_AEstadoHambre_CuandoJuegaMucho()
        {
            // Arrange
            var tamagochi = new TAMAGOCHI();
            tamagochi.CambiarEstado(new EstadoFeliz());

            // Act
            for (int i = 0; i < 6; i++)
            {
                tamagochi.estado.Jugar(tamagochi);
            }

            // Assert
            Assert.IsType<EstadoHambre>(tamagochi.estado);
        }

        [Fact]
        public void Tamagochi_CambiaDeEstado_AEstadoFeliz_CuandoJuegaEnEstadoAburrido()
        {
            // Arrange
            var tamagochi = new TAMAGOCHI();
            tamagochi.CambiarEstado(new EstadoAburrido(DateTime.Now));

            // Act
            tamagochi.estado.Jugar(tamagochi);

            // Assert
            Assert.IsType<EstadoFeliz>(tamagochi.estado);
        }

        [Fact]
        public void Tamagochi_CambiaDeEstado_AEstadoFeliz_CuandoComeEnEstadoAburrido()
        {
            // Arrange
            var tamagochi = new TAMAGOCHI();
            tamagochi.CambiarEstado(new EstadoAburrido(DateTime.Parse("2025-03-24 23:59:59") ) );

            // Act
            tamagochi.estado.Comer(tamagochi);

            // Assert
            Assert.IsType<EstadoFeliz>(tamagochi.estado);
        }

        [Fact]
        public void Tamagochi_CambiaDeEstado_AEstadoAburrido_CuandoJuegaEnEstadoFeliz()
        {
            // Arrange
            var tamagochi = new TAMAGOCHI();
            tamagochi.CambiarEstado(new EstadoFeliz());

            // Act
            for (int i = 0; i < 6; i++)
            {
                tamagochi.estado.Jugar(tamagochi);
            }

            // Assert
            Assert.IsType<EstadoHambre>(tamagochi.estado);
        }

        [Fact]
        public void Tamagochi_CambiaDeEstado_AEstadoFeliz_CuandoComeEnEstadoFeliz()
        {
            // Arrange
            var tamagochi = new TAMAGOCHI();
            tamagochi.CambiarEstado(new EstadoFeliz());

            // Act
            tamagochi.estado.Comer(tamagochi);

            // Assert
            Assert.IsType<EstadoFeliz>(tamagochi.estado);
        }

        [Fact]
        public void Tamagochi_NoCambiaDeEstado_CuandoJuegaEnEstadoHambre()
        {
            // Arrange
            var tamagochi = new TAMAGOCHI();
            tamagochi.CambiarEstado(new EstadoHambre());

            // Act
            tamagochi.estado.Jugar(tamagochi);

            // Assert
            Assert.IsType<EstadoHambre>(tamagochi.estado);
        }
    }
}