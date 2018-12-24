using System.Collections.Generic;
using System.Collections;
namespace ConsoleTest{
 

/*
En caso de no poder crear la clase X generica desde cero, una posible opción es:
- Crear una nueva clase X<T> en la que se redefinan los metodos incluyendo el parametro generico cuando sea necesario.

    public class X<T>{
        public X instancia_no_generica;

        public X(){
            X = new X();
        }

        public T metodo1 ( parametro){
            return T;
        }

    }
 */

    public interface ILista<T> : IEnumerable<T>{
       int Count {get;}
       T GetAt(int idx); 
       void Add(T item);
       IEnumerable<T> Find(IPredicate<T> predicate);
    }

    public interface ILista {
        int Count {get;}
        void Add(object item);
        object GetAt(int idx);


    }


    public class Lista<T> : ILista<T>, ILista {

        private readonly T[] _items;
        public int Count {get; private set;}
        public Lista(int limite){

            _items = new T[limite];
            Count = 0;
        }

        public IEnumerable<T> Find (IPredicate<T> predicate){
            foreach(var current in _items){
                if(current != null && predicate.Match(current)){
                    yield return current;
                }
            }
        }

          object ILista.GetAt(int idx){
            return _items[idx];
        }

        public T GetAt(int index){
            return _items[index];
        }

         public void Add(object item){
                Add((T)item);
        }
        
        public void Add(T item){
            if(Count == _items.Length){
                throw new System.InvalidOperationException("Lista llena");
            }
            _items[Count] = item;
            Count++;

        }

        IEnumerator IEnumerable.GetEnumerator(){
            return GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator(){

            //En este caso, yield nos permite ahorrarnos el implementar todos los metodos que requiere el implementar
            //la interfaz IEnumerable. El implementar esa interfaz, por otra parte, permite iterar con foreach
            foreach (var item in _items)
            {
                yield return item; 
            }
        }

    }



}