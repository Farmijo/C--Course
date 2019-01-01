namespace ConsoleTest{

    public abstract class Figura : IFigura{

        public int Fila {get; }
        public int Columna {get;}

        public Posicion Pos {get;}
        public string Name {get;}



        public Figura(int fila, int columna, string name){

            Pos = new Posicion(fila, columna); 
            Name = name;
        }

        public abstract void Dibujar();

  

    }
}