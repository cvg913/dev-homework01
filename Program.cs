using System;

namespace dev_homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! - My name is: César");

            //Constantes
            const string nombre = "César";
            //Variables
            int edad = 16;
        
            Console.WriteLine($"Mi nombre es: {nombre} y mi edad es { edad } años.");

            float miDomingo = 150.5F;

            Console.WriteLine($"Mi domingo es de {miDomingo}");
        
            var resultado = miDomingo * 46;

            Console.WriteLine($"Resultado: { resultado }");


            var areaTriangulo = 0F;

            float basee = 315.0723F;
            float altura = 11238.0234F;
            const float dos = 2.0F;
            areaTriangulo = basee * altura / dos;
        
            Console.WriteLine ($"Area de un triangulo es igual a la base: ({basee}) por la altura ({altura}) entre dos");
            Console.WriteLine ($"Resutlado Area: {areaTriangulo} ");

            char letraA = 'a';
            Console.WriteLine ($"Letara: { letraA}");

            float  floatF = 1F/3;
            double doubleD = 1D/3;
            decimal decimalD = 1M/3;

            Console.WriteLine ($"flotante: {floatF}");
            Console.WriteLine ($"doubleD: {doubleD}");
            Console.WriteLine ($"decimalD: {decimalD}");

            bool falso = false;
            bool verdadero = true;
            Console.WriteLine ($"Falso { falso }  Verdadero { verdadero}");
            // Tarea
            /* ESTA ES MI TAREA 
              1) área de un triángulo, circulo, cuadrado.
              2) Si mi sueldo es de $100,000, ¿cuanto es el 10%?
              3) Si de domingo me dan 15 pesos ¿cuanto dinero junte en 3 años?  
              4) Si de domingo me dan 15 pesos y cada año me aumentan 20% ¿cuanto dinero junte en 5 años?;
              5) Investigar el problema de los conejos de Fibonacci (programar la respuesta.)            
            */

                    // Tarea 1

            var areaTriangulo2 = 0F;

            float basse1 = 15.382F;
            float altura1 = 8.45F;
            const float doss = 2.0F;
            areaTriangulo2 = basse1 * altura1 / doss; 

            Console.WriteLine ($"Area de un triangulo es igual a la base: ({basse1}) por la altura({altura1}) entre dos: ({doss})");
            Console.WriteLine ($"Resultado Area: {areaTriangulo2} ");
            
           // Tarea 2 

           var porcentaje = 0F;

           float sueldoo = 100000F;
           float multiplicacion = 10F;
           float dividendo = 100F;
           porcentaje = sueldoo * multiplicacion / dividendo;

           Console.WriteLine ($"Si mi sueldo es de $100,000, ¿cuanto es el 10%?");
           Console.WriteLine ($"Respuesta: {porcentaje}");

           // Tarea 3

           var dinero1 = 0F;

           float domngo = 15F;
           float días = 52F;
           float años = 3F;
           dinero1 = (domngo * días) * años;

           Console.WriteLine ($"Si de domingo me dan 15 pesos ¿cuanto dinero junte en 3 años?");
           Console.WriteLine ($"Respuesta: {dinero1} ");

           //Tarea 4

           var total = 0F;

           float domingo2 = 780F;
           float domingo3 = 936F;
           float domingo4 = 1123.2F;
           float doming = 1349.92F;
           float omingo = 1619.94F;
           total = domingo2 + domingo3 + domingo4 + doming + omingo;

           Console.WriteLine ($"Si de domingo me dan 15 pesos y cada año me aumentan 20% ¿cuanto dinero junte en 5 años?");
           Console.WriteLine ($"respuesta: {total} ");

           // Tarea 5

           float bunny1 = 610F;
           float bunny2 = 987F;
           float bunny3 = 1597F;
           float bunny4 = 2584F;
           float bunny5 = 4181F;

           Console.WriteLine ($"Para sacar saber como es la respuesta hay que ir sumando los dos numeros anteriores");
           Console.WriteLine ($"Ejemplo: ({bunny1}) + ({bunny2}) = {bunny3} ");
           Console.WriteLine ($"Para poder sacar los en que mes es hay que hacer la operación anterior, para poder sacar el mes en que hubo {bunny5} ");
           Console.WriteLine ($"Hay que sumar los dos anterios, y nos quedaria asi: {bunny3} + {bunny4} = {bunny5} ");
           Console.WriteLine ($"asi vemos que en el mes 18 hay {bunny5} ");

    }
}}
