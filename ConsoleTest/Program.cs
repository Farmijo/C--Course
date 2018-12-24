using System;
using System.Collections.Generic;
using System.Collections;
namespace ConsoleTest
{

   public  struct Test{
       public int I {get;set;}

    }

    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("1 - Dibujo");
            Console.WriteLine("2 - Salir");
            
            var i = new Test();
            i.I = 10;
            //Las clases van por referencia!!!! Las estructuras por valor!!!!
            Foo( i);

            bool opcion = DrawMenu();
            while(!opcion){
                opcion = DrawMenu();
            }

            
            //GetMultiplesOf(1,2,5);

        }

        static IEnumerable<int> GetMultiplesOf(int n, int start, int end){

            List<int> multiples = new List<int>();
            for (int i = start; i < end; i++)
            {
                if (i % n == 0)
                {
                    Console.WriteLine(
                        $"{i} GetMultiplesOf");
                    multiples.Add(i);
                }
            }
            return multiples;
                    
        }

        static IEnumerable<int> YieldMultiplesOf(int n, int start, int end){

            

            for (int i = start; i < end; i++)
            {
                if (i % n == 0)
                {
                    Console.WriteLine(
                        $"{i} YieldMultiplesOf");
                    yield return i;
                }
            }

        }
        
        
        static void Foo( Test i){
            
            i.I = 2;
        }

        static bool DrawMenu(){


            ConsoleKeyInfo info =  Console.ReadKey();
            if(info.KeyChar == '1'){

                Dibujo dibujo = new Dibujo();
                dibujo.Dibujar();
                return true;

            }
            else if(info.KeyChar == '2'){
                return true;
            }
            else{
                Console.WriteLine("Seleccione 1 o 2");
                return false;
            }
        }

    }
}
