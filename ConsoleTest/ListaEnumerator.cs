using System.Collections;
using System.Collections.Generic;
// NO NECESARIO DE IMPLEMENTAR
namespace ConsoleTest{

    public class ListEnumerator<T> : IEnumerator<T>, IEnumerator{
    
        private int _idx;
        private readonly ILista<T> _lista;

        public ListEnumerator(ILista<T> lista){
            _lista = lista;
            _idx = -1;
        }

        public T Current {
            get
            {
                return _lista.GetAt(_idx);
            }
        }

        object IEnumerator.Current {
            get{
                return Current;
            }
        }
        public void Dispose(){

        }
        public void Reset(){
            _idx = 0;
        }

        public bool MoveNext()
        {
            _idx++;
            return _idx<_lista.Count;
        }

    }
}