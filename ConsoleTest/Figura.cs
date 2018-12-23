namespace ConsoleTest{

    public abstract class Figura : IFigura{

        public int Fila {get; }
        public int Columna {get;}

        public Posicion Pos {get;}

        public Figura(int fila, int columna){

            Pos = new Posicion(fila, columna); 
        }

        public abstract void Dibujar();

  

    }
}