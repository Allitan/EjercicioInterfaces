
namespace EjercicioInterfaces
{
    public interface IOperaciones
    {

        double CalcularAreaCirculo(double radio);
        double CalcularPerimetroRectangulo(double largo, double ancho);
        double CalcularVolumenCilindro(double radio, double altura);
        double CalcularHipotenusa(double cateto1, double cateto2);
        double CalcularVelocidad(double distancia, double tiempo);

    }
}
