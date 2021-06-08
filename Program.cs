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
            
        }
    }
}
