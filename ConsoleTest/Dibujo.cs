using System.Collections.Generic;
using System.Linq;
namespace ConsoleTest{

    public class Dibujo{

        private readonly IList<IFigura> _figuras;
        private IList<int> _lista2;

        public Dibujo(){
            _figuras = new List<IFigura>(10);
        }
        
        public void AddFigura(IFigura figura){
            _figuras.Add(figura);
        }
        public void Dibujar(){
            foreach(var figuras in _figuras){
                figuras?.Dibujar();
            }
        }

       

    }
}