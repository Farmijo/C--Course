using System;
using System.Threading.Tasks;
namespace Async
{
    class Program
    {
        static async Task Main(string[] args)
        {
                 intermedio();
                Console.WriteLine("En main");
                Console.ReadLine();
            
        }

        static async Task intermedio() {
            Console.WriteLine("Incio!");
            var r = await LongRun();
            Console.WriteLine("Fin!");
            Console.WriteLine("Y el resultado es : " + r);
            Console.ReadLine();

        }
        static  Task<int> LongRun(){

            var t = Task.Factory.StartNew(()=>{
                for (int j = 0; j < 99; j++){
                    for (int i = 0; i < 99999999; i++);
                }
                Console.WriteLine(" LongRun ha acabado!");
                return 2;

            });

            return t;

        }
    }


}
