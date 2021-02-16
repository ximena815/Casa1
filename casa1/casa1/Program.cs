using System;

namespace casa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a casa 1 ;3");


            Random aleatorio = new Random();
            string respuesta = "s";
            int dado1 = 0, dado2 = 0, total = 0, pares = 0;
            double contador = 0,seis = 0;

            while (respuesta == "s" && total < 100)
            {
                Console.WriteLine("¿tirar los dados?");
                respuesta = Console.ReadLine();

                if (respuesta == "s")
                {
                    dado1 = aleatorio.Next (1, 7);
                    Console.WriteLine("tu dado1 es: " + dado1);

                    dado2 = aleatorio.Next(1, 7);
                    Console.WriteLine("tu dado2 es: " + dado2);

                    if (dado1 == dado2 && (dado1 !=1 && dado2 != 1))
                    {
                        pares += 1;
                        Console.WriteLine("pares: " + pares);
                        
                    }
                    if (pares == 3)
                    {
                        Console.WriteLine("Has ganado");
                        string pajarito =
                      "\n  ^ ^" +
                      "\n (O,O)" +
                      "\n (   )" +
                      "\n  T T";
                        Console.WriteLine(pajarito);
                        respuesta = "n";
                    }
                    if(1 == dado1 && dado2==1)
                    {
                        Console.WriteLine("salado mijo perdio");
                        respuesta = "n";
                    }
                    total += dado1 + dado2;
                    Console.WriteLine("total actual: "+ total);
                    if (dado1+dado2>6)
                    {
                        seis += 1;
                    }
                    
                }
                else
                {
                    Console.WriteLine("que gallina se retiro");
                }
                contador++;
                Console.WriteLine("contador: " + contador);

            }
            if (total >= 100)
            {
                Console.WriteLine("has obtenido un logro en tu vida ganaste ;3");
                string pajarito =
                      "\n  ^ ^" +
                      "\n (O,O)" +
                      "\n (   )" +
                      "\n  T T";
                Console.WriteLine(pajarito);
            }
            double porcentaje = (seis / contador)*100;
            Console.WriteLine("porcentaje: " + porcentaje);
        }
    }
}
