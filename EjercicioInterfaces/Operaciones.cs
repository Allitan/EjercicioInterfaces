
namespace EjercicioInterfaces
{
    public class Operaciones : IOperaciones
    {
        public double CalcularAreaCirculo(double radio)
        {
            return Math.PI * radio * radio;
        }

        public double CalcularHipotenusa(double cateto1, double cateto2)
        {
            return Math.Sqrt((cateto1 * cateto1) + (cateto2 * cateto2));
        }

        public double CalcularPerimetroRectangulo(double largo, double ancho)
        {
            return 2 * (largo + ancho);
        }

        public double CalcularVelocidad(double distancia, double tiempo)
        {
            return distancia / tiempo;
        }

        public double CalcularVolumenCilindro(double radio, double altura)
        {
            return Math.PI * radio * radio * altura;
        }

        public void Imprimir(double radio, double largo, double ancho, double radioCilindro, double altura, double cateto1, double cateto2, double distancia, double tiempo)
        {
            Console.WriteLine("Resultado de las operaciones: ");
            Console.WriteLine();
            Console.WriteLine($"Area del circulo: {CalcularAreaCirculo(radio)}");
            Console.WriteLine($"Perimetro del rectangulo: {CalcularPerimetroRectangulo(largo, ancho)}");
            Console.WriteLine($"Volumen del cilindro: {CalcularVolumenCilindro(radioCilindro, altura)}");
            Console.WriteLine($"Hipotenusa del triangulo: {CalcularHipotenusa(cateto1, cateto2)}");
            Console.WriteLine($"Velocidad: {CalcularVelocidad(distancia, tiempo)} m/s");

        }
    }
}
