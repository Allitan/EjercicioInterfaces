using EjercicioInterfaces;

double radio, largo, ancho, radioCilindro, altura, cateto1, cateto2, distancia, tiempo;

Operaciones operaciones = new Operaciones();

Console.WriteLine("Ingrese el radio del circulo: ");
radio = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el largo del rectangulo: ");
largo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el ancho del rectangulo: ");
ancho = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el radio del cilindro: ");
radioCilindro = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese la altura del cilindro: ");
altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el primer cateto del triangulo: ");
cateto1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el segundo cateto del triangulo: ");
cateto2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese la distancia recorrida en metros: ");
distancia = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el tiempo transcurrido en segundos: ");
tiempo = Convert.ToDouble(Console.ReadLine());

operaciones.Imprimir(radio, largo, ancho, radioCilindro, altura, cateto1, cateto2, distancia, tiempo);