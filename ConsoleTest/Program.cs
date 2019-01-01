using System;
using System.Collections.Generic;
using System.Collections;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace ConsoleTest
{

   public  struct Test{
       public int I {get;set;}

    }

    class Program
    {
        static async Task Main(string[] args)
        {

            
            Console.WriteLine("1 - Dibujo");
            Console.WriteLine("2 - Salir");
            Console.WriteLine("3 - Api");
            
            var i = new Test();
            i.I = 10;
            //Las clases van por referencia!!!! Las estructuras por valor!!!!
            

            bool opcion = await DrawMenu();
            while(!opcion){
                opcion = await DrawMenu();
            }

            

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

        //Pattern matching
        private static void Evaluar(IFigura figura){

            /*
                        if(figura is Texto texto){

               Console.WriteLine("Es un texto con mensaje", texto.Name);
            }
             */

             switch (figura){

                case Texto t:
                    Console.WriteLine("Mensaje es igual a " + t.Name);
                    break;
                case Cuadrado c when c.Fila==0:
                    Console.WriteLine("Es un cuadrado que tiene fila 0");
                    break;
                default:
                    Console.WriteLine("caca");
                    break;

             }




        }

        static async Task<bool> DrawMenu(){


            ConsoleKeyInfo info =  Console.ReadKey();
            if(info.KeyChar == '1'){

                Dibujo dibujo = new Dibujo();
                
                dibujo.Dibujar();
                return true;

            }
            else if(info.KeyChar == '2'){
                return true;
            }
            else if(info.KeyChar=='3'){
                 await LlamarApi();
                 return true;
            }
            else{
                Console.WriteLine("Seleccione 1 o 2");
                return false;
            }
        }

        private static async Task LlamarApi(){
            var client = new HttpClient();
            var response = await client.GetAsync("https://localhost:5001/api/values");
            if(response.IsSuccessStatusCode){

                var json = await response.Content.ReadAsStringAsync();
                dynamic data = JsonConvert.SerializeObject(json);
                var name = data.Name;
                
            }
        }
    }
}
