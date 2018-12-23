using System;

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
