using System;

namespace dev_homework03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************");
            Console.WriteLine("Tarea - 01");
            Console.WriteLine("Simple Array Sum");


            Console.WriteLine("Introduce cuantos numeros quieres sumar:");
            int numero=0;
            int suma = 0;
            
            numero=Convert.ToInt32(Console.ReadLine());
            string [] lectura = new string [numero];
            var arreglo= new int[numero];
            Console.Write("Introduce ");
            Console.Write(numero);
            Console.WriteLine(" numeros");
            
            lectura = Console.ReadLine().TrimEnd().Split(" ");


             if (lectura.Length>numero){
                Console.WriteLine("Favor de verificar la cantidad de numeros introducidos");
            } else{
                for(int i=0; i < lectura.Length;i++){
                    suma = suma+Convert.ToInt32(lectura[i]);
                }
            }

            Console.WriteLine("El valor total es: " + suma);

            
            Console.WriteLine("********************"); 
            Console.WriteLine("\n");
            Console.WriteLine("********************");
            Console.WriteLine("Tarea - 02");
            Console.WriteLine("Simple Array Sum");
            
            var positivos = 0;
            var negativos = 0;
            var ceros = 0;
            
            Console.WriteLine("¿Cúantos numeros vas a introducir?");
            Console.ReadLine();
            Console.WriteLine("Introduce los numeros, pueden ser postivos, negativos o cero." );
            var arr_temp = Console.ReadLine().Split(' ');
            var arr = Array.ConvertAll(arr_temp, Int32.Parse);

            for (int arr_i = 0; arr_i < arr.Length; arr_i++)
            {
            if (arr[arr_i] > 0)
                ++positivos;
            else if (arr[arr_i] < 0)
                ++negativos;
            else
                ++ceros;
            }
            Console.WriteLine("hay un ");
            Console.Write((double)positivos / arr.Length);
            Console.WriteLine("% de nuemros positivos ");
            Console.Write((double)negativos / arr.Length);
            Console.WriteLine("% de nuemros negativos ");
            Console.Write((double)ceros / arr.Length);
            Console.WriteLine("% de ceros ");
            Console.WriteLine("\n");
            Console.WriteLine("Hasta aqui mi Reporte Joaquin");



            Console.WriteLine("********************"); 
            Console.WriteLine("\n");
            Console.WriteLine("********************");
            Console.WriteLine("Tarea - 03");
            Console.WriteLine("Compare Tripplets");
            Console.WriteLine("\n");
            Console.WriteLine("Introduce el puntaje de Alice (3 valores)");
            var puntajeAlice = Console.ReadLine().Split(' ');
            var a0 = int.Parse(puntajeAlice[0]);
            var a1 = int.Parse(puntajeAlice[1]);
            var a2 = int.Parse(puntajeAlice[2]);
            Console.WriteLine("Introduce el puntaje de Bob (3 valores)");
            var puntajeBob = Console.ReadLine().Split(' ');
            var b0 = int.Parse(puntajeBob[0]);
            var b1 = int.Parse(puntajeBob[1]);
            var b2 = int.Parse(puntajeBob[2]);

            int aliceTotal = 0;
            int bobTotal = 0;
            if (a0 > b0)
                aliceTotal++;
            else if (b0 > a0)
                bobTotal++;

            if (a1 > b1)
                aliceTotal++;
            else if (b1 > a1)
                bobTotal++;

            if (a2 > b2)
                aliceTotal++;
            else if (b2 > a2)
                bobTotal++;
            
            
            Console.Write($"Alice: {aliceTotal}");
            Console.WriteLine($" Bob: {bobTotal}");
            Console.WriteLine("********************"); 
            Console.WriteLine("\n");





        }
    }
}
