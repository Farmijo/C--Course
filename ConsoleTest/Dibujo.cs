using System.Collections.Generic;
using System.Linq;
namespace ConsoleTest{

    public class Dibujo{

        private readonly IList<IFigura> _figuras;
        private IList<int> _lista2;

        public Dibujo(){
            _figuras = new List<IFigura>(10);
        }

        //Metodo de indice. Permite acceder a elements IFigura como si fuesen un array: _figuras["Texto"]
        public IFigura this[string name]{
            get{
                return _figuras.FirstOrDefault(x => x.Name == name );
            }
        }

        //Tupla
        public IEnumerable<(string name, System.Type tipo)> GetFiguraInfo() {
            foreach ( var figura in _figuras){
                yield return (figura.Name, figura.GetType());
            }
        }

        public T GetByName<T>(string name)
            where T : class, IFigura
        {
            var figura = this[name];
            return figura == null ? null : (T)figura;
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