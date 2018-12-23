namespace ConsoleTest{
 


      public class Lista<T>{

        private readonly T[] _items;
        public int Count {get; private set;}
        public Lista(int limite){

            _items = new T[limite];
            Count = 0;
        }


        public void Add(T item){
            if(Count == _items.Length){
                throw new System.InvalidOperationException("Lista llena");
            }
            _items[Count] = item;
            Count++;

        }

        public object GetAt(int index){
            return _items[index];
        }
    }

}