using System;

namespace dev_homework03
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("********************");
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

            
            Console.WriteLine("********************"); */
            Console.WriteLine("\n");
            Console.WriteLine("********************");
            Console.WriteLine("Tarea - 02");
            Console.WriteLine("Simple Array Sum");
            
            var positiveNumbers = 0;
            var negativeNumbers = 0;
            var zeroNumbers = 0;
            //No need to capture the size of array. I use array's length property instead.
            Console.WriteLine("¿Cúantos numeros vas a introducir?");
           
            Console.ReadLine();
            Console.WriteLine("Introduce los numeros, pueden ser postivos, negativos o cero." );
             var arr_temp = Console.ReadLine().Split(' ');
            var arr = Array.ConvertAll(arr_temp, Int32.Parse);

            for (int arr_i = 0; arr_i < arr.Length; arr_i++)
            {
            if (arr[arr_i] > 0)
                ++positiveNumbers;
            else if (arr[arr_i] < 0)
                ++negativeNumbers;
            else
                ++zeroNumbers;
            }
            Console.WriteLine("hay un ");
            Console.Write((double)positiveNumbers / arr.Length);
            Console.WriteLine("% de nuemros positivos ");
            Console.Write((double)negativeNumbers / arr.Length);
            Console.WriteLine("% de nuemros negativos ");
            Console.Write((double)zeroNumbers / arr.Length);
            Console.WriteLine("% de ceros ");





        }
    }
}
